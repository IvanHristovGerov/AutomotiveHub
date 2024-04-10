﻿// <auto-generated />
using System;
using AutomotiveHub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    [DbContext(typeof(AutomotiveHubDbContext))]
    partial class AutomotiveHubDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Car identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Brand name");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("Category identifier");

                    b.Property<int>("DealerId")
                        .HasColumnType("int")
                        .HasComment("Dealer identifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Car's description");

                    b.Property<int>("Fuel")
                        .HasColumnType("int")
                        .HasComment("Fuel type");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Image URL");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Kilometers")
                        .HasMaxLength(250000)
                        .HasColumnType("int")
                        .HasComment("Car's mileage");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Model name");

                    b.Property<int>("PricePerDay")
                        .HasColumnType("int")
                        .HasComment("Price per day");

                    b.Property<string>("RenterId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User Id of the renterer");

                    b.Property<int>("Transmission")
                        .HasColumnType("int")
                        .HasComment("Transmission type");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasComment("Year of production");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DealerId");

                    b.HasIndex("RenterId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Audi",
                            CategoryId = 1,
                            DealerId = 4,
                            Description = "4.0l twin-turbo V8 with bigger turbochargers, modified ECU for a total of 768bhp. This high performance Audi transformed by Mansory is the unforgettable weekend escape.",
                            Fuel = 1,
                            ImageUrl = "https://www.topgear.com/sites/default/files/2021/10/904263.jpg?w=892&h=502",
                            IsActive = true,
                            Kilometers = 4500,
                            Model = "RS6",
                            PricePerDay = 399,
                            Transmission = 0,
                            Year = 2022
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Audi",
                            CategoryId = 2,
                            DealerId = 1,
                            Description = "4.0-litre twin-turbocharged V8.With 563HP and 590lb-ft of Torque is everything you need for a long and dynamic ride.",
                            Fuel = 1,
                            ImageUrl = "https://www.topgear.com/sites/default/files/2022/06/Medium-29191-AudiS8TFSIquattro.jpg?w=976&h=549",
                            IsActive = true,
                            Kilometers = 1350,
                            Model = "S8",
                            PricePerDay = 499,
                            Transmission = 0,
                            Year = 2024
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Porshe",
                            CategoryId = 5,
                            DealerId = 4,
                            Description = "You need a track car for the streets? This stylish sport car is for you.",
                            Fuel = 1,
                            ImageUrl = "https://www.topgear.com/sites/default/files/cars-car/carousel/2020/12/pcgb20_0589_fine.jpg?w=892&h=502",
                            IsActive = true,
                            Kilometers = 8500,
                            Model = "911 Turbo",
                            PricePerDay = 349,
                            Transmission = 0,
                            Year = 2022
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Volkswagen",
                            CategoryId = 3,
                            DealerId = 4,
                            Description = "3.0-litre V6 Diesel with 282bhp.It's more than capable of holding its own on the road, now in utter refinement, and it’s highly impressive off the beaten track too. ",
                            Fuel = 0,
                            ImageUrl = "https://www.topgear.com/sites/default/files/2023/11/Medium-36020-TouaregElegance.jpg?w=892&h=502",
                            IsActive = true,
                            Kilometers = 3500,
                            Model = "Touareg",
                            PricePerDay = 299,
                            Transmission = 0,
                            Year = 2021
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Lexus",
                            CategoryId = 1,
                            DealerId = 1,
                            Description = "If you need a convertible for the summer trip this Lexus nails it.With a V8 465bhp and 398lb-ft.Comfortable, stylish and exclusive.",
                            Fuel = 1,
                            ImageUrl = "https://www.topgear.com/sites/default/files/cars-car/carousel/2020/09/lc500c_238-scaled.jpg?w=892&h=502",
                            IsActive = true,
                            Kilometers = 11750,
                            Model = "LC500 Convertible",
                            PricePerDay = 379,
                            Transmission = 0,
                            Year = 2022
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Audi",
                            CategoryId = 3,
                            DealerId = 1,
                            Description = "350bhp with a battery-89kWh for a range up to 460km.",
                            Fuel = 3,
                            ImageUrl = "https://www.topgear.com/sites/default/files/2024/03/32673-Q8ETRONDEANSMITH07.jpg?w=892&h=502",
                            IsActive = true,
                            Kilometers = 16850,
                            Model = "Q8 e-tron",
                            PricePerDay = 399,
                            Transmission = 0,
                            Year = 2020
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Toyota",
                            CategoryId = 3,
                            DealerId = 1,
                            Description = "If you need practical and useful SUV this is the one.It has 2.5-litre four-cylinder engine good for about 203hp.",
                            Fuel = 0,
                            ImageUrl = "https://www.topgear.com/sites/default/files/2024/02/15%20Toyota%20RAV4%20US%20review%202024.jpg?w=892&h=502",
                            IsActive = true,
                            Kilometers = 26500,
                            Model = "Rav4",
                            PricePerDay = 250,
                            Transmission = 0,
                            Year = 2019
                        });
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Category identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Category's name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sports car"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sedan"
                        },
                        new
                        {
                            Id = 3,
                            Name = "SUV"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Estate"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Hatchback"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Convertible"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Van"
                        });
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("City identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("City name");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sofia"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Plovdiv"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Burgas"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Blagoevgrad"
                        });
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Dealer identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Dealer's name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Dealer phone number");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Dealers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Luxury Motors",
                            PhoneNumber = "+35988832145",
                            UserId = "8cb5bcce-a58e-4271-9a58-13811fc3c9e3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Prestige Rents",
                            PhoneNumber = "+359894333878",
                            UserId = "0e1bd4e6-ab89-4490-a276-87c350e034dd"
                        });
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Dealership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Dealership identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Dealership's address");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("DealerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Dealership's name");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DealerId");

                    b.ToTable("Dealerships");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Sofia, bul.Botevgradsko shose 320",
                            CityId = 1,
                            DealerId = 3,
                            Name = "Race Culture Dealership"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Plovdiv, bul.Bulgaria 3",
                            CityId = 2,
                            DealerId = 1,
                            Name = "LuxNWheels Dealership"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Sofia, bul.Botevgradsko shose 320",
                            CityId = 4,
                            DealerId = 2,
                            Name = "Auto Class Dealership"
                        });
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Reservation identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasComment("End date of the reservation");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ReservationPeriodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasComment("Start date of the reservation");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int")
                        .HasComment("Total price of the reservation");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("ReservationPeriodId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 2,
                            EndDate = new DateTime(2024, 4, 13, 19, 0, 43, 744, DateTimeKind.Local).AddTicks(3221),
                            IsActive = false,
                            ReservationPeriodId = 2,
                            StartDate = new DateTime(2024, 4, 10, 19, 0, 43, 744, DateTimeKind.Local).AddTicks(3182),
                            TotalPrice = 1397
                        });
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.ReservationPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("ReservationPeriod identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Days")
                        .HasColumnType("int")
                        .HasComment("Total days of the reservation");

                    b.HasKey("Id");

                    b.ToTable("ReservationPeriods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Days = 2
                        },
                        new
                        {
                            Id = 2,
                            Days = 3
                        },
                        new
                        {
                            Id = 3,
                            Days = 5
                        },
                        new
                        {
                            Id = 4,
                            Days = 7
                        },
                        new
                        {
                            Id = 5,
                            Days = 10
                        },
                        new
                        {
                            Id = 6,
                            Days = 30
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fd0bcf92-d377-4e7b-97d2-ef5df5e2411c",
                            Email = "ivangerov@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "IVANGEROV@GMAIL.COM",
                            NormalizedUserName = "IVANGEROV@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELDud3qzfEB2l+cWAKXydiWVixDUNiznXmCsZD56lBudt6k77s7J8nWTlLKQ5nKTFw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6fc94814-a81a-4f09-a84d-2685b11fb9c3",
                            TwoFactorEnabled = false,
                            UserName = "ivangerov@gmail.com",
                            FirstName = "UserIvan",
                            IsActive = true,
                            LastName = "UserGerov"
                        },
                        new
                        {
                            Id = "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "11895550-fb8a-4adb-ac4c-7331ea4593ab",
                            Email = "admindealer@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINDEALER@GMAIL.COM",
                            NormalizedUserName = "ADMINDEALER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMWpYa9M5rOqSz7f6ub8wUa0j9T5Qr+L8MukZHTLFNjntd9uJR6oAYZKI2o+L0Cwbw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "37ac57e2-dffd-4096-a044-239bbe9f8c08",
                            TwoFactorEnabled = false,
                            UserName = "admindealer@gmail.com",
                            FirstName = "Ivan",
                            IsActive = true,
                            LastName = "Gerov"
                        },
                        new
                        {
                            Id = "1b151ae1-d290-44d5-8461-af3d415f9432",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "de186589-d94b-4c1f-986f-370b035e581b",
                            Email = "admintest@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINTEST@GMAIL.COM",
                            NormalizedUserName = "ADMINTEST@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEvjqDcOTcsJf01GcqOnZe5WjdFDBClmWqmbaH3ulZkEBKmQ28Ub4xdQCtaKaVDpeQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a924c042-130d-4289-86e3-f3c45b2fd4d5",
                            TwoFactorEnabled = false,
                            UserName = "admintest@gmail.com",
                            FirstName = "Admin",
                            IsActive = true,
                            LastName = "Test"
                        },
                        new
                        {
                            Id = "3568d76e-ff9b-4c43-9c03-863154db67b1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fec1c7ad-7e06-486b-8d65-7b62b0fb78a9",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJX60vytiXQY23psnwps09STHED/J16MsAhzudHngc1+5TJk62rTjXKw4zgTJHisSQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "77625162-dacd-4eff-b137-f94e510378f8",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com",
                            FirstName = "Main",
                            IsActive = true,
                            LastName = "Admin"
                        });
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Car", b =>
                {
                    b.HasOne("AutomotiveHub.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutomotiveHub.Infrastructure.Data.Models.Dealer", "Dealer")
                        .WithMany("Cars")
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutomotiveHub.Infrastructure.Data.Models.ApplicationUser", "Renter")
                        .WithMany()
                        .HasForeignKey("RenterId");

                    b.Navigation("Category");

                    b.Navigation("Dealer");

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Dealer", b =>
                {
                    b.HasOne("AutomotiveHub.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Dealership", b =>
                {
                    b.HasOne("AutomotiveHub.Infrastructure.Data.Models.City", "City")
                        .WithMany("Dealerships")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutomotiveHub.Infrastructure.Data.Models.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Dealer");
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Reservation", b =>
                {
                    b.HasOne("AutomotiveHub.Infrastructure.Data.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutomotiveHub.Infrastructure.Data.Models.ReservationPeriod", "ReservationPeriod")
                        .WithMany()
                        .HasForeignKey("ReservationPeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("ReservationPeriod");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.City", b =>
                {
                    b.Navigation("Dealerships");
                });

            modelBuilder.Entity("AutomotiveHub.Infrastructure.Data.Models.Dealer", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
