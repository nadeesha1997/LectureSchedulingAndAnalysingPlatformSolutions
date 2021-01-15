using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class permissiontypenew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_PermissionTypes_PermissionTypeId",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls");

            migrationBuilder.AlterColumn<int>(
                name: "PermissionTypeId",
                table: "Halls",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls",
                column: "PermissionTypeId",
                unique: true,
                filter: "[PermissionTypeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_PermissionTypes_PermissionTypeId",
                table: "Halls",
                column: "PermissionTypeId",
                principalTable: "PermissionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_PermissionTypes_PermissionTypeId",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls");

            migrationBuilder.AlterColumn<int>(
                name: "PermissionTypeId",
                table: "Halls",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls",
                column: "PermissionTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_PermissionTypes_PermissionTypeId",
                table: "Halls",
                column: "PermissionTypeId",
                principalTable: "PermissionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
