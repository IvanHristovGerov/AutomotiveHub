using AutomotiveHub.Core.Contracts.Admin;
using AutomotiveHub.Core.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static AutomotiveHub.Areas.Constants.UserConstants;

namespace AutomotiveHub.Areas.Administrator.Controllers
{
    public class RentController : AdminBaseController
    {
       private readonly IRentService rentService;
        private readonly IMemoryCache memoryCache;

        public RentController(IRentService _rentService, IMemoryCache _memoryCache)
        {
            rentService = _rentService;
            memoryCache = _memoryCache;
        }


        public async Task<IActionResult> All()
        {
            var allRents = memoryCache.Get<IEnumerable<AllRentsModel>>(RentsCacheKey);

            if (allRents == null)
            {
                allRents = await rentService.AllRentsAsync();

                var memoryCacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                memoryCache.Set(RentsCacheKey, allRents, memoryCacheOptions);
            }

            return View(allRents);
        }
    }
}
