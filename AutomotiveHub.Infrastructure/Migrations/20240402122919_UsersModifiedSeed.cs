using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class UsersModifiedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f57f554-bc53-44b1-8856-2cd7efd5b661", "Ivan", "Gerov", "AQAAAAEAACcQAAAAEFWRi+m2jwKRXdjbJYKLmfoSUNSJ1qA411VaD7NEYOjqzKqSXlWwYmlDZdlFQ6EGmQ==", "cacf4526-eb6b-475a-990f-180427a5b6f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8830c344-c602-49e3-a51b-28107c1ba513", "UserIvan", "UserGerov", "AQAAAAEAACcQAAAAEAEnHUYX8ORJ8nYgaVLIwMdhNHcTSCW59vj0iqzibt6f08sbN0NYLXRTeitVh1v2sw==", "700972eb-bf27-4e36-8aa8-916c8a3745b7" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 15, 29, 18, 106, DateTimeKind.Local).AddTicks(6675), new DateTime(2024, 4, 2, 15, 29, 18, 106, DateTimeKind.Local).AddTicks(6633) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bae34be-02b9-4c9f-9adc-2c60192b07d6", "", "", "AQAAAAEAACcQAAAAEAt9lbxytCKJa6b2+BlJcK0SxAoX0ZjcxKRs2T63pkdr7v2xjIwXVk6zEMZ9s5q2ZA==", "da1621ba-f598-4d7d-ba0a-baf5a5898905" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8546f63-d8f5-4f36-93b2-34998e152381", "", "", "AQAAAAEAACcQAAAAEIRjzaxREHKi9fMY6eWB+1+j0CVPXfL/FkYuxUwG83T8n1zIE1Hcd0kakaoaoBRuUQ==", "34ec4eae-16f9-4317-8342-b25591428d76" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 5, 15, 4, 49, 119, DateTimeKind.Local).AddTicks(3678), new DateTime(2024, 4, 2, 15, 4, 49, 119, DateTimeKind.Local).AddTicks(3632) });
        }
    }
}
