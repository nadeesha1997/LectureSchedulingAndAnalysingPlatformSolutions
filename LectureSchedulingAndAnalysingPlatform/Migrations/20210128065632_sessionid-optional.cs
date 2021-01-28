using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class sessionidoptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Sessions_SessionId",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_SessionId",
                table: "Permissions");

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Permissions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_SessionId",
                table: "Permissions",
                column: "SessionId",
                unique: true,
                filter: "[SessionId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Sessions_SessionId",
                table: "Permissions",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Sessions_SessionId",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_SessionId",
                table: "Permissions");

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Permissions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_SessionId",
                table: "Permissions",
                column: "SessionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Sessions_SessionId",
                table: "Permissions",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
