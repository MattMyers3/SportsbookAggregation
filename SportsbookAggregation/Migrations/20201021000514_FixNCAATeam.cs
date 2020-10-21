using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class FixNCAATeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2d1c1515-d4f5-409f-bb81-d77604310a6c"),
                column: "Location",
                value: "Louisiana-Monroe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2d1c1515-d4f5-409f-bb81-d77604310a6c"),
                column: "Location",
                value: "Louisiana–Monroe");
        }
    }
}
