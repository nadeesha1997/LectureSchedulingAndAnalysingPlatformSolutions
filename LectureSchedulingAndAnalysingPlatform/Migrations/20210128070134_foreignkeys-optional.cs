using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class foreignkeysoptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Halls_HallId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Reservers_ReserverId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Sessions_SessionId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_ReserverTypes_ReserverTypeId",
                table: "Reservers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_Users_UserId",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_ReserverTypeId",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_HallId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReserverId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_SessionId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reservers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ReserverTypeId",
                table: "Reservers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Reservations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ReserverId",
                table: "Reservations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HallId",
                table: "Reservations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_ReserverTypeId",
                table: "Reservers",
                column: "ReserverTypeId",
                unique: true,
                filter: "[ReserverTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_HallId",
                table: "Reservations",
                column: "HallId",
                unique: true,
                filter: "[HallId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReserverId",
                table: "Reservations",
                column: "ReserverId",
                unique: true,
                filter: "[ReserverId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SessionId",
                table: "Reservations",
                column: "SessionId",
                unique: true,
                filter: "[SessionId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Halls_HallId",
                table: "Reservations",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Reservers_ReserverId",
                table: "Reservations",
                column: "ReserverId",
                principalTable: "Reservers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Sessions_SessionId",
                table: "Reservations",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_ReserverTypes_ReserverTypeId",
                table: "Reservers",
                column: "ReserverTypeId",
                principalTable: "ReserverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_Users_UserId",
                table: "Reservers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Halls_HallId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Reservers_ReserverId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Sessions_SessionId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_ReserverTypes_ReserverTypeId",
                table: "Reservers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_Users_UserId",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_ReserverTypeId",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_HallId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReserverId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_SessionId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reservers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReserverTypeId",
                table: "Reservers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReserverId",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HallId",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_ReserverTypeId",
                table: "Reservers",
                column: "ReserverTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_HallId",
                table: "Reservations",
                column: "HallId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReserverId",
                table: "Reservations",
                column: "ReserverId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SessionId",
                table: "Reservations",
                column: "SessionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Halls_HallId",
                table: "Reservations",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Reservers_ReserverId",
                table: "Reservations",
                column: "ReserverId",
                principalTable: "Reservers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Sessions_SessionId",
                table: "Reservations",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_ReserverTypes_ReserverTypeId",
                table: "Reservers",
                column: "ReserverTypeId",
                principalTable: "ReserverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_Users_UserId",
                table: "Reservers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
