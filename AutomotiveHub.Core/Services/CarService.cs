using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Enumerations;
using AutomotiveHub.Core.Extension;
using AutomotiveHub.Core.Models.Cars;
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

        public async Task<IEnumerable<CarServiceModel>> AllCarsByUserId(string userId)
        {
            return await repository
                .All<Car>()
                .Where(c => c.RenterId == userId)
                .ProjectToCarServiceModel()
                .ToListAsync();
        }

        public async Task<IEnumerable<CarServiceModel>> AllCarsByDealerId(int dealerId)
        {
            return await repository
                .All<Car>()
                .Where(c => c.IsActive == true)
                .Where(c => c.DealerId == dealerId)
                .ProjectToCarServiceModel()
                .ToListAsync();
        }

        public async Task<bool> ExistsAsync(int carId)
        {
            return await repository.AllReadOnly<Car>()
               .Where(c => c.IsActive == true)
               .AnyAsync(c => c.Id == carId);
        }

        public async Task<CarDetailsServiceModel> GetCarsDetailsIdAsync(int carId)
        {

            var car = await repository.AllReadOnly<Car>()
                .Where(c => c.IsActive == true)
                .Where(c => c.Id == carId)
                .Select(c => new CarDetailsServiceModel()
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Year = c.Year,
                    Model = c.Model,
                    PricePerDay = c.PricePerDay,
                    Description = c.Description,
                    ImageUrl = c.ImageUrl,
                    IsRented = c.RenterId != null,
                    Fuel = c.Fuel,
                    Category = c.Category.Name,
                    Transmission = c.Transmission,
                    Dealer = new Models.Dealer.DealerQueryModel()
                    {
                        Name = c.Dealer.Name,
                        Email = c.Dealer.User.Email,
                        PhoneNumber = c.Dealer.PhoneNumber
                    }

                })
                .FirstOrDefaultAsync();

            if (car == null)
            {
                throw new ArgumentNullException();
            }

            return car;
        }

        public async Task<IEnumerable<CarCategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .OrderBy(c => c.Id)
                .Select(c => new CarCategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExistAsync(int categoryId)
        {
            return await repository.AllReadOnly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }



        public async Task<int> CreateCarAsync(CarFormModel model, int dealerId)
        {
            Car car = new Car()
            {
                Brand = model.Brand,
                CategoryId = model.CategoryId,
                Model = model.Model,
                DealerId = dealerId,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                PricePerDay = model.PricePerDay,
                Fuel = model.Fuel,
                Transmission = model.Transmission,
                Year = model.Year
            };

            await repository.AddAsync(car);
            await repository.SaveChangesAsync();

            return car.Id;
        }

        public async Task<bool> IsRentedAsync(int id)
        {
            var car = await repository.GetByIdAsync<Car>(id);

            return car.RenterId != null;

        }

        public async Task<bool> IsRentedByUserId(int carId, string userId)
        {
            var car = await repository.GetByIdAsync<Car>(carId);

            if (car == null || car.RenterId != userId)
            {
                return false;
            }

            return true;
        }

        public async Task Rent(int carId, string userId)
        {
            var car = await repository.GetByIdAsync<Car>(carId);

            var reservationPeriod = await repository.GetByIdAsync<ReservationPeriod>(1);

            var reservation = new Reservation()
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(reservationPeriod.Days),
                TotalPrice = car.PricePerDay * reservationPeriod.Days,
                IsActive = true,
                CarId = carId,
                ReservationPeriodId = reservationPeriod.Id,

            };

            await repository.AddAsync(reservation);

            if (car != null)
            {
                car.RenterId = userId;
            }

            await repository.SaveChangesAsync();
        }

        public async Task<bool> HasDealerWithIdAsync(int carId, string currUserId)
        {
            var car = await repository.GetByIdAsync<Car>(carId);

            var dealer = await repository.AllReadOnly<Dealer>()
                .FirstOrDefaultAsync(d => d.Id == car.DealerId);

            if (dealer == null || dealer.UserId != currUserId)
            {
                return false;
            }

            return true;
        }

        public async Task LeaveAsync(int carId)
        {
            var car = await repository.GetByIdAsync<Car>(carId);

            if (car != null)
            {
                car.RenterId = null;
                await repository.SaveChangesAsync();
            }
        }


        public async Task EditAsync(int carId, CarFormModel model)
        {
            var car = await repository.GetByIdAsync<Car>(carId);

            if (car != null)
            {
                car.Brand = model.Brand;
                car.Model = model.Model;
                car.Year = model.Year;
                car.Kilometers = model.Kilometers;
                car.Description = model.Description;
                car.ImageUrl = model.ImageUrl;
                car.Transmission = model.Transmission;
                car.Fuel = model.Fuel;
                car.PricePerDay = model.PricePerDay;
                car.CategoryId = model.CategoryId;


                await repository.SaveChangesAsync();
            }


        }

        public async Task<int> GetCarCategoryId(int carId)
        {
            var car = await repository.GetByIdAsync<Car>(carId);

            return car.CategoryId;
        }
    }
}
