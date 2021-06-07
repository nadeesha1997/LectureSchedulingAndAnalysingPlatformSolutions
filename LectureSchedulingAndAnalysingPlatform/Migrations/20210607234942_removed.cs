using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class removed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hods_Departments_DepartmentId",
                table: "Hods");

            migrationBuilder.DropForeignKey(
                name: "FK_Hods_Users_UserId",
                table: "Hods");

            migrationBuilder.DropTable(
                name: "A");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "PermissionTypes");

            migrationBuilder.DropTable(
                name: "Reservers");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Hods_DepartmentId",
                table: "Hods");

            migrationBuilder.DropIndex(
                name: "IX_Hods_UserId",
                table: "Hods");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "64337396-4414-45de-93ed-318dda6cffd5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a94352dd-7cd9-40b5-ad25-337106e86d74");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ea5cefaa-b020-41cd-b2de-391c8c951790");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "eaf34864-872a-4aa1-973b-712f5877345f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f37a2294-3b76-4cfe-ae4b-adbd44879995");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Hods");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Hods");

            migrationBuilder.AddColumn<string>(
                name: "ArMail",
                table: "Hods",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CivilMail",
                table: "Hods",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElectricalMail",
                table: "Hods",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MechanicalMail",
                table: "Hods",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HodId",
                table: "Departments",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cf5be22d-9ed6-471a-afcf-f4ba9516882d", "5409ec9f-786d-4263-a746-d6e438391e5b", "Lecturer", "LECTURER" },
                    { "2d8c0a4a-0f6b-4352-bd4f-deb21620f437", "66e6f7f8-c89b-4398-907d-dd39928a0df9", "Student", "STUDENT" },
                    { "e3f3af64-7883-47ae-b355-5b6fd41a45e8", "1e900b18-65c4-4cac-8cd4-2b45c9b11039", "Admin", "ADMIN" },
                    { "15c1ea27-59fc-4f26-9e2b-3eee37933eb8", "4925a806-83f3-4c69-b071-7184706c57ef", "AR", "AR" },
                    { "c1b00149-2ab0-4016-a243-fe6f5b33b8ce", "cda05e89-5cf5-476b-8f77-34b3e70d7bc0", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HodId",
                table: "Departments",
                column: "HodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Hods_HodId",
                table: "Departments",
                column: "HodId",
                principalTable: "Hods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Hods_HodId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_HodId",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "15c1ea27-59fc-4f26-9e2b-3eee37933eb8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2d8c0a4a-0f6b-4352-bd4f-deb21620f437");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c1b00149-2ab0-4016-a243-fe6f5b33b8ce");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cf5be22d-9ed6-471a-afcf-f4ba9516882d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e3f3af64-7883-47ae-b355-5b6fd41a45e8");

            migrationBuilder.DropColumn(
                name: "ArMail",
                table: "Hods");

            migrationBuilder.DropColumn(
                name: "CivilMail",
                table: "Hods");

            migrationBuilder.DropColumn(
                name: "ElectricalMail",
                table: "Hods");

            migrationBuilder.DropColumn(
                name: "MechanicalMail",
                table: "Hods");

            migrationBuilder.DropColumn(
                name: "HodId",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Hods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Hods",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LecturerID = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permitted = table.Column<bool>(type: "bit", nullable: false),
                    PermittedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermittedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PermissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ar = table.Column<bool>(type: "bit", nullable: false),
                    Hod = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HallId = table.Column<int>(type: "int", nullable: true),
                    Permitted = table.Column<bool>(type: "bit", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "A",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedById = table.Column<int>(type: "int", nullable: true),
                    ApprovedById1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_A_Users_ApprovedById1",
                        column: x => x.ApprovedById1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservers_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eaf34864-872a-4aa1-973b-712f5877345f", "ef1c7a41-6689-430d-8c9d-b4a811a0edf2", "Lecturer", "LECTURER" },
                    { "a94352dd-7cd9-40b5-ad25-337106e86d74", "71a1b94c-34f4-4b4c-8e97-8ea63e8a8991", "Student", "STUDENT" },
                    { "f37a2294-3b76-4cfe-ae4b-adbd44879995", "79633623-51c6-4faf-abb7-5710c3a2c2dc", "Admin", "ADMIN" },
                    { "ea5cefaa-b020-41cd-b2de-391c8c951790", "4ef35f9b-80c9-44ab-9e5f-265d4ae564c9", "AR", "AR" },
                    { "64337396-4414-45de-93ed-318dda6cffd5", "1845ed43-99aa-4466-9c13-72680d724cc0", "HOD", "HOD" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Hods_DepartmentId",
                table: "Hods",
                column: "DepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hods_UserId",
                table: "Hods",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_A_ApprovedById1",
                table: "A",
                column: "ApprovedById1");

            migrationBuilder.CreateIndex(
                name: "IX_A_PermissionId",
                table: "A",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_SessionId",
                table: "Permissions",
                column: "SessionId",
                unique: true,
                filter: "[SessionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_HallId",
                table: "Reservations",
                column: "HallId",
                unique: true,
                filter: "[HallId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_ReservationId",
                table: "Reservers",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_UserId",
                table: "Reservers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hods_Departments_DepartmentId",
                table: "Hods",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hods_Users_UserId",
                table: "Hods",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
