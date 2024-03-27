using AutomotiveHub.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Infrastructure.Data.SeedDb
{
    internal class DealershipConfiguration : IEntityTypeConfiguration<Dealership>
    {
        public void Configure(EntityTypeBuilder<Dealership> builder)
        {
            builder.HasData(CreateDealerships());
        }

        private List<Dealership> CreateDealerships()
        {
            return new List<Dealership>()
            {
                new Dealership()
                {
                    Id = 1,
                    Name = "Race Culture Dealership",
                    Address ="Sofia, bul.Botevgradsko shose 320",
                    CityId = 1,
                    DealerId = 3
                },
                new Dealership()
                {
                    Id = 2,
                    Name = "LuxNWheels Dealership",
                    Address ="Plovdiv, bul.Bulgaria 3",
                    CityId = 2,
                    DealerId = 1
                },
                new Dealership()
                {
                    Id = 3,
                    Name = "Auto Class Dealership",
                    Address ="Sofia, bul.Botevgradsko shose 320",
                    CityId = 4,
                    DealerId = 2
                }
            };
        }
    }
}
