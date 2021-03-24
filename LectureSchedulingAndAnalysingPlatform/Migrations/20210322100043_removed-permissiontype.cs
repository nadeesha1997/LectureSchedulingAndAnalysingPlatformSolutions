using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class removedpermissiontype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_PermissionTypes_PermissionTypeId",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "46b47973-58da-48f9-afa7-8c253daa3800");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a7aa7923-10b3-4318-a4f7-b166cfc2db78");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "abed848b-da38-431b-9f7f-7ea83b73faef");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b077743c-07b1-4fc8-8730-06a15f46f6b9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e855a7b7-2ed4-4290-957b-1cdb7019c0a6");

            migrationBuilder.DropColumn(
                name: "PermissionTypeId",
                table: "Halls");

            migrationBuilder.AddColumn<string>(
                name: "PermissionType",
                table: "Halls",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "PermissionType",
                value: "elecHOD");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "PermissionType",
                value: "elecHOD");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "PermissionType",
                value: "mechHOD");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "PermissionType",
                value: "civilHOD");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f0bb29f1-06bd-42ec-8018-3c72d7f3bf2d", "f2cfc5e3-44ac-41ae-866d-fe97c0068658", "Teacher", "TEACHER" },
                    { "2a4671a7-1d6a-4a17-b911-9f96db9271e9", "f54da98a-8ca3-413f-9630-1fde92b36f6f", "Student", "STUDENT" },
                    { "6ea5a969-66d2-453d-a140-4a06cea886a4", "32106cbd-3143-411d-b92c-a977a10e6c7d", "Admin", "ADMIN" },
                    { "c6c8fe23-6442-466c-82ec-acc1ba184aa2", "c235830e-3c22-4658-98d9-4d99cb3730bc", "AR", "AR" },
                    { "ca66a7cd-ca08-4007-8382-2ad1c723db27", "17e4bf2b-d94a-44c7-8f42-cf15973fcf29", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2a4671a7-1d6a-4a17-b911-9f96db9271e9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6ea5a969-66d2-453d-a140-4a06cea886a4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c6c8fe23-6442-466c-82ec-acc1ba184aa2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ca66a7cd-ca08-4007-8382-2ad1c723db27");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0bb29f1-06bd-42ec-8018-3c72d7f3bf2d");

            migrationBuilder.DropColumn(
                name: "PermissionType",
                table: "Halls");

            migrationBuilder.AddColumn<int>(
                name: "PermissionTypeId",
                table: "Halls",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "PermissionTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "PermissionTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "PermissionTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "PermissionTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "PermissionTypeId",
                value: 1);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e855a7b7-2ed4-4290-957b-1cdb7019c0a6", "2e5cf8ab-7202-484a-93b8-25567f511e29", "Teacher", "TEACHER" },
                    { "a7aa7923-10b3-4318-a4f7-b166cfc2db78", "39e7a521-a4ce-49f2-8910-2a050a4f64bf", "Student", "STUDENT" },
                    { "abed848b-da38-431b-9f7f-7ea83b73faef", "bddfaf29-6170-47ca-8bbd-4f2e47d6426b", "Admin", "ADMIN" },
                    { "b077743c-07b1-4fc8-8730-06a15f46f6b9", "26c26f84-5196-4058-ac80-66e9d01ec74b", "AR", "AR" },
                    { "46b47973-58da-48f9-afa7-8c253daa3800", "5e8458dd-4dab-42b4-97b0-3f1e78bde4f7", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Halls_PermissionTypeId",
                table: "Halls",
                column: "PermissionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_PermissionTypes_PermissionTypeId",
                table: "Halls",
                column: "PermissionTypeId",
                principalTable: "PermissionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
