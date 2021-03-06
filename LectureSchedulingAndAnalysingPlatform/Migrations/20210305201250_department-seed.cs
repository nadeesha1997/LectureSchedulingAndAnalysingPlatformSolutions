using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class departmentseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0e257bbc-2783-4bad-b249-a5d196968f51");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1b1da069-cde8-49f5-affc-90f0dcd4b0cc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7aeaf1d9-06d6-4e09-95d6-8ae9e7adf597");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9d2cfaa4-bd06-4622-9762-8f8f6e074030");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f59d608f-8896-4597-ba00-5eb5b5946c49");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "CE1301 ", "Introduction to Civil Engineering" },
                    { 2, "CE2302 ", "Mechanics of Materials" },
                    { 3, "CE2201 ", "Fundamentals of Fluid Mechanics" },
                    { 4, "CE3301 ", "Building Planning and Cost Estimating " }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e257bbc-2783-4bad-b249-a5d196968f51", "19b769bb-fed4-40e4-9ecb-dfd631461c7f", "Teacher", "TEACHER" },
                    { "f59d608f-8896-4597-ba00-5eb5b5946c49", "661c0d60-a7c7-472c-a914-5122bd0e6cfc", "Student", "STUDENT" },
                    { "9d2cfaa4-bd06-4622-9762-8f8f6e074030", "f1cddd01-d698-4706-b0a9-e1a2b39bbba6", "Admin", "ADMIN" },
                    { "7aeaf1d9-06d6-4e09-95d6-8ae9e7adf597", "741df160-abd1-4446-9f93-780310633e25", "AR", "AR" },
                    { "1b1da069-cde8-49f5-affc-90f0dcd4b0cc", "224d3890-d9a8-4cf3-9bb2-f6f04692c5f2", "HOD", "HOD" }
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
    }
}
