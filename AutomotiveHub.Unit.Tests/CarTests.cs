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
            var carModel = new CarFormModel()
            {
                Brand = "Audi",
                Model = "A6",
                Description = "",
                ImageUrl = "",
                Year = 2020,
                PricePerDay = 70,
                Transmission = 0,
                Fuel = 0,
                CategoryId = 1
            };

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


            await repository.AddAsync(new Car()
            {
                Id = 1,
                Brand = "",
                Model = "",
                Description = "",
                ImageUrl = "",
                PricePerDay = 0,
                Transmission = 0,
                Fuel = 0,
                CategoryId = 0,
                DealerId = 1,
                IsActive = true
            });

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

            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName = "" };
            await repository.AddAsync(user);

            var car = new Car()
            {
                Id = 1,
                Brand = "",
                Model = "",
                Description = "",
                ImageUrl = "",
                PricePerDay = 0,
                Transmission = 0,
                Fuel = 0,
                CategoryId = 0,
                DealerId = 1,
                IsActive = true,
                RenterId = ""
            };
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
            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName = "" };
            await repository.AddAsync(user);

            var car = new Car()
            {
                Id = 1,
                Brand = "",
                Model = "",
                Description = "",
                ImageUrl = "",
                PricePerDay = 0,
                Transmission = 0,
                Fuel = 0,
                CategoryId = 0,
                DealerId = 1,
                IsActive = true,
                RenterId = ""
            };
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

        [Test]
        public async Task TestGetAllCarsByGivenDealer()
        {

            var dealer = new Dealer() { Id = 1, Name = "", PhoneNumber = "", UserId = "" };
            await repository.AddAsync(dealer);

            await repository.AddRangeAsync(new List<Car>()
            {
                new Car() { Id = 1, Brand = "", Model = "", Description = "",
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true},
                new Car() { Id = 2, Brand = "", Model = "", Description = "",
                    ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true},
            });

            await repository.SaveChangesAsync();

            var cars = await carService.AllCarsByDealerId(1);

            Assert.That(dealer.Cars.Count(), Is.EqualTo(cars.Count()));
            Assert.That(dealer.Cars.Any(x => x.Id == 1), Is.True);
        }




        [Test]
        public async Task TestGetTrueIfItIsDealerIsWithGivenId()
        {
            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName = "" };
            await repository.AddAsync(user);

            var dealer = new Dealer() { Id = 1, Name = "", PhoneNumber = "", UserId = "user" };
            await repository.AddAsync(dealer);

            await repository.AddAsync(new Car()
            {
                Id = 1,
                Brand = "",
                Model = "",
                Description = "",
                ImageUrl = "",
                PricePerDay = 0,
                Transmission = 0,
                Fuel = 0,
                CategoryId = 0,
                DealerId = 1,
                IsActive = true
            });

            await repository.SaveChangesAsync();

            await carService.HasDealerWithIdAsync(1, "user");

            Assert.That(dealer.UserId, Is.EqualTo(user.Id));
        }

        [Test]
        public async Task TestGetFalseIfItIsNotDealerWithGivenId()
        {
            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName = "" };
            await repository.AddAsync(user);

            var dealer = new Dealer() { Id = 1, Name = "", PhoneNumber = "", UserId = "" };
            await repository.AddAsync(dealer);

            await repository.AddAsync(new Car()
            {
                Id = 1,
                Brand = "",
                Model = "",
                Description = "",
                ImageUrl = "",
                PricePerDay = 0,
                Transmission = 0,
                Fuel = 0,
                CategoryId = 0,
                DealerId = 1,
                IsActive = true
            });

            await repository.SaveChangesAsync();

            await carService.HasDealerWithIdAsync(1, "user");

            Assert.That(dealer.UserId, Is.Not.EqualTo(user.Id));
        }

        [Test]
        public async Task TestGetFalseIfDealerWithGivenIdIsNull()
        {
            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName = "" };
            await repository.AddAsync(user);

            var dealer = new Dealer() { Id = 1, Name = "", PhoneNumber = "", UserId = "" };
            await repository.AddAsync(dealer);

            dealer = await repository.GetByIdAsync<Dealer>(3);

            await repository.AddAsync(new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true });

            await repository.SaveChangesAsync();

            await carService.HasDealerWithIdAsync(1, "user");

            Assert.That(dealer, Is.Null);
        }

        [Test]
        public async Task TestGetAllCategories()
        {
            await repository.AddRangeAsync(new List<Category>(){
                new Category() { Id = 1, Name = "Sport" },
                new Category() { Id = 2, Name = "SUV" },
                new Category() { Id = 3, Name = "Estate" },
                new Category() { Id = 4, Name = "Coupe" },
            });

            await repository.SaveChangesAsync();

            var categories = await carService.AllCategoriesAsync();

            Assert.That(categories.Count() == 4);
            Assert.That(categories.Any(x => x.Name == "Estate"), Is.True);
            Assert.That(categories.Any(x => x.Name == null), Is.False);
        }

        [Test]
        public async Task TestGetAllCategoriesNames()
        {
            await repository.AddRangeAsync(new List<Category>(){
                new Category() { Id = 1, Name = "Sport" },
                new Category() { Id = 2, Name = "SUV" },
                new Category() { Id = 3, Name = "Estate" },
                new Category() { Id = 4, Name = "Coupe" },
            });

            await repository.SaveChangesAsync();

            var categories = await carService.AllCategoriesNamesAsync();

            Assert.That(categories.Count() == 4);
            Assert.That(categories.Any(x => x == null), Is.False);
        }

        [Test]
        public async Task TestGetCarCategoryId()
        {
            await repository.AddAsync(new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 1, DealerId = 1, IsActive = true });

            await repository.SaveChangesAsync();

            var carCategory = await carService.GetCarCategoryId(1);

            Assert.That(carCategory, Is.EqualTo(1));
        }

        [Test]
        public async Task TestIfCategoryExists()
        {
            await repository.AddAsync(new Category() { Id = 1, Name = "Estate" });

            await repository.SaveChangesAsync();

            Assert.That(await carService.CategoryExistAsync(1), Is.True);
        }

        [Test]
        public async Task TestIfCarExists()
        {
            await repository.AddAsync(new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 1, DealerId = 1, IsActive = true });

            await repository.SaveChangesAsync();

            Assert.That(await carService.ExistsAsync(1), Is.True);
        }



        [Test]
        public async Task TestIfCarIsRented()
        {
            await repository.AddAsync(new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "abc" });

            await repository.SaveChangesAsync();

            await carService.IsRentedAsync(1);
            var car = await repository.GetByIdAsync<Car>(1);

            Assert.That(car.RenterId, Is.Not.Null);
        }

        [Test]
        public async Task TestRecieveTrueIfCarIsRentedByGivenUser()
        {
            var user = new ApplicationUser() { Id = "abc", UserName = "", Email = "", FirstName = "", LastName ="" };
            await repository.AddAsync(user);

            await repository.AddAsync(new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "abc" });

            await repository.SaveChangesAsync();

            await carService.IsRentedByUserId(1, "user");
            var car = await repository.GetByIdAsync<Car>(1);

            Assert.That(car.RenterId, Is.EqualTo(user.Id));
        }

        [Test]
        public async Task TestRecieveFalseIfCarIsNull()
        {

            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName = "" };
            await repository.AddAsync(user);

            await repository.AddAsync(new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "abc" });

            await repository.SaveChangesAsync();

            await carService.IsRentedByUserId(0, "user");
            var car = await repository.GetByIdAsync<Car>(0);

            Assert.That(car, Is.Null);
        }

        [Test]
        public async Task TestRecieveFalseIfCarIsRentedByOtherUser()
        {
            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName ="" };
            await repository.AddAsync(user);

            await repository.AddAsync(new Car() { Id = 1, Brand = "", Model = "", Description = "", 
                ImageUrl = "", PricePerDay = 0, Transmission = 0, Fuel = 0, CategoryId = 0, DealerId = 1, IsActive = true, RenterId = "otherUser" });

            await repository.SaveChangesAsync();

            await carService.IsRentedByUserId(1, "user");
            var car = await repository.GetByIdAsync<Car>(1);

            Assert.That(car.RenterId, Is.Not.EqualTo(user.Id));
        }



        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }

    }
}