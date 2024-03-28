using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveHub.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
