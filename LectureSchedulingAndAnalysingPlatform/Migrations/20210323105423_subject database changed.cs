using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class subjectdatabasechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 84);

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
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 134);

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
                    { "884fb79e-ab29-41ff-932f-8eea69efed4f", "300683e1-efdc-47a0-a0c1-8d2fc0ca2179", "Teacher", "TEACHER" },
                    { "3573d863-c80e-41ef-bff5-9dba96bf0596", "b8d95484-75f1-4db7-8d46-8aee1617b398", "Student", "STUDENT" },
                    { "2c25405d-8504-4200-9052-b79456d7b0ce", "061b98bc-89e3-44cb-ba26-408ee5f347fe", "Admin", "ADMIN" },
                    { "81a0e633-bd95-4008-af1a-1809f112b48c", "cb89762f-7572-4844-a987-e41701ee9ed1", "AR", "AR" },
                    { "04a40217-5aa5-40bb-9ef8-8d826fbc11b8", "d2e95354-45d4-4487-b24f-d1bc0a2dedd2", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "04a40217-5aa5-40bb-9ef8-8d826fbc11b8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c25405d-8504-4200-9052-b79456d7b0ce");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3573d863-c80e-41ef-bff5-9dba96bf0596");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "81a0e633-bd95-4008-af1a-1809f112b48c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "884fb79e-ab29-41ff-932f-8eea69efed4f");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34462ae2-e05f-462c-8107-55a7eef22c62", "9d1a3d52-9a42-41f5-bea8-62fb8c587871", "HOD", "HOD" },
                    { "aa26678e-bad4-4657-a006-d04ed976388e", "9b93e942-a38e-4251-bc76-93c00f879382", "Admin", "ADMIN" },
                    { "7a0de2b2-d0a8-4ff4-802e-11c737a8cede", "1955c619-0727-47fb-9849-7d783b17fa10", "Student", "STUDENT" },
                    { "64b2567c-f017-4bae-b4de-64f8aa7e8a49", "31d6978d-27c6-47e8-a898-af0612063682", "Teacher", "TEACHER" },
                    { "342f8079-2f22-47d4-8909-9f9992bfc354", "1d765c24-e30c-4615-b9e4-dafc453eda48", "AR", "AR" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 148, "ME8213", "Individual Research Project (TE)" },
                    { 147, "EE8212", "Biomedical Engineering (TE)" },
                    { 146, "ME8312", "Energy Management (TE)" },
                    { 145, "ME8311", "Aerospace Engineering (TE)" },
                    { 134, "ME6114", "Technical Presentation Skills (TE)" },
                    { 118, "ME4312", "Automobile Engineering (TE)" },
                    { 89, "EE7211", "Optical Fiber Communication (TE)" },
                    { 88, "EE7210", "Telecommunication Networks (TE)" },
                    { 87, "EE7209", "Digital Signal Processing (TE)" },
                    { 86, "EE7208", "Advanced Data Communication (TE)" },
                    { 85, "EE7207", "Computer Vision and Image Processing (TE)" },
                    { 83, "EE7206", "Mobile Application Development (TE)" },
                    { 82, "EE7205", "Object Oriented Design Patterns and Principles (TE)" },
                    { 81, "EE7204", "Scientific Computing (TE)" },
                    { 46, "CE8254", "Analysis and Design of Large Structures for Dynamic Loadings (TE)" },
                    { 45, "CE8253", "Water Resource Planning and Management (TE)" },
                    { 44, "CE8252", "Irrigation and Watershed Management (TE)" },
                    { 43, "CE7254", "Water Reclamation and Reuse (TE)" },
                    { 42, "CE7253", "Highway Maintenance and Management (TE)" },
                    { 32, "CE6254", "Coastal Engineering (TE)" },
                    { 31, "CE6253", "Ecological Engineering (TE)" },
                    { 30, "CE6252", "Dynamic & Control of Structures (TE)" },
                    { 22, "CE5255", "Remote Sensing and GIS (TE)" },
                    { 21, "CE5254", "Integrated Solid Waste Management (TE)" },
                    { 84, "EE7206", "Machine Learning (TE)" },
                    { 20, "CE5253", "Infrastructure Planning (TE)" }
                });
        }
    }
}
