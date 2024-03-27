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
    internal class DealerConfiguration : IEntityTypeConfiguration<Dealer>
    {
        public void Configure(EntityTypeBuilder<Dealer> builder)
        {
            builder.HasData(CreateDealer());
        }

        private List<Dealer> CreateDealer()
        {
            return new List<Dealer>()
            {
                new Dealer()
                {
                    Id=1,
                    Name="Luxury Motors",
                    PhoneNumber ="+359888321456",
                    UserId = "e243a13e-a16b-4d10-a2eb-789c1c3d4413"
                },
                new Dealer()
                {
                    Id=2,
                    Name="Prestige Rentals",
                    PhoneNumber="+359894333878",
                    UserId = "0e1bd4e6-ab89-4490-a276-87c350e034dd"
                },
                new Dealer()
                {
                    Id=3,
                    Name="Fast Lane Autos",
                    PhoneNumber="+359878931336",
                    UserId = "5af45714-a89d-4aaa-90ed-fe41a9ab1966"
                }

            };
        }
    }
}
