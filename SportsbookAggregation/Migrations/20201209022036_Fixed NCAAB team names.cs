using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class FixedNCAABteamnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("43f58925-3aaa-435f-a078-556ba535d9bc"),
                column: "Location",
                value: "Loyola Chicago");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4d25165c-b394-4bf2-8fce-6b0277e3dd5e"),
                column: "Location",
                value: "Loyola Maryland");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("43f58925-3aaa-435f-a078-556ba535d9bc"),
                column: "Location",
                value: "Loyola (Chicago)");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4d25165c-b394-4bf2-8fce-6b0277e3dd5e"),
                column: "Location",
                value: "Loyola (Maryland)");
        }
    }
}
