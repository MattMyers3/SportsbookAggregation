using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddSiteToPlayerProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GamblingSiteId",
                table: "PlayerProp",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastRefresh",
                table: "PlayerProp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "PropBetType",
                columns: new[] { "PropBetTypeId", "Description" },
                values: new object[] { new Guid("d399e68e-ac96-4eb1-9091-87ab18408dbb"), "First Touchdown Scorer" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProp_GamblingSiteId",
                table: "PlayerProp",
                column: "GamblingSiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerProp_GamblingSite_GamblingSiteId",
                table: "PlayerProp",
                column: "GamblingSiteId",
                principalTable: "GamblingSite",
                principalColumn: "GamblingSiteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerProp_GamblingSite_GamblingSiteId",
                table: "PlayerProp");

            migrationBuilder.DropIndex(
                name: "IX_PlayerProp_GamblingSiteId",
                table: "PlayerProp");

            migrationBuilder.DeleteData(
                table: "PropBetType",
                keyColumn: "PropBetTypeId",
                keyValue: new Guid("d399e68e-ac96-4eb1-9091-87ab18408dbb"));

            migrationBuilder.DropColumn(
                name: "GamblingSiteId",
                table: "PlayerProp");

            migrationBuilder.DropColumn(
                name: "LastRefresh",
                table: "PlayerProp");
        }
    }
}
