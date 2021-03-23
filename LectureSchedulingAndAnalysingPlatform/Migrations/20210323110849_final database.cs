using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class finaldatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "06116ced-c22c-493e-bc8a-d369ec874e8f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "08830cda-d753-4220-8019-882a8fbc110c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "465b57f8-998f-4eb7-b1d5-763905711126");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5bc04c03-b0c0-4f35-b2ea-f20876b1854a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f7f26183-afcf-435d-9aec-97e5b3a8e517");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8bdfb6a0-ad29-4907-9c7e-b608604a4612", "8786d6ac-7359-4ef2-aa1f-50c47fe94c39", "Teacher", "TEACHER" },
                    { "71f4fb01-1b52-4da6-a381-bdae94e4c59d", "d493af51-7272-4932-b825-15db7cf540f3", "Student", "STUDENT" },
                    { "f3b2c16f-ba61-41c7-8b15-2588ce447384", "e7d6d372-a54d-4d80-b3e0-56035c55e48f", "Admin", "ADMIN" },
                    { "8ca0ac39-b4ff-44a4-baa0-2c128e09870f", "fcd708f0-e366-45be-86ab-272a9a6ccbd7", "AR", "AR" },
                    { "7ec73e80-ece1-4d96-80c5-69c7c6b8254a", "49f254f9-3387-4547-b8fe-e425f2866cbf", "HOD", "HOD" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 85, "EE7207", "Computer Vision and Image Processing (TE)" },
                    { 86, "EE7208", "Advanced Data Communication (TE)" },
                    { 87, "EE7209", "Digital Signal Processing (TE)" },
                    { 88, "EE7210", "Telecommunication Networks (TE)" },
                    { 89, "EE7211", "Optical Fiber Communication (TE)" },
                    { 145, "ME8311", "Aerospace Engineering (TE)" },
                    { 146, "ME8312", "Energy Management (TE)" },
                    { 147, "EE8212", "Biomedical Engineering (TE)" },
                    { 148, "ME8213", "Individual Research Project (TE)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "71f4fb01-1b52-4da6-a381-bdae94e4c59d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7ec73e80-ece1-4d96-80c5-69c7c6b8254a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8bdfb6a0-ad29-4907-9c7e-b608604a4612");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8ca0ac39-b4ff-44a4-baa0-2c128e09870f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f3b2c16f-ba61-41c7-8b15-2588ce447384");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08830cda-d753-4220-8019-882a8fbc110c", "91926380-d7c6-4e5e-abc6-fb0fb7378ad2", "Teacher", "TEACHER" },
                    { "465b57f8-998f-4eb7-b1d5-763905711126", "752a2f6d-904e-4c36-bc01-0f4f9722d43f", "Student", "STUDENT" },
                    { "5bc04c03-b0c0-4f35-b2ea-f20876b1854a", "c7356f0f-bde2-4077-b262-4ed54f5debe2", "Admin", "ADMIN" },
                    { "06116ced-c22c-493e-bc8a-d369ec874e8f", "9c5846be-898f-4709-a9c1-0dfae11403fe", "AR", "AR" },
                    { "f7f26183-afcf-435d-9aec-97e5b3a8e517", "280cdb43-ad52-4b8f-9110-f0e47166042b", "HOD", "HOD" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 55, "EE3207", "Planning and Management for Electrical Engineers (TE)" });
        }
    }
}
