using Microsoft.AspNetCore.Mvc;

namespace AutomotiveHub.Areas.Administrator.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
