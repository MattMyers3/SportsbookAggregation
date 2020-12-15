using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddNCAABTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot" },
                values: new object[,]
                {
                    { new Guid("e4a1cb5d-7fcd-45a2-941f-c33902097430"), "American", "Eagles" },
                    { new Guid("f325ad98-7e99-4a6f-b400-744dad202fc7"), "Saint Peter's", "Peacocks and Peahens" },
                    { new Guid("5007db45-e59a-4a60-be48-cda1250401b9"), "Saint Mary's", "Gaels" },
                    { new Guid("3cdc23db-c4ba-49a2-ace9-1b26a56402dc"), "Saint Louis", "Billikens" },
                    { new Guid("45ea7148-6415-47ff-a3bc-0fd43dc0bca1"), "Saint Joseph's", "Hawks" },
                    { new Guid("9c414187-218e-43aa-adf5-5ae41d4afe20"), "St. John's", "Red Storm" },
                    { new Guid("e39a41c8-8ac9-4738-ad79-0d2f50b414b0"), "St. Francis Brooklyn", "Terriers" },
                    { new Guid("a1150ec9-c896-4b85-b58a-4b92b1898be7"), "St. Bonaventure", "Bonnies" },
                    { new Guid("a9476b7d-91b2-4c1d-9b96-ec37e35e0eff"), "Rider", "Broncs" },
                    { new Guid("87f3c4ad-4da1-44dc-a13c-a95781f40216"), "Radford", "Highlanders" },
                    { new Guid("cb22f2fe-603f-4abc-978a-032cc98bedd9"), "Quinnipiac", "Bobcats" },
                    { new Guid("6b543276-c2f3-4211-a48b-47f6caa16a31"), "Purdue Fort Wayne", "Mastodons" },
                    { new Guid("a8df5701-814d-4bd9-bdb3-72f771587d7a"), "Providence", "Friars" },
                    { new Guid("aae2c260-e1f2-4636-90e7-c9c8d5cadd2a"), "Portland", "Pilots" },
                    { new Guid("cc46eb51-97d2-4c35-bd1f-2fcd624b7153"), "Pepperdine", "Waves" },
                    { new Guid("2d47f3b0-e0f9-4b3d-a63d-de6bbfd41c3d"), "Pacific", "Tigers" },
                    { new Guid("6dc6c635-41e8-4bb0-b615-e632ce1e659b"), "Oral Roberts", "Golden Eagles" },
                    { new Guid("fa90a5a4-0a32-4520-984c-1affa831c25d"), "Omaha", "Mavericks" },
                    { new Guid("0f845d27-fcc4-4c73-b373-85f4d1053df0"), "Oakland", "Golden Grizzlies" },
                    { new Guid("7a8ae778-0e63-4f45-a5ee-b43ed00687fd"), "Northern Kentucky", "Norse" },
                    { new Guid("da44963f-5ca5-4eee-8464-ee5d473093f1"), "Northeastern", "Huskies" },
                    { new Guid("0367f043-4896-4a9f-a64d-be0635bea573"), "North Florida", "Ospreys" },
                    { new Guid("c01bff87-80ba-4253-9b5a-eaf0842404e7"), "San Francisco", "Dons" },
                    { new Guid("64111619-830c-40ef-84cf-f7e9f181e86d"), "NJIT", "Highlanders" },
                    { new Guid("1b00ee55-f721-4703-8a1e-9335344233e4"), "Santa Clara", "Broncos" },
                    { new Guid("43cbb0ed-c801-4d88-9d2e-fbfcf76129cc"), "Seton Hall", "Pirates" },
                    { new Guid("5cdebd77-0350-4652-883c-7332398f4fbe"), "Winthrop", "Eagles" },
                    { new Guid("7d57e23e-e128-4c23-92a0-e05020375b6a"), "Wichita State", "Shockers" },
                    { new Guid("851790c6-b526-4e38-9585-626eaaea3ee5"), "VCU", "Rams" },
                    { new Guid("79863c8b-50b5-4b06-8ae6-c4b266c6a1c7"), "Vermont", "Catamounts" },
                    { new Guid("c8077fb3-a4ef-4cfb-a7a1-382cc9eb9b88"), "UTRGV", "Vaqueros" },
                    { new Guid("7ab490a6-0232-40a0-9e1c-7b267fbcf692"), "Utah Valley", "Wolverines" },
                    { new Guid("37451565-9a41-4052-bd78-8effe6ccf4c6"), "UNC Wilmington", "Seahawks" },
                    { new Guid("d448f2e6-34ec-4c34-8fa3-d5c47be11444"), "UNC Greensboro", "Spartans" },
                    { new Guid("5cc89795-f2b6-44ae-ad35-de17e3bf7f94"), "UNC Asheville", "Bulldogs" },
                    { new Guid("95b84940-2f78-4c12-b525-7c3bf2e49b20"), "UMBC", "Retrievers" },
                    { new Guid("d393e1e1-fe39-4107-a048-5e1dd3f67ca5"), "UMass Lowell", "River Hawks" },
                    { new Guid("636f32bb-316a-4939-bd63-25462708c2ed"), "UIC", "Flames" },
                    { new Guid("1bca29cc-e85a-4807-9d02-1d10240c599f"), "UC Santa Barbara", "Gauchos" },
                    { new Guid("78214529-ebca-4d36-9d6a-60669d1a9b8f"), "UC San Diego", "Tritons" },
                    { new Guid("46a4bb0b-0a6f-45cf-869e-8bf8add19201"), "UC Irvine", "Anteaters" },
                    { new Guid("74a288a6-2532-4efd-9c76-5430f727d948"), "UC Riverside", "Highlanders" },
                    { new Guid("1a123cd7-fe09-4091-8a3e-217d18595575"), "Texas–Arlington", "Mavericks" },
                    { new Guid("e235a28e-f1c7-48e4-9831-6ab58199bb25"), "Texas A&M–Corpus Christi", "Islanders" },
                    { new Guid("541a0e5c-73ae-4d8a-9905-0bf111bbd312"), "South Carolina Upstate", "Spartans" },
                    { new Guid("c7eb8178-db47-4d5f-8622-a4b6ba3b1219"), "SIU Edwardsville", "Cougars" },
                    { new Guid("fecff937-e3d1-49f7-9760-d27b83d7c803"), "Siena", "Saints" },
                    { new Guid("878a0978-4828-4262-bbf4-87c4dcf3001a"), "Seattle", "Redhawks" },
                    { new Guid("20a89232-732f-4561-9f2b-6fdcec4aa0f2"), "Wright State", "Raiders" },
                    { new Guid("55cc6d3b-6ee2-4b5c-b832-b69eae07bc04"), "Niagara", "Purple Eagles" },
                    { new Guid("5a46e9b6-36db-4f06-8f77-1e61d2e23042"), "Mount Saint Mary's", "Mountaineers" },
                    { new Guid("1245e5b2-524b-4472-933f-c22406321305"), "Fairleigh Dickinson", "Knights" },
                    { new Guid("46d83116-f12a-414e-9536-f85dbcef9f94"), "Fairfield", "Stags" },
                    { new Guid("953d75a0-79a6-4f24-8082-920dd8ce99e7"), "Evansville", "Purple Aces" },
                    { new Guid("56e94264-968b-45ed-b969-699b8b10897e"), "Drexel", "Dragons" },
                    { new Guid("d2488bcf-0db9-45d9-8873-4438d1009b1b"), "Detroit Mercy", "Titans" },
                    { new Guid("f572375d-052d-468a-bdd8-829145bee0cf"), "DePaul", "Blue Demons" },
                    { new Guid("9a6a1ae5-1de0-4aee-bbb3-9e63222f9103"), "Denver", "Pioneers" },
                    { new Guid("24a89f5d-6249-4ff6-b168-639e2ccb318f"), "Creighton", "Bluejays" },
                    { new Guid("6cf59f82-d34e-494a-84a8-b8c383eedd1c"), "Cleveland State", "Vikings" },
                    { new Guid("89585d54-3717-47b5-9788-927fc7274b48"), "Chicago State", "Cougars" },
                    { new Guid("e8f102a3-745e-438a-bb93-03fe9c61695e"), "Charleston", "Cougars" },
                    { new Guid("71db5975-01ac-4490-82c9-0d9203ad72e0"), "Canisius", "Golden Griffins" },
                    { new Guid("1e7f1764-6292-4047-b7f1-540ca0310daa"), "California Baptist", "Lancers" },
                    { new Guid("04781b4e-5d8c-4451-b719-848152852dc0"), "Cal State Northridge", "Matadors" },
                    { new Guid("6ca5bba8-7e39-43da-8389-b3f6958e9529"), "Cal State Fullerton", "Titans" },
                    { new Guid("63f87e9f-f30b-42c2-b384-896e39f51560"), "Cal State Bakersfield", "Roadrunners" },
                    { new Guid("0969783b-afb7-45f5-977a-106219c69256"), "Bradley", "Braves" },
                    { new Guid("8642905a-fc93-4111-94cd-d27ed207eb3d"), "Boston University", "Terriers" },
                    { new Guid("4e731fb6-95ce-44ea-a74a-5430ff75033e"), "Binghamton", "Bearcats" },
                    { new Guid("ccfb1588-2bcd-4122-a144-16718fb34457"), "Belmont", "Bruins" },
                    { new Guid("1bfb4e58-5a58-416b-9035-e2a1e42cb8d2"), "Bellarmine", "Knights" },
                    { new Guid("3228a14c-9dd1-4710-ba45-6db18c0c5274"), "Florida Gulf Coast", "Eagles" },
                    { new Guid("790ce365-441e-4a22-82ae-45a2010871f7"), "New Orleans", "Privateers" },
                    { new Guid("ff1ed53a-2d73-4fff-9f9b-9d5cccf0e116"), "George Mason", "Patriots" },
                    { new Guid("3f726429-be41-4636-836a-ca144e19c76d"), "Gonzaga", "Bulldogs/Zags" },
                    { new Guid("0e9b7039-555d-4a32-a470-e7dd6547cdde"), "Milwaukee", "Panthers" },
                    { new Guid("7bedceed-01c9-47ca-81a4-08bbb9c2d18a"), "Maryland Eastern Shore", "Hawks" },
                    { new Guid("f7f140f1-680c-4129-b474-6d052d54514a"), "Marquette", "Golden Eagles" },
                    { new Guid("943b75d4-ac3d-402f-8bfa-495961b27e23"), "Manhattan", "Jaspers" },
                    { new Guid("ab9708ff-8fbd-495c-b7eb-ddf8d394e3d9"), "Loyola Marymount", "Lions" },
                    { new Guid("4d25165c-b394-4bf2-8fce-6b0277e3dd5e"), "Loyola (Maryland)", "Greyhounds" },
                    { new Guid("43f58925-3aaa-435f-a078-556ba535d9bc"), "Loyola (Chicago)", "Ramblers" },
                    { new Guid("b62cb916-c7b7-4ee5-83e7-6c07f9ac9b7d"), "Longwood", "Lancers" },
                    { new Guid("82cb9d7f-fe66-4c67-b28c-0ed14fc4efb3"), "Long Beach State", "The Beach" },
                    { new Guid("de3ad849-437e-4e91-b48f-72feed63fe2b"), "Little Rock", "Trojans" },
                    { new Guid("c59fda41-55e0-420b-a4ca-6a791d492193"), "Lipscomb", "Bisons" },
                    { new Guid("8f446a40-0bd0-4ce0-8508-f5bda31e151a"), "La Salle", "Explorers" },
                    { new Guid("926cdfc3-245c-4b69-87de-40154e915259"), "Kansas City", "Roos" },
                    { new Guid("a8db0056-7e65-40ba-b423-b9fdafebcba3"), "Jacksonville", "Dolphins" },
                    { new Guid("56b2833c-3103-45e8-8e19-be0d316132f8"), "Iona", "Gaels" },
                    { new Guid("b4159df5-c910-4a6c-a514-ec9a11d819a6"), "IUPUI", "Jaguars" },
                    { new Guid("cbea6fa8-9102-4865-a894-8e15543602e2"), "Hofstra", "Pride" },
                    { new Guid("c3c12ebd-1f96-48c6-8bfb-aacb99481f26"), "High Point", "Panthers" },
                    { new Guid("556a2735-23e3-407b-b871-6a52f842645a"), "Hartford", "Hawks" },
                    { new Guid("5b6d83a9-2496-40d7-a1a8-6e4a8baa4974"), "Green Bay", "Phoenix" },
                    { new Guid("b9932b36-5304-4e18-a56a-1015d4a2bb6b"), "Grand Canyon", "Antelopes" },
                    { new Guid("f0372d43-abf6-4d6e-b67e-d6b1a6dd2d41"), "George Washington", "Colonials" },
                    { new Guid("3ce1fb16-497e-466b-8c3a-a549cf4f0f03"), "Xavier", "Musketeers" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0367f043-4896-4a9f-a64d-be0635bea573"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("04781b4e-5d8c-4451-b719-848152852dc0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0969783b-afb7-45f5-977a-106219c69256"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0e9b7039-555d-4a32-a470-e7dd6547cdde"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0f845d27-fcc4-4c73-b373-85f4d1053df0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1245e5b2-524b-4472-933f-c22406321305"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1a123cd7-fe09-4091-8a3e-217d18595575"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1b00ee55-f721-4703-8a1e-9335344233e4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1bca29cc-e85a-4807-9d02-1d10240c599f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1bfb4e58-5a58-416b-9035-e2a1e42cb8d2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1e7f1764-6292-4047-b7f1-540ca0310daa"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("20a89232-732f-4561-9f2b-6fdcec4aa0f2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("24a89f5d-6249-4ff6-b168-639e2ccb318f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2d47f3b0-e0f9-4b3d-a63d-de6bbfd41c3d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3228a14c-9dd1-4710-ba45-6db18c0c5274"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("37451565-9a41-4052-bd78-8effe6ccf4c6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3cdc23db-c4ba-49a2-ace9-1b26a56402dc"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3ce1fb16-497e-466b-8c3a-a549cf4f0f03"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3f726429-be41-4636-836a-ca144e19c76d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("43cbb0ed-c801-4d88-9d2e-fbfcf76129cc"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("43f58925-3aaa-435f-a078-556ba535d9bc"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("45ea7148-6415-47ff-a3bc-0fd43dc0bca1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("46a4bb0b-0a6f-45cf-869e-8bf8add19201"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("46d83116-f12a-414e-9536-f85dbcef9f94"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4d25165c-b394-4bf2-8fce-6b0277e3dd5e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4e731fb6-95ce-44ea-a74a-5430ff75033e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5007db45-e59a-4a60-be48-cda1250401b9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("541a0e5c-73ae-4d8a-9905-0bf111bbd312"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("556a2735-23e3-407b-b871-6a52f842645a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("55cc6d3b-6ee2-4b5c-b832-b69eae07bc04"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("56b2833c-3103-45e8-8e19-be0d316132f8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("56e94264-968b-45ed-b969-699b8b10897e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5a46e9b6-36db-4f06-8f77-1e61d2e23042"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5b6d83a9-2496-40d7-a1a8-6e4a8baa4974"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5cc89795-f2b6-44ae-ad35-de17e3bf7f94"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5cdebd77-0350-4652-883c-7332398f4fbe"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("636f32bb-316a-4939-bd63-25462708c2ed"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("63f87e9f-f30b-42c2-b384-896e39f51560"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("64111619-830c-40ef-84cf-f7e9f181e86d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6b543276-c2f3-4211-a48b-47f6caa16a31"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6ca5bba8-7e39-43da-8389-b3f6958e9529"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6cf59f82-d34e-494a-84a8-b8c383eedd1c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6dc6c635-41e8-4bb0-b615-e632ce1e659b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("71db5975-01ac-4490-82c9-0d9203ad72e0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("74a288a6-2532-4efd-9c76-5430f727d948"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("78214529-ebca-4d36-9d6a-60669d1a9b8f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("790ce365-441e-4a22-82ae-45a2010871f7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("79863c8b-50b5-4b06-8ae6-c4b266c6a1c7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7a8ae778-0e63-4f45-a5ee-b43ed00687fd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7ab490a6-0232-40a0-9e1c-7b267fbcf692"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7bedceed-01c9-47ca-81a4-08bbb9c2d18a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7d57e23e-e128-4c23-92a0-e05020375b6a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("82cb9d7f-fe66-4c67-b28c-0ed14fc4efb3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("851790c6-b526-4e38-9585-626eaaea3ee5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8642905a-fc93-4111-94cd-d27ed207eb3d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("878a0978-4828-4262-bbf4-87c4dcf3001a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("87f3c4ad-4da1-44dc-a13c-a95781f40216"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("89585d54-3717-47b5-9788-927fc7274b48"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8f446a40-0bd0-4ce0-8508-f5bda31e151a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("926cdfc3-245c-4b69-87de-40154e915259"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("943b75d4-ac3d-402f-8bfa-495961b27e23"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("953d75a0-79a6-4f24-8082-920dd8ce99e7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("95b84940-2f78-4c12-b525-7c3bf2e49b20"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9a6a1ae5-1de0-4aee-bbb3-9e63222f9103"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9c414187-218e-43aa-adf5-5ae41d4afe20"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a1150ec9-c896-4b85-b58a-4b92b1898be7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a8db0056-7e65-40ba-b423-b9fdafebcba3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a8df5701-814d-4bd9-bdb3-72f771587d7a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a9476b7d-91b2-4c1d-9b96-ec37e35e0eff"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("aae2c260-e1f2-4636-90e7-c9c8d5cadd2a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ab9708ff-8fbd-495c-b7eb-ddf8d394e3d9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b4159df5-c910-4a6c-a514-ec9a11d819a6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b62cb916-c7b7-4ee5-83e7-6c07f9ac9b7d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b9932b36-5304-4e18-a56a-1015d4a2bb6b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c01bff87-80ba-4253-9b5a-eaf0842404e7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c3c12ebd-1f96-48c6-8bfb-aacb99481f26"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c59fda41-55e0-420b-a4ca-6a791d492193"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c7eb8178-db47-4d5f-8622-a4b6ba3b1219"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c8077fb3-a4ef-4cfb-a7a1-382cc9eb9b88"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cb22f2fe-603f-4abc-978a-032cc98bedd9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cbea6fa8-9102-4865-a894-8e15543602e2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cc46eb51-97d2-4c35-bd1f-2fcd624b7153"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ccfb1588-2bcd-4122-a144-16718fb34457"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d2488bcf-0db9-45d9-8873-4438d1009b1b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d393e1e1-fe39-4107-a048-5e1dd3f67ca5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d448f2e6-34ec-4c34-8fa3-d5c47be11444"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("da44963f-5ca5-4eee-8464-ee5d473093f1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("de3ad849-437e-4e91-b48f-72feed63fe2b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e235a28e-f1c7-48e4-9831-6ab58199bb25"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e39a41c8-8ac9-4738-ad79-0d2f50b414b0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e4a1cb5d-7fcd-45a2-941f-c33902097430"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e8f102a3-745e-438a-bb93-03fe9c61695e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f0372d43-abf6-4d6e-b67e-d6b1a6dd2d41"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f325ad98-7e99-4a6f-b400-744dad202fc7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f572375d-052d-468a-bdd8-829145bee0cf"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f7f140f1-680c-4129-b474-6d052d54514a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fa90a5a4-0a32-4520-984c-1affa831c25d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fecff937-e3d1-49f7-9760-d27b83d7c803"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ff1ed53a-2d73-4fff-9f9b-9d5cccf0e116"));
        }
    }
}
