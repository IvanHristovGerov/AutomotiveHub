using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class MissingCarsAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3a4d43c-74f6-4b11-a989-8f596ef19233", "AQAAAAEAACcQAAAAELMlJ8jG6QsOoXE8APYRiWNQTaYkSyBf46X26W8SiHEtrMFIiWcuaqFw9vacYAOnNg==", "b9fe31d6-2fec-4278-bd3f-7347362990f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20afba5c-1d12-4328-a29a-64c165175678", "AQAAAAEAACcQAAAAEMqX/13Qn6NeUDsmu0NAMTaQhhuptPGLfqDfRaDkb1WV7G0CD8XGBWMT0LSLsSiA5w==", "da65a66a-ec06-4222-aa93-38ebc7f1e7c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fba7145-bb59-4944-b8ff-a41115fa92bf", "AQAAAAEAACcQAAAAEHDsYWFzqxbbxQ582kPquyndJ7QHCs1WuMGi9Mo4KSTBS9ASO/e2Id0m2+Rjhx/UnQ==", "b5e12c1a-43d1-4f38-a13a-57ec0817d149" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DealerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DealerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DealerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "DealerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "DealerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 6, 19, 32, 33, 824, DateTimeKind.Local).AddTicks(9795), new DateTime(2024, 4, 3, 19, 32, 33, 824, DateTimeKind.Local).AddTicks(9755) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 6, 19, 30, 23, 312, DateTimeKind.Local).AddTicks(7702), new DateTime(2024, 4, 3, 19, 30, 23, 312, DateTimeKind.Local).AddTicks(7651) });
        }
    }
}
