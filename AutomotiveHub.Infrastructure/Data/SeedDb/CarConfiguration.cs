using AutomotiveHub.Infrastructure.Data.Models;
using AutomotiveHub.Infrastructure.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomotiveHub.Infrastructure.Data.SeedDb
{
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(CreateVehicles());
        }

        private List<Car> CreateVehicles()
        {
            return new List<Car>()
            {
                new()
                {
                    Id = 1,
                    Brand = "Audi",
                    Model = "RS6",
                    Year = 2022,
                    Kilometers = 4500,
                    Description = "4.0l twin-turbo V8 with bigger turbochargers, modified ECU for a total of 768bhp. This high performance Audi transformed by Mansory is the unforgettable weekend escape.",
                    Transmission = Transmission.Automatic,
                    Fuel = Fuel.Petrol,
                    PricePerDay = 399,
                    ImageUrl = "https://www.topgear.com/sites/default/files/2021/10/904263.jpg?w=892&h=502",
                    DealerId = 4,
                    CategoryId=1
                },
                new()
                {
                     Id = 2,
                    Brand = "Audi",
                    Model = "S8",
                    Year = 2024,
                    Kilometers = 1350,
                    Description = "4.0-litre twin-turbocharged V8.With 563HP and 590lb-ft of Torque is everything you need for a long and dynamic ride.",
                    Transmission = Transmission.Automatic,
                    Fuel = Fuel.Petrol,
                    PricePerDay = 499,
                    ImageUrl = "https://www.topgear.com/sites/default/files/2022/06/Medium-29191-AudiS8TFSIquattro.jpg?w=976&h=549",
                    DealerId = 1,
                    CategoryId=2
                },
                new()
                {
                    Id = 3,
                    Brand = "Porshe",
                    Model = "911 Turbo",
                    Year = 2022,
                    Kilometers = 8500,
                    Description = "You need a track car for the streets? This stylish sport car is for you.",
                    Transmission = Transmission.Automatic,
                    Fuel = Fuel.Petrol,
                    PricePerDay = 349,
                    ImageUrl = "https://www.topgear.com/sites/default/files/cars-car/carousel/2020/12/pcgb20_0589_fine.jpg?w=892&h=502",
                    DealerId = 4,
                    CategoryId=5
                },
                new()
                {
                    Id = 4,
                    Brand = "Volkswagen",
                    Model = "Touareg",
                    Year = 2021,
                    Kilometers = 3500,
                    Description = "3.0-litre V6 Diesel with 282bhp.It's more than capable of holding its own on the road, now in utter refinement, and it’s highly impressive off the beaten track too. ",
                    Transmission = Transmission.Automatic,
                    Fuel = Fuel.Diesel,
                    PricePerDay = 299,
                    ImageUrl = "https://www.topgear.com/sites/default/files/2023/11/Medium-36020-TouaregElegance.jpg?w=892&h=502",
                    DealerId = 4,
                    CategoryId=3
                },
                new()
                {
                    Id = 6,
                    Brand = "Lexus",
                    Model = "LC500 Convertible",
                    Year = 2022,
                    Kilometers = 11750,
                    Description = "If you need a convertible for the summer trip this Lexus nails it.With a V8 465bhp and 398lb-ft.Comfortable, stylish and exclusive.",
                    Transmission = Transmission.Automatic,
                    Fuel = Fuel.Petrol,
                    PricePerDay = 379,
                    ImageUrl = "https://www.topgear.com/sites/default/files/cars-car/carousel/2020/09/lc500c_238-scaled.jpg?w=892&h=502",
                    DealerId = 1,
                    CategoryId=1
                },
                new Car()
                {
                    Id = 7,
                    Brand = "Audi",
                    Model = "Q8 e-tron",
                    Year = 2020,
                    Kilometers = 16850,
                    Description = "350bhp with a battery-89kWh for a range up to 460km.",
                    Transmission = Transmission.Automatic,
                    Fuel = Fuel.Electrical,
                    PricePerDay = 399,
                    ImageUrl = "https://www.topgear.com/sites/default/files/2024/03/32673-Q8ETRONDEANSMITH07.jpg?w=892&h=502",
                    DealerId = 1,
                    CategoryId=3
                },
                new Car()
                {
                    Id = 8,
                    Brand = "Toyota",
                    Model = "Rav4",
                    Year = 2019,
                    Kilometers = 26500,
                    Description = "If you need practical and useful SUV this is the one.It has 2.5-litre four-cylinder engine good for about 203hp.",
                    Transmission = Transmission.Automatic,
                    Fuel = Fuel.Diesel,
                    PricePerDay = 250,
                    ImageUrl = "https://www.topgear.com/sites/default/files/2024/02/15%20Toyota%20RAV4%20US%20review%202024.jpg?w=892&h=502",
                    DealerId = 1,
                    CategoryId=3
                }
            };
        }
    }
}
