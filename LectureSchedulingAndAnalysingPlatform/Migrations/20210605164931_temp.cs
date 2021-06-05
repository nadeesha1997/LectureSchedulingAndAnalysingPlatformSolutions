using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class temp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "20fce5be-c51f-4a32-ae16-b4f579df57c8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "31bdbc56-8735-4271-b498-67daff815a32");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6a605635-e043-479e-bae3-3e40b88193f7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7029ea08-288d-460c-9b4d-aa0ceffb2652");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d10a1aba-c4a3-47af-a426-b1f1a57d6f76");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Lecturers",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Lecturers");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31bdbc56-8735-4271-b498-67daff815a32", "5e7768f4-5a3d-45bc-8ed5-0f1ddd3b3ca8", "Teacher", "TEACHER" },
                    { "7029ea08-288d-460c-9b4d-aa0ceffb2652", "9ace28d9-fb25-43ef-ab51-39c1932dc2ee", "Student", "STUDENT" },
                    { "20fce5be-c51f-4a32-ae16-b4f579df57c8", "30b35b57-1329-46f7-8db7-226cfe2da89a", "Admin", "ADMIN" },
                    { "6a605635-e043-479e-bae3-3e40b88193f7", "1d6d5655-6330-4802-8893-06c34e8eec96", "AR", "AR" },
                    { "d10a1aba-c4a3-47af-a426-b1f1a57d6f76", "c3a5f4b4-7bcb-4902-86c7-d598e573af04", "HOD", "HOD" }
                });
        }
    }
}
