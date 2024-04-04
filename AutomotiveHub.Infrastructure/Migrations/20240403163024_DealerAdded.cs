using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class DealerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e16aaea-a2b8-430b-b0c4-116d2bd89c92", "AQAAAAEAACcQAAAAEB9YsOWfYGGPnFE7tBwpRqtnsoRI+Z2UpziTF0YZGLv95EHXrGQwlNlo6uTf82KePA==", "461d397d-798c-4c6b-8f2a-ed8a19c75eec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7daeef33-9635-46d9-aa58-1d5214fefa48", "AQAAAAEAACcQAAAAEBJUrcCZNwNLVOTuJo1mLE0/rlY+rJ/LX0Sb34VxVldRVoEnZPweDnw2EAnYsnBOUw==", "bf064251-d2f7-41e3-bd05-b7633a45076d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48f91063-889f-4edb-bf4c-d569dcbe4bf9", "AQAAAAEAACcQAAAAEBN+nqmKM9s0QjMkwttOWG/S3mGV98lgTQT6ZBEStBBpG7z0W6nn+VgGArSwsv1LRQ==", "2edb12ea-86df-44f8-a241-3183e12009d5" });

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

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "Id", "Name", "PhoneNumber", "UserId" },
                values: new object[] { 4, "Prestige Rents", "+359894333878", "0e1bd4e6-ab89-4490-a276-87c350e034dd" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 6, 19, 30, 23, 312, DateTimeKind.Local).AddTicks(7702), new DateTime(2024, 4, 3, 19, 30, 23, 312, DateTimeKind.Local).AddTicks(7651) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}
