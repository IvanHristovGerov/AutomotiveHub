using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Extension;
using AutomotiveHub.Core.Models.Cars;
using AutomotiveHub.Core.Models.Dealer;
using AutomotiveHub.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Internal;
using Microsoft.AspNetCore.Mvc;
using static AutomotiveHub.Core.Constants.MessageConstants;

namespace AutomotiveHub.Controllers
{
    public class CarController : BaseController
    {
        private readonly ICarService carService;
        private readonly IDealerService dealerService;

        private readonly ILogger logger;

        public CarController(ICarService _carService, IDealerService _dealerService, ILogger<CarController> _logger)
        {
            carService = _carService;
            dealerService = _dealerService;
            logger = _logger;
        }

        //1
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] CarsQueryModel model)
        {
            var query = await carService.AllAsync(
                model.Category,
                model.SearchQuery,
                model.Sorting,
                model.CurrentPage,
                model.CarsPerPage
                );

            model.TotalCarsCount = query.TotalCarsCount;
            model.Cars = query.Cars;

            model.Categories = await carService.AllCategoriesNamesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();

            IEnumerable<CarServiceModel> model;

            if (await dealerService.ExistsByIdAsync(userId))
            {
                var dealerId = await dealerService.GetDealerId(userId);

                model = await carService.AllCarsByDealerId(dealerId);
            }
            else
            {
                model = await carService.AllCarsByUserId(userId);
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id, string info)
        {
            if (!await carService.ExistsAsync(id))
            {
                return BadRequest();
            }

            var model = await carService.GetCarsDetailsIdAsync(id);
            var modelInfo = model.GetInformation();

            if (modelInfo != model.GetInformation())
            {
                return BadRequest();
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CarFormModel()
            {
                Categories = await carService.AllCategoriesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarFormModel carModel)
        {
            if (!ModelState.IsValid)
            {
                carModel.Categories = await carService.AllCategoriesAsync();
            }

            if (await carService.CategoryExistAsync(carModel.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(carModel.CategoryId), CategoryNotExists);
            }

            int dealerId = await dealerService.GetDealerId(User.Id());
            int newCarId;

            try
            {
                newCarId = await carService.CreateCarAsync(carModel, dealerId);
            }
            catch (Exception)
            {

                TempData[Error] = CouldNotCreateCar;
                return View(carModel);
            }

            TempData[Success] = SuccessfulCreation;

            return RedirectToAction(nameof(Details), new { id = newCarId, information = carModel.GetInformation() });
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            if (await carService.ExistsAsync(id)==false)
            {
                return BadRequest();
            }

            if (await dealerService.ExistsByIdAsync(User.Id()))
            {
                return Unauthorized();
            }

            if (await carService.IsRentedAsync(id))
            {
                return BadRequest();
            }

            try
            {
                await carService.Rent(id, User.Id());
            }
            catch (Exception)
            {

                TempData[Error] = CannotRent;
                return RedirectToAction(nameof(All));
            }
            TempData[Success] = SuccessfulRent;

            return RedirectToAction(nameof(Mine));
        }
    }
}
