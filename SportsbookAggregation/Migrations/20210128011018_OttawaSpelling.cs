using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class OttawaSpelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("113bfd18-9c4a-482c-b8b6-405742a2a0b1"),
                column: "Location",
                value: "Ottawa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("113bfd18-9c4a-482c-b8b6-405742a2a0b1"),
                column: "Location",
                value: "Ottowa");
        }
    }
}
