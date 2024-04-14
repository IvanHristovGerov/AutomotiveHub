using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Models.Cars;
using AutomotiveHub.Core.Services;
using AutomotiveHub.Data;
using AutomotiveHub.Infrastructure.Data.Models;
using AutomotiveHub.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveHub.Unit.Tests
{
    [TestFixture]
    public class CarTests
    {
        private AutomotiveHubDbContext context;
        private ICarService carService;
        private IRepository repository;


        public CarTests()
        {
           
        }


        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AutomotiveHubDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;

            context = new AutomotiveHubDbContext(options);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            repository = new Repository(context);
            carService = new CarService(repository);
        }

        [Test]
        public async Task TestGetAllCars()
        {
            

            var user = new ApplicationUser() { Id = "abc", UserName = "", Email = "", FirstName = "", LastName = "" };
            await repository.AddAsync(user);

            await repository.AddRangeAsync(new List<Car>()
            {
                new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "abc"},
                new Car() { Id = 2, Brand = "", Model = "", Description = "", 
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "abc"},
            });

            await repository.SaveChangesAsync();

            var cars = await carService.AllCarsAsync();

            Assert.That(cars.Any(x => x.Id == 2));
            Assert.That(cars.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task TestGetAllActiveCars()
        {
           

            await repository.AddRangeAsync(new List<Car>()
            {
                new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 0, IsActive = true},
                new Car() { Id = 2, Brand = "", Model = "", Description = "", 
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 0, IsActive = false},
            });

            await repository.SaveChangesAsync();
            var cars = await carService.AllAsync();

            Assert.That(1, Is.EqualTo(cars.TotalCarsCount));
        }

    

        [Test]
        public async Task TestAllCarsByGivenUser()
        {

            var user = new ApplicationUser() { Id = "abc", UserName = "", Email = "", FirstName = "", LastName = "" };
            await repository.AddAsync(user);

            await repository.AddRangeAsync(new List<Car>()
            {
                new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "abc"},
                new Car() { Id = 2, Brand = "", Model = "", Description = "", 
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "abc"},
            });

            await repository.SaveChangesAsync();

            var cars = await carService.AllCarsByUserId("abc");

            Assert.That(cars.Any(x => x.Id == 2));
            Assert.That(cars.Count(), Is.EqualTo(2));
        }



        [Test]
        public async Task TestCreateANewCar()
        {
            var carModel = new CarFormModel() { Brand = "Audi", Model = "A6", Description = "", 
                ImageUrl = "", Year = 2020, PricePerDay = 70, Transmission = 0, Fuel = 0, CategoryId = 1 };

            await carService.CreateCarAsync(carModel, 1);

            var car = await repository.GetByIdAsync<Car>(1);

            Assert.That(car, Is.Not.Null);
            Assert.That(car.Year, Is.EqualTo(2020));
        }

        [Test]
        public async Task TestDeleteACar()
        {
            

            await repository.AddRangeAsync(new List<Car>()
            {
                new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true},
                new Car() { Id = 2, Brand = "", Model = "", Description = "", 
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true},
            });

            await repository.SaveChangesAsync();
            await carService.DeleteAsync(1);

            var cars = await repository.AllReadOnly<Car>().ToListAsync();
            var deletedCar = await repository.GetByIdAsync<Car>(1);

            Assert.That(cars.Count(), Is.EqualTo(2));
            Assert.That(deletedCar.IsActive, Is.False);
        }

        [Test]
        public async Task TestEditACar()
        {
            

            await repository.AddAsync(new Car() { Id = 1, Brand = "", Model = "", Description = "",
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true });

            await repository.SaveChangesAsync();
            await carService.EditAsync(1, new CarFormModel()
            {
                CategoryId = 1,
                Brand = "BMW",
                Model = "",
                Description = "",
                Year = 0,
                Fuel = 0,
                Transmission = 0,
                ImageUrl = "",
                PricePerDay = 20
            });

            var car = await repository.GetByIdAsync<Car>(1);

            Assert.That(car.Brand, Is.EqualTo("BMW"));
            Assert.That(car.PricePerDay, Is.EqualTo(20));
        }

        [Test]
        public async Task TestRentACar()
        {
            
            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName ="" };
            await repository.AddAsync(user);

            var car = new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "" };
            await repository.AddAsync(car);

            await repository.AddAsync(new ReservationPeriod() { Id = 1, Days = 3 });
            var period = await repository.GetByIdAsync<ReservationPeriod>(1);

            await repository.AddAsync(new Reservation()
            {
                Id = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                IsActive = true,
                CarId = car.Id,
                TotalPrice = 0,
                ReservationPeriodId = period.Id
            });

            await repository.SaveChangesAsync();

            await carService.Rent(car.Id, "user");
            var newCar = await repository.GetByIdAsync<Car>(car.Id);

            Assert.That(newCar.RenterId, Is.EqualTo(user.Id));
        }

        [Test]
        public async Task TestLeaveACar()
        {
            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName ="" };
            await repository.AddAsync(user);

            var car = new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "" };
            await repository.AddAsync(car);

            await repository.AddAsync(new ReservationPeriod() { Id = 1, Days = 3 });
            var period = await repository.GetByIdAsync<ReservationPeriod>(1);

            await repository.AddAsync(new Reservation()
            {
                Id = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                IsActive = true,
                CarId = car.Id,
                TotalPrice = 0,
                ReservationPeriodId = period.Id
            });

            var reservation = await repository.GetByIdAsync<Reservation>(1);

            await repository.SaveChangesAsync();

            await carService.LeaveAsync(car.Id);
            var newCar = await repository.GetByIdAsync<Car>(car.Id);

            Assert.That(newCar.RenterId, Is.Null);
            Assert.That(reservation.IsActive, Is.False);
        }


        




        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }

    }
}