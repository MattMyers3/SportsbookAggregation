using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddMlsSport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OddsBoost",
                columns: table => new
                {
                    OddsBoostId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PreviousOdds = table.Column<int>(nullable: false),
                    BoostedOdds = table.Column<int>(nullable: false),
                    SportId = table.Column<Guid>(nullable: false),
                    GamblingSiteId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OddsBoost", x => x.OddsBoostId);
                    table.ForeignKey(
                        name: "FK_OddsBoost_GamblingSite_GamblingSiteId",
                        column: x => x.GamblingSiteId,
                        principalTable: "GamblingSite",
                        principalColumn: "GamblingSiteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OddsBoost_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "SportId", "Name" },
                values: new object[] { new Guid("c50f0844-6549-47e7-9409-921ad9bf160b"), "MLS" });

            migrationBuilder.CreateIndex(
                name: "IX_OddsBoost_GamblingSiteId",
                table: "OddsBoost",
                column: "GamblingSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_OddsBoost_SportId",
                table: "OddsBoost",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OddsBoost");

            migrationBuilder.DeleteData(
                table: "Sport",
                keyColumn: "SportId",
                keyValue: new Guid("c50f0844-6549-47e7-9409-921ad9bf160b"));
        }
    }
}
