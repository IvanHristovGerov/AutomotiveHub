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
    internal class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(CreateCities());
        }

        private List<City> CreateCities()
        {
            return new List<City>()
           {
               new City
               {
                   Id = 1,
                   Name = "Sofia"
               },
               new City
               {
                   Id = 2,
                   Name = "Plovdiv"
               },
               new City
               {
                   Id = 3,
                   Name = "Burgas"
               },
               new City
               {
                   Id = 4,
                   Name = "Blagoevgrad"
               },
           };
        }
    }
}
