using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class multi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUser_Subjects_SubjectId",
                table: "SubjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUser_Users_UserId",
                table: "SubjectUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectUser",
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

            migrationBuilder.RenameTable(
                name: "SubjectUser",
                newName: "SubjectUsers");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectUser_UserId",
                table: "SubjectUsers",
                newName: "IX_SubjectUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectUser_SubjectId",
                table: "SubjectUsers",
                newName: "IX_SubjectUsers_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectUsers",
                table: "SubjectUsers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17b6d1a7-5b8e-4407-b30f-75529c3778e6", "6b26d1c5-561c-4c24-874d-10e520a029f4", "Teacher", "TEACHER" },
                    { "a7767895-2e2d-4eba-90e9-222a7702f546", "8cb296a9-c824-43c0-9897-826c5a991b35", "Student", "STUDENT" },
                    { "356a571d-4ed2-4164-9960-7b6ba9d158c0", "2dc5f7f3-f485-4d0f-bff7-44e51c4feca6", "Admin", "ADMIN" },
                    { "11909249-8e58-4379-8a66-bd6261ef261c", "fb6ab1b8-effe-4e5e-8f5d-b99b2c41496f", "AR", "AR" },
                    { "c2b77959-877a-438a-bce8-8ee0c6b06ab3", "e4d00c04-30cd-4413-b8a4-f51874998b4c", "HOD", "HOD" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectUsers_Subjects_SubjectId",
                table: "SubjectUsers",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectUsers_Users_UserId",
                table: "SubjectUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUsers_Subjects_SubjectId",
                table: "SubjectUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUsers_Users_UserId",
                table: "SubjectUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectUsers",
                table: "SubjectUsers");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "11909249-8e58-4379-8a66-bd6261ef261c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "17b6d1a7-5b8e-4407-b30f-75529c3778e6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "356a571d-4ed2-4164-9960-7b6ba9d158c0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a7767895-2e2d-4eba-90e9-222a7702f546");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c2b77959-877a-438a-bce8-8ee0c6b06ab3");

            migrationBuilder.RenameTable(
                name: "SubjectUsers",
                newName: "SubjectUser");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectUsers_UserId",
                table: "SubjectUser",
                newName: "IX_SubjectUser_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectUsers_SubjectId",
                table: "SubjectUser",
                newName: "IX_SubjectUser_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectUser",
                table: "SubjectUser",
                column: "Id");

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
    }
}
