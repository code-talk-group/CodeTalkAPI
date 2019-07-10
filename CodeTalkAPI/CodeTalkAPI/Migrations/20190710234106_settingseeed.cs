using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTalkAPI.Migrations
{
    public partial class settingseeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InputCollection",
                table: "UserSnippets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InputCollection",
                table: "UserSnippets",
                nullable: true);
        }
    }
}
