using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddMLBTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot", "SportId" },
                values: new object[,]
                {
                    { new Guid("b80ba92d-3fea-4da0-a47f-f65cd46eb067"), "Arizona", "Diamondbacks", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("2f2cdf19-0cd7-4a35-881f-8cfbd8d4fea8"), "Texas", "Rangers", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("53fa4e27-c75f-479a-aeba-94f8014446d1"), "Tampa Bay", "Rays", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("10ed79cb-f213-403c-84da-c915ae5e4d4c"), "St. Louis", "Cardinals", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("58e52fc4-c688-4ad2-9944-ee3e5f92337c"), "Seattle", "Mariners", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("60ecf028-f2b7-49bc-8649-776df8b8f225"), "San Francisco", "Giants", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("f460874c-5ba5-4411-b602-239da45af489"), "San Diego", "Padres", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("30f456f3-caf8-4582-829f-fdfc4ef6c520"), "Pittsburgh", "Pirates", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("a0ac8958-26bf-4d95-ae39-bba328daa3f1"), "Philadelphia", "Phillies", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("a8e4de87-8da4-4bb0-8232-642a059451fe"), "Oakland", "Athletics", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("09faad84-aa61-4376-93cc-6d98a3e2a941"), "New York", "Yankees", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("bde59215-f8be-415a-99e8-31ea7b96d2cf"), "New York", "Mets", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("f3d27ac5-73cc-480d-bd44-11af1c8ddce9"), "Minnesota", "Twins", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("9aa7dd61-e5d7-4a80-8cef-e3b6e1a93920"), "Milwaukee", "Brewers", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("b3d8a035-746e-42c0-9264-a97ec10d5e78"), "Miami", "Marlins", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("3105b032-1df3-48c7-be70-21a7ec36d4fd"), "Los Angeles", "Dodgers", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("2f47feaf-29fd-49b3-af5e-a5cd3ad1c68d"), "Los Angeles", "Angels", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("53ab3b55-5d3f-4991-bbf6-fa5874eeacf5"), "Kansas City", "Royals", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("093d9c05-cf42-4260-be44-ab6fb8399c38"), "Houston", "Astros", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("61da07c9-a29c-4d0d-8375-7352458bd858"), "Detroit", "Tigers", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("da5a4c84-f866-49d3-960c-ead18a08346c"), "Colorado", "Rockies", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("6de834fc-509e-4989-b1d2-49c8b10c1ece"), "Cleveland", "Indians", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("bfb3beb9-76aa-4000-b8d5-e7c616d45c8b"), "Cincinnati", "Reds", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("66dfad29-3097-47a0-964b-136fce7fa365"), "Chicago", "White Sox", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("1f0c79e0-65ff-4d92-8b95-7e09f875beac"), "Chicago", "Cubs", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("7d297cb2-173e-4e4d-9eeb-86aecf711f7b"), "Boston", "Red Sox", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("764f8f26-b02b-43b5-946a-4429ff9d2ae9"), "Baltimore", "Orioles", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("c6bc8fc8-6391-4af8-9032-364c86ca59d5"), "Atlanta", "Braves", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("c03dd191-1cbd-4fe8-84b1-3dac7c839fff"), "Toronto", "Blue Jays", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") },
                    { new Guid("d4b12dee-abf7-41a0-b78a-d40072d5e2f8"), "Washington", "Nationals", new Guid("a90b8447-171a-4633-b191-fa4ca83270a8") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("093d9c05-cf42-4260-be44-ab6fb8399c38"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("09faad84-aa61-4376-93cc-6d98a3e2a941"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("10ed79cb-f213-403c-84da-c915ae5e4d4c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1f0c79e0-65ff-4d92-8b95-7e09f875beac"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2f2cdf19-0cd7-4a35-881f-8cfbd8d4fea8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2f47feaf-29fd-49b3-af5e-a5cd3ad1c68d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("30f456f3-caf8-4582-829f-fdfc4ef6c520"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3105b032-1df3-48c7-be70-21a7ec36d4fd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("53ab3b55-5d3f-4991-bbf6-fa5874eeacf5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("53fa4e27-c75f-479a-aeba-94f8014446d1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("58e52fc4-c688-4ad2-9944-ee3e5f92337c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("60ecf028-f2b7-49bc-8649-776df8b8f225"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("61da07c9-a29c-4d0d-8375-7352458bd858"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("66dfad29-3097-47a0-964b-136fce7fa365"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6de834fc-509e-4989-b1d2-49c8b10c1ece"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("764f8f26-b02b-43b5-946a-4429ff9d2ae9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7d297cb2-173e-4e4d-9eeb-86aecf711f7b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9aa7dd61-e5d7-4a80-8cef-e3b6e1a93920"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a0ac8958-26bf-4d95-ae39-bba328daa3f1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a8e4de87-8da4-4bb0-8232-642a059451fe"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b3d8a035-746e-42c0-9264-a97ec10d5e78"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b80ba92d-3fea-4da0-a47f-f65cd46eb067"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("bde59215-f8be-415a-99e8-31ea7b96d2cf"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("bfb3beb9-76aa-4000-b8d5-e7c616d45c8b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c03dd191-1cbd-4fe8-84b1-3dac7c839fff"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c6bc8fc8-6391-4af8-9032-364c86ca59d5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d4b12dee-abf7-41a0-b78a-d40072d5e2f8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("da5a4c84-f866-49d3-960c-ead18a08346c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f3d27ac5-73cc-480d-bd44-11af1c8ddce9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f460874c-5ba5-4411-b602-239da45af489"));
        }
    }
}
