using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddBetMGM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GamblingSite",
                columns: new[] { "GamblingSiteId", "Name" },
                values: new object[] { new Guid("153a8d43-3c06-4cb2-ba83-219001b133aa"), "BetMGM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GamblingSite",
                keyColumn: "GamblingSiteId",
                keyValue: new Guid("153a8d43-3c06-4cb2-ba83-219001b133aa"));
        }
    }
}
