using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Models.Dealer;
using AutomotiveHub.Extensions;
using Microsoft.AspNetCore.Mvc;
using static AutomotiveHub.Core.Constants.MessageConstants;
using static AutomotiveHub.Areas.Constants.UserConstants;

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
        public async Task<IActionResult> Become()
        {
            if (await dealerService.ExistsByIdAsync(User.Id()))
            {
                return RedirectToAction(nameof(HomeController.Index), "Home", new {DealerMessage });

            }

            return View();
        }

        [HttpPost]
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
    }
}
