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
                    GamblingSiteId = table.Column<byte[]>(nullable: false),
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
                    GameId = table.Column<byte[]>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    HomeTeamId = table.Column<byte[]>(nullable: true),
                    AwayTeamId = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    SportId = table.Column<byte[]>(nullable: false),
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
                    GameLineId = table.Column<byte[]>(nullable: false),
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
                    GameId = table.Column<byte[]>(nullable: false),
                    GamblingSiteId = table.Column<byte[]>(nullable: false)
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
                    GameResultId = table.Column<byte[]>(nullable: false),
                    HomeTeamScore = table.Column<int>(nullable: false),
                    AwayTeamScore = table.Column<int>(nullable: false),
                    GameId = table.Column<byte[]>(nullable: false)
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
                    TeamId = table.Column<byte[]>(nullable: false),
                    Mascot = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    SportId = table.Column<byte[]>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "GamblingSite",
                columns: new[] { "GamblingSiteId", "Name" },
                values: new object[,]
                {
                    { new byte[] { 35, 18, 195, 125, 245, 247, 154, 77, 134, 188, 30, 168, 107, 56, 71, 192 }, "Fanduel" },
                    { new byte[] { 163, 170, 13, 209, 13, 158, 177, 67, 186, 85, 175, 149, 75, 20, 203, 173 }, "FoxBet" },
                    { new byte[] { 125, 90, 93, 145, 115, 203, 218, 72, 173, 40, 22, 134, 209, 202, 67, 155 }, "DraftKings" },
                    { new byte[] { 226, 154, 81, 224, 110, 117, 163, 70, 143, 11, 222, 34, 240, 234, 198, 79 }, "BetRivers" }
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "SportId", "Name" },
                values: new object[,]
                {
                    { new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 }, "NBA" },
                    { new byte[] { 125, 36, 119, 168, 185, 143, 71, 71, 135, 244, 242, 109, 102, 11, 250, 66 }, "NFL" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot", "SportId" },
                values: new object[,]
                {
                    { new byte[] { 95, 29, 237, 149, 86, 42, 81, 73, 160, 114, 144, 52, 82, 130, 197, 207 }, "Atlanta", "Hawks", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 77, 38, 162, 83, 113, 116, 160, 65, 171, 40, 59, 169, 146, 105, 219, 196 }, "Toronto", "Raptors", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 32, 64, 120, 104, 187, 95, 220, 75, 166, 243, 170, 197, 79, 14, 23, 240 }, "San Antonio", "Spurs", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 218, 89, 240, 100, 227, 10, 222, 65, 140, 0, 107, 92, 199, 216, 250, 243 }, "Sacramento", "Kings", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 23, 16, 181, 220, 184, 129, 195, 64, 166, 170, 149, 172, 166, 116, 215, 172 }, "Portland", "Trail Blazers", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 254, 235, 50, 102, 179, 216, 191, 69, 135, 139, 38, 86, 224, 75, 212, 231 }, "Phoenix", "Suns", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 216, 54, 126, 254, 206, 101, 214, 75, 162, 45, 134, 157, 133, 131, 91, 136 }, "Philadelphia", "76ers", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 232, 155, 246, 218, 24, 46, 71, 76, 165, 202, 71, 27, 44, 155, 150, 82 }, "Orlando", "Magic", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 47, 59, 50, 19, 98, 186, 25, 74, 138, 84, 95, 133, 95, 79, 59, 211 }, "Oklahoma City", "Thunder", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 111, 46, 74, 149, 194, 91, 8, 72, 131, 197, 158, 186, 102, 156, 141, 123 }, "New York", "Knicks", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 29, 21, 251, 114, 239, 231, 145, 66, 172, 220, 23, 51, 23, 142, 184, 12 }, "New Orleans", "Pelicans", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 136, 39, 148, 225, 115, 244, 7, 79, 172, 141, 78, 76, 211, 184, 233, 187 }, "Minnesota", "Timberwolves", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 230, 120, 84, 93, 215, 85, 0, 79, 165, 68, 168, 157, 56, 78, 114, 216 }, "Milwaukee", "Bucks", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 51, 33, 149, 146, 93, 80, 86, 68, 162, 63, 211, 81, 138, 93, 193, 181 }, "Miami", "Heat", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 119, 25, 7, 253, 3, 138, 179, 71, 165, 145, 234, 120, 158, 209, 14, 82 }, "Memphis", "Grizzlies", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 145, 108, 116, 153, 125, 144, 14, 71, 150, 226, 139, 202, 109, 209, 185, 51 }, "Los Angeles", "Lakers", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 220, 46, 125, 97, 144, 234, 175, 65, 159, 99, 205, 88, 68, 29, 247, 73 }, "Los Angeles", "Clippers", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 133, 65, 223, 100, 150, 242, 33, 76, 145, 215, 77, 35, 26, 105, 208, 249 }, "Indiana", "Pacers", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 40, 145, 156, 66, 91, 231, 135, 79, 189, 15, 80, 212, 56, 99, 139, 72 }, "Houston", "Rockets", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 97, 64, 173, 24, 225, 228, 188, 66, 131, 62, 105, 152, 89, 194, 172, 100 }, "Golden State", "Warriors", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 116, 148, 204, 12, 188, 131, 82, 65, 177, 172, 79, 51, 244, 89, 197, 85 }, "Detroit", "Pistons", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 246, 184, 129, 18, 117, 43, 244, 74, 151, 192, 54, 168, 177, 246, 198, 26 }, "Denver", "Nuggets", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 17, 179, 14, 219, 183, 117, 214, 72, 175, 124, 254, 243, 35, 153, 211, 58 }, "Dallas", "Mavericks", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 177, 188, 171, 124, 168, 162, 162, 76, 180, 28, 140, 104, 190, 2, 178, 69 }, "Cleveland", "Cavaliers", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 145, 224, 109, 115, 72, 169, 122, 70, 134, 70, 179, 253, 207, 237, 226, 66 }, "Chicago", "Bulls", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 54, 9, 215, 49, 48, 27, 131, 69, 179, 48, 119, 52, 34, 173, 45, 53 }, "Charlotte", "Hornets", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 233, 171, 211, 80, 180, 143, 3, 71, 173, 199, 31, 149, 5, 200, 143, 1 }, "Brooklyn", "Nets", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 101, 120, 23, 10, 233, 203, 98, 67, 172, 75, 227, 36, 79, 210, 57, 193 }, "Boston", "Celtics", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 178, 97, 255, 146, 32, 249, 132, 72, 147, 194, 66, 246, 83, 231, 89, 22 }, "Utah", "Jazz", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } },
                    { new byte[] { 150, 239, 133, 221, 255, 208, 125, 67, 188, 185, 124, 55, 215, 130, 202, 16 }, "Washington", "Wizards", new byte[] { 103, 151, 70, 37, 84, 213, 213, 73, 142, 83, 188, 121, 141, 20, 123, 76 } }
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
