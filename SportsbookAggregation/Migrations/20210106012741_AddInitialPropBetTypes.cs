using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddInitialPropBetTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropBetType",
                columns: new[] { "PropBetTypeId", "Description" },
                values: new object[] { new Guid("70dc1a52-243a-4097-8263-7b45da56d77f"), "Touchdown Scorer" });

            migrationBuilder.InsertData(
                table: "PropBetType",
                columns: new[] { "PropBetTypeId", "Description" },
                values: new object[] { new Guid("324bd1c0-28a7-478c-8e10-b89ee0ad54eb"), "Basket Scorer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropBetType",
                keyColumn: "PropBetTypeId",
                keyValue: new Guid("324bd1c0-28a7-478c-8e10-b89ee0ad54eb"));

            migrationBuilder.DeleteData(
                table: "PropBetType",
                keyColumn: "PropBetTypeId",
                keyValue: new Guid("70dc1a52-243a-4097-8263-7b45da56d77f"));
        }
    }
}
