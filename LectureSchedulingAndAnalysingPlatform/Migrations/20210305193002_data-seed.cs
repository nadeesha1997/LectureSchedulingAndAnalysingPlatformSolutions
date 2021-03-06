using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "218c66fc-e496-4576-8567-0579796e6d0b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6619f372-2df5-4a97-b5d0-70a637c59fff");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "91b03e1a-c7f0-487d-b575-5c94d8d2418a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d70061c7-ddaa-4a5b-bef3-61e13d20b403");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "de923c10-7132-4b7f-9aeb-6d4771fde90e");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Sessions");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "Sessions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateTime",
                table: "Sessions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f8323b78-1d91-4d10-aac7-6fd0fefd3b72", "9ff9f641-53ae-49d3-a190-065c467e83f9", "Teacher", "TEACHER" },
                    { "972dc48c-28a3-4a1f-9b21-05e2d84ec1f5", "5057ce2d-ccf5-4294-adc6-8b10125716c9", "Student", "STUDENT" },
                    { "6655f50b-3f9a-4619-810c-fe53cfa15d26", "55d8ff2d-e754-4f50-875b-ccc7f6bdcdc8", "Admin", "ADMIN" },
                    { "c142ef0b-2a79-4e5c-8e3d-51be2b34b150", "37f108a9-bcaf-41d6-a725-95c6f7313e71", "AR", "AR" },
                    { "890c4b4e-919b-429d-b817-ca4356e5d216", "8b5f6049-2b2b-43ba-a44d-a8a4b38002c0", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6655f50b-3f9a-4619-810c-fe53cfa15d26");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "890c4b4e-919b-429d-b817-ca4356e5d216");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "972dc48c-28a3-4a1f-9b21-05e2d84ec1f5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c142ef0b-2a79-4e5c-8e3d-51be2b34b150");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f8323b78-1d91-4d10-aac7-6fd0fefd3b72");

            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "StartDateTime",
                table: "Sessions");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Sessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Sessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "de923c10-7132-4b7f-9aeb-6d4771fde90e", "99d1fefe-fa42-4648-a226-ae317d5dc9ee", "Teacher", "TEACHER" },
                    { "91b03e1a-c7f0-487d-b575-5c94d8d2418a", "a509f090-e88c-4fc3-8534-6b57305438f3", "Student", "STUDENT" },
                    { "6619f372-2df5-4a97-b5d0-70a637c59fff", "a62145ac-8f36-4c81-a5ce-60832e4a3f3f", "Admin", "ADMIN" },
                    { "218c66fc-e496-4576-8567-0579796e6d0b", "67068ecc-5bae-45db-a032-da1b09cfe353", "AR", "AR" },
                    { "d70061c7-ddaa-4a5b-bef3-61e13d20b403", "083800bb-040d-40b8-a553-35ae473b3985", "HOD", "HOD" }
                });
        }
    }
}
