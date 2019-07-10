using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTalkAPI.Migrations
{
    public partial class settingseee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Input",
                table: "UserSnippets",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "UserSnippets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Input",
                value: "[i, am, a, string]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Input",
                table: "UserSnippets");
        }
    }
}
