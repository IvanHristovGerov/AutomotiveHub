using AutomotiveHub.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomotiveHub.Infrastructure.Data.SeedDb
{
    internal class CarConfiguration:IEntityTypeConfiguration<Car>
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
                    Year = 2023,
                    Kilometers = 4500,
                    Description = "4.0-litre twin-turbo V8 with bigger turbochargers, modified ECU for a total of 768bhp. This high performance Audi transformed by Mansory is the unforgettable weekend escape.",
                    Transmission = Enumerations.Transmission.Automatic,
                    Fuel = Enumerations.Fuel.Petrol,
                    PricePerDay = 399,
                    ImageUrl = "https://www.topgear.com/sites/default/files/2021/10/904263.jpg?w=892&h=502"
                },
                new()
                {

                }
            };
        }
    }
}
