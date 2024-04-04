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
                    PhoneNumber ="+35988832145",
                    UserId = "8cb5bcce-a58e-4271-9a58-13811fc3c9e3"
                },
                new Dealer()
                {
                    Id=4,
                    Name="Prestige Rents",
                    PhoneNumber="+359894333878",
                    UserId = "0e1bd4e6-ab89-4490-a276-87c350e034dd"
                },
                //new Dealer()
                //{
                //    Id=3,
                //    Name="Fast Lane Autos",
                //    PhoneNumber="+359878931334",
                //    UserId = "0e1bd4e6-ab89-4490-a276-87c350e034dd"
                //}

            };
        }
    }
}
