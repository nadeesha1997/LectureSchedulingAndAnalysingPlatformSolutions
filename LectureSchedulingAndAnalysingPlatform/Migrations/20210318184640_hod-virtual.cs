using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class hodvirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Hods_DepartmentId",
                table: "Hods");

            migrationBuilder.DropIndex(
                name: "IX_Hods_UserId",
                table: "Hods");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "73d4ddae-860c-419e-aff8-b2a4588b9c3c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "741e6f26-2a9f-4a9f-8c70-401f406cf915");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "83763bc2-84fd-44d7-a214-ce7647f64b6f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d3c8d0cc-42be-4f42-b260-f58bae4a0019");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e3178dad-f3af-4a25-aeb9-b8260712c09d");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e855a7b7-2ed4-4290-957b-1cdb7019c0a6", "2e5cf8ab-7202-484a-93b8-25567f511e29", "Teacher", "TEACHER" },
                    { "a7aa7923-10b3-4318-a4f7-b166cfc2db78", "39e7a521-a4ce-49f2-8910-2a050a4f64bf", "Student", "STUDENT" },
                    { "abed848b-da38-431b-9f7f-7ea83b73faef", "bddfaf29-6170-47ca-8bbd-4f2e47d6426b", "Admin", "ADMIN" },
                    { "b077743c-07b1-4fc8-8730-06a15f46f6b9", "26c26f84-5196-4058-ac80-66e9d01ec74b", "AR", "AR" },
                    { "46b47973-58da-48f9-afa7-8c253daa3800", "5e8458dd-4dab-42b4-97b0-3f1e78bde4f7", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hods_DepartmentId",
                table: "Hods",
                column: "DepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hods_UserId",
                table: "Hods",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Hods_DepartmentId",
                table: "Hods");

            migrationBuilder.DropIndex(
                name: "IX_Hods_UserId",
                table: "Hods");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "46b47973-58da-48f9-afa7-8c253daa3800");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a7aa7923-10b3-4318-a4f7-b166cfc2db78");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "abed848b-da38-431b-9f7f-7ea83b73faef");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b077743c-07b1-4fc8-8730-06a15f46f6b9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e855a7b7-2ed4-4290-957b-1cdb7019c0a6");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e3178dad-f3af-4a25-aeb9-b8260712c09d", "fc050c8d-3256-4b71-9586-6a5e26595144", "Teacher", "TEACHER" },
                    { "741e6f26-2a9f-4a9f-8c70-401f406cf915", "82852956-fd68-478f-9541-86ea57bfb1db", "Student", "STUDENT" },
                    { "d3c8d0cc-42be-4f42-b260-f58bae4a0019", "ae74b9a3-3787-44e8-92d1-5b6d14985a12", "Admin", "ADMIN" },
                    { "83763bc2-84fd-44d7-a214-ce7647f64b6f", "736cc769-4fe1-4e0b-be49-e2c39c97fce9", "AR", "AR" },
                    { "73d4ddae-860c-419e-aff8-b2a4588b9c3c", "069cdb47-5ac3-49ed-a977-d2fa62e5434c", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hods_DepartmentId",
                table: "Hods",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Hods_UserId",
                table: "Hods",
                column: "UserId");
        }
    }
}
