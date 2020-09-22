using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddAlerts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alert",
                columns: table => new
                {
                    AlertId = table.Column<Guid>(nullable: false),
                    GameId = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    CurrentOver = table.Column<double>(nullable: true),
                    CurrentUnder = table.Column<double>(nullable: true),
                    CurrentOverPayout = table.Column<int>(nullable: true),
                    CurrentUnderPayout = table.Column<int>(nullable: true),
                    CurrentHomeSpread = table.Column<double>(nullable: true),
                    CurrentHomeSpreadPayout = table.Column<int>(nullable: true),
                    CurrentAwaySpread = table.Column<double>(nullable: true),
                    CurrentAwaySpreadPayout = table.Column<int>(nullable: true),
                    CurrentHomeMoneyLine = table.Column<int>(nullable: true),
                    CurrentAwayMoneyLine = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alert", x => x.AlertId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alert");
        }
    }
}
