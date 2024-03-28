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
    internal class ReservationPeriodConfiguration : IEntityTypeConfiguration<ReservationPeriod>
    {
        public void Configure(EntityTypeBuilder<ReservationPeriod> builder)
        {
            builder.HasData(CreateReservationPeriods());
        }

        private List<ReservationPeriod> CreateReservationPeriods()
        {
            return new List<ReservationPeriod>()
            {
                new ReservationPeriod()
                {
                    Id = 1,
                    Days = 2
                },
                new ReservationPeriod()
                {
                    Id = 2,
                    Days = 3
                },
                new ReservationPeriod()
                {
                    Id = 3,
                    Days = 5
                },
                new ReservationPeriod()
                {
                    Id = 4,
                    Days = 7
                },
                new ReservationPeriod()
                {
                    Id = 5,
                    Days = 10
                },
                new ReservationPeriod()
                {
                    Id = 6,
                    Days = 30
                },
            };
        }
    }
}
