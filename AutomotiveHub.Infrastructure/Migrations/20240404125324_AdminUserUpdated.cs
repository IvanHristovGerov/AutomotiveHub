using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class AdminUserUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7306fafc-088e-4295-abb1-e9d5aeb1fbf1", "ADMINDEALER@GMAIL.COM", "AQAAAAEAACcQAAAAEHEg52huXVY/JgiukoOiq29U9byJ9eRZfTzsqATVLF1PGFbVCehMfzSf7EVSQJmlcA==", "ad4e665e-3d44-4f9f-8c39-e46cef4d9262", "admindealer@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f184dc-c192-4a38-823f-49f7f36e5571", "AQAAAAEAACcQAAAAEL9cxJeLVi50TGtRHpEqw5YrT9zKt8FltWxc0IiFcw1/1JryKrr/SwXi2dKTBOoVaA==", "38942bdf-6915-4fda-b4d0-81e5e2103f20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021116f7-b817-4403-b844-1aec00093f0a", "AQAAAAEAACcQAAAAEPArEvaPPHH0lvl0CeDExQncQPHhjNp/etLkX3T8aMuDJj9237fgpxESpG4TBzurCQ==", "0ebda638-273c-4cbb-9f32-11a8f6707999" });

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
                values: new object[] { new DateTime(2024, 4, 7, 15, 53, 22, 73, DateTimeKind.Local).AddTicks(5511), new DateTime(2024, 4, 4, 15, 53, 22, 73, DateTimeKind.Local).AddTicks(5466) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e3a4d43c-74f6-4b11-a989-8f596ef19233", "ADMIN", "AQAAAAEAACcQAAAAELMlJ8jG6QsOoXE8APYRiWNQTaYkSyBf46X26W8SiHEtrMFIiWcuaqFw9vacYAOnNg==", "b9fe31d6-2fec-4278-bd3f-7347362990f7", "Admin" });

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
    }
}
