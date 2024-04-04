using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class NewApplicationUserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fdf38f0-ab13-4a83-93ee-cdea9d08894a", "AQAAAAEAACcQAAAAEO37+eNJArGUJV5tY1/fd/22Lrx/WlTP8OYSlsYmV44BFkJKvlu6b0pcbCsnkp4Evw==", "f32f6b42-cb9b-4918-a5e2-5b32dca78d4a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b151ae1-d290-44d5-8461-af3d415f9432", 0, "a7b803ee-50fd-4a0a-854f-2a2836a3b4b5", "ApplicationUser", "admintest@gmail.com", false, "Admin", true, "Test", false, null, "ADMINTEST@GMAIL.COM", "ADMINTEST", "AQAAAAEAACcQAAAAEGVn5d1cm07aXlDPNU6wFBwk+BKUNUN9rPq5ke2Nwj4Y0tSzVz9RAoMVr3xa1c5zLQ==", null, false, "80007991-6748-4302-8723-c32ee3b41f66", false, "AdminTest" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 15, 40, 57, 851, DateTimeKind.Local).AddTicks(4409), new DateTime(2024, 4, 2, 15, 40, 57, 851, DateTimeKind.Local).AddTicks(4357) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8830c344-c602-49e3-a51b-28107c1ba513", "AQAAAAEAACcQAAAAEAEnHUYX8ORJ8nYgaVLIwMdhNHcTSCW59vj0iqzibt6f08sbN0NYLXRTeitVh1v2sw==", "700972eb-bf27-4e36-8aa8-916c8a3745b7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e1bd4e6-ab89-4490-a276-87c350e034dd", 0, "4f57f554-bc53-44b1-8856-2cd7efd5b661", "ApplicationUser", "admindealer@gmail.com", false, "Ivan", true, "Gerov", false, null, "ADMINDEALER@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEFWRi+m2jwKRXdjbJYKLmfoSUNSJ1qA411VaD7NEYOjqzKqSXlWwYmlDZdlFQ6EGmQ==", null, false, "cacf4526-eb6b-475a-990f-180427a5b6f3", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 15, 29, 18, 106, DateTimeKind.Local).AddTicks(6675), new DateTime(2024, 4, 2, 15, 29, 18, 106, DateTimeKind.Local).AddTicks(6633) });
        }
    }
}
