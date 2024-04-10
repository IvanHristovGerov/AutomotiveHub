using AutomotiveHub.Core.Models.Dealer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Contracts
{
    public interface IDealerService
    {
        Task CreateAsync(string userId, string phoneNumber, string name);

        Task<bool> ExistsByIdAsync(string userId);

        Task<int> GetDealerId(string userId);

        Task<bool> HasDealerPhoneNumber(string phoneNumber);

        Task AddDealershipAsync(string userId, AddDealershipServiceModel model);

        Task<IEnumerable<AllCitiesServiceModel>> AllCitiesAsync();

        Task<bool> CityExistsById(int cityId);
        
    }
}
