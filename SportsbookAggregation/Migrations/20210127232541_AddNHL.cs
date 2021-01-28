using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddNHL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot" },
                values: new object[,]
                {
                    { new Guid("19d1cee4-36dc-4729-9c69-353e6bf5eab8"), "Calgary", "Flames" },
                    { new Guid("0acfac22-e715-4e31-845e-40a5d0ee86a6"), "St. Louis", "Blues" },
                    { new Guid("6d58fd86-a283-4d2d-9687-6a6c0f7d417e"), "Minnesota", "Wild" },
                    { new Guid("3cf61e0d-4465-4c3c-ab70-3d72682fa7c0"), "Los Angeles", "Kings" },
                    { new Guid("dafb53fd-f235-48d0-9c80-6dc198d81280"), "Colorado", "Avalanche" },
                    { new Guid("01e23993-86d3-4f6c-9b3f-fc54fb552e31"), "Arizona", "Coyotes" },
                    { new Guid("bf495ab6-1028-4b99-b35b-cd0c43c50b38"), "Anaheim", "Ducks" },
                    { new Guid("1e35d18d-2472-4c81-add1-d591de8b1ba2"), "Tampa Bay", "Lightning" },
                    { new Guid("c3bcfc79-ad0a-4a3c-b2ed-5e2d19906ec9"), "Nashville", "Predators" },
                    { new Guid("d2884665-94d8-43ef-b96a-9a1014c9e140"), "Florida", "Panthers" },
                    { new Guid("af394a5b-d0c3-4420-88bb-f74d2804f913"), "Detroit", "Red Wings" },
                    { new Guid("4569d99d-6342-4c4e-8ccd-6d4dbcb45b5a"), "Dallas", "Stars" },
                    { new Guid("21d326eb-acc4-492e-a89a-57111d2c8849"), "Columbus", "Blue Jackets" },
                    { new Guid("1795a2c9-525f-4a07-84bb-9cd528f095a8"), "Chicago", "Blackhawks" },
                    { new Guid("ab281eac-c420-4699-be77-cd2f46b44726"), "San Jose", "Sharks" },
                    { new Guid("bc157451-999e-437e-b179-4a3f43972ac5"), "Carolina", "Hurricanes" },
                    { new Guid("02279907-4a1e-4e48-9bec-affb2bb194df"), "Pittsburgh", "Penguins" },
                    { new Guid("545cbed7-d055-4085-842d-4b1ca35dfa10"), "Philadelphia", "Flyers" },
                    { new Guid("7776c949-48fc-4d56-bae2-a710b898bd25"), "New York", "Rangers" },
                    { new Guid("4c783eb1-0d51-46aa-886d-e4a8411fdf42"), "New York", "Islanders" },
                    { new Guid("0d21b9f3-8d5f-4468-b7df-3aac3435fa62"), "New Jersey", "Devils" },
                    { new Guid("6543a625-05af-4a7b-94b1-e77e4ee50aa0"), "Buffalo", "Sabres" },
                    { new Guid("8cfcab6d-51ce-4a5e-b82b-5e45cddfd183"), "Boston", "Bruins" },
                    { new Guid("7e292728-06bd-4911-9c27-59b41be33369"), "Winnipeg", "Jets" },
                    { new Guid("b427c5a6-2679-4cb0-a73f-bb460c2b78d6"), "Vancouver", "Canucks" },
                    { new Guid("057f4c1e-7bfa-4bd9-ad97-8cc135f796bf"), "Toronto", "Maple Leafs" },
                    { new Guid("113bfd18-9c4a-482c-b8b6-405742a2a0b1"), "Ottawa", "Senators" },
                    { new Guid("f33752d2-dfae-4905-a63a-7d5f53ce63aa"), "Montreal", "Canadiens" },
                    { new Guid("e7e4e96c-0f0f-4dd3-baaf-082a36942e47"), "Edmonton", "Oilers" },
                    { new Guid("91ef093c-c176-409b-afaf-944e2826db6f"), "Washington", "Capitals" },
                    { new Guid("99b45ffd-dc2f-4b48-8ac2-bcbacfd4794f"), "Vegas", "Golden Knights" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("01e23993-86d3-4f6c-9b3f-fc54fb552e31"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("02279907-4a1e-4e48-9bec-affb2bb194df"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("057f4c1e-7bfa-4bd9-ad97-8cc135f796bf"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0acfac22-e715-4e31-845e-40a5d0ee86a6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0d21b9f3-8d5f-4468-b7df-3aac3435fa62"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("113bfd18-9c4a-482c-b8b6-405742a2a0b1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1795a2c9-525f-4a07-84bb-9cd528f095a8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("19d1cee4-36dc-4729-9c69-353e6bf5eab8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1e35d18d-2472-4c81-add1-d591de8b1ba2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("21d326eb-acc4-492e-a89a-57111d2c8849"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3cf61e0d-4465-4c3c-ab70-3d72682fa7c0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4569d99d-6342-4c4e-8ccd-6d4dbcb45b5a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4c783eb1-0d51-46aa-886d-e4a8411fdf42"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("545cbed7-d055-4085-842d-4b1ca35dfa10"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6543a625-05af-4a7b-94b1-e77e4ee50aa0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6d58fd86-a283-4d2d-9687-6a6c0f7d417e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7776c949-48fc-4d56-bae2-a710b898bd25"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7e292728-06bd-4911-9c27-59b41be33369"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8cfcab6d-51ce-4a5e-b82b-5e45cddfd183"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("91ef093c-c176-409b-afaf-944e2826db6f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("99b45ffd-dc2f-4b48-8ac2-bcbacfd4794f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ab281eac-c420-4699-be77-cd2f46b44726"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("af394a5b-d0c3-4420-88bb-f74d2804f913"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b427c5a6-2679-4cb0-a73f-bb460c2b78d6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("bc157451-999e-437e-b179-4a3f43972ac5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("bf495ab6-1028-4b99-b35b-cd0c43c50b38"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c3bcfc79-ad0a-4a3c-b2ed-5e2d19906ec9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d2884665-94d8-43ef-b96a-9a1014c9e140"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("dafb53fd-f235-48d0-9c80-6dc198d81280"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e7e4e96c-0f0f-4dd3-baaf-082a36942e47"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f33752d2-dfae-4905-a63a-7d5f53ce63aa"));
        }
    }
}
