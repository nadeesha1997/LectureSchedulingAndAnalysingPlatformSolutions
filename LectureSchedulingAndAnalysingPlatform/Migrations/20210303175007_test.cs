using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_SubjectUser_SubjectUserId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_SubjectUser_SubjectUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SubjectUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_SubjectUserId",
                table: "Subjects");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "04194912-8237-4502-be17-1fd57d1530a1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0fc0f64a-fe36-412c-b5aa-31937e643767");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9fa5edea-8007-4df7-9cf0-74d2f937ea27");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a80fd1e1-0b64-4ef8-b971-c1e4e84f9c29");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e7a86abd-fc20-4410-af19-5005c57bdaa4");

            migrationBuilder.DropColumn(
                name: "SubjectUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SubjectUserId",
                table: "Subjects");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "SubjectUser",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "SubjectUser",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "66303848-bd2e-49af-93bd-92705a764d0e", "1403a113-b0ca-43c1-af46-c973c422697e", "Teacher", "TEACHER" },
                    { "d6fba2ba-a508-45c3-b22d-72d422e00e8c", "c46f1422-a672-40e9-b78d-1fa4d9f995fb", "Student", "STUDENT" },
                    { "ec9587d8-0f0d-493e-a198-f6df57699356", "e3e72ea9-8168-426e-a243-365391bfd2c5", "Admin", "ADMIN" },
                    { "3046300b-5f0a-473d-b941-4dbf53aeb6a4", "e59c5b01-3121-45b6-abe1-679d3cde2089", "AR", "AR" },
                    { "9be4af6a-11fc-4dec-ba1a-8a1104ac7888", "44bfc2e7-b4a0-4173-9b06-0c7fce052996", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectUser_SubjectId",
                table: "SubjectUser",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectUser_UserId",
                table: "SubjectUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectUser_Subjects_SubjectId",
                table: "SubjectUser",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectUser_Users_UserId",
                table: "SubjectUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUser_Subjects_SubjectId",
                table: "SubjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUser_Users_UserId",
                table: "SubjectUser");

            migrationBuilder.DropIndex(
                name: "IX_SubjectUser_SubjectId",
                table: "SubjectUser");

            migrationBuilder.DropIndex(
                name: "IX_SubjectUser_UserId",
                table: "SubjectUser");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3046300b-5f0a-473d-b941-4dbf53aeb6a4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "66303848-bd2e-49af-93bd-92705a764d0e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9be4af6a-11fc-4dec-ba1a-8a1104ac7888");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d6fba2ba-a508-45c3-b22d-72d422e00e8c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ec9587d8-0f0d-493e-a198-f6df57699356");

            migrationBuilder.DropColumn(
                name: "ProfilePictureName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "SubjectUser");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SubjectUser");

            migrationBuilder.AddColumn<int>(
                name: "SubjectUserId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectUserId",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a80fd1e1-0b64-4ef8-b971-c1e4e84f9c29", "8f287ff5-45ed-4b60-80ab-d205031a7b0e", "Teacher", "TEACHER" },
                    { "0fc0f64a-fe36-412c-b5aa-31937e643767", "a65a9f59-4187-4a04-aeb2-99226a595487", "Student", "STUDENT" },
                    { "04194912-8237-4502-be17-1fd57d1530a1", "3df8a56f-7b94-4981-8920-1b7f54fd6cba", "Admin", "ADMIN" },
                    { "e7a86abd-fc20-4410-af19-5005c57bdaa4", "b7f2c367-5807-4206-bcc5-1ba9a8f66f00", "AR", "AR" },
                    { "9fa5edea-8007-4df7-9cf0-74d2f937ea27", "e13dfabc-629a-456a-8439-1fc82bcef616", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_SubjectUserId",
                table: "Users",
                column: "SubjectUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SubjectUserId",
                table: "Subjects",
                column: "SubjectUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_SubjectUser_SubjectUserId",
                table: "Subjects",
                column: "SubjectUserId",
                principalTable: "SubjectUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SubjectUser_SubjectUserId",
                table: "Users",
                column: "SubjectUserId",
                principalTable: "SubjectUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
