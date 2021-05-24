using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class onlinesession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0b807a0a-4e6d-4cc5-a722-cc562c80884d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "31274737-f131-447f-b3dd-10a83ecaeb58");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5daf77bb-0386-470b-9ef1-6fcdf59d98a7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ae2a85c1-9923-421e-a050-a8742ede488a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f6ff08a7-1ecd-4545-b5b6-1746e82110fa");

            migrationBuilder.CreateTable(
                name: "OnlineSessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    SubjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineSessions_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineSessions_Users_UserId",
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
                    { "31bdbc56-8735-4271-b498-67daff815a32", "5e7768f4-5a3d-45bc-8ed5-0f1ddd3b3ca8", "Teacher", "TEACHER" },
                    { "7029ea08-288d-460c-9b4d-aa0ceffb2652", "9ace28d9-fb25-43ef-ab51-39c1932dc2ee", "Student", "STUDENT" },
                    { "20fce5be-c51f-4a32-ae16-b4f579df57c8", "30b35b57-1329-46f7-8db7-226cfe2da89a", "Admin", "ADMIN" },
                    { "6a605635-e043-479e-bae3-3e40b88193f7", "1d6d5655-6330-4802-8893-06c34e8eec96", "AR", "AR" },
                    { "d10a1aba-c4a3-47af-a426-b1f1a57d6f76", "c3a5f4b4-7bcb-4902-86c7-d598e573af04", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OnlineSessions_SubjectId",
                table: "OnlineSessions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineSessions_UserId",
                table: "OnlineSessions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnlineSessions");

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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5daf77bb-0386-470b-9ef1-6fcdf59d98a7", "2b91cbe5-4b66-4cd6-ab0b-5820db5bced6", "Teacher", "TEACHER" },
                    { "ae2a85c1-9923-421e-a050-a8742ede488a", "57f5d6c5-a7c8-4be7-8c63-58a4174b1f3c", "Student", "STUDENT" },
                    { "31274737-f131-447f-b3dd-10a83ecaeb58", "16989de9-a1c1-413e-8e96-72ba0716e730", "Admin", "ADMIN" },
                    { "0b807a0a-4e6d-4cc5-a722-cc562c80884d", "b2885bb7-345e-4387-8d5f-0bdfe90b30a6", "AR", "AR" },
                    { "f6ff08a7-1ecd-4545-b5b6-1746e82110fa", "1ee6eb21-b6db-40dc-8b50-76fda55543e5", "HOD", "HOD" }
                });
        }
    }
}
