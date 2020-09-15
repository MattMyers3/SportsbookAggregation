using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddBetAmerica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GamblingSite",
                columns: new[] { "GamblingSiteId", "Name" },
                values: new object[] { new Guid("89f19651-c30c-4846-8197-8f10e43b4ae6"), "BetAmerica" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GamblingSite",
                keyColumn: "GamblingSiteId",
                keyValue: new Guid("89f19651-c30c-4846-8197-8f10e43b4ae6"));
        }
    }
}
