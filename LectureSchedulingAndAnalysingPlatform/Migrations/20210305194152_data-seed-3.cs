using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class dataseed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "064cfa5b-a62b-406b-ad13-dcc3f42dfa68");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0f93f0b0-d5de-4c61-ad80-3b406e9bd007");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "593bc972-2fb4-4fe6-affe-eb2710b85fe4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8250adbe-9a9e-4da9-89b6-046e248d1159");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e365ed0-bb15-4c51-97ef-9f18f2f72e05");

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

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 2, "CE2302 ", "Mechanics of Materials" },
                    { 3, "CE2201 ", "Fundamentals of Fluid Mechanics" },
                    { 4, "CE3301 ", "Building Planning and Cost Estimating " },
                    { 5, "CE3202 ", "Concrete Technology" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f93f0b0-d5de-4c61-ad80-3b406e9bd007", "f0963144-bef3-4d79-8f9f-90cf4362c873", "Teacher", "TEACHER" },
                    { "593bc972-2fb4-4fe6-affe-eb2710b85fe4", "42df2183-1ecb-429c-bd3a-1e4b44a0c53f", "Student", "STUDENT" },
                    { "064cfa5b-a62b-406b-ad13-dcc3f42dfa68", "7cbbe15a-93e3-478a-907e-442417138bbe", "Admin", "ADMIN" },
                    { "9e365ed0-bb15-4c51-97ef-9f18f2f72e05", "63a203e9-8f97-4dc2-a458-5627e7623bfb", "AR", "AR" },
                    { "8250adbe-9a9e-4da9-89b6-046e248d1159", "ee901051-479a-435f-baa4-33abe20c4289", "HOD", "HOD" }
                });
        }
    }
}
