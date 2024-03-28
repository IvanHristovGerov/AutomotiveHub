using Microsoft.AspNetCore.Mvc;

namespace AutomotiveHub.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
