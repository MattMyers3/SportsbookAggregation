using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddDixieState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot" },
                values: new object[] { new Guid("ec0dc24e-f546-442a-9b2a-ab0803a31170"), "Dixie State", "Trailblazers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ec0dc24e-f546-442a-9b2a-ab0803a31170"));
        }
    }
}
