using AutomotiveHub.Infrastructure.Data.Models;
using AutomotiveHub.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveHub.Data
{
    public class AutomotiveHubDbContext : IdentityDbContext<ApplicationUser>
    {
        public AutomotiveHubDbContext(DbContextOptions<AutomotiveHubDbContext> options)
            : base(options)
        {

        }

       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>()
                .Property(a => a.UserName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Entity<ApplicationUser>()
                .Property(x => x.Email)
                .HasMaxLength(20)
                .IsRequired();

           

            //builder.ApplyConfiguration(new CategoryConfiguration());
            //builder.ApplyConfiguration(new CityConfiguration());
            //builder.ApplyConfiguration(new UserConfiguration());
            //builder.ApplyConfiguration(new DealerConfiguration());
            //builder.ApplyConfiguration(new DealershipConfiguration());
            //builder.ApplyConfiguration(new CarConfiguration());
            //builder.ApplyConfiguration(new ReservationPeriodConfiguration());
            //builder.ApplyConfiguration(new ReservationConfiguration());




            base.OnModelCreating(builder);
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
