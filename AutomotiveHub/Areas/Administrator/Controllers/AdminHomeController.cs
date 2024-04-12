using Microsoft.AspNetCore.Mvc;

namespace AutomotiveHub.Areas.Administrator.Controllers
{
    public class AdminHomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
