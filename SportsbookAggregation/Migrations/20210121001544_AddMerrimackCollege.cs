using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddMerrimackCollege : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot" },
                values: new object[] { new Guid("0a3568ad-970a-4deb-a5ec-c9386327e078"), "Merrimack", "Warriors" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0a3568ad-970a-4deb-a5ec-c9386327e078"));
        }
    }
}
