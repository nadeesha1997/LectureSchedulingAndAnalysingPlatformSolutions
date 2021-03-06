using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class departmentseedcorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "37063f0a-c2c6-409f-9c16-fe4e3fe3e5a2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7d1c2b58-f962-44f3-9bc3-2a64e2e774fd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7fe5646f-d3a0-4d54-8b66-eab295b41b1a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d945467c-3077-4890-91e1-9881b9ebc61c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e8399b00-55a8-478b-9cad-eedad53d219a");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name" },
                values: new object[] { "EIE", "Electrical and Information Engineering" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CEE", "Civil and Environment Engineering" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Name" },
                values: new object[] { "MME", "Mechanical and Manufacturing Engineering" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name" },
                values: new object[] { "IS", "Interdisciplinary Studies" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d48c2aba-9813-49e0-9876-0ed083b23311", "d38f74a6-0748-438a-9060-1beff74d7b81", "Teacher", "TEACHER" },
                    { "3639722e-1d68-49ee-ab0a-315bdc5c2afa", "f5f2c02b-3487-40a9-bf09-26656483e5af", "Student", "STUDENT" },
                    { "0a398be8-a0dd-48bf-80ff-ba82b06a018e", "ee680fbb-2d8e-4982-a25a-a6a9aeb38eb2", "Admin", "ADMIN" },
                    { "e9bb835e-44ff-44ef-842e-0067209a2215", "3b49e79c-4af7-4294-8d4a-551f3a501858", "AR", "AR" },
                    { "da3c86e6-89a9-4336-bb21-875abbd776f3", "84f5be0d-d56c-4e34-924a-6352582cb2dd", "HOD", "HOD" }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE1301 ", "Introduction to Civil Engineering" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE2302 ", "Mechanics of Materials" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE2201 ", "Fundamentals of Fluid Mechanics" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE3301 ", "Building Planning and Cost Estimating " });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 5, "CE3202 ", "Concrete Technology" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0a398be8-a0dd-48bf-80ff-ba82b06a018e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3639722e-1d68-49ee-ab0a-315bdc5c2afa");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d48c2aba-9813-49e0-9876-0ed083b23311");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "da3c86e6-89a9-4336-bb21-875abbd776f3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e9bb835e-44ff-44ef-842e-0067209a2215");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE1301 ", "Introduction to Civil Engineering" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE2302 ", "Mechanics of Materials" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE2201 ", "Fundamentals of Fluid Mechanics" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE3301 ", "Building Planning and Cost Estimating " });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7fe5646f-d3a0-4d54-8b66-eab295b41b1a", "62ea356a-ebb3-4be9-8264-34cb05cc0b6d", "Teacher", "TEACHER" },
                    { "37063f0a-c2c6-409f-9c16-fe4e3fe3e5a2", "2c60c678-2884-470e-8a0c-8f5f09245542", "Student", "STUDENT" },
                    { "e8399b00-55a8-478b-9cad-eedad53d219a", "6073cb5b-49ea-4081-8861-cf91f2c26a81", "Admin", "ADMIN" },
                    { "7d1c2b58-f962-44f3-9bc3-2a64e2e774fd", "b9755747-3548-4aa4-8734-fb7c1fefc0d4", "AR", "AR" },
                    { "d945467c-3077-4890-91e1-9881b9ebc61c", "64d305ff-32b0-4689-97d2-bffc84c14acb", "HOD", "HOD" }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name" },
                values: new object[] { "EIE", "Electrical and Information Engineering" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CEE", "Civil and Environmental Engineering" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Name" },
                values: new object[] { "MME", "Mechanical and Manufacturing Engineering" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name" },
                values: new object[] { "IS", "Interdisciplinery Studies" });
        }
    }
}
