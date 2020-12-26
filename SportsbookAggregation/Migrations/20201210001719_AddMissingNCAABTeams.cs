using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddMissingNCAABTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot" },
                values: new object[] { new Guid("05b00303-9ef9-4b2d-8fcd-64c111447536"), "UNA", "Lions" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot" },
                values: new object[] { new Guid("e0c9bc0e-2b51-44dc-93e9-7fb1126927c1"), "Coppin State", "Eagles" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot" },
                values: new object[] { new Guid("a26364b1-c1a4-4cad-b2fe-3065f85966e3"), "UMKC", "Kasey the Kangaroo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("05b00303-9ef9-4b2d-8fcd-64c111447536"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a26364b1-c1a4-4cad-b2fe-3065f85966e3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e0c9bc0e-2b51-44dc-93e9-7fb1126927c1"));
        }
    }
}
