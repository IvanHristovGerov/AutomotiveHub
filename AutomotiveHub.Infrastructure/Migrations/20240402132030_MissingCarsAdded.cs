using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class MissingCarsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe3882a2-e05e-4dfc-941d-3ab3872c1e2a", "AQAAAAEAACcQAAAAELiQd6Dv3gW0BE8Ln2XZtSfQwJJ+zBO78TC88264s971MZZw9IhE22KYqpNHNkPN2A==", "cc8620f4-2792-42a8-a406-9299c5443871" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5fd264d-d9a8-463d-be11-1e1667fd0510", "AQAAAAEAACcQAAAAEF4Jd0NBtZ4m5ZvWErDTiATuAZNC7yK86viBwbRu7mlsrh8WtwXmvKy+qn/xNFGD8A==", "f89f33b3-628b-488f-b0d8-bf881dc22387" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "572a7285-a7ea-4b08-ae32-85c73f1f8bc8", "AQAAAAEAACcQAAAAEMeoSTrtDsKGv2kLW8UJ6FQpHvDJX6+Z0nTCbcsYXL45vZwy9SGFT7RdylUB9oYqxg==", "d71a7f9d-6f5f-4cda-a23b-961fc2ab2a25" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DealerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DealerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DealerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "DealerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "DealerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 20, 27, 830, DateTimeKind.Local).AddTicks(6268), new DateTime(2024, 4, 2, 16, 20, 27, 830, DateTimeKind.Local).AddTicks(6217) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b794fab-aa26-47de-8fde-b43700d35afe", "AQAAAAEAACcQAAAAEAOPpPh/hmC+Sq4uGBkEr06jCpYqAwBu4IxJ8AzeP64v4ViVyXzNiUHW4tWS2sfuRQ==", "1d8d665d-6a31-42a2-9912-733e7f01579a" });

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
                table: "Dealers",
                columns: new[] { "Id", "Name", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { 2, "Prestige Rentals", "+359894333878", "0e1bd4e6-ab89-4490-a276-87c350e034dd" },
                    { 3, "Fast Lane Autos", "+359878931334", "0e1bd4e6-ab89-4490-a276-87c350e034dd" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 14, 59, 54, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 4, 2, 16, 14, 59, 54, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DealerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DealerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DealerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "DealerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "DealerId",
                value: 2);
        }
    }
}
