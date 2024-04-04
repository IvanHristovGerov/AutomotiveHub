using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Models.Cars;
using AutomotiveHub.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> All([FromQuery]CarsQueryModel model)
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

            model.Categories= await carService.AllCategoriesNamesAsync();

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
    }
}
