using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static AutomotiveHub.Areas.Constants.UserConstants;

namespace AutomotiveHub.Areas.Administrator.Controllers
{
    [Area(AreaName)]
    [Route("Administrator/[controller]/[Action]/{id?}")]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
       
    }
}
