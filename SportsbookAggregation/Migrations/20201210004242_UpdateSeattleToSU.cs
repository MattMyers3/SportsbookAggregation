using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class UpdateSeattleToSU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("878a0978-4828-4262-bbf4-87c4dcf3001a"),
                column: "Location",
                value: "SU");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("878a0978-4828-4262-bbf4-87c4dcf3001a"),
                column: "Location",
                value: "Seattle");
        }
    }
}
