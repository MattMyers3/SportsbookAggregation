using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class Kangaroo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a26364b1-c1a4-4cad-b2fe-3065f85966e3"),
                column: "Mascot",
                value: "Kangaroos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a26364b1-c1a4-4cad-b2fe-3065f85966e3"),
                column: "Mascot",
                value: "Kasey the Kangaroo");
        }
    }
}
