using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class onehallmanysessions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sessions_HallId",
                table: "Sessions");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "076f1c11-eb7e-4765-87fc-fa469233c1fe");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "37f2dd58-7c8f-407a-84e1-92b1e4cab83c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "85993c77-4830-4706-b03f-d0421c61a099");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ca2e3960-7a10-4622-bfc8-e0f531a271de");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "db527aa0-a2df-445b-9128-a18d9057ca66");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9fd308f9-29ab-463d-8a6d-d162592c2d13", "b8f5a863-9dba-4073-9783-81dd7cb9abf8", "Teacher", "TEACHER" },
                    { "124f7a62-4fd1-46b9-9759-ff41d7c2092c", "ce18151d-f385-4988-87cd-d651ac31a6ea", "Student", "STUDENT" },
                    { "67e765d3-d1f6-4a75-8e62-54f4835e4f4a", "43ed5bfa-7e52-4495-9301-f33a415b0e24", "Admin", "ADMIN" },
                    { "f78a7587-2eb8-4062-80ee-82256e2a1363", "350e1d70-289c-4aaa-b64a-bec29c1cc1b7", "AR", "AR" },
                    { "5ffa5d89-5a27-4f11-8405-0796db1671c8", "6f04d348-d90d-4c2d-92dc-bfcb64dfcd8b", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_HallId",
                table: "Sessions",
                column: "HallId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sessions_HallId",
                table: "Sessions");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "124f7a62-4fd1-46b9-9759-ff41d7c2092c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5ffa5d89-5a27-4f11-8405-0796db1671c8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "67e765d3-d1f6-4a75-8e62-54f4835e4f4a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9fd308f9-29ab-463d-8a6d-d162592c2d13");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f78a7587-2eb8-4062-80ee-82256e2a1363");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ca2e3960-7a10-4622-bfc8-e0f531a271de", "3176bf58-b8f7-4278-87ef-b9e86c884619", "Teacher", "TEACHER" },
                    { "37f2dd58-7c8f-407a-84e1-92b1e4cab83c", "9b938b4f-46f9-49d7-b731-ab358f3d8c40", "Student", "STUDENT" },
                    { "db527aa0-a2df-445b-9128-a18d9057ca66", "4099f1e0-14ce-446a-8b31-ec43907e83f1", "Admin", "ADMIN" },
                    { "076f1c11-eb7e-4765-87fc-fa469233c1fe", "d0bd3cdb-485f-40a8-8aa1-e0632349693d", "AR", "AR" },
                    { "85993c77-4830-4706-b03f-d0421c61a099", "586403fd-423d-43a5-adb6-df82419bf766", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_HallId",
                table: "Sessions",
                column: "HallId",
                unique: true,
                filter: "[HallId] IS NOT NULL");
        }
    }
}
