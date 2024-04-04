using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class ApplicationUsersNamesAndEmailsFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "81c131bf-d730-4f36-bc14-e3e9b70da0a0", "ADMINTEST@GMAIL.COM", "AQAAAAEAACcQAAAAECQ3Vu9yPXaKT8Z0INcdZcLCi2VJDNCVNonB4YvmP6EzgmHl1JbUqAU1j+DS6wUs7w==", "1db0416b-2c95-4e1a-a8f5-135cf761333a", "admintest@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aa708c92-f5b7-4fb6-8156-68171d9258c7", "IVANGEROV@GMAIL.COM", "AQAAAAEAACcQAAAAEPcK3AAgSVXC3FAVvEOlXavGl28AvNdbIOGlzoj975U1YTWXJ7noLudcddRPXFGsQg==", "fdf7261f-2da6-46d8-9760-e04e78875bde", "ivangerov@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 0, 25, 246, DateTimeKind.Local).AddTicks(956), new DateTime(2024, 4, 4, 21, 0, 25, 246, DateTimeKind.Local).AddTicks(918) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7306fafc-088e-4295-abb1-e9d5aeb1fbf1", "AQAAAAEAACcQAAAAEHEg52huXVY/JgiukoOiq29U9byJ9eRZfTzsqATVLF1PGFbVCehMfzSf7EVSQJmlcA==", "ad4e665e-3d44-4f9f-8c39-e46cef4d9262" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b151ae1-d290-44d5-8461-af3d415f9432",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "94f184dc-c192-4a38-823f-49f7f36e5571", "ADMINTEST", "AQAAAAEAACcQAAAAEL9cxJeLVi50TGtRHpEqw5YrT9zKt8FltWxc0IiFcw1/1JryKrr/SwXi2dKTBOoVaA==", "38942bdf-6915-4fda-b4d0-81e5e2103f20", "AdminTest" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "021116f7-b817-4403-b844-1aec00093f0a", "IVANGEROV", "AQAAAAEAACcQAAAAEPArEvaPPHH0lvl0CeDExQncQPHhjNp/etLkX3T8aMuDJj9237fgpxESpG4TBzurCQ==", "0ebda638-273c-4cbb-9f32-11a8f6707999", "IvanGerov" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 53, 22, 73, DateTimeKind.Local).AddTicks(5511), new DateTime(2024, 4, 4, 15, 53, 22, 73, DateTimeKind.Local).AddTicks(5466) });
        }
    }
}
