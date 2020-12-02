using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddUserSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    DefaultBooks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSettings");
        }
    }
}
