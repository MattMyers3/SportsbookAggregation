using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddNCAATeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Location", "Mascot", "SportId" },
                values: new object[,]
                {
                    { new Guid("3720981d-72a8-434f-9e7b-ef939f849b08"), "Air Force", "Falcons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8e5fb891-5530-4ef5-9999-c0a3b5e92dd8"), "West Texas A&M University", "Buffaloes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("762df54a-cdb0-4612-a87b-7ad0c01e9154"), "West Liberty University", "Hilltoppers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f58efc04-9784-411f-8423-b635ef71d025"), "University of West Georgia", "Wolves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("36debda6-3d83-47ac-b713-b70aeb26e813"), "University of West Florida", "Argonauts", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5a79ebc3-bf4f-4262-ad3e-81910a23649a"), "West Chester University", "Golden Rams", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("280c6901-4d9a-4893-b190-3302e10d931b"), "University of West Alabama", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("50aa026d-c774-4202-8468-0599b3a97397"), "Wayne State College", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("85218a1e-206a-41a0-98a6-35e7bfbd8d2b"), "Wayne State University", "Warriors", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4c9ced22-2b50-481f-8545-5b3f857e65e3"), "Washburn University", "Ichabods", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a26f8080-ca42-42a9-b18a-2d7d48f60e80"), "Walsh University", "Cavaliers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("69c75371-6742-443f-afb7-6be32f112709"), "West Virginia State University", "Yellow Jackets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b5ee2c50-3510-4dba-a65e-91a37ddc9774"), "University of Virginia's College at Wise", "Cavaliers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("24eae274-b58e-435f-9cbd-c87f8a6902dd"), "Virginia State University", "Trojans", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5643e9e1-7c37-4506-bcfc-b37ca6238020"), "Valdosta State University", "Blazers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1d2de3e2-df62-4396-8e6f-18c23ead20f4"), "Upper Iowa University", "Peacocks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2aefc0a2-d151-4adc-86e5-12d504a896d1"), "Tuskegee University", "Golden Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("46cd7664-51b8-455e-99ae-18b6282d0115"), "Tusculum University", "Pioneers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("34694e6e-7805-4446-beb2-a2ff1e11befe"), "Truman State University", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("381e3e61-e629-420d-8bc1-5dd1c05018e1"), "Tiffin University", "Dragons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2b2757a9-24e6-4f3a-93b8-79fd3f1ae161"), "University of Texas of the Permian Basin", "Falcons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8480bce3-3e63-403c-8047-62db48ceea92"), "Texas A&M University–Kingsville", "Javelinas", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("53c9c860-02bd-42b3-9bd1-7e034c7a5ec0"), "Texas A&M University–Commerce", "Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("36c72a92-2393-4e00-9002-b6e1c62505b0"), "Virginia Union University", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("698d4a6f-55a7-484d-a65a-990a3fde5c84"), "Stonehill College", "Skyhawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4c2f2c9f-16f9-4332-b9ff-e941599e6b1e"), "West Virginia Wesleyan College", "Bobcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f6d7280a-9cd2-46d8-9958-17c8ff434e86"), "Western New Mexico University", "Mustangs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("96bc2645-30dd-41ee-af18-42dbc1495eab"), "Central Connecticut", "Blue Devils", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("369b4ec9-f7a2-4938-b42d-93165351ac6b"), "Central Arkansas", "Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ec4fe60a-babb-4602-a676-e53e2e4274ae"), "Campbell", "Fighting Camels", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4e198cfe-f1af-429e-b4e9-d69d846acc9c"), "Cal Poly", "Mustangs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("fe304d40-73ca-42f2-b6a9-02f413c895ec"), "Butler", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f6d7f107-8d60-47b7-b46e-1f6400963c8a"), "Bucknell", "Bison", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("0464439a-6563-4c9a-9a3a-f8b499136902"), "Bryant", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("03325589-2edb-4877-81d5-d5c8f723cc5c"), "Brown", "Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8c714169-f069-45ed-b153-53d2e1424068"), "Bethune-Cookman", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("65024b55-a0af-4e2b-a0b8-04ef9c3cd0d0"), "Austin Peay", "Governors", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2de7360f-2dc1-43ee-a62f-431527e86e45"), "Western Colorado University", "Mountaineers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("032e2388-27cd-4c17-9947-3937b418007b"), "Arkansas-Pine Bluff", "Golden Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("099065c0-5982-49b9-a4e8-a5bbe28f6e7f"), "Albany", "Great Danes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1e5979ae-c317-4e8f-b1b4-5f0c7fc1c8db"), "Alabama State", "Hornets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8704c753-093e-49c5-9fdd-848a206ef423"), "Alabama A&M", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f8d90403-bbd8-440a-a2db-10fba819ab17"), "Abilene Christian", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("30776384-7802-421c-93d5-2d4991cb32d3"), "Winston–Salem State University", "Rams", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5d70f15d-a844-4442-965b-a15e71c96d15"), "Winona State University", "Warriors", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b41b883a-df82-452f-871b-69a2cbbac46b"), "Wingate University", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9273dbff-16c6-47a8-853f-32adad9e2c55"), "William Jewell College", "Cardinals", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("43378c29-ad7c-488b-9163-6a091573b83a"), "Wheeling University", "Cardinals", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a9358fc5-9386-4ec0-b2c2-2fc556f8c3d2"), "Western Oregon University", "Wolves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("29269198-c391-4d09-b836-4fa00081fa38"), "Alcorn State", "Braves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("49bf6cf1-6265-4b2c-b310-23110acde823"), "Charleston Southern", "Buccaneers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9a2f920c-31a9-4bb5-8f41-5ceb9e665af2"), "Southwestern Oklahoma State University", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8fb3ae7b-30f0-478c-8e2e-11cd4871ad28"), "Southwest Baptist University", "Bearcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("631f3101-8e0f-4a04-bfe1-1324680c24ac"), "Northwest Missouri State University", "Bearcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d0e63515-2955-4b69-b4e5-d127c9360f51"), "Northern State University", "Wolves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5a4c12fc-9bee-4b24-9f80-a3d408a1e0ee"), "Northern Michigan University", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d41296ba-8cf0-469f-9e06-a8249fc883fb"), "Northeastern State University", "RiverHawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("12d0d5ec-eb3a-4b8d-ae39-069caf9bfbbd"), "North Greenville University", "Crusaders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a096be3e-8006-47b8-897c-ef23615327b2"), "University of North Carolina at Pembroke", "Braves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("741ff517-5c31-4bb1-af9a-0c61c7a05041"), "Newberry College", "Wolves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3874deb8-794f-4156-9d47-504e989cbc0c"), "New Mexico Highlands University", "Cowboys", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("dc45127e-69ba-49e9-af1e-d07c6e9f8cb1"), "University of New Haven", "Chargers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a72cf65e-ed43-4b80-b3da-dfd4f1582458"), "University of Nebraska at Kearney", "Lopers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("62ab810e-28db-45de-99eb-cbb0cf749110"), "Northwestern Oklahoma State University", "Rangers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("36de9297-3292-4d53-a83c-7571cc564e01"), "Morehouse College", "Maroon Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("30fd3fd3-12af-4a33-a5f3-b2d35756a77c"), "Missouri Southern State University", "Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("dbc3e594-39e9-43f0-ac9f-c7854a82295f"), "Missouri University of Science and Technology", "Miners", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("64a3cc80-ca8f-4ca2-9472-21c314a9df94"), "Mississippi College", "Choctaws", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d9a96ad3-ba46-4b18-b484-fdd8357bfd67"), "Minot State University", "Beavers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3a9e0f0a-0da3-42d5-a151-405904f64146"), "University of Minnesota Duluth", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9596dd45-8c69-4a23-8a79-f878ca1d6cd8"), "Minnesota State University Moorhead", "Dragons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("60597b47-f950-43bb-99ae-842a466b1f6b"), "Minnesota State University, Mankato", "Mavericks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d4adc99c-b0cf-4840-a81f-58bb7cdc97fd"), "Millersville University of Pennsylvania", "Marauders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("56621524-ccbf-4f42-b509-a9873c6eee84"), "Miles College", "Golden Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("aa3806b5-39bc-4ee9-9d19-0011fea6dad0"), "Midwestern State University", "Mustangs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("029e641f-02d2-4224-98d8-2d5ef7710a4e"), "Missouri Western State University", "Griffons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2f9c6079-49e8-41b7-b76e-9e2d5eff3370"), "Southwest Minnesota State University", "Mustangs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("00d40333-3548-4ed3-8f75-e20fcdad14d9"), "Northwood University", "Timberwolves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5ae18030-4969-4b44-a727-10040e290de1"), "Ohio Dominican University", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a761ed4e-7af6-4231-b035-27e7b9cfc497"), "Southern Nazarene University", "Crimson Storm", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("69356021-2a3d-4463-89bf-2cd0c5ff1f38"), "Southern Connecticut State University", "Fighting Owls", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2b7856c4-faee-4632-83a8-c9b9a33ef365"), "Southern Arkansas University", "Muleriders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f71abd6e-38a3-4698-a71c-15733a9be1ec"), "Southeastern Oklahoma State University", "Savage Storm", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4f580292-fd2b-4e7d-a87e-a3d3c50d3ea7"), "South Dakota School of Mines and Technology", "Hardrockers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9c4492d1-2108-4f48-a50d-186e7ca2bf59"), "Slippery Rock University of Pennsylvania", "The Rock", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1b307053-e577-4d63-b9de-417333355134"), "University of Sioux Falls", "Cougars", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2b4eb23f-886a-4064-9503-20da965c403e"), "Simon Fraser University", "Clan", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ce17d7a7-367a-479d-af8c-149a12e2c06d"), "Shorter University", "Hawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f60dcf78-0a6f-4bae-ade7-107989188a76"), "Shippensburg University of Pennsylvania", "Red Raiders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("06938054-7e65-4977-95b2-965a4b75cd26"), "Notre Dame College", "Falcons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9e8706c0-3524-4750-a8e0-4f9446907c91"), "Shepherd University", "Rams", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1e97a417-13b4-4179-bcc2-f69782560a14"), "Seton Hill University", "Griffins", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("67c6e5d3-5646-4499-a5b4-9dd546d2af8c"), "Savannah State University", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("dceca5bf-6c84-433b-abf7-52639510a968"), "Saint Augustine's University", "Falcons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a7126260-1582-4b9c-85d3-36ef32808325"), "Saint Anselm College", "Hawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("011e3106-c9f1-41c4-9c79-192956e3542f"), "Saginaw Valley State University", "Cardinals", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9a1c3f19-beed-40f7-97cf-6f08524969c7"), "Quincy University", "Hawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("28772c09-6bce-4e4e-b0ed-520c97ffa8b0"), "Pittsburg State University", "Gorillas", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d3d28642-6f89-46b2-9843-dcfbeb69cd4b"), "Pace University", "Setters", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("96200518-724d-401d-98ca-56f6823ef750"), "Ouachita Baptist University", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f53b5b50-942c-4c40-be7d-edf61f4b431c"), "Oklahoma Baptist University", "Bison", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b316f1a2-b11e-446c-aab9-38442f7bd16c"), "Shaw University", "Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5cad253b-0666-48af-b21e-16389e5b8db9"), "Chattanooga", "Mocs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b4bc1ff2-983b-49bd-b13e-858971316ca2"), "The Citadel", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a06ea107-add7-4bdb-9b01-0d2ada806c8d"), "Colgate", "Raiders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f4100a4c-90bc-465d-b0c8-f14f365e46c7"), "San Diego", "Toreros", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("02289f4b-0c95-4e49-a166-ab758681cf65"), "Samford", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6f13541a-7843-46ed-b6a9-536ed9e94f78"), "Sam Houston State", "Bearkats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("37f9c7ab-e697-4350-9237-19270918ff62"), "Saint Francis", "Red Flash", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4033002e-8f29-414c-bc0d-c23af5c988f0"), "Sacred Heart", "Pioneers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("32cb3d14-0a72-4e95-a567-fc5d13cf5e84"), "Sacramento State", "Hornets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1645c62c-2cfb-44c5-b8fd-a6007e6b8a4a"), "Robert Morris", "Colonials", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("cb0877af-1c28-49f1-aa87-e08648616658"), "Richmond", "Spiders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a137308a-870c-4730-92df-860d4401bb20"), "Rhode Island", "Rams", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ae15c74b-7924-4399-a2b0-21af69393328"), "Princeton", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1d07fb52-c07e-4726-ba94-414d752a0479"), "South Carolina State", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("13c35e48-32b2-49ce-8f17-97a4f0ae42d9"), "Presbyterian", "Blue Hose", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("59b42d3e-1bdb-4021-98ce-f150e26e653f"), "Portland State", "Vikings", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c5d25836-a934-4df1-ab38-cee0a16df1a3"), "Penn", "Quakers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("93a67ff7-7b10-4236-bb9b-4ca4c778e6ef"), "Northwestern State", "Demons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("0e7435cb-5eec-49ad-b046-687bf838539f"), "Northern Iowa", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d9df70e2-cf06-4c62-8149-a8d380294fa1"), "Northern Colorado", "Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("cef37a98-06c7-4bfa-a362-88ae0c2118d1"), "Northern Arizona", "Lumberjacks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("fba58cbc-dd1b-42a9-9c83-c68028800c07"), "North Dakota State", "Bison", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4763d8ef-96db-42df-a329-f22d1fe1bf8a"), "North Dakota", "Fighting Hawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("159d3e63-601d-48b2-b369-2255bbf99b62"), "North Carolina Central", "Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9792ffdf-0430-48c4-901f-1ac2501a7594"), "North Carolina A&T", "Aggies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("add5907c-b2b7-43a7-b7cb-451a86a4a320"), "Prairie View A&M", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("041314da-c0e8-4504-91a2-b67376309930"), "Norfolk State", "Spartans", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("55b561d0-cc71-4410-9dd6-71925a5f87ff"), "South Dakota", "Coyotes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1fe8aa47-57e4-432b-a769-c0ca97193af5"), "Southeast Missouri State", "Redhawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d8e92866-9439-4d00-be05-c08d3adb3bf7"), "Wofford", "Terriers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("778046d7-1e64-46ba-b9f5-ab3b63be3dff"), "William & Mary", "Tribe", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8762f6d1-8e23-4b31-b088-10cb05e40449"), "Western Illinois", "Leathernecks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1a3f1f83-0b79-4a6e-beec-51433b0f0933"), "Western Carolina", "Catamounts", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4f04e436-8d4a-4ebc-85ef-969d4ed2b090"), "Weber State", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("31c10d18-9470-487d-802a-53528a1b19c1"), "Wagner", "Seahawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("44660b90-f3fc-4f4d-80a0-6b0612be6e38"), "VMI", "Keydets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("43ded2c4-6c47-408a-922c-6954fc45d22e"), "Villanova", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("209eec96-658a-43db-bdc5-1cc089f4f11a"), "Valparaiso", "Crusaders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ceb34d14-29ea-4cb5-bb43-dd7406ba29d4"), "UT Martin", "Skyhawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("428baa8d-7078-4089-942d-1ffce3bda92c"), "South Dakota State", "Jackrabbits", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("15f42b96-0a5b-4243-b516-b98d09dab7e1"), "UC Davis", "Aggies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("24a745a1-1b3f-47ad-bfe2-3c51fe1b64b3"), "Texas Southern", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("7573dba2-c07a-4f45-92b8-b5b70fb40320"), "Tennessee Tech", "Golden Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("861ee774-09a4-444f-bf48-d7de27931e54"), "Tennessee State", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("37be6525-6149-469e-b650-be00ffee0fce"), "Stony Brook", "Seawolves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2c45b91e-c932-4c32-b185-270b2334de9b"), "Stetson", "Hatters", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2815a40a-469b-4298-b84e-fa7d8df79e8a"), "Stephen F. Austin", "Lumberjacks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("17b3a55f-5b23-461e-aeca-ee765cc2ff99"), "Southern Utah", "Thunderbirds", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("aa1f7f49-6db7-4ee3-874d-014a99f78c79"), "Southern Illinois", "Salukis", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2a738d4d-1968-4e2e-9b3d-8128774cb55d"), "Southern", "Jaguars", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("94d4baf9-3016-42ba-bcd0-80192aa2978a"), "Southeastern Louisiana", "Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("08392c9b-b716-4f84-8a32-4a3b7fe8a245"), "Towson", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2f400ee0-7c08-413e-b434-a89e37fded28"), "Nicholls", "Colonels", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a1d47943-4bd9-4b3a-b306-23b5486e23a6"), "New Hampshire", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("72803f90-1777-45a1-beca-2b8ba6166549"), "Murray State", "Racers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("10a886fe-c69c-4304-b905-1093710e0372"), "Harvard", "Crimson", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b00b01f0-38d5-4ad2-9b18-8f9dd229257d"), "Hampton", "Pirates", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1ecf8a1c-485a-40ff-bb4d-ad315e4215a1"), "Grambling State", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("0cdd94b2-37f3-44db-9090-3172b549bc24"), "Georgetown", "Hoyas", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ca4087c2-7cd4-45cc-9282-cffd007938f1"), "Gardner-Webb", "Runnin' Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("7c1ee9fb-6d7a-40cb-adee-f380e5b8e45b"), "Furman", "Paladins", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f08f8dc0-b864-4665-bc1f-357a2ca70397"), "Fordham", "Rams", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b50ecc61-91de-4c5a-8582-d5680e59da5e"), "Florida A&M", "Rattlers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("69d35701-038b-4f97-894f-1951098a6f9b"), "Elon", "Phoenix", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("65911120-87f2-4d8b-98fa-6f021e7b292d"), "Eastern Washington", "Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5cdd4e35-6a58-451a-91e1-6685dc682f2c"), "Holy Cross", "Crusaders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("98799384-2f22-49c4-8796-31489950a30b"), "Eastern Kentucky", "Colonels", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("413e95cf-b1bb-492c-a1de-e0de8222b0b4"), "East Tennessee State", "Buccaneers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6c5701b4-1dc8-461f-8a06-6fbe8c0feef0"), "Duquesne", "Dukes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a1ed7b0d-5f85-4cb9-a196-b0f56b3956bd"), "Drake", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3e403a25-806f-4fd5-8449-93b3bf5de39f"), "Delaware State", "Hornets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d9e98815-af8b-42f8-874f-1db6070473b8"), "Delaware", "Fightin' Blue Hens", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("fc6801cc-3e5c-416f-bf94-13b28dee2fdc"), "Dayton", "Flyers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("51ae9f34-576a-4e92-ba60-9f8abc154539"), "Davidson", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("96da4305-a48d-451b-8483-e4f1ef1020f6"), "Dartmouth", "Big Green", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("dfd6f023-5a31-4e40-89f9-e1073393e740"), "Cornell", "Big Red", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("86b9f97c-7f78-473b-924d-508d41be2e8a"), "Columbia", "Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5efb6430-18e9-45ec-bf77-3fd17b6bac6d"), "Eastern Illinois", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9c88c9f8-3c8a-4051-bf90-54a01d79bb3c"), "Houston Baptist", "Huskies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("005ece0e-20b8-4058-9ea3-93b5d84066a7"), "Howard", "Bison", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9380180c-c833-4b62-99e9-5595dd4e27f6"), "Idaho", "Vandals", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1a154fc3-0808-4785-945e-bbc07a8ca9af"), "Morgan State", "Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("218237ed-9de3-44f2-8b83-50432b4cf77f"), "Morehead State", "Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3e11359f-2e92-4822-b364-22de86494b89"), "Montana State", "Bobcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("77fd0384-a596-4a1d-916d-52507b2753e0"), "Montana", "Grizzlies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("78cb29e4-7cef-4c1e-89af-06998c3ad4da"), "Monmouth", "Hawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("444edfe0-4dc5-410a-9a1a-653fd80a517b"), "Missouri State", "Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e80b82fe-ca15-4bde-92b7-0c9af8125f90"), "Mississippi Valley State", "Delta Devils", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6adf5680-85b4-428e-b213-0f63445cb5c0"), "Mercer", "Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("366250fa-8de8-442f-af30-3a509df77319"), "McNeese State", "Cowboys", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c7b7908d-4cac-41d4-a8b3-d5a76f3d6227"), "Marist", "Red Foxes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("872ef5ec-0f1f-4ff0-9241-e79a1cdd3626"), "Maine", "Black Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1d799804-bf30-4c82-953c-5267d8b13196"), "LIU[d]", "Sharks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("90176d63-e4e9-4135-afa9-e4829156d4ba"), "Lehigh", "Mountain Hawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1942c862-a76d-4c7b-853a-c129a01d8dd3"), "Lamar", "Cardinals", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b4f345f0-264e-4b6c-a6f0-9d36216a8071"), "Lafayette", "Leopards", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8796287e-fc66-48a4-a99c-2ba9205d5044"), "Kennesaw State", "Owls", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("34e7f0f8-d8e8-4a7a-9e0a-7fa3938c9682"), "James Madison", "Dukes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6c0ed2d5-a99f-4caf-a269-6e585df0f251"), "Jacksonville State", "Gamecocks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("307a6b82-1d89-46cb-a7d2-a140e802e8d4"), "Jackson State", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e3036717-a8e1-4173-a042-6410f3e27deb"), "Indiana State", "Sycamores", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("084cff3f-31d8-49c0-a256-a5889b95758b"), "Incarnate Word", "Cardinals", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("951cdac6-e370-4896-8b1b-82b7bf1aec62"), "Illinois State", "Redbirds", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c0aaf2a1-c9fb-4044-a8df-a8c1ddc6ba1a"), "Idaho State", "Bengals", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3e22e5ea-cdd5-40d5-848a-f8ac7f557181"), "Michigan Technological University", "Huskies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("75e5da44-2639-450c-a8e6-1e62b1b718bd"), "Yale", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("0ccbb8ed-1606-41eb-a44b-4483ffd13b67"), "Mercyhurst University", "Lakers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1dfc6337-683a-4f92-8551-f8de7e11f960"), "University of Mary", "Marauders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c5d80d01-5aa0-44fd-abed-d45a07cb59f3"), "Notre Dame", "Fighting Irish", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("57e9ea79-f661-4bf0-b4f0-13d68bd787da"), "Northwestern", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f180d607-143e-4111-9dbd-0f06f340bb83"), "Northern Illinois", "Huskies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2dbbff9e-a49b-45aa-bd1f-e7bbcdc4df35"), "North Texas", "Mean Green", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("32fadf72-fc36-440b-ad07-8ea95078e87b"), "North Carolina", "Tar Heels", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5d96fd5f-f02c-4522-88e0-15c6e105948e"), "New Mexico State", "Aggies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("79cf1fc5-8814-4768-8e0d-cdfc7acf09f7"), "New Mexico", "Lobos", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("75ee4f92-9fb6-46cc-8ef1-6f837030f2e7"), "Nevada", "Wolf Pack", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2a81f47c-7d0c-4327-9316-e425d51681ad"), "Nebraska", "Cornhuskers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("0ca5443a-7ef2-45f4-b215-ec089b9311bd"), "NC State", "Wolfpack", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("78ec77e2-f40a-4c01-b902-cfabb08252c8"), "Ohio", "Bobcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("48381d19-05de-4848-96b2-4a4d59b29ef6"), "Navy", "Midshipmen", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("213b1eda-6901-48ff-9664-af6523be8de4"), "Mississippi State", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6f29a5cc-8255-4fa3-993c-489ead194a6c"), "Minnesota", "Golden Gophers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("91340f28-0eab-4b8b-9475-fd44896e6501"), "Middle Tennessee", "Blue Raiders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4e67f20a-d1b6-42ca-ae84-3f40cfed3c4b"), "Michigan State", "Spartans", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3832e3d9-3af3-45e6-af8a-4a53113d7949"), "Michigan", "Wolverines", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("fa483ccb-48a5-447d-98a2-f6ad9aa75b3a"), "Miami (OH)", "RedHawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f4931982-df6e-4370-8708-be89734439be"), "Miami (FL)", "Hurricanes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("995b28ff-3dbd-4fb2-bf3e-5ddcfe2e65e3"), "Memphis", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("96d0ce55-360f-480d-8f88-4549477e5aa8"), "Maryland", "Terrapins", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("57d999d9-c2a2-49c3-83e6-319625f8140f"), "Marshall", "Thundering Herd", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9396c169-7626-4b82-8cab-6b19a0bc00ae"), "Missouri", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9e727ccd-5bc4-418d-ad08-36dd3d515700"), "LSU", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6a122e79-fc13-48d2-b057-012f30e8f057"), "Ohio State", "Buckeyes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("91ca67b3-c7e3-44d5-a9c5-ab104b71ef02"), "Oklahoma State", "Cowboys", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c90d76a0-1153-4c15-adff-0b6008053af4"), "Texas", "Longhorns", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c74ed639-9c42-45e4-99e2-265554b47d6e"), "Tennessee", "Volunteers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6932689b-eabd-445c-a2e0-e3430ddf6eed"), "Temple", "Owls", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("58d968e1-d7c2-4161-8ed5-9136f4c60f26"), "TCU", "Horned Frogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6e95cbba-55e2-4599-b5a0-48be82804698"), "Syracuse", "Orange", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("fb4107b2-4858-4ec8-b459-8f7973d0b3ef"), "Stanford", "Cardinal", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f4d31ecf-e23c-4231-bb9c-1b5e4b7f3ca8"), "Southern Miss", "Golden Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("da08f9fd-295f-4833-b41a-bb67026cee4e"), "South Florida", "Bulls", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("25e0cea7-0964-42f3-8c14-0c8b09c6c661"), "South Carolina", "Gamecocks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b68c1928-18da-492f-9d8f-266676598556"), "South Alabama", "Jaguars", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("74d18c47-b671-42a7-a1e7-72ba5587edba"), "Oklahoma", "Sooners", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("92238b64-3240-4e33-b804-9c13a67d8e5b"), "SMU", "Mustangs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("fc3d295f-1aa5-4658-a4cc-1101b294b095"), "San Diego State", "Aztecs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("47b7005d-0cab-4d59-a360-b84e7f35a8b3"), "Rutgers", "Scarlet Knights", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2ed06e46-8da4-4000-b255-e4b4c5e72a75"), "Rice", "Owls", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e463eaf6-5d8d-44d5-9d1a-965d7e689b9e"), "Purdue", "Boilermakers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("57c99c82-6e61-4c87-84c6-9c55cdba2d78"), "Pittsburgh", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("7d14c9e4-a9f2-4672-a55e-be7fb73be427"), "Penn State", "Nittany Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6a8c0919-7b97-498b-bb50-cd1b9f078100"), "Oregon State", "Beavers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("288cb3c5-b409-4330-9606-9e0b547ea113"), "Oregon", "Ducks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("337b4c6f-b6a8-4cc0-8df9-f8dc175dad69"), "Ole Miss", "Rebels", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("dd2cd859-e87a-42b3-826a-ccdde505b3cf"), "Old Dominion", "Monarchs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("715853d6-1744-4ea7-808a-7de1958d2b1e"), "San Jose State", "Spartans", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("169b3ac2-72c7-411f-ad4a-b7b2b68932e7"), "Texas A&M", "Aggies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("7af5607f-33ba-4097-87be-f12bcd9c6d86"), "Louisville", "Cardinals", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2d1c1515-d4f5-409f-bb81-d77604310a6c"), "Louisiana–Monroe", "Warhawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1f23eae6-c435-480c-8ec9-9c94446baa27"), "Coastal Carolina", "Chanticleers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d132ad01-f5d7-467c-807e-ede061c8e1da"), "Clemson", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e44bc372-1aa2-401d-9b4f-bba6ccb6c4f0"), "Cincinnati", "Bearcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a5827181-10e3-40d5-81bc-bd1041d7c984"), "Charlotte", "49ers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("39a441a7-a7b2-4117-834d-8fb618a09c11"), "Central Michigan", "Chippewas", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a1eff97e-4540-4ef5-a052-d9cc781487ed"), "California", "Golden Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4d3803d1-9c46-4e27-b9fd-950113a71486"), "BYU", "Cougars", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("30b29761-0fe2-40b2-b4e5-78be0c3402b0"), "Buffalo", "Bulls", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6dc3d63f-9668-4d92-91a3-762cf1177af0"), "Bowling Green", "Falcons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c0d34aed-7306-4218-a5b5-6cf202e5fe23"), "Boston College", "Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("239ce30f-0215-40e4-b72d-7d5959c9350c"), "Colorado", "Buffaloes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4429456c-42ce-4263-ba0d-806790138dc2"), "Boise State", "Broncos", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("113d2f5b-9b3c-4b8e-9090-9b6a6a4f8657"), "Ball State", "Cardinals", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9c582190-5582-48fd-8ec0-4792bf6a3771"), "Auburn", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d36709cf-8b81-42ca-b97b-c2267f5496db"), "Army", "Black Knights", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("73431256-2f1c-4ccd-ac30-3550c54f33e8"), "Arkansas State", "Red Wolves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3a2e5eae-781c-45ec-ba9b-9ca3e360214d"), "Arkansas", "Razorbacks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3e0778ba-8cdb-4fa1-b68c-5a0bc372402f"), "Arizona State", "Sun Devils", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("aeced65d-ca82-4774-9920-cee005da677e"), "Arizona", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3bdf3b8d-decb-4a94-ac49-4ef2eb8802ed"), "Appalachian State", "Mountaineers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e01cd500-5fee-4437-9420-d7d09f77ebcb"), "Alabama", "Crimson Tide", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("edb1df77-dbb5-4ede-a79c-38c3abe4ff31"), "Akron", "Zips", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("05647b9e-a6b4-4eb2-8d2a-4f09864a776d"), "Baylor", "Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f16f99b5-3b5e-4734-9b9e-8f2c3a538eff"), "Louisiana Tech", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b343206d-5aa7-4592-93b3-6ecda9da164c"), "Colorado State", "Rams", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("06b76656-a702-4db6-8bc9-e40bf9b2b52d"), "East Carolina", "Pirates", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d91df7ef-6a5c-41a5-95f4-5cec0f61452a"), "Louisiana", "Ragin' Cajuns", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1ed98dd2-c2d8-4f58-8f0a-03e4eb97fa92"), "Liberty", "Flames", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1c0d9917-2aae-4cc3-8a62-67316a439662"), "Kentucky", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("fb659ac3-5852-4d93-9141-45384ddf885f"), "Kent State", "Golden Flashes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b4fc66d0-6c9a-4362-ac0b-f6dfb3d952a3"), "Kansas State", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8c719dfd-a35b-45d5-b254-08a6f9dcd360"), "Kansas", "Jayhawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("41e9ca34-8f43-4379-8bc5-cbe3eee41e25"), "Iowa State", "Cyclones", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("429dd80a-9f76-4cd6-8c9e-5c12caf9a38f"), "Iowa", "Hawkeyes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b64e70e3-3562-4d26-b636-8485d4ae3374"), "Indiana", "Hoosiers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2bfbdfda-4191-4216-a2bd-7f70e7ca495b"), "Illinois", "Fighting Illini", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ff189979-a020-4f2a-8353-cdd59442fb1d"), "Duke", "Blue Devils", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a289536a-ada6-4e57-a184-e950d3a0b6a3"), "Houston", "Cougars", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e8c00107-d76c-42af-86e7-8aee1a33eeda"), "Georgia Tech", "Yellow Jackets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e02b497d-92fe-4cda-9f70-550f4b189564"), "Georgia State", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3b79c096-35a6-47ab-adcd-74732af1aa44"), "Georgia Southern", "Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("867fdecf-1f35-4262-9b71-89575b6d6bd6"), "Georgia", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("28a14514-1d87-477a-bf45-82f98dc06c98"), "Fresno State", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8c4d88ae-1998-4bd7-a2a9-0c97afdd084e"), "Florida State", "Seminoles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a6e4724a-fff9-47d8-b626-25e03b6dd9e4"), "Florida Atlantic", "Owls", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b2697180-4643-4b36-9337-b9db04c791b5"), "Florida", "Gators", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9410e375-0ba7-448c-9591-746589c71f04"), "FIU", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ceb6cb21-0551-4a59-913a-98c5cc7e6080"), "Eastern Michigan", "Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("eebddb99-b5d2-4ad8-bbaa-9732561fdb68"), "Hawaii", "Rainbow Warriors", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4a6fd5ef-805c-4b03-acf7-34c14155b6bf"), "Texas State", "Bobcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2c14348b-c680-4363-a368-3a5f2d9e526b"), "Texas Tech", "Red Raiders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("71b96197-f743-480e-95cb-651830053a89"), "Toledo", "Rockets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e65034db-4a30-4c06-932e-51155f9d928d"), "Fort Hays State University", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("45688e4e-d0ba-4f27-914f-8917c8477a1e"), "University of Findlay", "Oilers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("642de0f3-9f73-4f6b-a0f6-6f336ddc3e10"), "Ferris State University", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8727bcb2-3149-4af2-bb0b-973be4ad62d6"), "Fayetteville State University", "Broncos", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5a13589a-d317-4aa0-9c6a-aedbf0e213e9"), "Fairmont State University", "Falcons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5ed9bfa5-ca58-423c-b417-78f1b88c4fed"), "Erskine College", "Flying Fleet", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("7bcc19aa-1f3b-4245-a255-9e390b15a189"), "Emporia State University", "Hornets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("49daa45d-5c8b-41d9-af1a-016534b15f71"), "Elizabeth City State University", "Vikings", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("aeb4b23c-1d47-4857-91b6-2b9eaa549ade"), "Edinboro University of Pennsylvania", "Fighting Scots", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("858f03e3-397f-4fb1-ad3f-6c8ed098a924"), "Eastern New Mexico University", "Greyhounds", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("63b510b3-b0e7-404b-9633-66a1125a4f15"), "Fort Lewis College", "Skyhawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c809c3ac-bdc8-4852-8e20-e83fa7ab819a"), "East Stroudsburg University of Pennsylvania", "Warriors", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3e41d53f-548d-4877-8433-2a75160d0272"), "Delta State University", "Statesmen", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("033740bc-5799-468d-8400-fba6dd0eefe1"), "Davenport University", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a0f44954-3788-44e7-a896-421cdcf4d30f"), "Concordia University–St. Paul", "Golden Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("fe753d81-ee7e-45f5-8628-4548a86ae820"), "Concord University", "Mountain Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a9263f61-8355-42ba-a34e-f99c86dc4c36"), "Colorado State University–Pueblo", "ThunderWolves", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1dfa0fab-d67d-4ecf-8569-878f19d331f7"), "Colorado School of Mines", "Orediggers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f6048836-1275-4bd3-84ef-8633b2556a2b"), "Colorado Mesa University", "Mavericks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("eeab71c7-369c-40bc-8af4-045799b589c5"), "Clark Atlanta University", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ba983104-0638-4c32-b293-289a6af3fb2c"), "Clarion University of Pennsylvania", "Golden Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ba353d36-bac2-400c-a747-5d2e6a428328"), "Chowan University", "Hawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8e0f8170-ad6f-41f2-89d7-10cfe1662342"), "East Central University", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8a78eea4-e6c8-46f0-8657-7f5c255cdaa6"), "University of Charleston", "Golden Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c43d3561-3cc1-4a37-ad67-771d319e1495"), "Fort Valley State University", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("cc55501c-4c3f-4712-ab72-d8ac9ebbe002"), "Frostburg State University", "Bobcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("396a1840-c30d-4040-a16d-df3a51f29624"), "Mars Hill University", "Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1e4dfe82-252d-4027-9267-a331d13a2ad4"), "Lock Haven University of Pennsylvania", "Bald Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ca66b7cf-7bcb-4f78-9616-d5ec5a572589"), "Livingstone College", "Blue Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("cdd37f7a-d050-43d3-ad20-152bde3a56bb"), "Lindenwood University", "Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("cd3c16b5-b43b-4812-8ca3-57e738b7f8c2"), "Lincoln University (PA)", "Lions", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2b4c9db4-95b1-4a38-bfa4-296effd884ec"), "Lincoln University (MO)", "Blue Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c5d731cc-bee5-4c53-81db-140de27ef691"), "Limestone University", "Saints", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("cbd3fef3-1336-40a1-ab03-db59ef3a8fc2"), "Lenoir–Rhyne University", "Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a00a0a13-a4b6-4049-8bc7-879972c98b2c"), "Lane College", "Dragons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f63071ab-2be6-406a-bf28-608177be2b79"), "Lake Erie College", "Storm", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("088e69e6-2a04-4c5f-97a7-a237e46548dd"), "Franklin Pierce University", "Ravens", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1f74e857-7ff8-48f1-ab00-4b5827330c5e"), "Kutztown University of Pennsylvania", "Golden Bears", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6b4b0b71-c73a-4eb2-8068-20855d87cfd4"), "Kentucky State University", "Thorobreds", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("cd74c5b3-29f8-4249-a078-ec0477e90455"), "Johnson C. Smith University", "Golden Bulls", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("445ef1a1-4394-49fa-b2fe-a2a5880b80f0"), "University of Indianapolis", "Greyhounds", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("717eb6f6-ba85-4235-96fa-fc4df47ff179"), "Indiana University of Pennsylvania", "Crimson Hawks", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("88b84c9c-30c4-4f44-8852-8ef4f7fcd3a2"), "Hillsdale College", "Chargers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("001f86dd-e1da-4a50-b980-e932b5d3857d"), "Henderson State University", "Reddies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("39130bfe-72d6-4de5-a0ad-3f775236517e"), "Harding University", "Bisons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("bdb213a7-96bd-4437-a53b-7f826bb38a69"), "Grand Valley State University", "Lakers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9210587d-d5d1-4844-9e75-095d86c5cd86"), "Glenville State College", "Pioneers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("62c1e1ea-f73b-402a-a246-459bf45bd13c"), "Gannon University", "Golden Knights", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("874dd2a5-84b5-4d19-8e3a-f16de58f8f2a"), "Kentucky Wesleyan College", "Panthers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("fb2503bf-18b7-4653-b0af-feb02e0a063c"), "Chadron State College", "Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c009d2b2-0f9d-44e9-9090-ea803d6e1025"), "Central Washington University", "Wildcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f5c0a319-ec62-410a-b78a-dc228e5dc769"), "Central State University", "Marauders", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f0b7eb4a-77e9-4878-816e-514d4a395c2b"), "Western Kentucky", "Hilltoppers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("66530a91-5da7-42ea-8a6a-f61c773fbceb"), "West Virginia", "Mountaineers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("5903c577-5ebf-4cd2-8dfb-52c2fbd63519"), "Washington State", "Cougars", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a5b52222-1118-44bb-8933-82ff9717022e"), "Washington", "Huskies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d90ba8ed-3658-4855-9d4c-a5c01a042479"), "Wake Forest", "Demon Deacons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2855350d-cc95-4abc-b21f-5294b501bfd2"), "Virginia Tech", "Hokies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("02b773ac-99f4-4829-af26-f7c275140421"), "Virginia", "Cavaliers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("a001f889-7ae1-4cfa-8230-264a02d60368"), "Vanderbilt", "Commodores", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d1ef27e6-2d5d-48bc-b82f-4cb1be9fb78b"), "Utah State", "Aggies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4a5dfd5a-a54d-4f84-a47e-423306c12d16"), "Utah", "Utes", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("bccbcf1c-de44-4f6f-ad2f-6a2d7d6d85cf"), "Western Michigan", "Broncos", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("765c656e-e97c-457a-91af-c89042981bcb"), "UTSA", "Roadrunners", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("7e727efd-409f-4689-8821-6e001fe9ad29"), "USC", "Trojans", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4749811b-fcb3-4508-b13a-368d78b54e70"), "UNLV", "Rebels", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9a48297d-5e4d-45b1-a6ea-0c7db6aba63f"), "UMass", "Minutemen", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3af71f9d-b8b1-492d-9f5c-15ca759561a8"), "UConn", "Huskies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("560a8f7d-42ee-4c6a-a5c5-7abe950146a3"), "UCLA", "Bruins", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e3d9bd0c-3b9f-41de-9eb0-9b14f8bbdbd5"), "UCF", "Knights", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c47afb45-baa5-46b7-b922-b74d87abecef"), "UAB", "Blazers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("9d1227be-bb77-4018-8234-fc1ad8e9fb19"), "Tulsa", "Golden Hurricane", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6d674d7a-a8e8-481f-a389-a6a72306e694"), "Tulane", "Green Wave", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("2b11f841-3285-41bf-8490-6f0ab3706ab2"), "Troy", "Trojans", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ddd09054-e1f8-431c-b94e-cf148f9e4350"), "UTEP", "Miners", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("71069ebb-2b7d-4363-a8e6-ad7a2195fd3e"), "Wisconsin", "Badgers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1437cb9e-49a7-4756-bb56-990f7f24783b"), "Wyoming", "Cowboys", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("553be47a-01fb-48a8-983a-f4495aa7850a"), "Adams State University", "Grizzlies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("d487f5bc-ced5-412a-aae4-7470bf441796"), "University of Central Oklahoma", "Bronchos", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("07109dcc-9001-415d-b31c-44efa048c011"), "University of Central Missouri", "Mules", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("adc3d098-eeaa-4e2c-816a-4c09c4496423"), "Catawba College", "Indians", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ae1cacb2-8120-40a6-a475-7c7590d5d80c"), "Carson–Newman University", "Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e710a4a9-58df-4a3d-8e0f-7e266269c01e"), "California University of Pennsylvania", "Vulcans", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("3ef7e327-5f53-40dc-a204-e93070e0aae1"), "Bowie State University", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("33f211ca-dc3f-4d8a-a2e9-fbd49de4f574"), "Bloomsburg University of Pennsylvania", "Huskies", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("04ed16bd-9f32-4647-9a62-777357f1e886"), "Black Hills State University", "Yellow Jackets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("1047999e-7c06-452e-856f-4823a7c6fd15"), "Bentley University", "Falcons", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("c76da2fa-3bdc-46da-aee9-cee5cb2f9c25"), "Benedict College", "Tigers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6849b316-f61a-40fd-97b8-2ca8bf6fee2e"), "Bemidji State University", "Beavers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("7bdcd480-bcc8-4c5b-b509-6390873f64cb"), "Barton College", "Bulldogs", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("99dd929b-4306-432e-8255-5e3608d7c7f7"), "Azusa Pacific University", "Cougars", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("dda2dd88-2c22-42a3-9513-6064c45f233d"), "Augustana University", "Vikings", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e56158b8-46e7-47b1-947e-17403ca4aaea"), "Assumption University", "Greyhounds", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("26d49413-1b52-41e9-b939-1905a6259900"), "Ashland University", "Eagles", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("ac76689f-13fa-4bd0-bd30-a482a990510a"), "University of Arkansas at Monticello", "Boll Weevils", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("f803d79c-c569-478f-815d-0ee2f9d97fd6"), "Arkansas Tech University", "Wonder Boys", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e2df694b-e24e-4ed4-99cb-f75874a9e4b9"), "Angelo State University", "Rams", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("0abce16a-f153-468d-baa7-2f3fa57de79e"), "American International College", "Yellow Jackets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("b7210d0d-d2c1-49d7-887d-191f06379e01"), "Allen University", "Yellow Jackets", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("4115e1de-70dc-441b-a472-b0a0b6a14960"), "Alderson Broaddus University", "Battlers", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("8d4076c2-7160-4091-ae78-5f9186da26b5"), "Albany State University", "Golden Rams", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("e8c2c994-27e7-41b1-b51b-385684091259"), "McKendree University", "Bearcats", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") },
                    { new Guid("6d3871e7-8d02-4830-84f9-a97b0e09a1a5"), "Youngstown State", "Penguins", new Guid("43ecce0d-7a55-4cdb-9378-6777ae8ab0aa") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("001f86dd-e1da-4a50-b980-e932b5d3857d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("005ece0e-20b8-4058-9ea3-93b5d84066a7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("00d40333-3548-4ed3-8f75-e20fcdad14d9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("011e3106-c9f1-41c4-9c79-192956e3542f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("02289f4b-0c95-4e49-a166-ab758681cf65"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("029e641f-02d2-4224-98d8-2d5ef7710a4e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("02b773ac-99f4-4829-af26-f7c275140421"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("032e2388-27cd-4c17-9947-3937b418007b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("03325589-2edb-4877-81d5-d5c8f723cc5c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("033740bc-5799-468d-8400-fba6dd0eefe1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("041314da-c0e8-4504-91a2-b67376309930"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0464439a-6563-4c9a-9a3a-f8b499136902"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("04ed16bd-9f32-4647-9a62-777357f1e886"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("05647b9e-a6b4-4eb2-8d2a-4f09864a776d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("06938054-7e65-4977-95b2-965a4b75cd26"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("06b76656-a702-4db6-8bc9-e40bf9b2b52d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("07109dcc-9001-415d-b31c-44efa048c011"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("08392c9b-b716-4f84-8a32-4a3b7fe8a245"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("084cff3f-31d8-49c0-a256-a5889b95758b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("088e69e6-2a04-4c5f-97a7-a237e46548dd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("099065c0-5982-49b9-a4e8-a5bbe28f6e7f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0abce16a-f153-468d-baa7-2f3fa57de79e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0ca5443a-7ef2-45f4-b215-ec089b9311bd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0ccbb8ed-1606-41eb-a44b-4483ffd13b67"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0cdd94b2-37f3-44db-9090-3172b549bc24"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("0e7435cb-5eec-49ad-b046-687bf838539f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1047999e-7c06-452e-856f-4823a7c6fd15"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("10a886fe-c69c-4304-b905-1093710e0372"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("113d2f5b-9b3c-4b8e-9090-9b6a6a4f8657"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("12d0d5ec-eb3a-4b8d-ae39-069caf9bfbbd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("13c35e48-32b2-49ce-8f17-97a4f0ae42d9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1437cb9e-49a7-4756-bb56-990f7f24783b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("159d3e63-601d-48b2-b369-2255bbf99b62"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("15f42b96-0a5b-4243-b516-b98d09dab7e1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1645c62c-2cfb-44c5-b8fd-a6007e6b8a4a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("169b3ac2-72c7-411f-ad4a-b7b2b68932e7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("17b3a55f-5b23-461e-aeca-ee765cc2ff99"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1942c862-a76d-4c7b-853a-c129a01d8dd3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1a154fc3-0808-4785-945e-bbc07a8ca9af"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1a3f1f83-0b79-4a6e-beec-51433b0f0933"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1b307053-e577-4d63-b9de-417333355134"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1c0d9917-2aae-4cc3-8a62-67316a439662"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1d07fb52-c07e-4726-ba94-414d752a0479"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1d2de3e2-df62-4396-8e6f-18c23ead20f4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1d799804-bf30-4c82-953c-5267d8b13196"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1dfa0fab-d67d-4ecf-8569-878f19d331f7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1dfc6337-683a-4f92-8551-f8de7e11f960"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1e4dfe82-252d-4027-9267-a331d13a2ad4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1e5979ae-c317-4e8f-b1b4-5f0c7fc1c8db"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1e97a417-13b4-4179-bcc2-f69782560a14"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1ecf8a1c-485a-40ff-bb4d-ad315e4215a1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1ed98dd2-c2d8-4f58-8f0a-03e4eb97fa92"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1f23eae6-c435-480c-8ec9-9c94446baa27"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1f74e857-7ff8-48f1-ab00-4b5827330c5e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("1fe8aa47-57e4-432b-a769-c0ca97193af5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("209eec96-658a-43db-bdc5-1cc089f4f11a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("213b1eda-6901-48ff-9664-af6523be8de4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("218237ed-9de3-44f2-8b83-50432b4cf77f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("239ce30f-0215-40e4-b72d-7d5959c9350c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("24a745a1-1b3f-47ad-bfe2-3c51fe1b64b3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("24eae274-b58e-435f-9cbd-c87f8a6902dd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("25e0cea7-0964-42f3-8c14-0c8b09c6c661"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("26d49413-1b52-41e9-b939-1905a6259900"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("280c6901-4d9a-4893-b190-3302e10d931b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2815a40a-469b-4298-b84e-fa7d8df79e8a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2855350d-cc95-4abc-b21f-5294b501bfd2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("28772c09-6bce-4e4e-b0ed-520c97ffa8b0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("288cb3c5-b409-4330-9606-9e0b547ea113"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("28a14514-1d87-477a-bf45-82f98dc06c98"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("29269198-c391-4d09-b836-4fa00081fa38"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2a738d4d-1968-4e2e-9b3d-8128774cb55d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2a81f47c-7d0c-4327-9316-e425d51681ad"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2aefc0a2-d151-4adc-86e5-12d504a896d1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2b11f841-3285-41bf-8490-6f0ab3706ab2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2b2757a9-24e6-4f3a-93b8-79fd3f1ae161"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2b4c9db4-95b1-4a38-bfa4-296effd884ec"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2b4eb23f-886a-4064-9503-20da965c403e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2b7856c4-faee-4632-83a8-c9b9a33ef365"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2bfbdfda-4191-4216-a2bd-7f70e7ca495b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2c14348b-c680-4363-a368-3a5f2d9e526b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2c45b91e-c932-4c32-b185-270b2334de9b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2d1c1515-d4f5-409f-bb81-d77604310a6c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2dbbff9e-a49b-45aa-bd1f-e7bbcdc4df35"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2de7360f-2dc1-43ee-a62f-431527e86e45"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2ed06e46-8da4-4000-b255-e4b4c5e72a75"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2f400ee0-7c08-413e-b434-a89e37fded28"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("2f9c6079-49e8-41b7-b76e-9e2d5eff3370"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("30776384-7802-421c-93d5-2d4991cb32d3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("307a6b82-1d89-46cb-a7d2-a140e802e8d4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("30b29761-0fe2-40b2-b4e5-78be0c3402b0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("30fd3fd3-12af-4a33-a5f3-b2d35756a77c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("31c10d18-9470-487d-802a-53528a1b19c1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("32cb3d14-0a72-4e95-a567-fc5d13cf5e84"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("32fadf72-fc36-440b-ad07-8ea95078e87b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("337b4c6f-b6a8-4cc0-8df9-f8dc175dad69"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("33f211ca-dc3f-4d8a-a2e9-fbd49de4f574"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("34694e6e-7805-4446-beb2-a2ff1e11befe"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("34e7f0f8-d8e8-4a7a-9e0a-7fa3938c9682"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("366250fa-8de8-442f-af30-3a509df77319"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("369b4ec9-f7a2-4938-b42d-93165351ac6b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("36c72a92-2393-4e00-9002-b6e1c62505b0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("36de9297-3292-4d53-a83c-7571cc564e01"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("36debda6-3d83-47ac-b713-b70aeb26e813"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3720981d-72a8-434f-9e7b-ef939f849b08"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("37be6525-6149-469e-b650-be00ffee0fce"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("37f9c7ab-e697-4350-9237-19270918ff62"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("381e3e61-e629-420d-8bc1-5dd1c05018e1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3832e3d9-3af3-45e6-af8a-4a53113d7949"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3874deb8-794f-4156-9d47-504e989cbc0c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("39130bfe-72d6-4de5-a0ad-3f775236517e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("396a1840-c30d-4040-a16d-df3a51f29624"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("39a441a7-a7b2-4117-834d-8fb618a09c11"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3a2e5eae-781c-45ec-ba9b-9ca3e360214d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3a9e0f0a-0da3-42d5-a151-405904f64146"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3af71f9d-b8b1-492d-9f5c-15ca759561a8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3b79c096-35a6-47ab-adcd-74732af1aa44"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3bdf3b8d-decb-4a94-ac49-4ef2eb8802ed"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3e0778ba-8cdb-4fa1-b68c-5a0bc372402f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3e11359f-2e92-4822-b364-22de86494b89"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3e22e5ea-cdd5-40d5-848a-f8ac7f557181"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3e403a25-806f-4fd5-8449-93b3bf5de39f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3e41d53f-548d-4877-8433-2a75160d0272"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("3ef7e327-5f53-40dc-a204-e93070e0aae1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4033002e-8f29-414c-bc0d-c23af5c988f0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4115e1de-70dc-441b-a472-b0a0b6a14960"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("413e95cf-b1bb-492c-a1de-e0de8222b0b4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("41e9ca34-8f43-4379-8bc5-cbe3eee41e25"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("428baa8d-7078-4089-942d-1ffce3bda92c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("429dd80a-9f76-4cd6-8c9e-5c12caf9a38f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("43378c29-ad7c-488b-9163-6a091573b83a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("43ded2c4-6c47-408a-922c-6954fc45d22e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4429456c-42ce-4263-ba0d-806790138dc2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("444edfe0-4dc5-410a-9a1a-653fd80a517b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("445ef1a1-4394-49fa-b2fe-a2a5880b80f0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("44660b90-f3fc-4f4d-80a0-6b0612be6e38"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("45688e4e-d0ba-4f27-914f-8917c8477a1e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("46cd7664-51b8-455e-99ae-18b6282d0115"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4749811b-fcb3-4508-b13a-368d78b54e70"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4763d8ef-96db-42df-a329-f22d1fe1bf8a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("47b7005d-0cab-4d59-a360-b84e7f35a8b3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("48381d19-05de-4848-96b2-4a4d59b29ef6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("49bf6cf1-6265-4b2c-b310-23110acde823"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("49daa45d-5c8b-41d9-af1a-016534b15f71"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4a5dfd5a-a54d-4f84-a47e-423306c12d16"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4a6fd5ef-805c-4b03-acf7-34c14155b6bf"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4c2f2c9f-16f9-4332-b9ff-e941599e6b1e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4c9ced22-2b50-481f-8545-5b3f857e65e3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4d3803d1-9c46-4e27-b9fd-950113a71486"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4e198cfe-f1af-429e-b4e9-d69d846acc9c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4e67f20a-d1b6-42ca-ae84-3f40cfed3c4b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4f04e436-8d4a-4ebc-85ef-969d4ed2b090"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("4f580292-fd2b-4e7d-a87e-a3d3c50d3ea7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("50aa026d-c774-4202-8468-0599b3a97397"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("51ae9f34-576a-4e92-ba60-9f8abc154539"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("53c9c860-02bd-42b3-9bd1-7e034c7a5ec0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("553be47a-01fb-48a8-983a-f4495aa7850a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("55b561d0-cc71-4410-9dd6-71925a5f87ff"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("560a8f7d-42ee-4c6a-a5c5-7abe950146a3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5643e9e1-7c37-4506-bcfc-b37ca6238020"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("56621524-ccbf-4f42-b509-a9873c6eee84"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("57c99c82-6e61-4c87-84c6-9c55cdba2d78"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("57d999d9-c2a2-49c3-83e6-319625f8140f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("57e9ea79-f661-4bf0-b4f0-13d68bd787da"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("58d968e1-d7c2-4161-8ed5-9136f4c60f26"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5903c577-5ebf-4cd2-8dfb-52c2fbd63519"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("59b42d3e-1bdb-4021-98ce-f150e26e653f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5a13589a-d317-4aa0-9c6a-aedbf0e213e9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5a4c12fc-9bee-4b24-9f80-a3d408a1e0ee"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5a79ebc3-bf4f-4262-ad3e-81910a23649a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5ae18030-4969-4b44-a727-10040e290de1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5cad253b-0666-48af-b21e-16389e5b8db9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5cdd4e35-6a58-451a-91e1-6685dc682f2c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5d70f15d-a844-4442-965b-a15e71c96d15"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5d96fd5f-f02c-4522-88e0-15c6e105948e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5ed9bfa5-ca58-423c-b417-78f1b88c4fed"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("5efb6430-18e9-45ec-bf77-3fd17b6bac6d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("60597b47-f950-43bb-99ae-842a466b1f6b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("62ab810e-28db-45de-99eb-cbb0cf749110"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("62c1e1ea-f73b-402a-a246-459bf45bd13c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("631f3101-8e0f-4a04-bfe1-1324680c24ac"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("63b510b3-b0e7-404b-9633-66a1125a4f15"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("642de0f3-9f73-4f6b-a0f6-6f336ddc3e10"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("64a3cc80-ca8f-4ca2-9472-21c314a9df94"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("65024b55-a0af-4e2b-a0b8-04ef9c3cd0d0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("65911120-87f2-4d8b-98fa-6f021e7b292d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("66530a91-5da7-42ea-8a6a-f61c773fbceb"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("67c6e5d3-5646-4499-a5b4-9dd546d2af8c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6849b316-f61a-40fd-97b8-2ca8bf6fee2e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6932689b-eabd-445c-a2e0-e3430ddf6eed"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("69356021-2a3d-4463-89bf-2cd0c5ff1f38"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("698d4a6f-55a7-484d-a65a-990a3fde5c84"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("69c75371-6742-443f-afb7-6be32f112709"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("69d35701-038b-4f97-894f-1951098a6f9b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6a122e79-fc13-48d2-b057-012f30e8f057"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6a8c0919-7b97-498b-bb50-cd1b9f078100"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6adf5680-85b4-428e-b213-0f63445cb5c0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6b4b0b71-c73a-4eb2-8068-20855d87cfd4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6c0ed2d5-a99f-4caf-a269-6e585df0f251"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6c5701b4-1dc8-461f-8a06-6fbe8c0feef0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6d3871e7-8d02-4830-84f9-a97b0e09a1a5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6d674d7a-a8e8-481f-a389-a6a72306e694"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6dc3d63f-9668-4d92-91a3-762cf1177af0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6e95cbba-55e2-4599-b5a0-48be82804698"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6f13541a-7843-46ed-b6a9-536ed9e94f78"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("6f29a5cc-8255-4fa3-993c-489ead194a6c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("71069ebb-2b7d-4363-a8e6-ad7a2195fd3e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("715853d6-1744-4ea7-808a-7de1958d2b1e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("717eb6f6-ba85-4235-96fa-fc4df47ff179"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("71b96197-f743-480e-95cb-651830053a89"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("72803f90-1777-45a1-beca-2b8ba6166549"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("73431256-2f1c-4ccd-ac30-3550c54f33e8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("741ff517-5c31-4bb1-af9a-0c61c7a05041"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("74d18c47-b671-42a7-a1e7-72ba5587edba"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7573dba2-c07a-4f45-92b8-b5b70fb40320"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("75e5da44-2639-450c-a8e6-1e62b1b718bd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("75ee4f92-9fb6-46cc-8ef1-6f837030f2e7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("762df54a-cdb0-4612-a87b-7ad0c01e9154"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("765c656e-e97c-457a-91af-c89042981bcb"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("778046d7-1e64-46ba-b9f5-ab3b63be3dff"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("77fd0384-a596-4a1d-916d-52507b2753e0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("78cb29e4-7cef-4c1e-89af-06998c3ad4da"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("78ec77e2-f40a-4c01-b902-cfabb08252c8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("79cf1fc5-8814-4768-8e0d-cdfc7acf09f7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7af5607f-33ba-4097-87be-f12bcd9c6d86"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7bcc19aa-1f3b-4245-a255-9e390b15a189"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7bdcd480-bcc8-4c5b-b509-6390873f64cb"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7c1ee9fb-6d7a-40cb-adee-f380e5b8e45b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7d14c9e4-a9f2-4672-a55e-be7fb73be427"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("7e727efd-409f-4689-8821-6e001fe9ad29"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8480bce3-3e63-403c-8047-62db48ceea92"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("85218a1e-206a-41a0-98a6-35e7bfbd8d2b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("858f03e3-397f-4fb1-ad3f-6c8ed098a924"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("861ee774-09a4-444f-bf48-d7de27931e54"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("867fdecf-1f35-4262-9b71-89575b6d6bd6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("86b9f97c-7f78-473b-924d-508d41be2e8a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8704c753-093e-49c5-9fdd-848a206ef423"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8727bcb2-3149-4af2-bb0b-973be4ad62d6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("872ef5ec-0f1f-4ff0-9241-e79a1cdd3626"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("874dd2a5-84b5-4d19-8e3a-f16de58f8f2a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8762f6d1-8e23-4b31-b088-10cb05e40449"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8796287e-fc66-48a4-a99c-2ba9205d5044"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("88b84c9c-30c4-4f44-8852-8ef4f7fcd3a2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8a78eea4-e6c8-46f0-8657-7f5c255cdaa6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8c4d88ae-1998-4bd7-a2a9-0c97afdd084e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8c714169-f069-45ed-b153-53d2e1424068"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8c719dfd-a35b-45d5-b254-08a6f9dcd360"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8d4076c2-7160-4091-ae78-5f9186da26b5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8e0f8170-ad6f-41f2-89d7-10cfe1662342"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8e5fb891-5530-4ef5-9999-c0a3b5e92dd8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("8fb3ae7b-30f0-478c-8e2e-11cd4871ad28"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("90176d63-e4e9-4135-afa9-e4829156d4ba"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("91340f28-0eab-4b8b-9475-fd44896e6501"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("91ca67b3-c7e3-44d5-a9c5-ab104b71ef02"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9210587d-d5d1-4844-9e75-095d86c5cd86"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("92238b64-3240-4e33-b804-9c13a67d8e5b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9273dbff-16c6-47a8-853f-32adad9e2c55"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9380180c-c833-4b62-99e9-5595dd4e27f6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9396c169-7626-4b82-8cab-6b19a0bc00ae"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("93a67ff7-7b10-4236-bb9b-4ca4c778e6ef"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9410e375-0ba7-448c-9591-746589c71f04"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("94d4baf9-3016-42ba-bcd0-80192aa2978a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("951cdac6-e370-4896-8b1b-82b7bf1aec62"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9596dd45-8c69-4a23-8a79-f878ca1d6cd8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("96200518-724d-401d-98ca-56f6823ef750"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("96bc2645-30dd-41ee-af18-42dbc1495eab"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("96d0ce55-360f-480d-8f88-4549477e5aa8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("96da4305-a48d-451b-8483-e4f1ef1020f6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9792ffdf-0430-48c4-901f-1ac2501a7594"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("98799384-2f22-49c4-8796-31489950a30b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("995b28ff-3dbd-4fb2-bf3e-5ddcfe2e65e3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("99dd929b-4306-432e-8255-5e3608d7c7f7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9a1c3f19-beed-40f7-97cf-6f08524969c7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9a2f920c-31a9-4bb5-8f41-5ceb9e665af2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9a48297d-5e4d-45b1-a6ea-0c7db6aba63f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9c4492d1-2108-4f48-a50d-186e7ca2bf59"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9c582190-5582-48fd-8ec0-4792bf6a3771"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9c88c9f8-3c8a-4051-bf90-54a01d79bb3c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9d1227be-bb77-4018-8234-fc1ad8e9fb19"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9e727ccd-5bc4-418d-ad08-36dd3d515700"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("9e8706c0-3524-4750-a8e0-4f9446907c91"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a001f889-7ae1-4cfa-8230-264a02d60368"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a00a0a13-a4b6-4049-8bc7-879972c98b2c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a06ea107-add7-4bdb-9b01-0d2ada806c8d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a096be3e-8006-47b8-897c-ef23615327b2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a0f44954-3788-44e7-a896-421cdcf4d30f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a137308a-870c-4730-92df-860d4401bb20"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a1d47943-4bd9-4b3a-b306-23b5486e23a6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a1ed7b0d-5f85-4cb9-a196-b0f56b3956bd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a1eff97e-4540-4ef5-a052-d9cc781487ed"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a26f8080-ca42-42a9-b18a-2d7d48f60e80"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a289536a-ada6-4e57-a184-e950d3a0b6a3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a5827181-10e3-40d5-81bc-bd1041d7c984"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a5b52222-1118-44bb-8933-82ff9717022e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a6e4724a-fff9-47d8-b626-25e03b6dd9e4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a7126260-1582-4b9c-85d3-36ef32808325"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a72cf65e-ed43-4b80-b3da-dfd4f1582458"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a761ed4e-7af6-4231-b035-27e7b9cfc497"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a9263f61-8355-42ba-a34e-f99c86dc4c36"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("a9358fc5-9386-4ec0-b2c2-2fc556f8c3d2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("aa1f7f49-6db7-4ee3-874d-014a99f78c79"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("aa3806b5-39bc-4ee9-9d19-0011fea6dad0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ac76689f-13fa-4bd0-bd30-a482a990510a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("adc3d098-eeaa-4e2c-816a-4c09c4496423"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("add5907c-b2b7-43a7-b7cb-451a86a4a320"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ae15c74b-7924-4399-a2b0-21af69393328"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ae1cacb2-8120-40a6-a475-7c7590d5d80c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("aeb4b23c-1d47-4857-91b6-2b9eaa549ade"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("aeced65d-ca82-4774-9920-cee005da677e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b00b01f0-38d5-4ad2-9b18-8f9dd229257d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b2697180-4643-4b36-9337-b9db04c791b5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b316f1a2-b11e-446c-aab9-38442f7bd16c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b343206d-5aa7-4592-93b3-6ecda9da164c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b41b883a-df82-452f-871b-69a2cbbac46b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b4bc1ff2-983b-49bd-b13e-858971316ca2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b4f345f0-264e-4b6c-a6f0-9d36216a8071"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b4fc66d0-6c9a-4362-ac0b-f6dfb3d952a3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b50ecc61-91de-4c5a-8582-d5680e59da5e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b5ee2c50-3510-4dba-a65e-91a37ddc9774"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b64e70e3-3562-4d26-b636-8485d4ae3374"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b68c1928-18da-492f-9d8f-266676598556"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("b7210d0d-d2c1-49d7-887d-191f06379e01"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ba353d36-bac2-400c-a747-5d2e6a428328"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ba983104-0638-4c32-b293-289a6af3fb2c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("bccbcf1c-de44-4f6f-ad2f-6a2d7d6d85cf"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("bdb213a7-96bd-4437-a53b-7f826bb38a69"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c009d2b2-0f9d-44e9-9090-ea803d6e1025"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c0aaf2a1-c9fb-4044-a8df-a8c1ddc6ba1a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c0d34aed-7306-4218-a5b5-6cf202e5fe23"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c43d3561-3cc1-4a37-ad67-771d319e1495"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c47afb45-baa5-46b7-b922-b74d87abecef"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c5d25836-a934-4df1-ab38-cee0a16df1a3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c5d731cc-bee5-4c53-81db-140de27ef691"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c5d80d01-5aa0-44fd-abed-d45a07cb59f3"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c74ed639-9c42-45e4-99e2-265554b47d6e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c76da2fa-3bdc-46da-aee9-cee5cb2f9c25"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c7b7908d-4cac-41d4-a8b3-d5a76f3d6227"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c809c3ac-bdc8-4852-8e20-e83fa7ab819a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("c90d76a0-1153-4c15-adff-0b6008053af4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ca4087c2-7cd4-45cc-9282-cffd007938f1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ca66b7cf-7bcb-4f78-9616-d5ec5a572589"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cb0877af-1c28-49f1-aa87-e08648616658"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cbd3fef3-1336-40a1-ab03-db59ef3a8fc2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cc55501c-4c3f-4712-ab72-d8ac9ebbe002"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cd3c16b5-b43b-4812-8ca3-57e738b7f8c2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cd74c5b3-29f8-4249-a078-ec0477e90455"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cdd37f7a-d050-43d3-ad20-152bde3a56bb"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ce17d7a7-367a-479d-af8c-149a12e2c06d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ceb34d14-29ea-4cb5-bb43-dd7406ba29d4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ceb6cb21-0551-4a59-913a-98c5cc7e6080"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("cef37a98-06c7-4bfa-a362-88ae0c2118d1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d0e63515-2955-4b69-b4e5-d127c9360f51"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d132ad01-f5d7-467c-807e-ede061c8e1da"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d1ef27e6-2d5d-48bc-b82f-4cb1be9fb78b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d36709cf-8b81-42ca-b97b-c2267f5496db"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d3d28642-6f89-46b2-9843-dcfbeb69cd4b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d41296ba-8cf0-469f-9e06-a8249fc883fb"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d487f5bc-ced5-412a-aae4-7470bf441796"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d4adc99c-b0cf-4840-a81f-58bb7cdc97fd"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d8e92866-9439-4d00-be05-c08d3adb3bf7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d90ba8ed-3658-4855-9d4c-a5c01a042479"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d91df7ef-6a5c-41a5-95f4-5cec0f61452a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d9a96ad3-ba46-4b18-b484-fdd8357bfd67"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d9df70e2-cf06-4c62-8149-a8d380294fa1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("d9e98815-af8b-42f8-874f-1db6070473b8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("da08f9fd-295f-4833-b41a-bb67026cee4e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("dbc3e594-39e9-43f0-ac9f-c7854a82295f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("dc45127e-69ba-49e9-af1e-d07c6e9f8cb1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("dceca5bf-6c84-433b-abf7-52639510a968"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("dd2cd859-e87a-42b3-826a-ccdde505b3cf"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("dda2dd88-2c22-42a3-9513-6064c45f233d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ddd09054-e1f8-431c-b94e-cf148f9e4350"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("dfd6f023-5a31-4e40-89f9-e1073393e740"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e01cd500-5fee-4437-9420-d7d09f77ebcb"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e02b497d-92fe-4cda-9f70-550f4b189564"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e2df694b-e24e-4ed4-99cb-f75874a9e4b9"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e3036717-a8e1-4173-a042-6410f3e27deb"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e3d9bd0c-3b9f-41de-9eb0-9b14f8bbdbd5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e44bc372-1aa2-401d-9b4f-bba6ccb6c4f0"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e463eaf6-5d8d-44d5-9d1a-965d7e689b9e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e56158b8-46e7-47b1-947e-17403ca4aaea"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e65034db-4a30-4c06-932e-51155f9d928d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e710a4a9-58df-4a3d-8e0f-7e266269c01e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e80b82fe-ca15-4bde-92b7-0c9af8125f90"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e8c00107-d76c-42af-86e7-8aee1a33eeda"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("e8c2c994-27e7-41b1-b51b-385684091259"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ec4fe60a-babb-4602-a676-e53e2e4274ae"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("edb1df77-dbb5-4ede-a79c-38c3abe4ff31"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("eeab71c7-369c-40bc-8af4-045799b589c5"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("eebddb99-b5d2-4ad8-bbaa-9732561fdb68"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f08f8dc0-b864-4665-bc1f-357a2ca70397"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f0b7eb4a-77e9-4878-816e-514d4a395c2b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f16f99b5-3b5e-4734-9b9e-8f2c3a538eff"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f180d607-143e-4111-9dbd-0f06f340bb83"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f4100a4c-90bc-465d-b0c8-f14f365e46c7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f4931982-df6e-4370-8708-be89734439be"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f4d31ecf-e23c-4231-bb9c-1b5e4b7f3ca8"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f53b5b50-942c-4c40-be7d-edf61f4b431c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f58efc04-9784-411f-8423-b635ef71d025"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f5c0a319-ec62-410a-b78a-dc228e5dc769"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f6048836-1275-4bd3-84ef-8633b2556a2b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f60dcf78-0a6f-4bae-ade7-107989188a76"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f63071ab-2be6-406a-bf28-608177be2b79"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f6d7280a-9cd2-46d8-9958-17c8ff434e86"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f6d7f107-8d60-47b7-b46e-1f6400963c8a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f71abd6e-38a3-4698-a71c-15733a9be1ec"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f803d79c-c569-478f-815d-0ee2f9d97fd6"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("f8d90403-bbd8-440a-a2db-10fba819ab17"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fa483ccb-48a5-447d-98a2-f6ad9aa75b3a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fb2503bf-18b7-4653-b0af-feb02e0a063c"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fb4107b2-4858-4ec8-b459-8f7973d0b3ef"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fb659ac3-5852-4d93-9141-45384ddf885f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fba58cbc-dd1b-42a9-9c83-c68028800c07"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fc3d295f-1aa5-4658-a4cc-1101b294b095"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fc6801cc-3e5c-416f-bf94-13b28dee2fdc"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fe304d40-73ca-42f2-b6a9-02f413c895ec"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("fe753d81-ee7e-45f5-8628-4548a86ae820"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: new Guid("ff189979-a020-4f2a-8353-cdd59442fb1d"));
        }
    }
}
