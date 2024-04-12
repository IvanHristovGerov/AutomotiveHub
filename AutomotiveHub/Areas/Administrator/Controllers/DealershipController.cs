using AutomotiveHub.Core.Contracts.Admin;
using AutomotiveHub.Core.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static AutomotiveHub.Areas.Constants.UserConstants;

namespace AutomotiveHub.Areas.Administrator.Controllers
{
    public class DealershipController : AdminBaseController
    {
        private readonly IDealershipService dealershipService;
        private readonly IMemoryCache memoryCache;

        public DealershipController(IDealershipService _dealershipService, IMemoryCache _memoryCache)
        {
            dealershipService = _dealershipService;
            memoryCache = _memoryCache;
        }

        public async Task<IActionResult> All()
        {
            var dealerships = memoryCache.Get<IEnumerable<AllDealershipsServiceModel>>(DealershipsCacheKey);

            if (dealerships == null)
            {
                dealerships = await dealershipService.AllDealershipsAsync();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                memoryCache.Set(DealershipsCacheKey, dealerships, cacheOptions);
            }

            return View(dealerships);
        }

    }
}
