using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class rem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Reservers_ReserverId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReserverId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4439b796-3653-4698-b033-c4557943d776");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4bf3dfc0-5d40-4fc0-a0b0-7d7076987df8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "89c74342-58af-40db-9b93-75ef425305e2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9da27523-e8ad-42ae-a61d-0a1736f11437");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "aeb66c6a-16db-4d2f-a2ea-4d3fc513be44");

            migrationBuilder.DropColumn(
                name: "ReserverId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Reservers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "de923c10-7132-4b7f-9aeb-6d4771fde90e", "99d1fefe-fa42-4648-a226-ae317d5dc9ee", "Teacher", "TEACHER" },
                    { "91b03e1a-c7f0-487d-b575-5c94d8d2418a", "a509f090-e88c-4fc3-8534-6b57305438f3", "Student", "STUDENT" },
                    { "6619f372-2df5-4a97-b5d0-70a637c59fff", "a62145ac-8f36-4c81-a5ce-60832e4a3f3f", "Admin", "ADMIN" },
                    { "218c66fc-e496-4576-8567-0579796e6d0b", "67068ecc-5bae-45db-a032-da1b09cfe353", "AR", "AR" },
                    { "d70061c7-ddaa-4a5b-bef3-61e13d20b403", "083800bb-040d-40b8-a553-35ae473b3985", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_ReservationId",
                table: "Reservers",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_Reservations_ReservationId",
                table: "Reservers",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_Reservations_ReservationId",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_ReservationId",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "218c66fc-e496-4576-8567-0579796e6d0b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6619f372-2df5-4a97-b5d0-70a637c59fff");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "91b03e1a-c7f0-487d-b575-5c94d8d2418a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d70061c7-ddaa-4a5b-bef3-61e13d20b403");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "de923c10-7132-4b7f-9aeb-6d4771fde90e");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Reservers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReserverId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "89c74342-58af-40db-9b93-75ef425305e2", "aeed7b82-44bb-449b-a957-ace017242968", "Teacher", "TEACHER" },
                    { "4439b796-3653-4698-b033-c4557943d776", "c0947c9d-e13b-4ab4-a9fd-d53b7797241f", "Student", "STUDENT" },
                    { "9da27523-e8ad-42ae-a61d-0a1736f11437", "bcae1674-58d5-450d-a92a-0b3f67a2283c", "Admin", "ADMIN" },
                    { "aeb66c6a-16db-4d2f-a2ea-4d3fc513be44", "ffde8e41-2852-4b67-93e3-e1d6542780c7", "AR", "AR" },
                    { "4bf3dfc0-5d40-4fc0-a0b0-7d7076987df8", "4f5cc7de-ffea-425c-bef5-f28a67adb9dd", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReserverId",
                table: "Reservations",
                column: "ReserverId",
                unique: true,
                filter: "[ReserverId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Reservers_ReserverId",
                table: "Reservations",
                column: "ReserverId",
                principalTable: "Reservers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
