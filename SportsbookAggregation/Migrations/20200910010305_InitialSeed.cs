using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GamblingSite",
                columns: new[] { "GamblingSiteId", "Name" },
                values: new object[,]
                {
                    { new Guid("dab029a6-34b5-4a37-ac8a-0158052df773"), "Fanduel" },
                    { new Guid("e3b718cd-7090-4f01-a1af-6f22fd61fd22"), "FoxBet" },
                    { new Guid("209ad3ca-bf6f-4520-b573-51a63e62fb28"), "DraftKings" },
                    { new Guid("5fab4388-e39a-43dc-9036-6f19da79827f"), "BetRivers" }
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "SportId", "Name" },
                values: new object[,]
                {
                    { new Guid("0584d380-a494-45ab-9c28-6fd0e921da12"), "NBA" },
                    { new Guid("eae3790f-5a86-4b26-aa98-d4001cdb602e"), "NFL" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot", "SportId" },
                values: new object[,]
                {
                    { new Guid("ad270e2d-233a-4018-b6a2-a9fc01a9c6a1"), "Atlanta", "Hawks", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("1d2d9b56-c858-4738-b22d-4f6d882f185b"), "Toronto", "Raptors", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("583c443c-bb95-44c7-a222-22e419897600"), "San Antonio", "Spurs", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("6617f87f-3d2d-4c55-96e2-ea0a28bbbaa8"), "Sacramento", "Kings", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("8ba5f13e-b46a-49ce-8aec-809b5d59bad7"), "Portland", "Trail Blazers", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("d486c72d-f408-4be4-85cf-1cb814214dd5"), "Phoenix", "Suns", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("67398008-c9d6-4d40-8891-c53de788c6c2"), "Philadelphia", "76ers", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("98b78113-c91c-44f8-ae18-f5c728427901"), "Orlando", "Magic", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("109c83be-ac66-44fd-ac5b-81f4319f8e06"), "Oklahoma City", "Thunder", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("4931cbf4-665d-42f1-8eea-314f01b0b0c8"), "New York", "Knicks", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("a9490907-31d7-47be-89ee-203144086c4f"), "New Orleans", "Pelicans", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("2cc24391-0aa7-4527-8af7-dc0b0e34d95e"), "Minnesota", "Timberwolves", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("abc1ac4d-7b67-4a3d-b27c-6c79640c67a5"), "Milwaukee", "Bucks", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("1a758a70-2365-4df3-ac70-9247bef4cfb7"), "Miami", "Heat", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("1b6edbe9-bdfc-4664-80f1-b69ee77fb4d1"), "Memphis", "Grizzlies", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("5eeecbe7-8943-4715-9bdd-70b26c1a00ee"), "Los Angeles", "Lakers", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("336c5256-9cf7-45d9-aeed-86eb947417e5"), "Los Angeles", "Clippers", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("89a6695c-4289-43da-9ab3-5ce14481f0bb"), "Indiana", "Pacers", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("9f97db29-1a71-41f8-bd9e-563f56644bb6"), "Houston", "Rockets", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("eac6d008-2adb-40e4-938c-4efc0011430e"), "Golden State", "Warriors", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("90de592a-2ac5-4c7d-8477-56d3e665b0f4"), "Detroit", "Pistons", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("682d44e4-ee55-4aa9-8359-8f0f3f3f4e4f"), "Denver", "Nuggets", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("79302ddf-c9a6-4254-9978-2ddd7bb5eb55"), "Dallas", "Mavericks", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("a44aa3b4-8943-4eed-8380-59654e428bb0"), "Cleveland", "Cavaliers", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("0185bde9-91b4-4935-a2ed-3911a77bb619"), "Chicago", "Bulls", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("5abdb10d-7059-4111-806d-1d4d272c96d4"), "Charlotte", "Hornets", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("d782b0a1-9c26-4b84-8408-1482611b7dfc"), "Brooklyn", "Nets", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("5ee7eefc-4838-453c-b904-d49daf994c89"), "Boston", "Celtics", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("fe06e876-dc97-4306-899e-925b6ab936ec"), "Utah", "Jazz", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") },
                    { new Guid("76e268e4-64c6-4fef-84d3-ef1a33f12641"), "Washington", "Wizards", new Guid("0584d380-a494-45ab-9c28-6fd0e921da12") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GamblingSite",
                keyColumn: "GamblingSiteId",
                keyValue: new Guid("209ad3ca-bf6f-4520-b573-51a63e62fb28"));

            migrationBuilder.DeleteData(
                table: "GamblingSite",
                keyColumn: "GamblingSiteId",
                keyValue: new Guid("5fab4388-e39a-43dc-9036-6f19da79827f"));

            migrationBuilder.DeleteData(
                table: "GamblingSite",
                keyColumn: "GamblingSiteId",
                keyValue: new Guid("dab029a6-34b5-4a37-ac8a-0158052df773"));

            migrationBuilder.DeleteData(
                table: "GamblingSite",
                keyColumn: "GamblingSiteId",
                keyValue: new Guid("e3b718cd-7090-4f01-a1af-6f22fd61fd22"));

            migrationBuilder.DeleteData(
                table: "Sport",
                keyColumn: "SportId",
                keyValue: new Guid("eae3790f-5a86-4b26-aa98-d4001cdb602e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0185bde9-91b4-4935-a2ed-3911a77bb619"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("109c83be-ac66-44fd-ac5b-81f4319f8e06"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1a758a70-2365-4df3-ac70-9247bef4cfb7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1b6edbe9-bdfc-4664-80f1-b69ee77fb4d1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1d2d9b56-c858-4738-b22d-4f6d882f185b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2cc24391-0aa7-4527-8af7-dc0b0e34d95e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("336c5256-9cf7-45d9-aeed-86eb947417e5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4931cbf4-665d-42f1-8eea-314f01b0b0c8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("583c443c-bb95-44c7-a222-22e419897600"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5abdb10d-7059-4111-806d-1d4d272c96d4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5ee7eefc-4838-453c-b904-d49daf994c89"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5eeecbe7-8943-4715-9bdd-70b26c1a00ee"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6617f87f-3d2d-4c55-96e2-ea0a28bbbaa8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("67398008-c9d6-4d40-8891-c53de788c6c2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("682d44e4-ee55-4aa9-8359-8f0f3f3f4e4f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("76e268e4-64c6-4fef-84d3-ef1a33f12641"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("79302ddf-c9a6-4254-9978-2ddd7bb5eb55"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("89a6695c-4289-43da-9ab3-5ce14481f0bb"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8ba5f13e-b46a-49ce-8aec-809b5d59bad7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("90de592a-2ac5-4c7d-8477-56d3e665b0f4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("98b78113-c91c-44f8-ae18-f5c728427901"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9f97db29-1a71-41f8-bd9e-563f56644bb6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a44aa3b4-8943-4eed-8380-59654e428bb0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a9490907-31d7-47be-89ee-203144086c4f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("abc1ac4d-7b67-4a3d-b27c-6c79640c67a5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ad270e2d-233a-4018-b6a2-a9fc01a9c6a1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d486c72d-f408-4be4-85cf-1cb814214dd5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d782b0a1-9c26-4b84-8408-1482611b7dfc"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("eac6d008-2adb-40e4-938c-4efc0011430e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fe06e876-dc97-4306-899e-925b6ab936ec"));

            migrationBuilder.DeleteData(
                table: "Sport",
                keyColumn: "SportId",
                keyValue: new Guid("0584d380-a494-45ab-9c28-6fd0e921da12"));
        }
    }
}
