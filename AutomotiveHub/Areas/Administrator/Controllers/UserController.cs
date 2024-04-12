using AutomotiveHub.Core.Contracts.Admin;
using AutomotiveHub.Core.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static AutomotiveHub.Areas.Constants.UserConstants;

namespace AutomotiveHub.Areas.Administrator.Controllers
{
    public class UserController : AdminBaseController
    {

        private readonly IUserService userService;
        private readonly IMemoryCache memoryCache;

        public UserController(IUserService _userService, IMemoryCache _memoryCache)
        {
            userService = _userService;
            memoryCache = _memoryCache;
        }


        public async Task<IActionResult> All()
        {
            var users = memoryCache.Get<IEnumerable<UserServiceModel>>(UsersCacheKey);

            if (users == null)
            {
                users = await userService.GetAllAsync();

                var memoryCacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                memoryCache.Set(UsersCacheKey, users, memoryCacheOptions);
            }

            return View(users);
        }

        public async Task<IActionResult> Delete(string userId)
        {
            try
            {
                await userService.DeleteUserAsync(userId);
            }
            catch (Exception)
            {
                throw new ArgumentException();
                
            }

            memoryCache.Remove(UsersCacheKey);

            return RedirectToAction(nameof(All));
        }
    }
}
