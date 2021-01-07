using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddPlayerProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropBetType",
                columns: table => new
                {
                    PropBetTypeId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropBetType", x => x.PropBetTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PlayerProp",
                columns: table => new
                {
                    PlayerPropId = table.Column<Guid>(nullable: false),
                    PropBetTypeId = table.Column<Guid>(nullable: false),
                    GameId = table.Column<Guid>(nullable: false),
                    GamblingSiteId = table.Column<Guid>(nullable: false),
                    PlayerName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PropValue = table.Column<double>(nullable: true),
                    Payout = table.Column<int>(nullable: true),
                    LastRefresh = table.Column<DateTime>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerProp", x => x.PlayerPropId);
                    table.ForeignKey(
                        name: "FK_PlayerProp_GamblingSite_GamblingSiteId",
                        column: x => x.GamblingSiteId,
                        principalTable: "GamblingSite",
                        principalColumn: "GamblingSiteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerProp_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerProp_PropBetType_PropBetTypeId",
                        column: x => x.PropBetTypeId,
                        principalTable: "PropBetType",
                        principalColumn: "PropBetTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProp_GamblingSiteId",
                table: "PlayerProp",
                column: "GamblingSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProp_GameId",
                table: "PlayerProp",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProp_PropBetTypeId",
                table: "PlayerProp",
                column: "PropBetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerProp");

            migrationBuilder.DropTable(
                name: "PropBetType");
        }
    }
}
