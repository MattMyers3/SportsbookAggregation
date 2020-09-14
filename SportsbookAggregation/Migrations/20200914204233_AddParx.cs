using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddParx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GamblingSite",
                columns: new[] { "GamblingSiteId", "Name" },
                values: new object[] { new Guid("ae98bc03-bf79-491a-8d5a-23acc23908a9"), "Parx" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GamblingSite",
                keyColumn: "GamblingSiteId",
                keyValue: new Guid("ae98bc03-bf79-491a-8d5a-23acc23908a9"));
        }
    }
}
