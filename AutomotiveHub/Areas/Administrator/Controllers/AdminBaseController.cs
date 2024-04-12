using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static AutomotiveHub.Areas.Constants.UserConstants;

namespace AutomotiveHub.Areas.Administrator.Controllers
{
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
       
    }
}
