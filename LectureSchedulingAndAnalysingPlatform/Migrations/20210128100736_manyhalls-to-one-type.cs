using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class manyhallstoonetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls",
                column: "PermissionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls",
                column: "PermissionTypeId",
                unique: true,
                filter: "[PermissionTypeId] IS NOT NULL");
        }
    }
}
