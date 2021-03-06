using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class dataseed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6655f50b-3f9a-4619-810c-fe53cfa15d26");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "890c4b4e-919b-429d-b817-ca4356e5d216");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "972dc48c-28a3-4a1f-9b21-05e2d84ec1f5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c142ef0b-2a79-4e5c-8e3d-51be2b34b150");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f8323b78-1d91-4d10-aac7-6fd0fefd3b72");

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

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1, "CE1301 ", "Introduction to Civil Engineering" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f8323b78-1d91-4d10-aac7-6fd0fefd3b72", "9ff9f641-53ae-49d3-a190-065c467e83f9", "Teacher", "TEACHER" },
                    { "972dc48c-28a3-4a1f-9b21-05e2d84ec1f5", "5057ce2d-ccf5-4294-adc6-8b10125716c9", "Student", "STUDENT" },
                    { "6655f50b-3f9a-4619-810c-fe53cfa15d26", "55d8ff2d-e754-4f50-875b-ccc7f6bdcdc8", "Admin", "ADMIN" },
                    { "c142ef0b-2a79-4e5c-8e3d-51be2b34b150", "37f108a9-bcaf-41d6-a725-95c6f7313e71", "AR", "AR" },
                    { "890c4b4e-919b-429d-b817-ca4356e5d216", "8b5f6049-2b2b-43ba-a44d-a8a4b38002c0", "HOD", "HOD" }
                });
        }
    }
}
