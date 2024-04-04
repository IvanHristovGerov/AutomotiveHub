using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class ApplicationUserModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "FullName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1bd4e6-ab89-4490-a276-87c350e034dd",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d5c788a-afc4-473b-97c0-47e67575667a", "Administrator", "AQAAAAEAACcQAAAAEM4rnuFMvmr7QggQLpF6MJl2g6YTgOGWJs0V/Q1rsMlKmGPSY1HbXR5M/zwpM1feNw==", "d02cb2fb-7b8c-4fa2-93a6-503cf64e1ce4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "843e4b0a-b843-4d8c-89cc-a3b58be59e8b", "Ivan Gerov", "AQAAAAEAACcQAAAAELQsJqR7n+4S624t7pjTs9eSK7qrjNsmmPrxIdNKembSkl6FlHdrm5gE+kVkQUdJUw==", "c02804c4-e561-4660-b1ac-7366e2c16360" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 34, 28, 629, DateTimeKind.Local).AddTicks(7913), new DateTime(2024, 3, 28, 10, 34, 28, 629, DateTimeKind.Local).AddTicks(7870) });
        }
    }
}
