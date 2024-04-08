using AutomotiveHub.Core.Enumerations;
using AutomotiveHub.Core.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Contracts
{
    public interface ICarService
    {
        Task<IEnumerable<CarServiceModel>> AllCarsAsync();

        Task<CarQueryServiceModel> AllAsync(
            string? category = null,
            string? searchQuery = null,
            CarSorting sorting = CarSorting.Newest,
            int currentPage = 1,
            int carsPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNamesAsync();

        Task<IEnumerable<CarServiceModel>> AllCarsByUserId(string userId);
        Task<IEnumerable<CarServiceModel>> AllCarsByDealerId(int dealerId);

        Task<bool> ExistsAsync(int carId);

        Task<CarDetailsServiceModel> GetCarsDetailsIdAsync(int carId);

        Task<bool> CategoryExistAsync(int categoryId);

        Task<IEnumerable<CarCategoryServiceModel>> AllCategoriesAsync();

        Task<int> CreateCarAsync(CarFormModel model, int dealerId);

        Task<bool> IsRentedAsync(int id);

        Task<bool> IsRentedByUserId(int carId, string userId);

        Task Rent(int carId, string userId);

        Task<bool> HasDealerWithId(int carId, string currUserId);



    }
}
