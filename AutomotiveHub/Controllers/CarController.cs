using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Extension;
using AutomotiveHub.Core.Models.Cars;
using AutomotiveHub.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static AutomotiveHub.Areas.Constants.UserConstants;
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
                CarsQueryModel.CarsPerPage);


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

            if (await dealerService.ExistsByIdAsync(userId) || User.IsInRole(AdminRole))
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

            TempData["message"] = "You have successfully added new car";

            return RedirectToAction(nameof(Details), new { id = newCarId, information = carModel.GetInformation() });
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            if (await carService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await dealerService.ExistsByIdAsync(User.Id()) && User.IsAdmin() == false)
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

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            if (await carService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (!await carService.IsRentedByUserId(id, User.Id()))
            {
                return Unauthorized();
            }

            try
            {
                await carService.LeaveAsync(id);
            }
            catch (UnauthorizedAccessException ex)
            {

                logger.LogError(ex, "CarController/Leave");

                return Unauthorized();
            }

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (await carService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await carService.HasDealerWithIdAsync(id, User.Id()) == false && User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            var car = await carService.GetCarsDetailsIdAsync(id);

            int categoryId = await carService.GetCarCategoryId(car.Id);

            var model = new CarFormModel()
            {
                Brand = car.Brand,
                Year = car.Year,
                Model = car.Model,
                Kilometers = car.Kilometers,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                Fuel = car.Fuel,
                Transmission = car.Transmission,
                ImageUrl = car.ImageUrl,
                CategoryId = categoryId,
                Categories = await carService.AllCategoriesAsync()

            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CarFormModel carModel)
        {
            if (await carService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await carService.HasDealerWithIdAsync(id, User.Id()) == false && User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            if (await carService.CategoryExistAsync(carModel.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(carModel.CategoryId), "Category does not exist!");
            }

            if (ModelState.IsValid)
            {
                carModel.Categories = await carService.AllCategoriesAsync();

                return View(carModel);
            }

            await carService.EditAsync(id, carModel);

            return RedirectToAction(nameof(Details), new { id, info = carModel.GetInformation() });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await carService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await carService.HasDealerWithIdAsync(id, User.Id()) == false && User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            var car = await carService.GetCarsDetailsIdAsync(id);

            var model = new CarDetailsViewModel()
            {
                Id = id,
                Brand = car.Brand,
                Model = car.Model,
                ImageUrl = car.ImageUrl,
                Category = car.Category
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CarDetailsViewModel carModel)
        {
            if (await carService.ExistsAsync(carModel.Id) == false)
            {
                return BadRequest();
            }
            if (await carService.HasDealerWithIdAsync(carModel.Id, User.Id()) == false && User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            await carService.DeleteAsync(carModel.Id);

            return RedirectToAction(nameof(All));
        }
    }
}
