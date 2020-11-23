using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AdjustPlayerProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerProp",
                columns: table => new
                {
                    PlayerPropId = table.Column<Guid>(nullable: false),
                    PropBetTypeId = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    GameId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PropValue = table.Column<double>(nullable: true),
                    Payout = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerProp", x => x.PlayerPropId);
                    table.ForeignKey(
                        name: "FK_PlayerProp_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerProp_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerProp_PropBetType_PropBetTypeId",
                        column: x => x.PropBetTypeId,
                        principalTable: "PropBetType",
                        principalColumn: "PropBetTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProp_GameId",
                table: "PlayerProp",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProp_PlayerId",
                table: "PlayerProp",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProp_PropBetTypeId",
                table: "PlayerProp",
                column: "PropBetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerProp");
        }
    }
}
