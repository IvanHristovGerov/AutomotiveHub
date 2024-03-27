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
    internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasData(CreateReservations());
        }

        private List<Reservation> CreateReservations()
        {
            return new List<Reservation>()
            {
                new Reservation()
                {
                    Id = 1,
                    CarId = 2,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now + TimeSpan.FromDays(3),
                    TotalPrice = 1397,
                    ReservationPeriodId = 2,
                    IsActive = false
                }
            };
        }
    }
}
