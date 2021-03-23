using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class subjectdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 142);

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

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Water and Wastewater Engineering");

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 44, "CE8252", "Irrigation and Watershed Management (TE)" },
                    { 45, "CE8253", "Water Resource Planning and Management (TE)" },
                    { 46, "CE8254", "Analysis and Design of Large Structures for Dynamic Loadings (TE)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81a0e633-bd95-4008-af1a-1809f112b48c", "cb89762f-7572-4844-a987-e41701ee9ed1", "AR", "AR" },
                    { "2c25405d-8504-4200-9052-b79456d7b0ce", "061b98bc-89e3-44cb-ba26-408ee5f347fe", "Admin", "ADMIN" },
                    { "3573d863-c80e-41ef-bff5-9dba96bf0596", "b8d95484-75f1-4db7-8d46-8aee1617b398", "Student", "STUDENT" },
                    { "884fb79e-ab29-41ff-932f-8eea69efed4f", "300683e1-efdc-47a0-a0c1-8d2fc0ca2179", "Teacher", "TEACHER" },
                    { "04a40217-5aa5-40bb-9ef8-8d826fbc11b8", "d2e95354-45d4-4487-b24f-d1bc0a2dedd2", "HOD", "HOD" }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Water and Wastewater Engineering CE4305");

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 142, "ME7314", "Polymer Technology (TE)" },
                    { 141, "ME7313", "Industrial Automation and Control (TE)" },
                    { 93, "EE8203", "High Performance Computing (TE)" },
                    { 80, "EE7203", "Power System Analysis (TE)" },
                    { 79, "EE7202", "Power Electronic Applications (TE)" },
                    { 69, "EE5207", "Internet Technologies (TE)" },
                    { 41, "CE7252", "Ground Improvement Techniques (TE)" },
                    { 40, "CE7251", "Coastal Engineering – Application and Management (TE)" },
                    { 29, "CE6251", "Building Services Engineering (TE)" },
                    { 92, "EE8202", "Electrical Systems in Buildings (TE)" },
                    { 19, "CE5252", "Graphical User Interface Programming (TE)" }
                });
        }
    }
}
