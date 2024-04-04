using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class ApplicationUserDataFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dd34eec-81e5-4418-bc4f-310e99645eda", "AQAAAAEAACcQAAAAELLXhnk8dM7N60i2dIzuf7M7d57DbUplkHatV5zCFyQRIFQXVOSTIDEzIpQP5HVAwg==", "8687ad2c-bdbe-4ada-9c19-a033af63be0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b846736-9172-4240-8a43-31ff12db4df1", "AQAAAAEAACcQAAAAELzhI8yfh1rsAYE896vwJ0NFufuBSseHXnnevLL8yfH/XK8jRq36lV+AdKpzYjqQ8w==", "e35e7f49-5fe6-448b-813b-20ef77b390bb" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e1bd4e6-ab89-4490-a276-87c350e034dd", 0, "9b794fab-aa26-47de-8fde-b43700d35afe", "ApplicationUser", "admindealer@gmail.com", false, "Ivan", true, "Gerov", false, null, "ADMINDEALER@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEAOPpPh/hmC+Sq4uGBkEr06jCpYqAwBu4IxJ8AzeP64v4ViVyXzNiUHW4tWS2sfuRQ==", null, false, "1d8d665d-6a31-42a2-9912-733e7f01579a", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 14, 59, 54, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 4, 2, 16, 14, 59, 54, DateTimeKind.Local).AddTicks(4025) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e590ed6-6a86-46da-9b66-247a3c973423", "AQAAAAEAACcQAAAAEDjP4/irA0aiWcvxYcjmf4WIksJnzlWa7mf7l6BxkLSIsBWTUNbXbUQqvvKzFdhoDA==", "3b55c0ef-5aa7-4f7d-85ce-ea57868875b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32b635da-2ab5-491e-81f9-66b86414110b", "AQAAAAEAACcQAAAAEKEQh+KQcnA4rsr6HCGBm/TIZNT+ya9037ZXZDCg0aeKGl7OtDukVQ0QEwm/dh+pOA==", "1f35af28-1c33-49e0-99cf-8148ea68a2ce" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 8, 24, 409, DateTimeKind.Local).AddTicks(893), new DateTime(2024, 4, 2, 16, 8, 24, 409, DateTimeKind.Local).AddTicks(852) });
        }
    }
}
