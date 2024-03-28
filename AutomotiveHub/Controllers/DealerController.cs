using Microsoft.AspNetCore.Mvc;

namespace AutomotiveHub.Controllers
{
    public class DealerController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
