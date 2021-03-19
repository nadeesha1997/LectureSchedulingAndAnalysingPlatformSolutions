using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class hod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Hods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hods_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hods");

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
                    { "713ff50b-e431-4fc6-ae72-278a0ac412d5", "ed782914-2594-41c9-9b9f-b0073c4b48e1", "Teacher", "TEACHER" },
                    { "f7e07c98-f313-455a-b63e-f26727685fe2", "e047a44e-442e-4263-bc1d-17be689dcac2", "Student", "STUDENT" },
                    { "f4134c45-f452-4e23-9f86-94142d0733eb", "499ffd57-2710-4ce1-8f0a-cb82dc2daff9", "Admin", "ADMIN" },
                    { "9f886034-e096-45c4-a567-82d109b6c815", "e8ddaa0a-89df-4160-8fc4-0a8983ee275b", "AR", "AR" },
                    { "014a3fca-f75d-47a3-8cfd-ee3a8747a43b", "a83f4477-6f74-47ab-8180-b8a5a7e52608", "HOD", "HOD" }
                });
        }
    }
}
