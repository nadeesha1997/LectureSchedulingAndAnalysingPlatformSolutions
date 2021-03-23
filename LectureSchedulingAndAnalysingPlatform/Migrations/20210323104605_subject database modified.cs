using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class subjectdatabasemodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1c73d407-cc71-487a-98ca-01b852d4aa76");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "34d2c848-ce0b-45ad-9902-1969b54ff7d8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7269c841-7064-43f0-a5b6-228a1820405f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "93c52557-5798-46e8-9e80-16a44a6e9267");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b6046ef1-68ec-4946-b6ae-136e89d4a02a");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64b2567c-f017-4bae-b4de-64f8aa7e8a49", "31d6978d-27c6-47e8-a898-af0612063682", "Teacher", "TEACHER" },
                    { "7a0de2b2-d0a8-4ff4-802e-11c737a8cede", "1955c619-0727-47fb-9849-7d783b17fa10", "Student", "STUDENT" },
                    { "aa26678e-bad4-4657-a006-d04ed976388e", "9b93e942-a38e-4251-bc76-93c00f879382", "Admin", "ADMIN" },
                    { "342f8079-2f22-47d4-8909-9f9992bfc354", "1d765c24-e30c-4615-b9e4-dafc453eda48", "AR", "AR" },
                    { "34462ae2-e05f-462c-8107-55a7eef22c62", "9d1a3d52-9a42-41f5-bea8-62fb8c587871", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "342f8079-2f22-47d4-8909-9f9992bfc354");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "34462ae2-e05f-462c-8107-55a7eef22c62");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "64b2567c-f017-4bae-b4de-64f8aa7e8a49");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7a0de2b2-d0a8-4ff4-802e-11c737a8cede");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "aa26678e-bad4-4657-a006-d04ed976388e");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34d2c848-ce0b-45ad-9902-1969b54ff7d8", "6239cc49-6703-4c63-a2f4-03f7972433de", "Teacher", "TEACHER" },
                    { "1c73d407-cc71-487a-98ca-01b852d4aa76", "7342e931-7a4d-40b2-8908-6f144c98b349", "Student", "STUDENT" },
                    { "93c52557-5798-46e8-9e80-16a44a6e9267", "de0e9942-18e1-48dc-bba1-d34be592c793", "Admin", "ADMIN" },
                    { "7269c841-7064-43f0-a5b6-228a1820405f", "5fe27e68-0395-4180-9e68-24bbe2441705", "AR", "AR" },
                    { "b6046ef1-68ec-4946-b6ae-136e89d4a02a", "77e5c074-b95a-40e6-8dc4-a8e2e4dbd309", "HOD", "HOD" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 98, "EE8208", "Intelligent Systems Design (TE)" },
                    { 99, "EE8209", "Microwave Communications (TE)" },
                    { 100, "EE8210", "Digital Communication (TE)" },
                    { 101, "EE8211", "Design and Management of Data Networks (TE)" },
                    { 102, "EE8212", "Biomedical Engineering (TE)" },
                    { 103, "EE8213", "Photonic Devices (TE)" },
                    { 104, "EE8115", "Introduction to Hardware Description Languages (TE)" },
                    { 105, "EE8117", "Video Compression and Communication (TE)" }
                });
        }
    }
}
