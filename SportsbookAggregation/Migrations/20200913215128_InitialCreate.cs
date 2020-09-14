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

            migrationBuilder.InsertData(
                table: "GamblingSite",
                columns: new[] { "GamblingSiteId", "Name" },
                values: new object[,]
                {
                    { new Guid("1fcec6f7-84b3-4033-af0f-e1f2bcb8528c"), "Fanduel" },
                    { new Guid("585e8b23-82e7-468e-b0f3-601cd6eb7a21"), "FoxBet" },
                    { new Guid("ef4a3b1e-dd09-4e32-a648-097ebae237d1"), "DraftKings" },
                    { new Guid("a13abd89-8246-4ce9-a3e1-34eee3084748"), "BetRivers" }
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "SportId", "Name" },
                values: new object[,]
                {
                    { new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024"), "NBA" },
                    { new Guid("6e972a45-6bd9-4085-9a78-faddf46294be"), "NFL" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot", "SportId" },
                values: new object[,]
                {
                    { new Guid("327fa1ce-ebd2-42b5-8ae3-af4e1f85c31b"), "Atlanta", "Hawks", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("4d89def6-375b-4b58-8385-858ea8957576"), "Toronto", "Raptors", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("2578493d-1735-4427-a2e1-492f8c43fdfd"), "San Antonio", "Spurs", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("adb45183-40f4-4cba-adec-062976372d31"), "Sacramento", "Kings", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("a0ada57d-419d-4fec-9d72-a6d6b96fcb34"), "Portland", "Trail Blazers", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("9490d52f-d1d1-4ac7-87d0-0ef922f4e3e2"), "Phoenix", "Suns", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("e3708fae-5fc1-40d6-b0bc-10330212eb46"), "Philadelphia", "76ers", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("377a4678-f768-41f8-850e-437b87315b10"), "Orlando", "Magic", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("17c82efe-820f-47f1-beda-7ca67f77fffa"), "Oklahoma City", "Thunder", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("aa91f18e-db7f-49b6-ae39-830232228741"), "New York", "Knicks", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("980e2d86-24f5-4db1-9e86-a24f69f64363"), "New Orleans", "Pelicans", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("49b08feb-f42e-4003-afea-14e5f967bf83"), "Minnesota", "Timberwolves", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("faae94d4-821c-4089-abc9-00e59164cfe4"), "Milwaukee", "Bucks", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("553993e6-d5d2-41d1-9aa4-96282469b7f4"), "Miami", "Heat", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("0dcdcb0d-5a8f-4f06-ae40-e6c8f9405a2b"), "Memphis", "Grizzlies", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("d96a3350-0ee1-4ebb-a3c5-7e8d9ffbdbcf"), "Los Angeles", "Lakers", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("a8427679-a566-4cb6-baf5-90f848a70ef1"), "Los Angeles", "Clippers", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("e07441a3-7862-4aa9-b102-fa9eff3a3d32"), "Indiana", "Pacers", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("9cb62c80-9eed-4778-9db9-c96a3f210548"), "Houston", "Rockets", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("a7d2b876-5c8f-40c0-a245-64009f1d6875"), "Golden State", "Warriors", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("136ffb0e-e6db-447f-ac0b-d24d0972c63a"), "Detroit", "Pistons", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("cc3a3123-ffcc-4575-aaf6-908bf0a29ae2"), "Denver", "Nuggets", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("f3449c73-2bdf-45d6-a12a-5fcdcdba9c7a"), "Dallas", "Mavericks", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("567d7281-3835-4ebe-9bbc-db22003ef4aa"), "Cleveland", "Cavaliers", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("9535fd86-0476-4267-964d-86b6ee59c5f1"), "Chicago", "Bulls", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("dba20e75-2763-45e0-8357-f7abdef5796e"), "Charlotte", "Hornets", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("51058c98-007a-4a03-a4dc-1678f39d0fe6"), "Brooklyn", "Nets", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("f4646032-8ce2-4115-aa17-6a3f829c48c6"), "Boston", "Celtics", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("104981bd-8e56-4d67-bbd0-f6f1bfd50a2d"), "Utah", "Jazz", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") },
                    { new Guid("261454ae-5f16-4707-ada1-bff5095f056b"), "Washington", "Wizards", new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024") }
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
