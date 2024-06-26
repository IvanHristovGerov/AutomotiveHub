﻿
using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Contracts.Admin;
using AutomotiveHub.Core.Services;
using AutomotiveHub.Core.Services.Admin;
using AutomotiveHub.Data;
using AutomotiveHub.Infrastructure.Data.Models;
using AutomotiveHub.Infrastructure.Data.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IDealerService, DealerService>();
            services.AddScoped<IRentService, RentService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDealershipService, DealershipService>();

            return services;
        }

        //DbContext settings
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AutomotiveHubDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services
            .AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            })
                .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<AutomotiveHubDbContext>();

            return services;
        }
    }
}
