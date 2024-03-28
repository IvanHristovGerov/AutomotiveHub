using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Enumerations;
using AutomotiveHub.Core.Extension;
using AutomotiveHub.Core.Models;
using AutomotiveHub.Infrastructure.Data.Models;
using AutomotiveHub.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Services
{
    public class CarService : ICarService
    {
        private readonly IRepository repository;

        public CarService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<CarServiceModel>> AllCarsAsync()
        {
            return await repository.AllReadOnly<Car>()
                .Where(c => c.IsActive == true)
                .Select(c => new CarServiceModel()
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    ImageUrl = c.ImageUrl,
                    PricePerDay = c.PricePerDay

                })
                .ToListAsync();
        }


        public async Task<CarQueryServiceModel> AllAsync(
            string? category = null,
            string? searchQuery = null,
            CarSorting sorting = CarSorting.Newest,
            int currentPage = 1,
            int carsPerPage = 1)
        {
            var carsToShow = repository.AllReadOnly<Car>();

            if (category != null)
            {
                carsToShow = carsToShow
                    .Where(c => c.Category.Name == category);
            }

            if (searchQuery != null)
            {
                string normalizedSearchQuery = searchQuery.ToLower();

                carsToShow = carsToShow
                    .Where(c => (c.Brand.ToLower().Contains(normalizedSearchQuery) ||
                                 c.Model.ToLower().Contains(normalizedSearchQuery) ||
                                 c.Description.ToLower().Contains(normalizedSearchQuery)));
            }

            carsToShow = sorting switch
            {
                CarSorting.Price => carsToShow
                    .OrderBy(c => c.PricePerDay),
                CarSorting.NotRentedFirst => carsToShow
                    .OrderBy(c => c.RenterId != null)
                    .ThenByDescending(c => c.Id),
                _ => carsToShow
                    .OrderByDescending(c => c.Id)
            };

            //pages
            var cars = await carsToShow
                .Skip((currentPage - 1) * carsPerPage)
                .Take(carsPerPage)
                .ProjectToCarServiceModel()
                .ToListAsync();

            int totalCars = await carsToShow.CountAsync();

            return new CarQueryServiceModel()
            {
                Cars = cars,
                TotalCarsCount = totalCars
            };
        }

        public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
                
        }
    }
}
