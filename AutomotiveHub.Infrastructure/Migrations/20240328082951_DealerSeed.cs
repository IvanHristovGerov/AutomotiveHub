using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveHub.Infrastructure.Migrations
{
    public partial class DealerSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3471407d-ac8b-477a-acf4-49b45e004593", "AQAAAAEAACcQAAAAEGyRDHGgx43G1//2j8xA+vrrY1yLNsY0/tQ/ZpXESTQaYTLIqRfGO+Gi/iyvlHPYbQ==", "1bfbb229-c421-4450-8762-a447bb90f4e1" });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "Id", "Name", "PhoneNumber", "UserId" },
                values: new object[] { 1, "Luxury Motors", "+359888321456", "8cb5bcce-a58e-4271-9a58-13811fc3c9e3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cb5bcce-a58e-4271-9a58-13811fc3c9e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "111e0778-0bf0-4dfe-8f29-72fe856de4a0", "AQAAAAEAACcQAAAAEH+LSkRaEFvEgoYn14H6ciNzriQ8aX3YYw6auZsfWKUzJ9B8qhOitjJvRRCDweSRfw==", "a43db6e1-e876-46ac-b084-0965176c8f5c" });
        }
    }
}
