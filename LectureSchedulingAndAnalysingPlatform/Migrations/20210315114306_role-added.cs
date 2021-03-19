using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class roleadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "713ff50b-e431-4fc6-ae72-278a0ac412d5", "ed782914-2594-41c9-9b9f-b0073c4b48e1", "Teacher", "TEACHER" },
                    { "f7e07c98-f313-455a-b63e-f26727685fe2", "e047a44e-442e-4263-bc1d-17be689dcac2", "Student", "STUDENT" },
                    { "f4134c45-f452-4e23-9f86-94142d0733eb", "499ffd57-2710-4ce1-8f0a-cb82dc2daff9", "Admin", "ADMIN" },
                    { "9f886034-e096-45c4-a567-82d109b6c815", "e8ddaa0a-89df-4160-8fc4-0a8983ee275b", "AR", "AR" },
                    { "014a3fca-f75d-47a3-8cfd-ee3a8747a43b", "a83f4477-6f74-47ab-8180-b8a5a7e52608", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "014a3fca-f75d-47a3-8cfd-ee3a8747a43b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "713ff50b-e431-4fc6-ae72-278a0ac412d5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9f886034-e096-45c4-a567-82d109b6c815");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f4134c45-f452-4e23-9f86-94142d0733eb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f7e07c98-f313-455a-b63e-f26727685fe2");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

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
        }
    }
}
