using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Models;
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
        public async Task<IActionResult> All([FromQuery]CarsQueryModel query)
        {
            var model = await carService.AllAsync(
                query.Category,
                query.SearchQuery,
                query.Sorting,
                query.CurrentPage,
                query.CarsPerPage
                );

            query.TotalCarsCount = model.TotalCarsCount;
            query.Cars = model.Cars;

            query.Categories= await carService.AllCategoriesNamesAsync();

            return View(query);
        }
    }
}
