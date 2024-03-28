using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class FinalSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "843e4b0a-b843-4d8c-89cc-a3b58be59e8b", "AQAAAAEAACcQAAAAELQsJqR7n+4S624t7pjTs9eSK7qrjNsmmPrxIdNKembSkl6FlHdrm5gE+kVkQUdJUw==", "c02804c4-e561-4660-b1ac-7366e2c16360" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e1bd4e6-ab89-4490-a276-87c350e034dd", 0, "3d5c788a-afc4-473b-97c0-47e67575667a", "ApplicationUser", "admindealer@gmail.com", false, "Administrator", true, false, null, "ADMINDEALER@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEM4rnuFMvmr7QggQLpF6MJl2g6YTgOGWJs0V/Q1rsMlKmGPSY1HbXR5M/zwpM1feNw==", null, false, "d02cb2fb-7b8c-4fa2-93a6-503cf64e1ce4", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CategoryId", "DealerId", "Description", "Fuel", "ImageUrl", "IsActive", "Kilometers", "Model", "PricePerDay", "RenterId", "Transmission", "Year" },
                values: new object[,]
                {
                    { 2, "Audi", 2, 1, "4.0-litre twin-turbocharged V8.With 563HP and 590lb-ft of Torque is everything you need for a long and dynamic ride.", 1, "https://www.topgear.com/sites/default/files/2022/06/Medium-29191-AudiS8TFSIquattro.jpg?w=976&h=549", true, 1350, "S8", 499, null, 0, 2024 },
                    { 6, "Lexus", 1, 1, "If you need a convertible for the summer trip this Lexus nails it.With a V8 465bhp and 398lb-ft.Comfortable, stylish and exclusive.", 1, "https://www.topgear.com/sites/default/files/cars-car/carousel/2020/09/lc500c_238-scaled.jpg?w=892&h=502", true, 11600, "LC500 Convertible", 379, null, 0, 2022 }
                });

            migrationBuilder.InsertData(
                table: "Dealerships",
                columns: new[] { "Id", "Address", "CityId", "DealerId", "Name" },
                values: new object[] { 2, "Plovdiv, bul.Bulgaria 3", 2, 1, "LuxNWheels Dealership" });

            migrationBuilder.InsertData(
                table: "ReservationPeriods",
                columns: new[] { "Id", "Days" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 5 },
                    { 4, 7 },
                    { 5, 10 },
                    { 6, 30 }
                });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "Id", "Name", "PhoneNumber", "UserId" },
                values: new object[] { 2, "Prestige Rentals", "+359894333878", "0e1bd4e6-ab89-4490-a276-87c350e034dd" });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "Id", "Name", "PhoneNumber", "UserId" },
                values: new object[] { 3, "Fast Lane Autos", "+359878931336", "0e1bd4e6-ab89-4490-a276-87c350e034dd" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CarId", "EndDate", "IsActive", "ReservationPeriodId", "StartDate", "TotalPrice" },
                values: new object[] { 1, 2, new DateTime(2024, 3, 31, 10, 34, 28, 629, DateTimeKind.Local).AddTicks(7913), false, 2, new DateTime(2024, 3, 28, 10, 34, 28, 629, DateTimeKind.Local).AddTicks(7870), 1397 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CategoryId", "DealerId", "Description", "Fuel", "ImageUrl", "IsActive", "Kilometers", "Model", "PricePerDay", "RenterId", "Transmission", "Year" },
                values: new object[,]
                {
                    { 1, "Audi", 1, 3, "4.0l twin-turbo V8 with bigger turbochargers, modified ECU for a total of 768bhp. This high performance Audi transformed by Mansory is the unforgettable weekend escape.", 1, "https://www.topgear.com/sites/default/files/2021/10/904263.jpg?w=892&h=502", true, 4500, "RS6", 399, null, 0, 2023 },
                    { 3, "Porshe", 5, 3, "You need a track car for the streets? This stylish sport car is for you.", 1, "https://www.topgear.com/sites/default/files/cars-car/carousel/2020/12/pcgb20_0589_fine.jpg?w=892&h=502", true, 7500, "911 Turbo", 349, null, 0, 2022 },
                    { 4, "Volkswagen", 3, 2, "3.0-litre V6 Diesel with 282bhp.It's more than capable of holding its own on the road, now in utter refinement, and it’s highly impressive off the beaten track too. ", 0, "https://www.topgear.com/sites/default/files/2023/11/Medium-36020-TouaregElegance.jpg?w=892&h=502", true, 3500, "Touareg", 299, null, 0, 2020 },
                    { 7, "Audi", 3, 2, "350bhp with a battery-89kWh for a range up to 460km.", 3, "https://www.topgear.com/sites/default/files/2024/03/32673-Q8ETRONDEANSMITH07.jpg?w=892&h=502", true, 15850, "Q8 e-tron", 399, null, 0, 2020 },
                    { 8, "Toyota", 3, 2, "If you need practical and useful SUV this is the one.It has 2.5-litre four-cylinder engine good for about 203hp.", 0, "https://www.topgear.com/sites/default/files/2024/02/15%20Toyota%20RAV4%20US%20review%202024.jpg?w=892&h=502", true, 24500, "Rav4", 250, null, 0, 2018 }
                });

            migrationBuilder.InsertData(
                table: "Dealerships",
                columns: new[] { "Id", "Address", "CityId", "DealerId", "Name" },
                values: new object[,]
                {
                    { 1, "Sofia, bul.Botevgradsko shose 320", 1, 3, "Race Culture Dealership" },
                    { 3, "Sofia, bul.Botevgradsko shose 320", 4, 2, "Auto Class Dealership" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dealerships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dealerships",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dealerships",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationPeriods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReservationPeriods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationPeriods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReservationPeriods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReservationPeriods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationPeriods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3471407d-ac8b-477a-acf4-49b45e004593", "AQAAAAEAACcQAAAAEGyRDHGgx43G1//2j8xA+vrrY1yLNsY0/tQ/ZpXESTQaYTLIqRfGO+Gi/iyvlHPYbQ==", "1bfbb229-c421-4450-8762-a447bb90f4e1" });
        }
    }
}
