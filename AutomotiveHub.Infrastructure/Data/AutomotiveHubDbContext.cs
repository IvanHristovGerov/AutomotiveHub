using AutomotiveHub.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveHub.Data
{
    public class AutomotiveHubDbContext : IdentityDbContext
    {
        public AutomotiveHubDbContext(DbContextOptions<AutomotiveHubDbContext> options)
            : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Dealer> Dealers { get; set; }

        public DbSet<Dealership> Dealerships { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<ReservationPeriod> ReservationPeriods { get; set; }


    }
}
