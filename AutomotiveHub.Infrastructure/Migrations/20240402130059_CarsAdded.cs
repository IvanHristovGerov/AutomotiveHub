using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class CarsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: 2022);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Kilometers",
                value: 8500);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: 2021);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Kilometers",
                value: 11750);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Kilometers",
                value: 16850);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Kilometers", "Year" },
                values: new object[] { 26500, 2019 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 0, 57, 965, DateTimeKind.Local).AddTicks(1568), new DateTime(2024, 4, 2, 16, 0, 57, 965, DateTimeKind.Local).AddTicks(1514) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b803ee-50fd-4a0a-854f-2a2836a3b4b5", "AQAAAAEAACcQAAAAEGVn5d1cm07aXlDPNU6wFBwk+BKUNUN9rPq5ke2Nwj4Y0tSzVz9RAoMVr3xa1c5zLQ==", "80007991-6748-4302-8723-c32ee3b41f66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fdf38f0-ab13-4a83-93ee-cdea9d08894a", "AQAAAAEAACcQAAAAEO37+eNJArGUJV5tY1/fd/22Lrx/WlTP8OYSlsYmV44BFkJKvlu6b0pcbCsnkp4Evw==", "f32f6b42-cb9b-4918-a5e2-5b32dca78d4a" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: 2023);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Kilometers",
                value: 7500);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: 2020);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Kilometers",
                value: 11600);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Kilometers",
                value: 15850);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Kilometers", "Year" },
                values: new object[] { 24500, 2018 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 15, 40, 57, 851, DateTimeKind.Local).AddTicks(4409), new DateTime(2024, 4, 2, 15, 40, 57, 851, DateTimeKind.Local).AddTicks(4357) });
        }
    }
}
