using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddCaesars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GamblingSite",
                columns: new[] { "GamblingSiteId", "Name" },
                values: new object[] { new Guid("ee7f8f4c-23a7-4c35-a450-fed7cc90a6dd"), "Caesars" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GamblingSite",
                keyColumn: "GamblingSiteId",
                keyValue: new Guid("ee7f8f4c-23a7-4c35-a450-fed7cc90a6dd"));
        }
    }
}
