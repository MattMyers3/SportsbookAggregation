using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddNCAAB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "SportId", "Name" },
                values: new object[] { new Guid("d455e82d-31d6-48ad-b119-c4059d9f273a"), "NCAAB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sport",
                keyColumn: "SportId",
                keyValue: new Guid("d455e82d-31d6-48ad-b119-c4059d9f273a"));
        }
    }
}
