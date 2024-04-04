using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class DataFixedMissingDealersAndCars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "+35988832145");

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "+359878931334");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 8, 24, 409, DateTimeKind.Local).AddTicks(893), new DateTime(2024, 4, 2, 16, 8, 24, 409, DateTimeKind.Local).AddTicks(852) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3cb7834-38ac-4bed-8ee3-108fceb7691a", "AQAAAAEAACcQAAAAELbbhkqdu+ZU0Hm2TKYHPGUdsojrHJdpK2ztCC95iPkiWuUwFB6bcAAp5muDKN/cDQ==", "4736dc4d-1072-4c17-9095-828988ac32cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a72add7e-7495-4f86-8186-9658e83d01a6", "AQAAAAEAACcQAAAAEMTyfSkSszJ5zf6qaHJyGZdVbb6DAghUyh0I9oudvSDh7mEErH5gt0Lp7B9btGuFRg==", "e68c8948-d1bc-435b-bab4-76c8aeaf3874" });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "+359888321456");

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "+359878931336");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 0, 57, 965, DateTimeKind.Local).AddTicks(1568), new DateTime(2024, 4, 2, 16, 0, 57, 965, DateTimeKind.Local).AddTicks(1514) });
        }
    }
}
