using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0a398be8-a0dd-48bf-80ff-ba82b06a018e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3639722e-1d68-49ee-ab0a-315bdc5c2afa");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d48c2aba-9813-49e0-9876-0ed083b23311");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "da3c86e6-89a9-4336-bb21-875abbd776f3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e9bb835e-44ff-44ef-842e-0067209a2215");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Electrical and Information Engineering Department Building" },
                    { 2, 2, "Civil and Environment Engineering Engineering Department Building" },
                    { 3, 3, "Mechanical and Manufacturing Engineering Department Building" },
                    { 4, null, "Administration Building" },
                    { 5, null, "Lecture Hall" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ca2e3960-7a10-4622-bfc8-e0f531a271de", "3176bf58-b8f7-4278-87ef-b9e86c884619", "Teacher", "TEACHER" },
                    { "37f2dd58-7c8f-407a-84e1-92b1e4cab83c", "9b938b4f-46f9-49d7-b731-ab358f3d8c40", "Student", "STUDENT" },
                    { "db527aa0-a2df-445b-9128-a18d9057ca66", "4099f1e0-14ce-446a-8b31-ec43907e83f1", "Admin", "ADMIN" },
                    { "076f1c11-eb7e-4765-87fc-fa469233c1fe", "d0bd3cdb-485f-40a8-8aa1-e0632349693d", "AR", "AR" },
                    { "85993c77-4830-4706-b03f-d0421c61a099", "586403fd-423d-43a5-adb6-df82419bf766", "HOD", "HOD" }
                });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "Ar", "Hod", "Name" },
                values: new object[,]
                {
                    { 1, false, false, "Lecture Hall Building" },
                    { 2, false, true, "Department Building" },
                    { 3, true, false, "Administration Building" },
                    { 4, true, false, "Auditorium" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "BuildingId", "Name", "PermissionTypeId" },
                values: new object[,]
                {
                    { 5, 5, "LT1", 1 },
                    { 1, 1, "ELR", 2 },
                    { 2, 1, "EIE Computer Lab", 2 },
                    { 3, 3, "MLR", 2 },
                    { 4, 2, "CLR", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "076f1c11-eb7e-4765-87fc-fa469233c1fe");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "37f2dd58-7c8f-407a-84e1-92b1e4cab83c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "85993c77-4830-4706-b03f-d0421c61a099");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ca2e3960-7a10-4622-bfc8-e0f531a271de");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "db527aa0-a2df-445b-9128-a18d9057ca66");

            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d48c2aba-9813-49e0-9876-0ed083b23311", "d38f74a6-0748-438a-9060-1beff74d7b81", "Teacher", "TEACHER" },
                    { "3639722e-1d68-49ee-ab0a-315bdc5c2afa", "f5f2c02b-3487-40a9-bf09-26656483e5af", "Student", "STUDENT" },
                    { "0a398be8-a0dd-48bf-80ff-ba82b06a018e", "ee680fbb-2d8e-4982-a25a-a6a9aeb38eb2", "Admin", "ADMIN" },
                    { "e9bb835e-44ff-44ef-842e-0067209a2215", "3b49e79c-4af7-4294-8d4a-551f3a501858", "AR", "AR" },
                    { "da3c86e6-89a9-4336-bb21-875abbd776f3", "84f5be0d-d56c-4e34-924a-6352582cb2dd", "HOD", "HOD" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
