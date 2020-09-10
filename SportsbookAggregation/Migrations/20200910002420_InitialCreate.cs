using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GamblingSite",
                columns: table => new
                {
                    GamblingSiteId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamblingSite", x => x.GamblingSiteId);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameId = table.Column<Guid>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    HomeTeamId = table.Column<Guid>(nullable: true),
                    AwayTeamId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    SportId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "GameLine",
                columns: table => new
                {
                    GameLineId = table.Column<Guid>(nullable: false),
                    OpeningOverUnder = table.Column<double>(nullable: true),
                    CurrentOverUnder = table.Column<double>(nullable: true),
                    OverPayOut = table.Column<int>(nullable: true),
                    UnderPayout = table.Column<int>(nullable: true),
                    OpeningSpread = table.Column<double>(nullable: true),
                    CurrentSpread = table.Column<double>(nullable: true),
                    HomeSpreadPayout = table.Column<int>(nullable: true),
                    AwaySpreadPayout = table.Column<int>(nullable: true),
                    HomeMoneyLinePayout = table.Column<int>(nullable: true),
                    AwayMoneyLinePayout = table.Column<int>(nullable: true),
                    GameId = table.Column<Guid>(nullable: false),
                    GamblingSiteId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLine", x => x.GameLineId);
                    table.ForeignKey(
                        name: "FK_GameLine_GamblingSite_GamblingSiteId",
                        column: x => x.GamblingSiteId,
                        principalTable: "GamblingSite",
                        principalColumn: "GamblingSiteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameLine_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameResult",
                columns: table => new
                {
                    GameResultId = table.Column<Guid>(nullable: false),
                    HomeTeamScore = table.Column<int>(nullable: false),
                    AwayTeamScore = table.Column<int>(nullable: false),
                    GameId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameResult", x => x.GameResultId);
                    table.ForeignKey(
                        name: "FK_GameResult_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<Guid>(nullable: false),
                    Mascot = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    SportId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Team_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameLine_GamblingSiteId",
                table: "GameLine",
                column: "GamblingSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_GameLine_GameId",
                table: "GameLine",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameResult_GameId",
                table: "GameResult",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_SportId",
                table: "Team",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameLine");

            migrationBuilder.DropTable(
                name: "GameResult");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "GamblingSite");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Sport");
        }
    }
}
