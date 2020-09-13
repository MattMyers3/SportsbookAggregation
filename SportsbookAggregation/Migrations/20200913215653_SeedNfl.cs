using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class SeedNfl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot", "SportId" },
                values: new object[,]
                {
                    { new Guid("03f86ef9-e837-4d16-a869-1561dde61798"), "Arizona", "Cardinals", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("360fd180-6f0e-4545-8d14-5f690944cfdc"), "Tampa Bay", "Buccaneers", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("8a7cdedd-a273-4320-b479-2eeae69694d2"), "San Francisco", "49ers", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("dd82688b-9c9d-42ac-975c-d4db4a211d29"), "Seattle", "Seahawks", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("a3629bd0-3c5b-4de6-a3e4-514333fc3fa5"), "Pittsburgh", "Steelers", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("fb02cf5b-4ad9-4131-86ab-9a7f49aaad55"), "Philadelphia", "Eagles", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("d3cadd00-d44a-4840-9632-5f24d72ef9d3"), "New York", "Jets", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("fd59c829-5712-450a-ac75-595757010acc"), "New York", "Giants", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("71245471-b0ff-4381-bf35-343f698ff077"), "New Orleans", "Saints", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("0da464e1-f39c-4049-b312-f2968aa71ae4"), "New England", "Patriots", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("69d2e5de-9793-4faa-a2a8-9bcc54e656d3"), "Minnesota", "Vikings", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("1c349295-7317-4ad8-ab5a-13275e3e03c6"), "Miami", "Dolphins", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("ec9d7c36-7379-4d1d-8a22-156d4ee83b2a"), "Las Vegas", "Raiders", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("1cf88a9e-82cf-4506-8d3b-ac0b8e8915fd"), "Los Angeles", "Rams", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("952efc18-905f-4ab9-8ac3-4f79b0e068e6"), "Los Angeles", "Chargers", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("d728eb6a-8a28-4c21-a50e-a226b2d5b70f"), "Kansas City", "Chiefs", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("6746d02f-0910-402b-86fc-e5a9a52d2e21"), "Jacksonville", "Jaguars", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("41f2f8a9-4671-41f1-86e5-c388423b5b04"), "Indianapolis", "Colts", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("2f8cd4fe-dc9c-4ed1-84d7-1d0923e73ac3"), "Houston", "Texans", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("7193bfbf-1aa8-480e-88e9-339312ea9da8"), "Green Bay", "Packers", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("23390e8c-e70c-48aa-9fab-6a3770d91de4"), "Detroit", "Lions", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("0b093a77-6b07-4207-b27c-848938ce522a"), "Denver", "Broncos", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("e5e561ba-70c8-4b72-bd63-d14f9e2db12c"), "Dallas", "Cowboys", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("450aa644-fcca-4e1e-9ed2-2eb8e87c6571"), "Cleveland", "Browns", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("3bfcc8bb-b87d-4a1a-adf1-bf1ed1c554f5"), "Cincinnati", "Bengals", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("0df55a06-1ce5-41f5-baa8-dedfc9982b14"), "Chicago", "Bears", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("48259823-78c5-4c42-ace2-7d59fd6d5b67"), "Carolina", "Panthers", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("b62aa542-7d3b-4a85-a4e8-8b6a2d8ebefa"), "Buffalo", "Bills", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("3b88d60b-96a7-411b-a061-d4a581d7a5a6"), "Baltimore", "Ravens", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("586fe718-6743-409a-969d-d19bd36d4254"), "Atlanta", "Falcons", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("4c713570-bf81-4b2f-b170-3258ca86d07e"), "Tennessee", "Titans", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") },
                    { new Guid("2bf36e69-9abd-40e5-92e3-3817e6c13253"), "Washington", "Football Team", new Guid("6e972a45-6bd9-4085-9a78-faddf46294be") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("03f86ef9-e837-4d16-a869-1561dde61798"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0b093a77-6b07-4207-b27c-848938ce522a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0da464e1-f39c-4049-b312-f2968aa71ae4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0df55a06-1ce5-41f5-baa8-dedfc9982b14"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1c349295-7317-4ad8-ab5a-13275e3e03c6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1cf88a9e-82cf-4506-8d3b-ac0b8e8915fd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("23390e8c-e70c-48aa-9fab-6a3770d91de4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2bf36e69-9abd-40e5-92e3-3817e6c13253"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2f8cd4fe-dc9c-4ed1-84d7-1d0923e73ac3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("360fd180-6f0e-4545-8d14-5f690944cfdc"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3b88d60b-96a7-411b-a061-d4a581d7a5a6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3bfcc8bb-b87d-4a1a-adf1-bf1ed1c554f5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("41f2f8a9-4671-41f1-86e5-c388423b5b04"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("450aa644-fcca-4e1e-9ed2-2eb8e87c6571"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("48259823-78c5-4c42-ace2-7d59fd6d5b67"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4c713570-bf81-4b2f-b170-3258ca86d07e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("586fe718-6743-409a-969d-d19bd36d4254"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6746d02f-0910-402b-86fc-e5a9a52d2e21"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("69d2e5de-9793-4faa-a2a8-9bcc54e656d3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("71245471-b0ff-4381-bf35-343f698ff077"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7193bfbf-1aa8-480e-88e9-339312ea9da8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8a7cdedd-a273-4320-b479-2eeae69694d2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("952efc18-905f-4ab9-8ac3-4f79b0e068e6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a3629bd0-3c5b-4de6-a3e4-514333fc3fa5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b62aa542-7d3b-4a85-a4e8-8b6a2d8ebefa"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d3cadd00-d44a-4840-9632-5f24d72ef9d3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d728eb6a-8a28-4c21-a50e-a226b2d5b70f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("dd82688b-9c9d-42ac-975c-d4db4a211d29"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e5e561ba-70c8-4b72-bd63-d14f9e2db12c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ec9d7c36-7379-4d1d-8a22-156d4ee83b2a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fb02cf5b-4ad9-4131-86ab-9a7f49aaad55"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fd59c829-5712-450a-ac75-595757010acc"));
        }
    }
}
