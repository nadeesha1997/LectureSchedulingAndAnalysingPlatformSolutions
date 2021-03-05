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
                keyValue: "11909249-8e58-4379-8a66-bd6261ef261c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "17b6d1a7-5b8e-4407-b30f-75529c3778e6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "356a571d-4ed2-4164-9960-7b6ba9d158c0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a7767895-2e2d-4eba-90e9-222a7702f546");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c2b77959-877a-438a-bce8-8ee0c6b06ab3");

            migrationBuilder.AddColumn<bool>(
                name: "Permitted",
                table: "Sessions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Sessions",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c6722ac-8e68-4cb8-83d6-a8f9ad5553f0", "d0294e28-8aa9-4e61-b371-e9cb99d618b2", "Teacher", "TEACHER" },
                    { "69ca4e40-9066-4093-b439-80f9410b8221", "a1df3b27-7b94-4c53-aa01-4ff53174b498", "Student", "STUDENT" },
                    { "329afd41-f0b5-48c4-940a-2c1228282092", "24bdd163-c300-4696-b92a-57550b17eaa8", "Admin", "ADMIN" },
                    { "2fd7c7a0-790c-43d9-ae60-b03b87557e75", "af9edf9e-747f-409f-9766-2e0f6a1078ab", "AR", "AR" },
                    { "c0522212-550b-4678-b519-14616686afa4", "bc4be5d9-cdf2-4533-bdc8-09f3059a5b55", "HOD", "HOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0c6722ac-8e68-4cb8-83d6-a8f9ad5553f0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2fd7c7a0-790c-43d9-ae60-b03b87557e75");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "329afd41-f0b5-48c4-940a-2c1228282092");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "69ca4e40-9066-4093-b439-80f9410b8221");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c0522212-550b-4678-b519-14616686afa4");

            migrationBuilder.DropColumn(
                name: "Permitted",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Sessions");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17b6d1a7-5b8e-4407-b30f-75529c3778e6", "6b26d1c5-561c-4c24-874d-10e520a029f4", "Teacher", "TEACHER" },
                    { "a7767895-2e2d-4eba-90e9-222a7702f546", "8cb296a9-c824-43c0-9897-826c5a991b35", "Student", "STUDENT" },
                    { "356a571d-4ed2-4164-9960-7b6ba9d158c0", "2dc5f7f3-f485-4d0f-bff7-44e51c4feca6", "Admin", "ADMIN" },
                    { "11909249-8e58-4379-8a66-bd6261ef261c", "fb6ab1b8-effe-4e5e-8f5d-b99b2c41496f", "AR", "AR" },
                    { "c2b77959-877a-438a-bce8-8ee0c6b06ab3", "e4d00c04-30cd-4413-b8a4-f51874998b4c", "HOD", "HOD" }
                });
        }
    }
}
