using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class Hod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "57ac6896-8ab8-45ee-9f1a-d1fa0e75e196");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5d3c14b4-6315-4fa7-82f8-1500b647089c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a6e8ad25-ef35-4ed6-a540-4f2a90fb3d6f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c5f5f2ea-2053-47fc-a52e-362644c88f8b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e36982ba-90d8-43af-bb25-ef2bd938cdf8");

            migrationBuilder.DropColumn(
                name: "HodId",
                table: "Departments");

            migrationBuilder.InsertData(
                table: "Hods",
                columns: new[] { "Id", "ArMail", "CivilMail", "ElectricalMail", "MechanicalMail" },
                values: new object[] { 1, "nadeeshamadhushan9@gmail.com", "nadeeshamadhushan9@gmail.com", "nadeeshamadhushan9@gmail.com", "nadeeshamadhushan9@gmail.com" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03eb2903-c076-4133-840d-eb35034f2469", "a0b6bda7-abc9-4e2b-b8d6-513fe5ff2de5", "Lecturer", "LECTURER" },
                    { "894273ef-63b8-4821-a7e2-06fc63a90f8e", "2aebb428-0254-4e30-92a0-135b34cde193", "Student", "STUDENT" },
                    { "68545bd7-abb8-4304-ac10-622193c29145", "d96d09f4-d6fd-4443-a4ab-f36f9a4611f7", "Admin", "ADMIN" },
                    { "c44e46c1-02ee-4124-99bc-7aa702842de7", "cf30edc3-2310-4247-b2e7-36eedb421399", "AR", "AR" },
                    { "2158f6d7-f644-4487-8b6e-cf78139b65cf", "27b04072-a79e-481b-a832-8f12bdaa35fd", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "03eb2903-c076-4133-840d-eb35034f2469");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2158f6d7-f644-4487-8b6e-cf78139b65cf");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "68545bd7-abb8-4304-ac10-622193c29145");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "894273ef-63b8-4821-a7e2-06fc63a90f8e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c44e46c1-02ee-4124-99bc-7aa702842de7");

            migrationBuilder.AddColumn<int>(
                name: "HodId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57ac6896-8ab8-45ee-9f1a-d1fa0e75e196", "1a6eedb2-7637-4538-b72a-767746322755", "Lecturer", "LECTURER" },
                    { "5d3c14b4-6315-4fa7-82f8-1500b647089c", "172dc9f2-683a-42bb-a869-8c0451f67149", "Student", "STUDENT" },
                    { "c5f5f2ea-2053-47fc-a52e-362644c88f8b", "b75e0ae5-9273-4dfe-9526-014be3a90b11", "Admin", "ADMIN" },
                    { "a6e8ad25-ef35-4ed6-a540-4f2a90fb3d6f", "2b575f42-7bc2-4843-9024-537fae3957be", "AR", "AR" },
                    { "e36982ba-90d8-43af-bb25-ef2bd938cdf8", "3287e2e6-9f4a-40c8-b7f8-3545b01cc3e8", "HOD", "HOD" }
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
    }
}
