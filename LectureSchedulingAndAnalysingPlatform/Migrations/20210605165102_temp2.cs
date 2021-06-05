using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class temp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2f9531fb-1f19-4150-a61c-60b8067aa037");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "456afad4-ff34-483a-bb82-f3d57897439f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "85185519-3c59-4d4d-8138-2a9c324812bc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8b681772-23af-4b7e-93ba-095a73cf8f2d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fa9e7e13-d31e-4ca2-9c8b-6e840cb04c9a");

            migrationBuilder.AlterColumn<int>(
                name: "Semester",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

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

            migrationBuilder.AlterColumn<int>(
                name: "Semester",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fa9e7e13-d31e-4ca2-9c8b-6e840cb04c9a", "29a370b8-aced-4b6f-aefc-dd692111d8e3", "Lecturer", "LECTURER" },
                    { "2f9531fb-1f19-4150-a61c-60b8067aa037", "a4ad090f-dd6a-4c40-89c6-f23b2ca7ccc0", "Student", "STUDENT" },
                    { "85185519-3c59-4d4d-8138-2a9c324812bc", "588e65da-2467-4d18-be7a-5cfacc896b28", "Admin", "ADMIN" },
                    { "456afad4-ff34-483a-bb82-f3d57897439f", "8ebc3afb-8cf3-493f-9b54-dacaf49d08b1", "AR", "AR" },
                    { "8b681772-23af-4b7e-93ba-095a73cf8f2d", "893ee647-8505-44a6-aa74-6b3be8ab47c4", "HOD", "HOD" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
