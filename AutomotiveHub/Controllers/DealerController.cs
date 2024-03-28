using Microsoft.AspNetCore.Mvc;

namespace AutomotiveHub.Controllers
{
    public class DealerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
