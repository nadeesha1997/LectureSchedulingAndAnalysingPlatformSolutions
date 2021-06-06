using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class onlinesessionidandpw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "15241908-e95f-485f-9fc4-ec3077ca6597");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "89eb97da-c956-4e4a-abf3-f5258dcfb102");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b5a6d21d-3823-4e7b-9508-2d25da853f23");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e90d5984-3e31-48d7-b2ec-082bf6d102b2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f50692f0-4009-403b-85b5-0699c8e72a6d");

            migrationBuilder.AddColumn<string>(
                name: "MeetingId",
                table: "OnlineSessions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "OnlineSessions",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eaf34864-872a-4aa1-973b-712f5877345f", "ef1c7a41-6689-430d-8c9d-b4a811a0edf2", "Lecturer", "LECTURER" },
                    { "a94352dd-7cd9-40b5-ad25-337106e86d74", "71a1b94c-34f4-4b4c-8e97-8ea63e8a8991", "Student", "STUDENT" },
                    { "f37a2294-3b76-4cfe-ae4b-adbd44879995", "79633623-51c6-4faf-abb7-5710c3a2c2dc", "Admin", "ADMIN" },
                    { "ea5cefaa-b020-41cd-b2de-391c8c951790", "4ef35f9b-80c9-44ab-9e5f-265d4ae564c9", "AR", "AR" },
                    { "64337396-4414-45de-93ed-318dda6cffd5", "1845ed43-99aa-4466-9c13-72680d724cc0", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "64337396-4414-45de-93ed-318dda6cffd5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a94352dd-7cd9-40b5-ad25-337106e86d74");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ea5cefaa-b020-41cd-b2de-391c8c951790");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "eaf34864-872a-4aa1-973b-712f5877345f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f37a2294-3b76-4cfe-ae4b-adbd44879995");

            migrationBuilder.DropColumn(
                name: "MeetingId",
                table: "OnlineSessions");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "OnlineSessions");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "89eb97da-c956-4e4a-abf3-f5258dcfb102", "e8c3306e-8433-4201-b983-1d78604e3050", "Lecturer", "LECTURER" },
                    { "b5a6d21d-3823-4e7b-9508-2d25da853f23", "967117eb-2eea-42fe-bc7e-6704e322a7af", "Student", "STUDENT" },
                    { "e90d5984-3e31-48d7-b2ec-082bf6d102b2", "fb262c52-21b4-44dd-beee-de4751f8d1a9", "Admin", "ADMIN" },
                    { "15241908-e95f-485f-9fc4-ec3077ca6597", "021829dd-7d07-4813-a855-503de49bb491", "AR", "AR" },
                    { "f50692f0-4009-403b-85b5-0699c8e72a6d", "d2464d4a-8bdf-4bd7-9f6a-57041aebb685", "HOD", "HOD" }
                });
        }
    }
}
