using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class hoddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60276952-68a7-4110-a1ae-a132296ccb16", "3a83e9c8-7747-40c5-9d73-eb4b0626e13a", "Lecturer", "LECTURER" },
                    { "c498f781-a827-4561-8601-c7d7f4e8930a", "683dbdcf-3af8-4210-99ac-cf98313d7bfe", "Student", "STUDENT" },
                    { "8cca3dbf-9c69-44fe-8292-c33437d2ec8c", "4df48f18-f959-4b54-a91f-a1e1d14041f1", "Admin", "ADMIN" },
                    { "19ff2918-e4e1-4948-bca3-8803302b66cd", "bbeee5bf-f141-43bd-8041-5ddf0eaf4fd2", "AR", "AR" },
                    { "16268820-1a40-4990-b1ad-69c3863f40a4", "7f0cfdbf-ba54-499a-a66d-3545a0a49229", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "16268820-1a40-4990-b1ad-69c3863f40a4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "19ff2918-e4e1-4948-bca3-8803302b66cd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "60276952-68a7-4110-a1ae-a132296ccb16");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8cca3dbf-9c69-44fe-8292-c33437d2ec8c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c498f781-a827-4561-8601-c7d7f4e8930a");

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
        }
    }
}
