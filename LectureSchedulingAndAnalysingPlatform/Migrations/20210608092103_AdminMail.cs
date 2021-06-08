using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class AdminMail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "AdminMail",
                table: "Hods",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hods",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdminMail",
                value: "nadeeshamadhushan9@gmail.com");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d3521b44-7597-45fb-ad94-38aa7bac8343", "f3093940-2169-4671-aea1-2e77ab32ebe9", "Lecturer", "LECTURER" },
                    { "80d90a9f-a5a8-44bc-903c-3af96806e802", "46cc393f-ea97-484e-9b6a-c9962dc947e7", "Student", "STUDENT" },
                    { "9a782287-7cb0-4945-b288-f794942717a0", "eb315df8-e3b7-41eb-96fa-a20b7c1b4ff0", "Admin", "ADMIN" },
                    { "d5565ff9-8d90-42c9-9190-6efa2e34a368", "a70f6e17-7c9e-4b0b-b748-02415313814f", "AR", "AR" },
                    { "da340324-50f0-4c65-8024-48a5b9f9c873", "8dfb9432-bc60-4853-b1a8-40975bc90a6e", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "80d90a9f-a5a8-44bc-903c-3af96806e802");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9a782287-7cb0-4945-b288-f794942717a0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d3521b44-7597-45fb-ad94-38aa7bac8343");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d5565ff9-8d90-42c9-9190-6efa2e34a368");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "da340324-50f0-4c65-8024-48a5b9f9c873");

            migrationBuilder.DropColumn(
                name: "AdminMail",
                table: "Hods");

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
    }
}
