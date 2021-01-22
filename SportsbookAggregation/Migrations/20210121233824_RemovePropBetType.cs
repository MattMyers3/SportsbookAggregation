using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class RemovePropBetType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerProp_PropBetType_PropBetTypeId",
                table: "PlayerProp");

            migrationBuilder.DropTable(
                name: "PropBetType");

            migrationBuilder.DropIndex(
                name: "IX_PlayerProp_PropBetTypeId",
                table: "PlayerProp");

            migrationBuilder.DropColumn(
                name: "PropBetTypeId",
                table: "PlayerProp");

            migrationBuilder.AddColumn<string>(
                name: "PropBetType",
                table: "PlayerProp",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropBetType",
                table: "PlayerProp");

            migrationBuilder.AddColumn<Guid>(
                name: "PropBetTypeId",
                table: "PlayerProp",
                type: "binary(16)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "PropBetType",
                columns: table => new
                {
                    PropBetTypeId = table.Column<Guid>(type: "binary(16)", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropBetType", x => x.PropBetTypeId);
                });

            migrationBuilder.InsertData(
                table: "PropBetType",
                columns: new[] { "PropBetTypeId", "Description" },
                values: new object[] { new Guid("70dc1a52-243a-4097-8263-7b45da56d77f"), "Touchdown Scorer" });

            migrationBuilder.InsertData(
                table: "PropBetType",
                columns: new[] { "PropBetTypeId", "Description" },
                values: new object[] { new Guid("324bd1c0-28a7-478c-8e10-b89ee0ad54eb"), "Basket Scorer" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProp_PropBetTypeId",
                table: "PlayerProp",
                column: "PropBetTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerProp_PropBetType_PropBetTypeId",
                table: "PlayerProp",
                column: "PropBetTypeId",
                principalTable: "PropBetType",
                principalColumn: "PropBetTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
