using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Models.Dealer;
using AutomotiveHub.Extensions;
using Microsoft.AspNetCore.Mvc;
using static AutomotiveHub.Core.Constants.MessageConstants;
using static AutomotiveHub.Areas.Constants.UserConstants;
using AutomotiveHub.Attributes;
using AutomotiveHub.Core.Constants;

namespace AutomotiveHub.Controllers
{
    public class DealerController : BaseController
    {
        private readonly IDealerService dealerService;

        public DealerController(IDealerService _dealerService)
        {
            dealerService = _dealerService;
        }

        [HttpGet]
        [NotADealer]
        public async Task<IActionResult> Become()
        {
            if (await dealerService.ExistsByIdAsync(User.Id()))
            {
                return RedirectToAction(nameof(HomeController.Index), "Home", new {DealerMessage });

            }

            return View();
        }

        [HttpPost]
        [NotADealer]
        public async Task<IActionResult> Become(BecomeDealerServiceModel model)
        {
            var userId = User.Id();

            if (await dealerService.HasDealerPhoneNumber(model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), DealerPhoneExists);
            }

            if (await dealerService.ExistsByIdAsync(User.Id()))
            {
                return RedirectToAction(nameof(HomeController.Index), "Home", new { DealerMessage });
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await dealerService.CreateAsync(User.Id(), model.PhoneNumber, model.Name);

            return RedirectToAction(nameof(CarController.All), "Car");
        }

        [HttpGet]
        [MustBeADealer]
        public async Task<IActionResult> AddDealership()
        {
            if (await dealerService.ExistsByIdAsync(User.Id()) == false)
            {
                return BadRequest();
            }

            return View(new AddDealershipServiceModel()
            {
                Cities = await dealerService.AllCitiesAsync()
            });
        }

        [HttpPost]
        [MustBeADealer]
        public async Task<IActionResult> AddDealership(AddDealershipServiceModel model)
        {
            var userId = User.Id();

            if (await dealerService.ExistsByIdAsync(userId) == false)
            {
                return BadRequest();
            }

            if (await dealerService.CityExistsById(model.CityId)==false)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                model.Cities = await dealerService.AllCitiesAsync();

                return View(model);
            }

            try
            {
                await dealerService.AddDealershipAsync(userId, model);
            }
            catch (Exception)
            {
                TempData[MessageConstants.Error] = "Something get wrong! Check your data!";

                return View(model);
            }

            return RedirectToAction(nameof(CarController.All), "Car");
        }
    }
}
