using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Contracts.Admin;
using AutomotiveHub.Core.Models.Dealer;
using AutomotiveHub.Core.Services;
using AutomotiveHub.Core.Services.Admin;
using AutomotiveHub.Data;
using AutomotiveHub.Infrastructure.Data.Models;
using AutomotiveHub.Infrastructure.Data.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Unit.Tests
{
    [TestFixture]
    public class DealerTests
    {
        private AutomotiveHubDbContext context;
        private IDealerService dealerService;
        private IDealershipService dealershipService;
        private IRentService rentService;
        private IRepository repository;
        private UserManager<ApplicationUser> userManager;


        public DealerTests()
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

            Mock<UserManager<ApplicationUser>> userManager = GetMockUserManager();

            repository = new Repository(context);
            dealerService = new DealerService(repository,userManager.Object);
        }

      

        [Test]
        public async Task TestAddNewDealer()
        {
            var user = new ApplicationUser() { Id = "user", UserName = "", Email = "", FirstName = "", LastName = "" };
            await repository.AddAsync(user);

            await dealerService.CreateAsync("user", "0894324332", "IvanDealer");

            var dealer = await repository.GetByIdAsync<Dealer>(1);

            Assert.That(dealer.Id, Is.EqualTo(1));
            Assert.That(dealer.Name, Is.EqualTo("IvanDealer"));
        }


        [Test]
        public async Task TestIfCityExistByGivenId()
        {

            await repository.AddAsync(new City() { Id = 1, Name = "Blagoevgrad" });

            await repository.SaveChangesAsync();

            Assert.That(await dealerService.CityExistsById(1), Is.True);
        }

        [Test]
        public async Task TestGetAllCities()
        {
    
            await repository.AddRangeAsync(new List<City>() {
                new City() { Id = 10, Name = "Blagoevgrad" },
                new City() { Id = 11, Name = "Sofia" },
                new City() { Id = 12, Name = "Plovdiv" },
                new City() { Id = 13, Name = "Burgas" }
            });

            await repository.SaveChangesAsync();

            var cities = await dealerService.AllCitiesAsync();

            Assert.That(cities.Count(), Is.EqualTo(4));
        }

        [Test]
        public async Task TestDealerIdByGivenId()
        {
            await repository.AddAsync(new Dealer() { Id = 1, Name = "Ivan", PhoneNumber = "0894324332", UserId = "testId" });

            await repository.SaveChangesAsync();

            var dealerId = await dealerService.GetDealerId("testId");

            Assert.That(dealerId, Is.EqualTo(1));
        }

        [Test]
        public async Task TestGetDealerPhoneByGivenPhoneNumber()
        {
            await repository.AddAsync(new Dealer() { Id = 1, Name = "Ivan", PhoneNumber = "0894324332", UserId = "testId" });

            await repository.SaveChangesAsync();

            var hasDealerPhoneNumber = await dealerService.HasDealerPhoneNumber("0894324332");

            Assert.That(hasDealerPhoneNumber, Is.True);
        }

        [Test]
        public async Task TestIfDealerExistByGivenId()
        {
            await repository.AddAsync(new Dealer() { Id = 1, Name = "Ivan", PhoneNumber = "0894324332", UserId = "testId" });

            await repository.SaveChangesAsync();

            var userExists = await dealerService.ExistsByIdAsync("testId");

            Assert.IsTrue(userExists);
        }

        [Test]
        public async Task TestAddNewDealership()
        {
            await repository.AddAsync(new Dealer() { Id = 1, Name = "Ivan", PhoneNumber = "0894324332", UserId = "testId" });

            await repository.SaveChangesAsync();

            var model = new AddDealershipServiceModel() { Name = "Blagoevgrad", Address = "", CityId = 1 };

            await dealerService.AddDealershipAsync("testId", model);

            var dealership = await repository.GetByIdAsync<Dealership>(1);

            Assert.That(dealership.Id, Is.EqualTo(1));
            Assert.That(dealership.Name, Is.EqualTo("Blagoevgrad"));
        }

        [Test]
        public async Task TestGetAllDealershipsAdded()
        {
            
            dealershipService = new DealershipService(repository);

            var dealer = new Dealer() { Id = 1, Name = "", PhoneNumber = "", UserId = "" };
            await repository.AddAsync(dealer);

            var city = new City() { Id = 1, Name = "Vidin" };

            await repository.AddRangeAsync(new List<Dealership>() {
                new Dealership() { Id = 1, Name = "", Address = "", City = city, Dealer = dealer},
                new Dealership() { Id = 2, Name = "", Address = "", City = city, Dealer = dealer},
                new Dealership() { Id = 3, Name = "", Address = "", City = city, Dealer = dealer}
            });

            await repository.SaveChangesAsync();

            var dealerships = await dealershipService.AllDealershipsAsync();

            Assert.That(dealerships.Count(), Is.EqualTo(3));
        }

        //Rent
        [Test]
        public async Task ShouldReturnAllRents()
        {
            rentService = new RentService(repository);

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

            var rents = await rentService.AllRentsAsync();

            Assert.That(rents.Count(), Is.EqualTo(1));

        }



        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }

        private Mock<UserManager<ApplicationUser>> GetMockUserManager()
        {
            var mock = new Mock<IUserStore<ApplicationUser>>();

            return new Mock<UserManager<ApplicationUser>>(
            mock.Object, null, null, null, null, null, null, null, null);
        }



    }
}
