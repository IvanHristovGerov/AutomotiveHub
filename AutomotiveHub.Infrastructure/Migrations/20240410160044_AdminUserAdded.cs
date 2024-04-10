using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class AdminUserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11895550-fb8a-4adb-ac4c-7331ea4593ab", "AQAAAAEAACcQAAAAEMWpYa9M5rOqSz7f6ub8wUa0j9T5Qr+L8MukZHTLFNjntd9uJR6oAYZKI2o+L0Cwbw==", "37ac57e2-dffd-4096-a044-239bbe9f8c08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de186589-d94b-4c1f-986f-370b035e581b", "AQAAAAEAACcQAAAAEEvjqDcOTcsJf01GcqOnZe5WjdFDBClmWqmbaH3ulZkEBKmQ28Ub4xdQCtaKaVDpeQ==", "a924c042-130d-4289-86e3-f3c45b2fd4d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd0bcf92-d377-4e7b-97d2-ef5df5e2411c", "AQAAAAEAACcQAAAAELDud3qzfEB2l+cWAKXydiWVixDUNiznXmCsZD56lBudt6k77s7J8nWTlLKQ5nKTFw==", "6fc94814-a81a-4f09-a84d-2685b11fb9c3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3568d76e-ff9b-4c43-9c03-863154db67b1", 0, "fec1c7ad-7e06-486b-8d65-7b62b0fb78a9", "ApplicationUser", "admin@mail.com", false, "Main", true, "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEJX60vytiXQY23psnwps09STHED/J16MsAhzudHngc1+5TJk62rTjXKw4zgTJHisSQ==", null, false, "77625162-dacd-4eff-b137-f94e510378f8", false, "admin@mail.com" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 0, 43, 744, DateTimeKind.Local).AddTicks(3221), new DateTime(2024, 4, 10, 19, 0, 43, 744, DateTimeKind.Local).AddTicks(3182) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3568d76e-ff9b-4c43-9c03-863154db67b1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b9d5758-17da-412b-a55d-3fbc69a19066", "AQAAAAEAACcQAAAAEM4VMGDvMS81TkQBh/45Cm/+fiTiolaiGWtNq5LWlbPYrog70nkY17v6AMvSmRfxtw==", "c322875c-660e-4345-95cc-918adb1b990f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81c131bf-d730-4f36-bc14-e3e9b70da0a0", "AQAAAAEAACcQAAAAECQ3Vu9yPXaKT8Z0INcdZcLCi2VJDNCVNonB4YvmP6EzgmHl1JbUqAU1j+DS6wUs7w==", "1db0416b-2c95-4e1a-a8f5-135cf761333a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa708c92-f5b7-4fb6-8156-68171d9258c7", "AQAAAAEAACcQAAAAEPcK3AAgSVXC3FAVvEOlXavGl28AvNdbIOGlzoj975U1YTWXJ7noLudcddRPXFGsQg==", "fdf7261f-2da6-46d8-9760-e04e78875bde" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 0, 25, 246, DateTimeKind.Local).AddTicks(956), new DateTime(2024, 4, 4, 21, 0, 25, 246, DateTimeKind.Local).AddTicks(918) });
        }
    }
}
