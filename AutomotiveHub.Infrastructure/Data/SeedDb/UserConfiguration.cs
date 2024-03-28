using AutomotiveHub.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Infrastructure.Data.SeedDb
{
    internal class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
            var users = new List<ApplicationUser>();
            var passHasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser()
            {
                Id = "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                UserName = "IvanGerov",
                NormalizedUserName = "IVANGEROV",
                Email = "ivangerov@gmail.com",
                NormalizedEmail = "IVANGEROV@GMAIL.COM",
                FullName = "Ivan Gerov",
                IsActive = true
            };

            user.PasswordHash = passHasher.HashPassword(user, "gerov333");
            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admindealer@gmail.com",
                NormalizedEmail = "ADMINDEALER@GMAIL.COM",
                FullName = "Administrator",
                IsActive = true
            };

            user.PasswordHash = passHasher.HashPassword(user, "admin333");
            users.Add(user);

            return users;
        }
    }
}
