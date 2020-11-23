using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsbookAggregation.Migrations
{
    public partial class AddNflPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("e1bebd88-22cf-4047-9a5f-f1c4200ba798"), "Ben", "DiNucci" },
                    { new Guid("a1bbe6b7-af57-4f7f-ba6c-ba0d636d9192"), "Tee", "Higgins" },
                    { new Guid("e99e1470-ae92-42f5-9bc0-3ff3abcaac62"), "John", "Ross" },
                    { new Guid("32781c93-a124-4571-8c48-b13e8abc8c63"), "Auden", "Tate" },
                    { new Guid("6357da48-f6eb-4746-a550-e205f8890d94"), "Mike", "Thomas" },
                    { new Guid("731a8622-910f-4580-b15c-befec0604e6d"), "Cethan", "Carter" },
                    { new Guid("4ca04f2d-01d0-4d73-85d2-1aaca7f11daf"), "Drew", "Sample" },
                    { new Guid("b02c08ed-1022-4fb6-8214-22c5beb74adb"), "Mason", "Schreck" },
                    { new Guid("f63163ac-5fa4-487a-93ef-998763afd1c3"), "Hakeem", "Adeniji" },
                    { new Guid("00597953-6477-4162-94f5-f6b08defc25d"), "B.", "J. Finney	" },
                    { new Guid("9ad70e60-6c5e-40c0-9229-d16b865b8806"), "Bobby", "Hart" },
                    { new Guid("9f82678d-cac8-434f-942b-b7b2db2f8ef1"), "Trey", "Hopkins" },
                    { new Guid("c87939f4-0837-43e3-9800-aae1ff053521"), "Fred", "Johnson" },
                    { new Guid("4422ea1b-0245-45ae-8fd6-81dd6faf2a37"), "Michael", "Jordan" },
                    { new Guid("fcf4e831-2bd9-4bc3-8e55-9d520ddd8bba"), "Billy", "Price" },
                    { new Guid("781e6d7e-d343-4d7d-8306-a995e6f68e60"), "Alex", "Redmond" },
                    { new Guid("82639716-60f9-4668-a331-39f33b224a84"), "A.", "J. Green	" },
                    { new Guid("e63a78bf-02f7-481f-8349-b226c0f93b61"), "Alex", "Erickson" },
                    { new Guid("afca41d1-ee5e-48e2-b499-ba7679538848"), "Tyler", "Boyd" },
                    { new Guid("70c34502-3327-4cdc-ac7f-4208401738fd"), "Trayveon", "Williams" },
                    { new Guid("2bd70d3b-4386-4034-934b-ae383cab5993"), "Nate", "Hairston" },
                    { new Guid("cb0e44b4-ccf0-4763-b461-7215d27c2746"), "Will", "Holden" },
                    { new Guid("d7c442d9-f885-41d0-8ba0-83ca5ba40bce"), "Tyler", "Huntley" },
                    { new Guid("72eb173d-d8ab-4a13-bd3e-98724fa8d49d"), "Jaylon", "Moore" },
                    { new Guid("9cc4d748-6902-498a-8cd6-05b79defd292"), "Nick", "Moore" },
                    { new Guid("b334db4f-925a-44db-a0b6-91bae98db2b4"), "Chauncey", "Rivers" },
                    { new Guid("4d7b87ad-fed6-464f-b00e-5345f7c0f266"), "Geno", "Stone" },
                    { new Guid("d96698fb-b3c6-4feb-9b42-bba3c59a856a"), "Keaton", "Sutherland" },
                    { new Guid("4c2e23ea-3ee2-48b9-a565-eb7f1a6685a0"), "Nigel", "Warrior" },
                    { new Guid("22fc77dc-b37a-4bae-854e-08ff889a5a5c"), "Ty'Son", "Williams" },
                    { new Guid("83d4b574-4e99-4c20-9685-e8dd09a45b8b"), "Eli", "Wolf" },
                    { new Guid("91abe9ca-8882-4e5a-9c44-076544fe4112"), "Joe", "Burrow" },
                    { new Guid("06512ea6-a6c5-481d-a3a5-2a9cd4fedd85"), "Ryan", "Finley" },
                    { new Guid("c34ff5b6-eca0-4336-bc4d-270883d9d423"), "Giovani", "Bernard" },
                    { new Guid("fa37f76d-a84d-4098-a661-953f880700b0"), "Joe", "Mixon" },
                    { new Guid("4bf07e37-f994-4d88-b1a4-56bc4d1b16ef"), "Samaje", "Perine" },
                    { new Guid("5cb2bb95-0762-468b-bc32-aaeda7667cbf"), "Kristian", "Welch" },
                    { new Guid("7e6609d1-40f2-4969-afb9-1140747de4b3"), "Xavier", "Grimble" },
                    { new Guid("27c6bfb8-7363-4306-9ced-f42e8548d4ac"), "Jonah", "Williams" },
                    { new Guid("f250c918-7023-4753-a237-d6bfe19a1882"), "Amani", "Bledsoe" },
                    { new Guid("b151b79e-4901-497b-a08e-c5d4ff655fc9"), "Brandon", "Wilson" },
                    { new Guid("6db9c929-e0f2-4b10-b178-86f0decc6ddb"), "Randy", "Bullock" },
                    { new Guid("e8083851-a489-4210-9fa2-5e0ae1905c56"), "Clark", "Harris" },
                    { new Guid("d263e12a-0fc4-41cf-961b-4af0dac5c14d"), "Kevin", "Huber" },
                    { new Guid("e26fbb93-0c62-49b1-90e7-15028e4e7da2"), "Austin", "Seibert" },
                    { new Guid("64f5f8c6-3a57-45d0-9765-381e9ac434eb"), "Sam", "Hubbard" },
                    { new Guid("eb7c3665-9eb3-4866-a680-be659c9bc7bf"), "Isaiah", "Prince" },
                    { new Guid("a7971bb2-ce60-4084-935b-a039ba4972c1"), "D.", "J. Reader	" },
                    { new Guid("b43d604b-ca0f-4701-83c7-3e1efe8815f4"), "Xavier", "Su'a-Filo" },
                    { new Guid("c7818484-6a45-4e4c-bd4f-b3ba48088cda"), "Josh", "Tupou" },
                    { new Guid("1fa85acb-2d97-41a0-a80c-01ba2d9cd2b5"), "C.", "J. Uzomah	" },
                    { new Guid("26129beb-1132-4d09-bb48-34714b075672"), "Trae", "Waynes" },
                    { new Guid("7937b123-ff1c-4139-9714-d1b7b5ddd490"), "Renell", "Wren" },
                    { new Guid("4f5b77f7-4b28-4298-848a-1389237c3314"), "Freedom", "Akinmoladun" },
                    { new Guid("23413a2d-0f31-4989-8e27-026d2ffa3f72"), "Brandon", "Allen" },
                    { new Guid("c0eb365a-c88a-4ffc-ab6a-8ceaccfe2910"), "Shawn", "Williams" },
                    { new Guid("6a27590b-b03e-44f2-89f1-17defa65c28a"), "LeShaun", "Sims" },
                    { new Guid("26857d9d-c53c-4c27-be2e-ec5c735cd19c"), "Darius", "Phillips" },
                    { new Guid("74b8bf60-a049-407a-b31f-b469681ff7e7"), "William", "Jackson III	" },
                    { new Guid("159b8906-7892-470a-a4c2-391a2ecd7a2d"), "Christian", "Covington" },
                    { new Guid("02e49c08-62ed-4cfd-983b-3e713037124e"), "Mike", "Daniels" },
                    { new Guid("45be1a9f-8962-453e-8312-77d403c897a2"), "Margus", "Hunt" },
                    { new Guid("367cebdb-7918-4556-80be-d536fdec1b22"), "Khalid", "Kareem" },
                    { new Guid("0b9531bf-a8d2-4f23-9eef-954a2053e7eb"), "Carl", "Lawson" },
                    { new Guid("304b17c5-b594-4320-a865-9adb56537b77"), "Xavier", "Williams" },
                    { new Guid("6bd6f707-d41c-4fca-bba7-efd24bee8b7e"), "Markus", "Bailey" },
                    { new Guid("b09eee37-233b-4bfe-b27f-7f007f630163"), "Geno", "Atkins" },
                    { new Guid("a17b72b9-aa6b-4bfc-9c0a-a666adffdd13"), "Josh", "Bynes" },
                    { new Guid("7c5dd6b4-ffca-45dd-8b16-4be120d285c7"), "Jordan", "Evans" },
                    { new Guid("e3229b40-9775-4f81-80d3-fa722894014f"), "Germaine", "Pratt" },
                    { new Guid("887be17a-9273-4874-924a-0d359a048267"), "Logan", "Wilson" },
                    { new Guid("31cc1aeb-1763-4d80-96f5-476fe0f8895b"), "Mackensie", "Alexander" },
                    { new Guid("2fa4e910-5e84-459d-b9b3-d13b8ad266e2"), "Jessie", "Bates" },
                    { new Guid("51efc953-5719-4c44-9ac6-5c35630252a3"), "Vonn", "Bell" },
                    { new Guid("3aaf89dc-2526-4a16-b027-55afb5b9fa53"), "Tony", "Brown" },
                    { new Guid("c047523b-f35d-49f4-b5a4-e2b9fa77aa3b"), "Akeem", "Davis-Gaither" },
                    { new Guid("2bfde9ef-42bd-44c3-8b5a-6c600d93bfa0"), "Sean", "Culkin" },
                    { new Guid("ede5eba3-6790-4f74-8796-59325cc529dd"), "Aaron", "Crawford" },
                    { new Guid("612e5796-4080-4b79-8e8f-968e67044461"), "Dez", "Bryant" },
                    { new Guid("86b48d98-88f3-4d9e-9f3c-a8429788898a"), "Marquise", "Brown" },
                    { new Guid("e46917a1-1a35-4b21-8ee4-f9d615dc9dfd"), "Devin", "Duvernay" },
                    { new Guid("d0a0bba5-9faa-4304-9b27-a37b33e6369f"), "Chris", "Moore" },
                    { new Guid("f6827c9c-f4cb-4af1-840e-71c7572d345b"), "James", "Proche" },
                    { new Guid("db491426-bd23-4fa7-ba3c-e9ac0ba9bb33"), "Willie", "Snead" },
                    { new Guid("bf0e297a-a04f-4929-85e7-789c4ee4ccb8"), "Mark", "Andrews" },
                    { new Guid("6472ffc2-d035-4f05-8358-b359527430f6"), "Nick", "Boyle" },
                    { new Guid("1b79a8a9-64e9-46de-8651-9364d60d436c"), "Bradley", "Bozeman" },
                    { new Guid("0d7b9cc8-e6fb-40be-bc13-51566d6ffcdb"), "Ben", "Bredeson" },
                    { new Guid("b455dbb8-a404-4daf-9708-47c531bf610c"), "Orlando", "Brown Jr.T	" },
                    { new Guid("d35189e5-4b69-42c7-ac19-cd6c587a87ea"), "Trystan", "Colon-Castillo" },
                    { new Guid("919887eb-3c47-448f-8972-f85af2dc000f"), "D.", "J. Fluker	" },
                    { new Guid("f847f52a-dc80-4db5-b330-f59c49895274"), "Patrick", "Mekari" },
                    { new Guid("5a94f953-d802-43e0-845a-72ec1d4dcadd"), "Ben", "Powers" },
                    { new Guid("d63c47e0-09b7-455d-9157-778251054c73"), "Matt", "Skura" },
                    { new Guid("ce23e99c-bb2a-40eb-b458-a8d6c13b5556"), "Miles", "Boykin" },
                    { new Guid("9cbbb04b-4690-4764-8c31-f03a980ed3ea"), "Patrick", "Ricard" },
                    { new Guid("29837f4c-a3df-4dc6-abf3-5d7d6b9cf891"), "Mark", "Ingram Jr.	" },
                    { new Guid("8c328756-3d18-4d91-a89d-c55e94621fb3"), "Justice", "Hill" },
                    { new Guid("4f400028-cee9-4506-aef6-051a70c4b4ab"), "Blake", "Hance" },
                    { new Guid("1c94f6d1-90a3-4169-868b-076248cb3ad3"), "Bennett", "Jackson" },
                    { new Guid("5b568cec-0130-4388-944f-30b76b4a32c3"), "Bronson", "Kaufusi" },
                    { new Guid("fce05491-1586-48bb-b93a-4beeb0fa6a14"), "Corbin", "Kaufusi" },
                    { new Guid("81d9effa-1996-4aa4-ab49-1661875a7c09"), "Zane", "Lewis" },
                    { new Guid("1e5a952f-7d75-4f5d-8a99-4d7672a81df0"), "Josh", "Malone" },
                    { new Guid("20b4681b-6178-47d3-9ac9-8bd97349ec0d"), "D.", "J. Montgomery	" },
                    { new Guid("712e017d-0553-43ea-945a-f40af9fd9170"), "Calais", "Campbell" },
                    { new Guid("8df5a2c9-6a4f-4c14-942c-e88614761576"), "Jaleel", "Scott" },
                    { new Guid("3171f61c-d87c-4b7a-abdd-1c9ce57eaf70"), "Ross", "Travis" },
                    { new Guid("fca83cda-d39c-4c8b-bd4f-4a8999e9863c"), "Mike", "White" },
                    { new Guid("a94ce79f-29f3-4931-b56c-0ab06414333a"), "Robert", "Griffin III	" },
                    { new Guid("369f7164-9c72-41a6-bfe4-9151f7248c29"), "Lamar", "Jackson" },
                    { new Guid("5ba63ebd-3023-4027-8f4f-3f515cafe6a8"), "Trace", "McSorley" },
                    { new Guid("ec15c795-1284-4710-a508-c7a83f4c58a7"), "J.", "K. Dobbins	" },
                    { new Guid("d34b8ee1-c7c2-4578-be94-fdb97a7dd613"), "Gus", "Edwards" },
                    { new Guid("d73c6d6f-8caf-4311-a29d-ea27fd0ccd11"), "Tanzel", "Smart" },
                    { new Guid("e4616a58-21a7-4b94-9e2d-5cb5f774c5d4"), "Justin", "Ellis" },
                    { new Guid("b8813cb3-e5c6-4986-8c98-fcf8f4bc126f"), "Justin", "Madubuike" },
                    { new Guid("17bca71c-0984-4863-8263-ea48870b0079"), "Jihad", "Ward" },
                    { new Guid("4df412e0-81a0-44f3-8ce9-741bb10f0df9"), "Sam", "Koch" },
                    { new Guid("932db2d2-b6ce-45c5-815d-c6b239fa4f08"), "Justin", "Tucker" },
                    { new Guid("8811a6de-4de1-4ae5-9e03-d2cb8001ed7a"), "Otaro", "Alaka" },
                    { new Guid("16c174dd-a969-47bb-8f20-de26ee8e09fe"), "Anthony", "Averett" },
                    { new Guid("c01a65b9-a0f0-4522-be89-b02161db7850"), "Jake", "Breeland" },
                    { new Guid("f25f9287-791c-451a-a320-48ecec37989c"), "Marlon", "Humphrey" },
                    { new Guid("b6c60217-8cb5-435b-9d21-19e79d847feb"), "Iman", "Marshall" },
                    { new Guid("f873f3bb-7cf0-4d1e-9898-f3885f850a0f"), "Morgan", "Cox" },
                    { new Guid("f00da9b1-d340-4d84-a2e7-71546c204509"), "Tyre", "Phillips" },
                    { new Guid("2ac3f78f-8cd1-400e-bd63-edc0daf02dae"), "Ronnie", "Stanley" },
                    { new Guid("2306fade-76df-4efb-94c1-cce61ef94246"), "De'Anthony", "Thomas" },
                    { new Guid("7d2584eb-ea45-472e-8d47-26fc3e13d7b7"), "Antoine", "Wesley" },
                    { new Guid("6f260854-dc34-4533-8125-f14e453d9c3e"), "DeAndrew", "White" },
                    { new Guid("fae8a477-1ce0-477c-bb65-e9862474ffec"), "Tavon", "Young" },
                    { new Guid("7fbe5dcb-c381-4d41-8d1e-98ed564ce053"), "Aaron", "Adeoye" },
                    { new Guid("f9f1f175-bb86-44d9-b43d-adc197aba95b"), "Terrell", "Bonds" },
                    { new Guid("0f7c1720-f5a9-4d68-8f5a-36ebf140c71c"), "Andre", "Smith" },
                    { new Guid("766733f9-b626-49fc-bc74-1e2a630a687c"), "Andrew", "Brown" },
                    { new Guid("c2efad17-5c5d-4de4-a85c-c42be7802f2d"), "Jimmy", "Smith" },
                    { new Guid("bf5ad3b9-6bdd-46b6-bcd9-b09e06cb99b2"), "Marcus", "Peters" },
                    { new Guid("e1cf96da-054c-4dba-98ff-d32c89d84a94"), "Broderick", "Washington Jr.	" },
                    { new Guid("1c2b0328-54f6-4431-8e63-e3ecdabc16f9"), "Brandon", "Williams" },
                    { new Guid("dc13bbc7-b73c-4e4d-97e8-8a4d9c2e57a2"), "Derek", "Wolfe" },
                    { new Guid("a3f911e4-d507-49e8-a5f6-72c4a8599aae"), "Chris", "Board" },
                    { new Guid("3cc9172c-b22d-40d3-b464-91e901a94204"), "Tyus", "Bowser" },
                    { new Guid("03ccaf05-a4ed-4999-864b-5e71f5f9836d"), "Jaylon", "Ferguson" },
                    { new Guid("cac74485-8aed-445b-b699-834c2e2212ed"), "L.", "J. Fort	" },
                    { new Guid("639b7803-f3a2-41c9-b9b1-d58ea741e2da"), "Jordan", "Richards" },
                    { new Guid("03394028-aa86-4e61-a1ca-79e3defb67c4"), "Malik", "Harrison" },
                    { new Guid("1aa5809d-6ad7-4ff7-a442-2567c9956d35"), "Pernell", "McPhee" },
                    { new Guid("a9d9390d-8e81-4a90-beeb-dc0727a4d625"), "Yannick", "Ngakoue" },
                    { new Guid("c0a0c79c-08b9-4c2a-a5fb-7238a88e9120"), "Patrick", "Queen" },
                    { new Guid("dc3e8557-8bcb-4ec3-9430-83e4cf3024b4"), "Chuck", "Clark" },
                    { new Guid("f3d968ac-accb-415c-95c6-63cbd64e7bb9"), "Khalil", "Dorsey" },
                    { new Guid("800a099b-18cd-4a38-a6f3-573ca7a1207a"), "DeShon", "Elliott" },
                    { new Guid("76b052b7-2778-4b8e-bc5d-4f966a21c777"), "Anthony", "Levine" },
                    { new Guid("14f70e31-0172-4a46-8a2f-9cfd0c9161d3"), "Matthew", "Judon" },
                    { new Guid("fba73656-b137-4a7a-94e0-6418545d1ff0"), "Shaq", "Calhoun" },
                    { new Guid("fe87bdde-bdcd-4a82-844d-fc9bc13857c8"), "Jalen", "Davis" },
                    { new Guid("616295ba-c53c-40e5-bb47-c7763551e56a"), "Kendall", "Donnerson" },
                    { new Guid("bcf48e23-405d-4ea6-bde2-a2cb7e6f9361"), "Anthony", "McFarland Jr.	" },
                    { new Guid("18772e3e-0d95-4845-a971-55134995ca69"), "Jaylen", "Samuels" },
                    { new Guid("5d7e29a0-a05c-459f-943a-8fd9d237b77f"), "Benny", "Snell" },
                    { new Guid("b82f5ceb-494e-494b-a866-4c05bc586139"), "Derek", "Watt" },
                    { new Guid("052c9daa-8b9e-469f-9969-782f473a2811"), "Chase", "Claypool" },
                    { new Guid("b414d14d-dedf-4638-ac40-f614be044daa"), "Diontae", "Johnson" },
                    { new Guid("95bdd71b-208b-43a0-b29e-9950911a4cd4"), "Ray", "McCloud" },
                    { new Guid("e6bde487-67c4-4682-8ffa-934c62f380e7"), "JuJu", "Smith-Schuster" },
                    { new Guid("78905f13-ed3d-4c4d-a1b0-5a504bf61662"), "James", "Washington" },
                    { new Guid("1330b19f-802c-491c-90c8-f2c97d41d5c2"), "Eric", "Ebron" },
                    { new Guid("7179998c-4d02-41f1-921b-2f623ed3fe97"), "Zach", "Gentry" },
                    { new Guid("807ead3c-cffb-4410-9c34-296440c93804"), "Vance", "McDonald" },
                    { new Guid("5f440bc8-f7d3-42f6-ae1e-184f7dad8be4"), "David", "DeCastro" },
                    { new Guid("df0b7e85-f8b2-417f-a5a6-13934740f788"), "Kevin", "Dotson" },
                    { new Guid("55359a08-1ceb-4f1c-bfbd-a14c1ba80da3"), "Matt", "Feiler" },
                    { new Guid("025a661d-79f9-40bc-930b-ad12a3b6cace"), "Trey", "Edmunds" },
                    { new Guid("a552f2eb-1416-42fa-b41b-d1396f551e81"), "James", "Conner" },
                    { new Guid("5fae93af-6b1b-456f-b522-916ae2c74202"), "Mason", "Rudolph" },
                    { new Guid("e94994fa-68ae-49a6-afef-b1b70479d96c"), "Ben", "Roethlisberger" },
                    { new Guid("41a6d627-de3d-45e7-9272-7d177b16809d"), "Ja'Marcus", "Bradley" },
                    { new Guid("609dd626-2706-474b-855a-5d801140bf89"), "Michael", "Dunn" },
                    { new Guid("50a1eee2-b942-4cad-8a7e-2c291e59d365"), "Jordan", "Franks" },
                    { new Guid("c5fb09bd-01c0-4e46-9df8-3da6e342fdd8"), "A.", "J. Green	" },
                    { new Guid("1687ffe0-34e7-4186-87dc-e8d81fc2868a"), "Joey", "Ivie" },
                    { new Guid("0f13d6d0-b9d9-4688-97fd-bfd0385b30ae"), "John", "Kelly" },
                    { new Guid("55acaebe-a194-4544-81d5-996ff2681a6c"), "Kyle", "Lauletta" },
                    { new Guid("6885afe6-bb0e-4be9-94cb-831b679d20a1"), "Derwin", "Gray" },
                    { new Guid("32cbff25-1b6e-4981-bf81-8d81b84cdf90"), "Cameron", "Malveaux" },
                    { new Guid("dd581e28-d2d8-4eb3-bb24-de499b4b9102"), "Montrel", "Meander" },
                    { new Guid("5c67a64b-06be-4766-b2e6-4eee7d756086"), "Timon", "Parris" },
                    { new Guid("629bbc91-c771-4044-b397-f6b29c85dad1"), "Prince", "Smith" },
                    { new Guid("e63459f2-ec12-4502-a0e6-f88f9ace8508"), "Johnny", "Stanton" },
                    { new Guid("63fe347e-f49a-485c-ac6a-8ac774e6eff4"), "Ryan", "Switzer" },
                    { new Guid("051f791e-f303-4b75-b9e6-f0f925e9af22"), "Alex", "Taylor" },
                    { new Guid("b3a24793-ac43-4f2d-96f5-8302eb2d53f4"), "Joshua", "Dobbs" },
                    { new Guid("3535da52-08a5-42c3-9bb9-0541a0a52b65"), "Matt", "McCrane" },
                    { new Guid("ccea9df4-977c-429b-8fe3-1fa619cb8389"), "J.", "C. Hassenauer	" },
                    { new Guid("e827f6d0-3fe2-4bb6-a9ca-f7a5edaeccee"), "Jerald", "Hawkins" },
                    { new Guid("d9c240a9-dac9-47e0-aeed-9f438fbe85d7"), "Chukwuma", "Okorafor" },
                    { new Guid("ea3a5144-cb97-456c-bdc5-51821ba905ff"), "Minkah", "Fitzpatrick" },
                    { new Guid("488369b9-531d-4f2e-93c7-d603a586d6f8"), "Joe", "Haden" },
                    { new Guid("fcd25da8-04b3-4c5a-9a76-39ceec9d4845"), "Mike", "Hilton" },
                    { new Guid("289543d0-c0bc-4320-a056-7e7f7ef1d625"), "Justin", "Layne" },
                    { new Guid("59f0667b-b65f-45ec-93c5-2fe1940a2049"), "Steven", "Nelson" },
                    { new Guid("c10b535a-2d9a-4f27-8524-547f2e164a31"), "James", "Pierre" },
                    { new Guid("9077383e-581d-4cda-bdb9-e4e6689b9a95"), "Cameron", "Sutton" },
                    { new Guid("4b3a3b89-8ab8-4aff-b6ba-16a477ff8f69"), "Terrell", "Edmunds" },
                    { new Guid("acf6b72d-e6b2-4aa2-9336-45daf221c970"), "Jordan", "Berry" },
                    { new Guid("c05abaec-faba-41a2-ab6a-998f173cc9ad"), "Kameron", "Canaday" },
                    { new Guid("eacc176d-0e01-4379-b009-0c3f5d634571"), "Zach", "Banner" },
                    { new Guid("af91b65f-d6a0-4e28-a63e-2993e3554ea9"), "Devin", "Bush Jr.	" },
                    { new Guid("f2ddefb5-05f7-4b0a-8ab9-657aadeb5512"), "Ulysees", "Gilbert IIII	" },
                    { new Guid("6e360a89-9b9d-459f-aa4c-19b31fbc64d7"), "Chris", "Wormley" },
                    { new Guid("a7a3abf9-946d-4691-bdb0-3c03e32a3073"), "John", "Battle" },
                    { new Guid("f0415d9a-a440-4a7c-b470-1e4953536acd"), "Antoine", "Brooks" },
                    { new Guid("33429b30-c79b-4a68-823b-215ab672139e"), "Chris", "Boswell" },
                    { new Guid("1b70e392-c67d-4d4c-86b5-9baccf32ad62"), "Elijah", "Benton" },
                    { new Guid("7b51355b-081d-4688-a6fd-69bcfbb307a6"), "Sean", "Davis" },
                    { new Guid("f143441d-bc70-4f58-a85f-3e1ed8849494"), "Avery", "Williamson" },
                    { new Guid("29b54c3c-415f-4911-80b0-4b1602444550"), "Maurkice", "Pouncey" },
                    { new Guid("e1fbd3cf-b1d1-4181-9808-07d381fb7363"), "Alejandro", "Villanueva" },
                    { new Guid("51c3aa4e-74f9-4aca-bab3-4cb139ffcace"), "Stefen", "Wisniewski" },
                    { new Guid("dd5fc73f-a1e9-41ec-8bd7-a2e998a0058c"), "Tyson", "Alualu" },
                    { new Guid("b4b4eb74-301f-4a53-ab5f-9781405410f8"), "Isaiah", "Buggs" },
                    { new Guid("ab15e1e9-29cf-499b-a14e-bf73b5de6b1d"), "Carlos", "Davis" },
                    { new Guid("9ce44592-d064-4851-bc69-6d066a991389"), "Cameron", "Heyward" },
                    { new Guid("c9d6420e-b4c6-4f17-bba0-c7ec02411921"), "Jordan", "Dangerfield" },
                    { new Guid("504cfc20-cb57-4aa4-a7ba-171dbc396975"), "Henry", "Mondeaux" },
                    { new Guid("bc9e1cb8-3b23-4563-ab18-dd5fafd36601"), "Olasunkanmi", "Adeniyi" },
                    { new Guid("9d01da8a-30de-4a72-be5a-e1519d7eaa97"), "Marcus", "Allen" },
                    { new Guid("3ac3eaab-cb29-4871-b4bc-7be5080dda74"), "Bud", "Dupree" },
                    { new Guid("2a8dd67c-f4e2-49c0-929a-fa09908a07a2"), "Alex", "Highsmith" },
                    { new Guid("fb372fa4-ce00-4063-9963-badaf93a443d"), "Robert", "Spillane" },
                    { new Guid("5755634b-018e-4489-b231-5472e3e5238a"), "T.", "J. Watt	" },
                    { new Guid("5c97a667-c237-4b11-ad83-07727fab622b"), "Vince", "Williams" },
                    { new Guid("2c09f0bf-43ca-4e8b-98b0-df397902cca0"), "Stephon", "Tuitt" },
                    { new Guid("a87cd9a7-2d06-4ed4-9d17-a9be8bd124ea"), "Bryce", "Hager" },
                    { new Guid("945bbf0c-4a9b-4322-9c94-a1dab1a4cbfc"), "Trevon", "Young" },
                    { new Guid("9f3e6626-c161-4829-9d65-4da8943028d2"), "Curtis", "Weaver" },
                    { new Guid("4e54ae5e-8d08-4aa5-ab81-e9f87e381a2c"), "Donovan", "Peoples-Jones" },
                    { new Guid("85beff14-afde-429c-a4c4-3d31978c8f18"), "Taywan", "Taylor" },
                    { new Guid("46866023-93ec-4c85-9c21-42ff8059abee"), "Harrison", "Bryant" },
                    { new Guid("64b50162-1891-4f19-a0f6-1c9d14ae0c28"), "Stephen", "Carlson" },
                    { new Guid("2760da8f-4794-422c-84c2-1affefaa4291"), "Austin", "Hooper" },
                    { new Guid("72904567-185a-4696-bc9e-d96f7f518d2f"), "David", "Njoku" },
                    { new Guid("880793f3-f7ce-4ac3-8312-398989f80cff"), "Joel", "Bitonio" },
                    { new Guid("4850ff50-0717-4bac-b621-2243ef4d6c92"), "Evan", "Brown" },
                    { new Guid("ca1fbf01-8940-4437-93f7-98be96e70051"), "Jack", "Conklin" },
                    { new Guid("f725790d-4f0c-48ca-ab3d-5770eb3ad05b"), "Nick", "Harris" },
                    { new Guid("ef5d2672-3a15-4bd9-ba3a-b6c196e2ef29"), "Chris", "Hubbard" },
                    { new Guid("ddf801d2-ed69-4660-b2b5-b30dea13b8c6"), "Kendall", "Lamm" },
                    { new Guid("db6ee2b3-7c1f-4c54-a435-ef992a115bb8"), "Wyatt", "Teller" },
                    { new Guid("7d09e25a-7eaf-4778-804e-91953f89e22c"), "J.", "C. Tretter	" },
                    { new Guid("894d6e3e-5fb2-4fce-a4db-5d04162980f9"), "Jedrick", "Wills" },
                    { new Guid("7212df9f-2d4a-4ff8-b19f-2c9cf646132a"), "Jarvis", "Landry" },
                    { new Guid("4844e877-6060-4081-917b-e4ca27720638"), "KhaDarel", "Hodge" },
                    { new Guid("58405e79-4ae5-4357-87f3-6d2559d5c1a1"), "Rashard", "Higgins" },
                    { new Guid("3c916a03-48a1-41e8-88a3-1bc5e6e1c369"), "D'Ernest", "Johnson" },
                    { new Guid("99f5074b-f88c-46df-ac7b-0e5048a2b2e0"), "Trenton", "Irwin" },
                    { new Guid("aa5c050a-166e-4cc8-a328-fe337d9445a6"), "Trayvon", "Henderson" },
                    { new Guid("1cd2d302-2b9b-4120-b506-2ff1800c95ce"), "Keandre", "Jones" },
                    { new Guid("9f07a59a-eedd-467a-acee-1c6cc7fb42c3"), "Kahlil", "McKenzie" },
                    { new Guid("861ea605-9cea-413b-aa95-b52ce11e825a"), "Torry", "McTyer" },
                    { new Guid("4f73cd28-01f7-4336-8eeb-4a265dfc1c2e"), "Stanley", "Morgan Jr.	" },
                    { new Guid("1516f8ca-0394-4e07-a0bd-8f7af48a1b55"), "Jacques", "Patrick" },
                    { new Guid("8fd84ea5-2bd9-4294-a6a6-58cc59b6a01c"), "Adrian", "Clayborn" },
                    { new Guid("39197659-aafc-4e59-b06b-8ff1a37824a2"), "Winston", "Rose" },
                    { new Guid("0696680d-63e2-4ed9-85f1-410b2cbc69f2"), "Scotty", "Washington" },
                    { new Guid("d1736f9c-4a3f-4b91-afbb-31ec7fd4428e"), "Mitchell", "Wilcox" },
                    { new Guid("f919ae0b-ed1d-4c00-8742-4c17bcba60c8"), "Case", "Keenum" },
                    { new Guid("069220b2-ea2f-4e9f-a7e6-5db8a2f335da"), "Baker", "Mayfield" },
                    { new Guid("37b8241b-dfcc-4574-854b-9f380d6d2780"), "Dontrell", "Hilliard" },
                    { new Guid("a9db729a-7c34-45cc-a056-72ac23d2e1b1"), "Kareem", "Hunt" },
                    { new Guid("6ede238c-5d1b-4b0b-911f-631f02564766"), "Andy", "Janovich" },
                    { new Guid("06d05ebf-955f-43f2-9d38-d1807f7ec85d"), "Quinton", "Spain" },
                    { new Guid("e9a11d92-7b0d-413f-8c1b-5affdf19a25f"), "Jordan", "Elliott" },
                    { new Guid("f1a4edc2-9b10-40d9-acb8-374aa603a756"), "Myles", "Garrett" },
                    { new Guid("b9bf97c2-ec4a-46c0-a26e-cf6ea4e7eb39"), "Porter", "Gustin" },
                    { new Guid("996c1c65-bb6c-4ad6-909f-4f59db516bc7"), "M.", "J. Stewart	" },
                    { new Guid("f82d9446-2e82-4477-998d-300922a69691"), "Tavierre", "Thomas" },
                    { new Guid("fc4ac7a5-159b-4aec-97ef-7eab7eb27fbb"), "Denzel", "Ward" },
                    { new Guid("2c270a6c-be40-4956-a702-650f14adb918"), "Jamie", "Gillan" },
                    { new Guid("3b891bb3-a739-459f-9389-f0fb0e2d1983"), "Charley", "Hughlett" },
                    { new Guid("15a19300-daac-4794-8630-3e4c3646b6a5"), "Cody", "Parkey" },
                    { new Guid("978bb326-1519-4f72-b276-2ab298575d41"), "Odell", "Beckham Jr.	" },
                    { new Guid("d850a63d-25ad-4e25-9be7-a1bf59019f72"), "Andrew", "Sendejo" },
                    { new Guid("75c54823-912f-4864-961b-d334e2813268"), "Andrew", "Billings" },
                    { new Guid("ffc23aef-59a0-44e1-9165-6a9cd1c5008f"), "Grant", "Delpit" },
                    { new Guid("c83bfb96-4a1f-456f-b88d-e45e3869367d"), "Drake", "Dorbeck" },
                    { new Guid("61c7ebb4-fb44-4ebb-9c8d-ffc143ed856f"), "Drew", "Forbes" },
                    { new Guid("a04a5a88-13d2-4f1e-ba7c-4c8563d58f51"), "Colby", "Gossett" },
                    { new Guid("f1dd44cf-804d-4445-9656-192aa282f73e"), "JoJo", "Natson" },
                    { new Guid("2362e2bc-15e0-42b4-85c8-f3cd13fb89bd"), "George", "Obinna" },
                    { new Guid("708a8322-5002-43c0-aea7-c569b67e66fb"), "Malcolm", "Pridgeon" },
                    { new Guid("ccea27e8-fae3-41f0-9685-324b051a9eb5"), "Nick", "Chubb" },
                    { new Guid("f5c22fad-f5ca-4a77-b8aa-f561567bf6d9"), "Greedy", "Williams" },
                    { new Guid("ef3ee613-bd73-4eca-bb2b-a6a0bf1e739d"), "Sheldrick", "Redwine" },
                    { new Guid("1d4ce6f0-9122-4482-93bf-4f649bb48010"), "Terrance", "Mitchell" },
                    { new Guid("ae9d9779-263c-42cd-b1d9-77c8e25e09ca"), "Joe", "Jackson" },
                    { new Guid("4d3b4061-3f38-4349-ad06-7592b98f3e30"), "Larry", "Ogunjobi" },
                    { new Guid("17a806c6-97f2-4289-a870-75c3eaca2520"), "Sheldon", "Richardson" },
                    { new Guid("192612a5-4975-4d01-a7b0-3e9e723e7a2b"), "Vincent", "Taylor" },
                    { new Guid("41c30755-558d-4a9b-aeee-5bd721bd7f0a"), "Olivier", "Vernon" },
                    { new Guid("258d4180-6e32-4b2d-b674-d5d5e13fc489"), "Tae", "Davis" },
                    { new Guid("8c5e473f-0dae-434b-8e32-5464d28954f6"), "B.", "J. Goodson	" },
                    { new Guid("5988d88c-29a0-4748-8a96-cc365f378a63"), "Jovante", "Moffatt" },
                    { new Guid("0ca5c1cf-afe9-488f-95a2-afaea5ced2b1"), "Elijah", "Lee" },
                    { new Guid("2e9088e1-43ca-4a32-b8e3-fef10aae8c62"), "Malcolm", "Smith" },
                    { new Guid("8a071b2b-9763-40c7-bb03-41947b7cc223"), "Sione", "Takitaki" },
                    { new Guid("c2142ceb-cb3f-42e8-aa6d-0425889759df"), "Mack", "Wilson" },
                    { new Guid("7ac04186-06ff-4872-a486-aef584513243"), "Ronnie", "Harrison" },
                    { new Guid("17e37f93-9091-4030-baf6-e60fddb670b3"), "Robert", "Jackson" },
                    { new Guid("99486ad8-4284-4aa9-92b0-56ad3c5c6549"), "Kevin", "Johnson" },
                    { new Guid("280bfc1a-d64b-4dd3-b900-a0757a2855b4"), "Karl", "Joseph" },
                    { new Guid("1926ab71-5513-4320-b0f8-7661627f7c27"), "Jacob", "Phillips" },
                    { new Guid("69a20be7-2788-45e9-a3b1-82012832e633"), "Noah", "Dawkins" },
                    { new Guid("ed8ab713-7f6a-48bb-9d04-6953e6bf6eef"), "Lawrence", "Cager" },
                    { new Guid("0d7cf538-2b5c-464f-8fc4-9d54d7a6b287"), "Josh", "Adams" },
                    { new Guid("bf342c6b-2df4-4912-9adf-837aedcc416f"), "Mike", "Gesicki" },
                    { new Guid("4a38e059-b05a-41d7-bea5-b6a6c3b09d2c"), "Adam", "Shaheen" },
                    { new Guid("498bb4f5-16fa-4e27-b7e5-5a78b0a4fee0"), "Durham", "Smythe" },
                    { new Guid("3a3ca7dc-6a13-4c4e-a55a-9b8c172a1282"), "Julién", "Davenport" },
                    { new Guid("f3d7c64c-efaf-47fb-8d98-398bc61923c0"), "Jesse", "Davis" },
                    { new Guid("bcb0a7c6-9bf0-4183-92dd-335fdc95484e"), "Michael", "Deiter" },
                    { new Guid("d01bd535-02d3-4bc4-a5ef-16494e769b53"), "Ereck", "Flowers" },
                    { new Guid("04974c3d-80bd-4be2-8a76-64154248c660"), "Robert", "Hunt" },
                    { new Guid("49d46aec-9cce-46f1-b058-b4eeb7b49ec5"), "Solomon", "Kindley" },
                    { new Guid("6059fce0-19cb-4ae9-93d4-45dd23028258"), "Ted", "Karras" },
                    { new Guid("dcfa17fe-01e9-47ee-98d1-e054953cccf2"), "Adam", "Pankey" },
                    { new Guid("8665dfc9-fc43-4835-bc6d-6aae7695598b"), "Raekwon", "Davis" },
                    { new Guid("fa195091-d311-4d53-88c4-9fab4101e8e4"), "Emmanuel", "Ogbah" },
                    { new Guid("9ec738c9-1258-4b88-a550-9c683a78d08b"), "Zach", "Sieler" },
                    { new Guid("c29c72e4-17e3-4fc7-bbab-4663137441aa"), "Jason", "Strowbridge" },
                    { new Guid("22f7f325-adf2-4363-a6ca-23d6893c5c73"), "Preston", "Williams" },
                    { new Guid("75dcfd87-afa6-40fd-9f4d-08507171f8ed"), "Malcolm", "Perry" },
                    { new Guid("2c9c55ab-7c24-49bb-9fda-21b7a7c83ffc"), "DeVante", "Parker" },
                    { new Guid("e81d626c-6cac-452e-937b-825dffa5b2cb"), "Mack", "Hollins" },
                    { new Guid("2943013a-d4ac-4062-8e7c-1c4fad921427"), "Christian", "Wade" },
                    { new Guid("b4ebcd22-a423-4a5e-a186-3a45bdd7ced8"), "Davis", "Webb" },
                    { new Guid("d5faa029-b848-4bdc-857c-178468559218"), "Antonio", "Williams" },
                    { new Guid("3e1e943e-b30c-48b2-8c8c-f0badb84eae4"), "Duke", "Williams" },
                    { new Guid("5e97876e-2c93-4ce1-84f9-147bfe123573"), "Daryl", "Worley" },
                    { new Guid("e368e5a0-9264-4bf6-a278-efa5f71e9da7"), "Ryan", "Fitzpatrick" },
                    { new Guid("5d04e82d-d864-4be3-8baf-081068c32861"), "Tua", "Tagovailoa" },
                    { new Guid("5e8490ed-1507-4621-85ae-380fbd3f9068"), "Christian", "Wilkins" },
                    { new Guid("b369c7bb-b414-4ea3-a399-74c6c100763c"), "Salvon", "Ahmed" },
                    { new Guid("656b1115-f152-4879-b9c3-0449cca9c57b"), "Chandler", "Cox" },
                    { new Guid("9062ed48-ac45-48f9-a41d-0f2ab6ce876c"), "Myles", "Gaskin" },
                    { new Guid("9f3b0ae4-becd-4cec-86cf-7646579b1a7f"), "Jordan", "Howard" },
                    { new Guid("71395053-19ec-4859-8dab-01f42361d86a"), "Patrick", "Laird" },
                    { new Guid("c9ffeb1f-3ae4-457f-bedc-15b6d1adaa6d"), "DeAndré", "Washington" },
                    { new Guid("63c93967-4ab0-44ad-b945-03b00ee7877b"), "Lynn", "Bowden" },
                    { new Guid("307ab349-5d48-45e9-811a-119a73d44c81"), "Jakeem", "Grant" },
                    { new Guid("052972bf-78cb-4b9f-b472-84c7cdd45ff5"), "Matt", "Breida" },
                    { new Guid("b40a5bff-9d73-4a16-a4ac-54b41449bce2"), "Jerome", "Baker" },
                    { new Guid("4be59e21-ec9f-47a1-9b5b-ba28a8478efd"), "Samuel", "Eguavoen" },
                    { new Guid("dafd7450-4120-4b07-9aef-b4e805715cb7"), "Kamu", "Grugier-Hill" },
                    { new Guid("1d5041f8-d94c-4d54-adac-faeae19c5bbb"), "Davon", "Godchaux" },
                    { new Guid("8af04c69-a01b-40fa-89c6-19c52e9fa12e"), "Allen", "Hurns" },
                    { new Guid("cd551efd-ba7a-475d-abff-8f4a0a27ba73"), "Jonathan", "Ledbetter" },
                    { new Guid("ac754c89-a8f1-4ae1-9138-b14c006568bd"), "Albert", "Wilson" },
                    { new Guid("50052cae-357b-4fc3-8bf0-d7009f55271d"), "Antonio", "Callaway" },
                    { new Guid("c1e1e180-4081-49c6-a09b-7f6b903bd977"), "Nick", "Coe" },
                    { new Guid("a636abc4-d739-4c4e-bdf9-624650864dc2"), "Brian", "Cole" },
                    { new Guid("4be5ed79-6a40-48d9-87de-525ac06c0fad"), "Vince", "Biegel" },
                    { new Guid("5b1dd940-9be6-4b09-a5c6-008d5b9f6f82"), "Matt", "Cole" },
                    { new Guid("85dafa16-3262-4873-a686-c9ae81152bfc"), "Tino", "Ellis" },
                    { new Guid("0dbd3cfe-4a80-4b81-8ba6-076fb768dd76"), "Tyler", "Gauthier" },
                    { new Guid("410a266d-74c8-4b04-bbd3-3a7c66135f5c"), "Tae", "Hayes" },
                    { new Guid("ab881637-e91c-4000-8ef7-ce7e31e6dc8b"), "Nate", "Holley" },
                    { new Guid("2ef4a61b-cf4e-409a-82fe-6362be4eece2"), "Jonathan", "Hubbard" },
                    { new Guid("d2c8db20-41e3-422c-81c9-3db2a50075fa"), "Kylan", "Johnson" },
                    { new Guid("385b8c93-bf76-4fd4-af44-e53008d2a1f3"), "Benito", "Jones" },
                    { new Guid("08d4e328-b24d-4ae0-bb9d-aecc465a51f1"), "Javaris", "Davis" },
                    { new Guid("6fe0f087-6baf-431c-ba4b-f9802664e697"), "Josh", "Thomas" },
                    { new Guid("f9e0f7a4-e630-4a1f-ae94-88a0b153cf07"), "Austin", "Jackson" },
                    { new Guid("71f079e2-78ed-4cf0-acfd-401d7746bf2d"), "Matt", "Haack" },
                    { new Guid("1c75ad82-0833-4cca-89b9-16590b2a4ee5"), "Shaq", "Lawson" },
                    { new Guid("0e63704e-169b-4f44-aa59-3f19838ead69"), "Calvin", "Munson" },
                    { new Guid("6cc19ae9-27da-4149-8e8c-1983c0ca987b"), "Elandon", "Roberts" },
                    { new Guid("f264916a-06c7-44a5-b67b-38e06751f382"), "Andrew", "Van Ginke	" },
                    { new Guid("200151ed-5c9a-46f2-98e8-3f78f1adffce"), "Kyle", "Van Noy	" },
                    { new Guid("2bc773e6-895e-439c-9260-3a7de5dd3761"), "Clayton", "Fejedelem" },
                    { new Guid("9370e93f-c311-46d7-8c3a-ce5b89ba9c05"), "Kavon", "Frazier" },
                    { new Guid("20a42ab4-d334-4a39-9322-7438b97c9e73"), "Jason", "Sanders" },
                    { new Guid("9e66098c-3ead-4f64-8a38-ac5db0b90260"), "Xavien", "Howard" },
                    { new Guid("61f8bff5-0e8a-445f-817c-462512027e79"), "Brandon", "Jones" },
                    { new Guid("b485c765-ccca-4d23-9f8c-d045611a1b0d"), "Byron", "Jones" },
                    { new Guid("48df5e3d-b831-4441-b41e-22ed9475de83"), "Bobby", "McCain" },
                    { new Guid("4a3402c2-a4c8-49b0-ad38-21d9cfc790e1"), "Nik", "Needham" },
                    { new Guid("0b7d52ef-d887-442f-b56e-7a0036999bf8"), "Jamal", "Perry" },
                    { new Guid("02fda7f0-395d-46ab-951f-c8f9f9e77ea2"), "Eric", "Rowe" },
                    { new Guid("3d8ae12d-f8d4-45c0-ad72-117f26754cc5"), "Blake", "Ferguson" },
                    { new Guid("9f941614-c246-40e9-aad7-df654eb7e59b"), "Noah", "Igbinoghene" },
                    { new Guid("af69ba19-d8b8-4e08-9333-bf54644dd8d8"), "Kirk", "Merritt" },
                    { new Guid("9f0a38dd-dfa6-4bfe-960b-0c72dfaf6091"), "Mike", "Love" },
                    { new Guid("6ece0883-7694-4419-b1a2-fe6bb8586309"), "Deon", "Lacey" },
                    { new Guid("4f3e726d-1b40-42a4-8840-f7801ff59158"), "Reggie", "Gilliam" },
                    { new Guid("1f11d13d-9eea-42e3-a399-7041f2009986"), "Tyler", "Kroft" },
                    { new Guid("fea7c4ce-8e3f-47ad-8637-97a128c0d40f"), "Lee", "Smith" },
                    { new Guid("d632de6f-2ae0-40d8-968a-e28066eefe89"), "Ryan", "Bates" },
                    { new Guid("d5be58ff-f6fd-422c-bb3b-7b58595a39e0"), "Ike", "Boettger" },
                    { new Guid("f54f9f2a-8c12-431b-8a27-f03d90644756"), "Dion", "Dawkins" },
                    { new Guid("470dc025-4192-466c-95c1-fe95032eaa64"), "Jon", "Feliciano" },
                    { new Guid("48944a31-5ed5-48ae-876a-87966596fa45"), "Cody", "Ford" },
                    { new Guid("886f5986-09fe-4664-9787-744669e51520"), "Mitch", "Morse" },
                    { new Guid("7d26a2fa-72d8-4457-a266-7a08faee451d"), "Ty", "Nsekhe" },
                    { new Guid("adadcd5e-3747-46c7-9f58-45e295e6e5be"), "Daryl", "Williams" },
                    { new Guid("d3907792-c7c0-4af1-89ef-061ba635301c"), "Brian", "Winters" },
                    { new Guid("76b2cf83-292a-4106-bfab-0ea46afb0271"), "Mario", "Addison" },
                    { new Guid("e7c85143-4736-4093-b6e5-ee73134293b5"), "Vernon", "Butler" },
                    { new Guid("1497ec48-737e-4b9b-ae78-dc1ce534947b"), "A.", "J. Epenesa	" },
                    { new Guid("abf9816a-e6ae-471f-b95c-a54b23ebe999"), "Andre", "Roberts" },
                    { new Guid("2ccaa608-9e05-4b6c-aae8-cd134ae11ae3"), "Isaiah", "McKenzie" },
                    { new Guid("da6f97c6-3980-4e4c-94db-0c132acc884d"), "Stefon", "Diggs" },
                    { new Guid("261e2afc-0c31-4fb0-9f91-2e890151dcd3"), "Gabriel", "Davis" },
                    { new Guid("3ce78a23-3bdb-4e95-b13d-e0362426524a"), "Cedrick", "Lattimore" },
                    { new Guid("e774ccd0-5178-4d1d-aaa7-b2fdce6f81e9"), "Tyler", "Mabry" },
                    { new Guid("0a2be22c-18ca-48d7-84b8-d1406256d754"), "Jayson", "Stanley" },
                    { new Guid("b4ccb57b-f35c-480d-a23c-7dc3bbe4554a"), "Stephen", "Sullivan" },
                    { new Guid("4737cd4e-aa5c-4521-a8a2-2c357c901dd6"), "Cody", "Thompson" },
                    { new Guid("740c80f9-6ea0-4d74-8817-3b94785f85a5"), "John", "Ursua" },
                    { new Guid("536b4b44-615f-4cdf-983c-483ba2d02b88"), "Chad", "Wheeler" },
                    { new Guid("5d3ed2f6-8fa7-4b37-bc71-cc9e8ea3134e"), "Jerry", "Hughes" },
                    { new Guid("e898b667-9ff6-4f52-9e9a-b82912a140f2"), "Josh", "Allen" },
                    { new Guid("b87d5098-1551-43c2-bb73-34a1824436b3"), "Jake", "Fromm" },
                    { new Guid("5f9ed096-786b-49e9-af23-e79305838208"), "Taiwan", "Jones" },
                    { new Guid("13918111-c1c2-427e-ac0d-849bcfb9f47a"), "Zack", "Moss" },
                    { new Guid("51590752-18ed-46fc-8633-de14c5f5f2a7"), "Devin", "Singletary" },
                    { new Guid("cfcae32d-ce59-49af-b6ab-266fcaef2a83"), "T.", "J. Yeldon	" },
                    { new Guid("5c300968-bcab-41f3-8455-c46d3a76da71"), "Cole", "Beasley" },
                    { new Guid("881a1ff1-824b-4f3a-9bbe-5b1d92359b2d"), "John", "Brown" },
                    { new Guid("cd50787d-aa01-477b-984f-433009b122d0"), "Matt", "Barkley" },
                    { new Guid("676945c4-8766-4e98-89ad-ce43e7461979"), "Quinton", "Jefferson" },
                    { new Guid("14b9a794-c6e8-4d8b-aff2-9a511d6892b2"), "Darryl", "Johnson" },
                    { new Guid("c29e4818-f692-46f5-bc6d-72dd890a9481"), "Trent", "Murphy" },
                    { new Guid("55c845dc-10d5-4331-b6ce-b779870b5068"), "Tyrel", "Dodson" },
                    { new Guid("e851f98a-cf53-4c85-8000-ec9ea9a12c59"), "E.", "J. Gaines	" },
                    { new Guid("7ffe2ea0-56e2-414d-a583-21d70ab28e8e"), "Isaiah", "Hodgins" },
                    { new Guid("8e224273-bdc2-4e69-bb16-6b3164c68130"), "Dawson", "Knox" },
                    { new Guid("d0c97ef6-6ecd-4917-b968-41ddb5f96d6c"), "Cam", "Lewis" },
                    { new Guid("8aa2a31d-271f-4da3-bff9-78d853ad15ca"), "Star", "Lotulelei" },
                    { new Guid("d0b97ab7-223c-40d8-976f-0ed42fb0e655"), "Del'Shawn", "Phillips" },
                    { new Guid("32f7c2ed-c059-4375-a7a5-09e98e0f08d4"), "Reid", "Ferguson" },
                    { new Guid("dfceb466-caa7-4656-a53e-e0ce5e3de887"), "Tommy", "Sweeney" },
                    { new Guid("2eb870f4-efc0-4875-afad-f00207081eed"), "Nate", "Becker" },
                    { new Guid("5fc4bdfb-73cd-4e7c-9dab-979b71363e49"), "Brandin", "Bryant" },
                    { new Guid("4261e0d0-05d5-42c4-bbd4-df629407143a"), "Bryan", "Cox Jr.	" },
                    { new Guid("7ab7e4b1-5177-42e8-a6b9-2b39f501ec05"), "Jordan", "Devey" },
                    { new Guid("72ea336c-611f-417c-b4c1-0534851fcbb5"), "Jonotthan", "Harrison" },
                    { new Guid("577332bb-07d9-409e-8a82-bcfeabfcb16b"), "Dane", "Jackson" },
                    { new Guid("8c71d9b1-e981-4332-be29-87377ea2cd38"), "Jake", "Kumerow" },
                    { new Guid("48aa5a4c-ead5-4e08-bd9c-d7d4240d7d7f"), "Trey", "Adams" },
                    { new Guid("74edcfb4-a21c-408e-a072-0a74b57e9d3c"), "Darron", "Lee" },
                    { new Guid("20cf7204-e680-44d0-8037-d748f5b574a2"), "Corey", "Bojorquez" },
                    { new Guid("dd3e31b7-4ff3-4087-8ba9-86c7c53d9c59"), "Tre'Davious", "White" },
                    { new Guid("6c53bd99-5fef-48cd-9ce6-300555a84540"), "Ed", "Oliver" },
                    { new Guid("7863af2b-d8f3-4fae-8b46-e7232144e308"), "Harrison", "Phillips" },
                    { new Guid("8b9e24fa-0a51-4710-a9b5-7a433740cde7"), "Justin", "Zimmer" },
                    { new Guid("c6d86478-9d09-46c9-9bc3-7840f94d08a2"), "Tremaine", "Edmunds" },
                    { new Guid("99b27443-60a7-4e7b-93f4-44d0a7a19ca7"), "A.", "J. Klein	" },
                    { new Guid("22342546-3a4d-4a78-886c-dec224838dc7"), "Tyler", "Matakevich" },
                    { new Guid("81e1f020-70a8-4bec-a5b1-15f798149645"), "Matt", "Milano" },
                    { new Guid("811a6cc9-d6a0-4d82-bca7-294249e583a3"), "Tyler", "Bass" },
                    { new Guid("7f0683e3-5406-499c-8f40-de92e9f99310"), "Andre", "Smith" },
                    { new Guid("be426e0b-041d-433a-8c97-0260cc3c6ce9"), "Jaquan", "Johnson" },
                    { new Guid("dcd1889a-5dcd-4376-af88-14dd5cefdf6a"), "Taron", "Johnson" },
                    { new Guid("ba4cf191-0974-45e2-8438-7f05e81e8f76"), "Dean", "Marlowe" },
                    { new Guid("4961f102-f827-4850-a2b0-33df455d2866"), "Siran", "Neal" },
                    { new Guid("f5e2e13d-ffe5-455c-999e-cea4ff3c0141"), "Josh", "Norman" },
                    { new Guid("6134bc26-0c31-4434-b0b8-60ab738aa76a"), "Jordan", "Poyer" },
                    { new Guid("4f595a34-973c-4243-9f0d-e2c9fbc96b00"), "Levi", "Wallace" },
                    { new Guid("2b7ebebe-f642-443e-9d30-aac4b1700be5"), "Micah", "Hyde" },
                    { new Guid("c46a865b-060e-4c36-84ab-3a596853e9c2"), "Deon", "Cain" },
                    { new Guid("61db301d-af31-4bf5-a992-1688a015959c"), "Chris", "Myarick" },
                    { new Guid("68329502-7240-4af8-a8ad-0c30e3ee9d61"), "Durval", "Queiroz-Neto" },
                    { new Guid("0ebd199c-94d6-4e34-a28b-34d43ee8b0da"), "Jamison", "Crowder" },
                    { new Guid("e4a4dc60-6df6-4f1e-80cc-d5650ea0d9a5"), "Denzel", "Mims" },
                    { new Guid("105ff179-4df8-4462-b6af-7820b707e405"), "Breshad", "Perriman" },
                    { new Guid("e6df1d3b-cb46-4a71-86a1-84c4d279661f"), "Jeff", "Smith" },
                    { new Guid("5a1af098-ffa8-4c7d-80d8-f415410b7fd6"), "Vyncint", "Smith" },
                    { new Guid("ed6250a5-4c8d-416e-bb6c-52f4ebcc7e78"), "Daniel", "Brown" },
                    { new Guid("a3fdabc0-ac95-4cf0-b8e6-7016e258f365"), "Ryan", "Griffin" },
                    { new Guid("e0691d53-c4a7-4dd0-858c-8efddf37256d"), "Chris", "Herndon" },
                    { new Guid("faff4063-b0f9-4815-8461-9e1853b108c9"), "Trevon", "Wesco" },
                    { new Guid("970d90cc-b8f8-458d-84a2-2de17fa5a95b"), "Josh", "Andrews" },
                    { new Guid("ee98cae7-b92c-4ff7-b685-3b8761b9ee43"), "Mekhi", "Becton" },
                    { new Guid("f6a6907d-16e9-45c2-9fad-7e81bc8fa292"), "Cameron", "Clark" },
                    { new Guid("d0cb45f2-92b7-47a7-b21b-0c880b47c97b"), "Chuma", "Edoga" },
                    { new Guid("bc2d3028-46ff-44c3-9c1e-d5d67ff730c8"), "George", "Fant" },
                    { new Guid("69f09636-101e-4eb0-a989-8c06f3b9529e"), "Alex", "Lewis" },
                    { new Guid("5b00ab33-39d0-48ce-9a4c-ff62b34a92ec"), "Braxton", "Berrios" },
                    { new Guid("989c9646-b2f6-4889-b529-bbfd2ae82585"), "La'Mical", "Perine" },
                    { new Guid("dd4e9991-4d0d-4db0-afe7-a8747cb59861"), "Ty", "Johnson" },
                    { new Guid("ffd6c575-773b-4055-a988-3bda79e70487"), "Frank", "Gore" },
                    { new Guid("79b9283c-d891-4033-aa4c-34da98f8d15f"), "Jake", "Dolegala" },
                    { new Guid("590450bf-4f94-4620-8517-72a72e6b88e4"), "Ryan", "Glasgow" },
                    { new Guid("eaf1fa8b-1ead-4eee-86eb-2f59b0a39593"), "Terez", "Hall" },
                    { new Guid("e8340b10-f358-413b-8456-b0b3769b2971"), "Mike", "Jackson Sr.	" },
                    { new Guid("83dcfa21-b540-4cb0-ada1-0b57c378f7a4"), "Mason", "Kinsey" },
                    { new Guid("549ecf40-d423-4b44-956b-0c152b3190bf"), "Donte", "Moncrief" },
                    { new Guid("d7efc1ff-239b-4f6a-ac89-6efbf2f4612f"), "Bill", "Murray" },
                    { new Guid("102ef4bf-b3ff-4ad2-8654-ba74d2905827"), "Conor", "McDermott" },
                    { new Guid("cdfc8878-0995-471c-94ae-2990451949fc"), "Michael", "Pinckney" },
                    { new Guid("9583b3e5-22aa-466a-b745-68d35a537732"), "D'Angelo", "Ross" },
                    { new Guid("b1e13ea2-1321-4187-9c73-192920d3ad11"), "Jordan", "Steckler" },
                    { new Guid("c0782b15-dfa1-4003-8d55-169c6edf6eb6"), "Kristian", "Wilkerson" },
                    { new Guid("45ae430e-b088-4a45-b56d-dca18be3e9f9"), "Isaiah", "Zuber" },
                    { new Guid("461b8bfc-9594-4a25-9f70-c52ad79141b3"), "Sam", "Darnold" },
                    { new Guid("408caea6-c4d2-4ebb-9e7b-7914009c1d64"), "Joe", "Flacco" },
                    { new Guid("2dbaea0c-1e50-4d26-bb92-905c34c2305d"), "James", "Morgan" },
                    { new Guid("030129ca-fe76-4262-9abc-22e9fd89b10e"), "Justin", "Rohrwasser" },
                    { new Guid("917be108-d164-4c2c-b1e5-f9d81ed548e2"), "Connor", "McGovern" },
                    { new Guid("76a8be55-f675-4ef7-a5be-1ad32e9bc207"), "Jimmy", "Murray" },
                    { new Guid("dd7cb468-784e-43ce-b829-6ad093b5d3a2"), "Greg", "Van Roten	" },
                    { new Guid("3b0acf1f-6716-486f-af5e-9a376c3de8c6"), "Brian", "Poole" },
                    { new Guid("375ac66a-578e-4c06-a3ca-a6cf6fbcc87d"), "Quincy", "Wilson" },
                    { new Guid("30440fbb-4801-42b6-a9f0-2a9239095482"), "Sergio", "Castillo" },
                    { new Guid("2bf29afd-2584-4246-9807-7defbae3869a"), "Sam", "Ficken" },
                    { new Guid("810fac6b-d519-40ca-8b9c-469e608e59d5"), "Thomas", "Hennessy" },
                    { new Guid("c680b667-cac9-498a-b053-c99f6e3895b8"), "Braden", "Mann" },
                    { new Guid("01d45597-ece1-4f11-b81a-1f7f1c91709e"), "Kyron", "Brown" },
                    { new Guid("c2afdb30-1e71-4158-b414-aea8ff7dc2e9"), "Marcus", "Maye" },
                    { new Guid("02f16099-357d-4a4a-80dd-31beea226cce"), "Josh", "Doctson" },
                    { new Guid("820d80c1-ff75-4914-a0be-e827165f78de"), "Chris", "Hogan" },
                    { new Guid("f7a7a270-dc55-48ee-9b69-5e9a0a8952b3"), "Leo", "Koloamatangi" },
                    { new Guid("126450ba-7805-4349-9d39-ae8a52796105"), "Frankie", "Luvu" },
                    { new Guid("e79b226f-a87d-4cd2-8bf1-986d559c0959"), "Bradley", "McDougald" },
                    { new Guid("6a7f7115-7963-45b6-8c1b-d52de4348ea0"), "C.", "J. Mosley	" },
                    { new Guid("7676065e-6b49-4e6e-8d80-1673ba4a9c2a"), "Patrick", "Onwuasor" },
                    { new Guid("a1d30817-3302-4a05-a033-e3254606799a"), "Kyle", "Phillips" },
                    { new Guid("fc17c28b-d94f-44b3-9197-5d60004f5378"), "Bryce", "Hall" },
                    { new Guid("2b7acf0a-40b0-4b98-a74b-89d8d073ff87"), "Jake", "Burt" },
                    { new Guid("570857f5-0306-45ff-be7d-5bdf97c31180"), "Arthur", "Maulet" },
                    { new Guid("85b01393-d613-42e3-96d2-b33544229a6f"), "Javelin", "Guidry" },
                    { new Guid("896e1b92-8dd3-420d-876e-18931e1d0f4e"), "Henry", "Anderson" },
                    { new Guid("ceeb6a4f-51a1-47aa-8775-86ca07574d82"), "Folorunso", "Fatukasi" },
                    { new Guid("141a5a2d-9539-4dc9-94f9-c484a71852df"), "John", "Franklin-Myers" },
                    { new Guid("4360fe14-b6a4-461a-a2f4-dd801b11c913"), "Nathan", "Shepherd" },
                    { new Guid("fd7cd889-429f-496b-a592-cbb7b6dcf1f3"), "Quinnen", "Williams" },
                    { new Guid("7e509006-439f-49e6-a7dd-61cfb297b37f"), "Tarell", "Basham" },
                    { new Guid("1deff829-cae0-4a42-b209-b6a8e8ae6368"), "Blake", "Cashman" },
                    { new Guid("d79bf1fa-d3da-4247-b9f4-4d1e355a9c33"), "Lamar", "Jackson" },
                    { new Guid("2863f172-36a7-4122-8fbb-b82856c2e5aa"), "Neville", "Hewitt" },
                    { new Guid("551df27a-a538-48ca-95a1-7e6e4e867d80"), "Jordan", "Jenkins" },
                    { new Guid("00ec3685-64b6-4b5f-8f0e-44c356d87371"), "Harvey", "Langi" },
                    { new Guid("127679dc-6fd1-4931-bddf-8d6888a4cc83"), "Jabari", "Zuniga" },
                    { new Guid("6b8ae4d5-d63a-4d6f-a78d-4b9ee2cbb6da"), "Blessuan", "Austin" },
                    { new Guid("aefe7cb5-86dd-4d9a-acbc-13837e56971e"), "Ashtyn", "Davis" },
                    { new Guid("ed194d66-2cad-4c84-8ac6-ca8a640a694f"), "Pierre", "Desir" },
                    { new Guid("4366bf7e-fd28-47a4-a018-dce927054387"), "Matthias", "Farley" },
                    { new Guid("c9236136-8eaa-4015-b615-6cfb8c41e06e"), "Bryce", "Huff" },
                    { new Guid("530a7a57-bd1b-47c8-a475-ac09ee4376c7"), "Matthew", "Orzech" },
                    { new Guid("b3645af7-ec11-4a87-9d7a-e5ee842b3b3c"), "Tashawn", "Bower" },
                    { new Guid("1dc8ca3f-b4d3-4732-9537-440ce0cc414d"), "Caleb", "Benenoch" },
                    { new Guid("5e0923f9-dc07-43d2-8630-8508e586e545"), "James", "Ferentz" },
                    { new Guid("dbe7cd88-3425-46c3-806f-610c4f39a130"), "Hjalte", "Froholdt" },
                    { new Guid("6742fa69-94bf-4b5d-b4d2-218ce2d7d322"), "Shaq", "Mason" },
                    { new Guid("f4b7d8d6-0a9f-4219-9ce8-44e6c59132fc"), "Michael", "Onwenu" },
                    { new Guid("d19c7736-da78-4d92-b056-de9a35393f3f"), "Joe", "Thuney" },
                    { new Guid("6151f64d-c5c6-430c-9348-5cef9b236aa8"), "Isaiah", "Wynn" },
                    { new Guid("9b66ea3e-3e8f-4083-8120-06b1b33bf3bc"), "Adam", "Butler" },
                    { new Guid("604e2495-b67d-4de8-a3b3-a38dbdb2f70c"), "Byron", "Cowart" },
                    { new Guid("9c72d668-15f2-439c-8c68-8fc5da6095e1"), "Carl", "Davis" },
                    { new Guid("406813d1-73f0-4006-8250-08cae9c88211"), "Lawrence", "Guy" },
                    { new Guid("d9ec3469-1abd-4417-a24b-5555da999407"), "Isaiah", "Mack" },
                    { new Guid("4e2e4dbf-c0a8-45d3-a04f-96e397cfc224"), "Derek", "Rivers" },
                    { new Guid("650243dd-4a8c-418c-90a3-2f6ff2780334"), "John", "Simon" },
                    { new Guid("704fa66d-30b3-40f0-96e7-90387da063a9"), "Nick", "Thurman" },
                    { new Guid("26439e33-8e05-43c4-85e0-c8b1686642e9"), "Chase", "Winovich" },
                    { new Guid("6c813fbb-84e8-47b1-992a-85e9dea4cb31"), "Korey", "Cunningham" },
                    { new Guid("962b770c-9bbb-4566-b3f7-ff5707e631b3"), "David", "Andrews" },
                    { new Guid("e6267f23-a4d3-495b-9ad3-363608ca7834"), "Dalton", "Keene" },
                    { new Guid("b27748f8-485d-46b3-9ccb-8f7204256474"), "Ryan", "Izzo" },
                    { new Guid("17b63d8e-6b6d-4fb5-bc98-3c075b9f7a03"), "Tyshun", "Render" },
                    { new Guid("98833b3c-6aed-47b7-941b-12c18fd5b178"), "Reid", "Sinnett" },
                    { new Guid("51131c34-3d7c-4909-8895-83406b9be2b5"), "Brian", "Hoyer" },
                    { new Guid("88d7f11f-fda1-4d63-86ed-64700dd35c58"), "Cam", "Newton" },
                    { new Guid("1c1d49ce-9035-4743-8db4-67ed894e4178"), "Jarrett", "Stidham" },
                    { new Guid("14ecd02d-8172-4b05-85e7-65297eeaffe6"), "Rex", "Burkhead" },
                    { new Guid("f6f2aabb-ef3a-441b-b525-f07931c0d962"), "Damien", "Harris" },
                    { new Guid("08a6e0b8-ae1c-4970-b41f-15c27c20cea5"), "Deatrich", "Wise Jr.	" },
                    { new Guid("7f1a5070-7a04-45e7-ae35-039d313e8610"), "Jakob", "Johnson" },
                    { new Guid("6155b425-ac97-4f70-94d3-c3503f37f4f5"), "James", "White" },
                    { new Guid("a7462353-2699-445b-8fda-35436cbb3516"), "Damiere", "Byrd" },
                    { new Guid("bf2999e4-a826-4584-b111-4390ed08b099"), "Isaiah", "Ford" },
                    { new Guid("536350fa-a92c-4452-84f4-cf9377b61669"), "N'Keal", "Harry" },
                    { new Guid("a0f1ebd2-d2a1-4b88-9c5c-0f30fab47b36"), "Jakobi", "Meyers" },
                    { new Guid("9ce252d6-73a8-4dc0-beaf-8abdf6f9815a"), "Gunner", "Olszewski" },
                    { new Guid("1a659b1e-c5fd-47d2-aa56-33c3d3ee0704"), "Matthew", "Slater" },
                    { new Guid("1b2e6713-f7f3-4dd1-ae63-d58841c086b3"), "J.", "J. Taylor	" },
                    { new Guid("733a90bc-6a95-4cab-8771-0bec924ffd6e"), "Ja'Whaun", "Bentley" },
                    { new Guid("c5a5d794-7d4b-490b-ac03-c7124bd50fb0"), "Shilique", "Calhoun" },
                    { new Guid("45cdaf1a-ea3e-4f50-9a2b-6d412f65ba3e"), "Anfernee", "Jennings" },
                    { new Guid("8f4e06ee-ed4d-44f6-ba71-9732e53b2b2a"), "Michael", "Barnett" },
                    { new Guid("470c0cf0-8b4c-455b-bb18-46c2d4309468"), "Brandon", "Bolden" },
                    { new Guid("3fea86af-6ec9-49a2-90f4-88c5b3f57bf8"), "Yodny", "Cajuste" },
                    { new Guid("ce741659-47ca-43e6-b3d8-87689d710aec"), "Marcus", "Cannon" },
                    { new Guid("1cb98b16-62b6-4f91-93c5-01867377d121"), "Patrick", "Chung" },
                    { new Guid("58af1095-35f1-48d8-8490-179e8354d730"), "Brandon", "Copeland" },
                    { new Guid("d6f86bf4-3c5b-4ebd-81f7-92b98f6161d5"), "Julian", "Edelman" },
                    { new Guid("f90ea56e-a67d-45e6-b5bf-259e9db47513"), "Devin", "Asiasi" },
                    { new Guid("9aaa9d7d-d989-4ff9-a8e8-8daa676b3ac9"), "Jermaine", "Eluemunor" },
                    { new Guid("0f8cfcc3-6ecb-4f91-8d31-cc52ce04eb7c"), "Dont'a", "Hightower" },
                    { new Guid("66235640-b839-433d-9e3a-7757dbf99a59"), "Brandon", "King" },
                    { new Guid("71c95012-4a17-464b-b738-ce01f2cefa64"), "Matt", "LaCosse" },
                    { new Guid("5b598f08-71aa-44bc-9d27-5b331c41677f"), "Marqise", "Lee" },
                    { new Guid("d5442e70-e970-4110-a7d3-5d1265ed441d"), "Sony", "Michel" },
                    { new Guid("93dc0081-e2de-4e61-adff-080f101d44de"), "Najee", "Toran" },
                    { new Guid("e4eb1470-3fcc-4ca1-b085-5d1186a4553f"), "Danny", "Vitale" },
                    { new Guid("6289440e-694b-4d27-b068-2a3fb658e26d"), "Justin", "Herron" },
                    { new Guid("1029e948-2ee7-4719-8d5c-b5a09af85f90"), "Rashod", "Berry" },
                    { new Guid("95bf8e04-51ed-4ebc-b95c-f9fdf66addd9"), "Beau", "Allen" },
                    { new Guid("3599b0bb-29fc-4c37-aaba-dee7c498a812"), "Nick", "Folk" },
                    { new Guid("bbb66cf0-7942-4afa-8f9e-a97edb8d75d2"), "Cassh", "Maluia" },
                    { new Guid("844aab2e-964e-4144-979e-593d229483ee"), "Josh", "Uche" },
                    { new Guid("025abf90-8275-4aa0-81fc-edf5f34335b2"), "Justin", "Bethe" },
                    { new Guid("e6d8496f-8c16-4faf-beab-f16e33a2c551"), "Terrence", "Brooks" },
                    { new Guid("dabde780-c168-4f84-b794-a5027b27682b"), "Myles", "Bryant" },
                    { new Guid("06e069ac-f9dc-43d2-a86e-0fb2af2edd30"), "Cody", "Davis" },
                    { new Guid("1d303f73-120a-4821-9ab2-fe3e2ed13e1f"), "Kyle", "Dugger" },
                    { new Guid("cb598c19-575f-44d9-9595-5dd3cd390644"), "Quincy", "Adeboyejo" },
                    { new Guid("996137b6-892a-4e0a-987f-2d97d67ed9dd"), "Stephon", "Gilmore" },
                    { new Guid("eb538e3d-8c99-450d-a7a9-af6dee77a659"), "Jonathan", "Jones" },
                    { new Guid("3c2e9316-2532-4025-b4fc-8203d628dd11"), "Devin", "McCourty" },
                    { new Guid("76f20e09-5fcb-4e7f-bee3-61877f5158e4"), "Jason", "McCourty" },
                    { new Guid("3c7dc368-4cec-4c41-9b62-5a8d03028b18"), "Adrian", "Phillips" },
                    { new Guid("3b256809-93bb-4cc6-8a3c-b695c2dad660"), "Joejuan", "Williams" },
                    { new Guid("12a34ffa-f8ce-4178-8244-78ca67169866"), "Jake", "Bailey" },
                    { new Guid("5d6a54ad-9bca-4b40-9285-dde7f5f3863d"), "Joe", "Cardona" },
                    { new Guid("8b601274-2348-4b52-bfc7-56fe47a55a6c"), "J.", "C. Jackson	" },
                    { new Guid("619dca0c-6c75-41f1-9a0b-2f3a9c2ea1d6"), "Mychal", "Kendricks" },
                    { new Guid("ac454ace-5354-4b34-8411-415c92fa08d9"), "Anthony", "Coyle" },
                    { new Guid("ba3b30b9-7cc3-412b-b379-c90e2fc7c303"), "Devlin", "Hodges" },
                    { new Guid("81404ea6-609c-4ea3-8095-2fd6961e0597"), "Eric", "Fisher" },
                    { new Guid("9799661e-c931-4ec6-bae7-dfbdc12f34ea"), "Daniel", "Kilgore" },
                    { new Guid("f12c25ee-779a-4355-9990-56ad4222f243"), "Austin", "Reiter" },
                    { new Guid("04c35e5c-ca51-4433-88ed-a50f92a8edd1"), "Mike", "Remmers" },
                    { new Guid("f76effdb-b466-47fb-9717-a4aabc196cb5"), "Mitchell", "Schwartz" },
                    { new Guid("e4f1215f-8714-4e57-a3da-b61b80b75949"), "Andrew", "Wylie" },
                    { new Guid("94d5ccce-7b4f-4aa3-bb1d-5966131db750"), "Taco", "Charlton" },
                    { new Guid("ea6f85fa-994a-4e4f-82a8-7d60987e6ed3"), "Frank", "Clark" },
                    { new Guid("56a6de63-5ede-4d14-b4aa-726b9b2cf97c"), "Mike", "Danna" },
                    { new Guid("3b3d37cd-3c5f-4acf-8ec4-19178f04e96f"), "Demone", "Harris" },
                    { new Guid("9b0cb0d6-3f21-4eaf-ae62-d050e071a024"), "Chris", "Jones" },
                    { new Guid("b6595fba-3032-4341-87e9-aa6a49892e5b"), "Tanoh", "Kpassagnon" },
                    { new Guid("58c82d80-ffd3-4507-bdad-d91b5228d21f"), "Derrick", "Nnadi" },
                    { new Guid("2a7dfc7a-2922-4dd9-a194-ff06f8b2c975"), "Mike", "Pennel" },
                    { new Guid("6ce3b7e1-c233-429a-9f13-30179819c1f4"), "Khalen", "Saunders" },
                    { new Guid("3c170a10-37ab-414a-885d-b87f1e2d9d84"), "Yasir", "Durant" },
                    { new Guid("35c9c443-8fd8-40b3-9216-7c122990395c"), "Nick", "Allegretti" },
                    { new Guid("2ca40a67-0942-4b2a-9a32-c8d6dfb6999a"), "Deon", "Yelder" },
                    { new Guid("5299bedf-6497-4228-9d44-28aa67dd2feb"), "Ricky", "Seals-Jones" },
                    { new Guid("69712b5f-6ab9-4965-b4a7-dfe7e79dc24f"), "Kevin", "Toliver" },
                    { new Guid("9332c80c-393d-43b1-bfdd-f349db438d77"), "Josh", "Watson" },
                    { new Guid("2949f409-1614-457d-aa82-7ed6e19a1fa6"), "Chad", "Henne" },
                    { new Guid("c5610f2d-e661-4c58-9d52-5e6cf7461e74"), "Patrick", "Mahomes" },
                    { new Guid("c3ca4946-e3af-4b37-97a1-bc2d812a1354"), "Le'Veon", "Bell" },
                    { new Guid("7eb4e5ba-d3de-4f99-b0bc-f4f29cda4483"), "Clyde", "Edwards-Helaire" },
                    { new Guid("2da8a8cc-205b-4977-a3a0-e419b13d61a8"), "Anthony", "Sherman" },
                    { new Guid("1439ac4d-b17e-427b-9142-8c42fca7aef2"), "Tershawn", "Wharton" },
                    { new Guid("263cf925-6837-41b3-861e-4ac14c6281ba"), "Darwin", "Thompson" },
                    { new Guid("850e5b25-88cb-4318-9298-be078dd99957"), "Mecole", "Hardman" },
                    { new Guid("d2354f27-8390-4a44-a79b-e1600fc42bf3"), "Tyreek", "Hill" },
                    { new Guid("ce1f7a63-a32b-49b2-9594-4910367bc32c"), "Byron", "Pringle" },
                    { new Guid("e9ea1c59-f2d4-4360-a8f8-06cc22b6a2b4"), "Demarcus", "Robinson" },
                    { new Guid("4a47d13f-802a-4e88-91d5-8a0372993a31"), "Sammy", "Watkins" },
                    { new Guid("0286b8a5-869e-4189-9652-b80f978d9230"), "Nick", "Keizer" },
                    { new Guid("2812a87e-dd0d-45ca-83f6-940a3de782ea"), "Travis", "Kelce" },
                    { new Guid("1e7f9be8-b3af-4646-a381-004365bf9fda"), "Darrel", "Williams" },
                    { new Guid("efad5bea-83e5-4946-b81d-eb0cecb417f5"), "Deyon", "Sizer" },
                    { new Guid("bd3cb8b0-ab94-4533-96ea-4ff02538732a"), "Willie", "Gay" },
                    { new Guid("fbc3abc7-8fb8-44f8-b76a-063c668c1728"), "Anthony", "Hitchens" },
                    { new Guid("3b73f8fa-52bb-42f2-83a7-da233b319367"), "Kelechi", "Osemele" },
                    { new Guid("0ee154fd-5202-46c2-816e-504013386cfa"), "Martinas", "Rankin" },
                    { new Guid("437372f3-9d92-482a-b00b-24d1748e5faa"), "L'Jarius", "Sneed" },
                    { new Guid("802ff01b-4e82-4f91-9c4f-c19f7342893a"), "Damien", "Williams" },
                    { new Guid("820c30f9-3419-4431-a203-82291472d59a"), "Rodney", "Clemons" },
                    { new Guid("d9745570-577d-499d-91b0-5418aa6b52d8"), "Omari", "Cobb" },
                    { new Guid("ff84af82-6ebc-49e9-94aa-91019d4fd6b4"), "Gehrig", "Dieter" },
                    { new Guid("3af5307c-9eff-4cbb-9ca5-3ed52f4ef22a"), "Maurice", "Ffrench" },
                    { new Guid("686975a8-4ce8-4b5d-976a-7eba0dedae1f"), "Jody", "Fortson" },
                    { new Guid("75c2bf54-7487-4b66-962e-3d2b7ffe1154"), "Lavert", "Hill" },
                    { new Guid("5dc0531d-939f-47e8-af86-ce7cc6e45377"), "Braxton", "Hoyett" },
                    { new Guid("f5935c4d-dd60-4927-943f-96c72e5b695e"), "Danny", "Isidora" },
                    { new Guid("e9eb1190-71b6-4cad-a2f4-8d135eb12754"), "Marcus", "Kemp" },
                    { new Guid("361232dc-6241-4ea5-b0bb-02ed6696763b"), "Chris", "Lammons" },
                    { new Guid("076f63d4-2368-4222-8353-6d670b1c0df1"), "Matt", "Moore" },
                    { new Guid("e8f665ec-3092-4bca-ab8b-36c98d2b95c1"), "Alex", "Okafor" },
                    { new Guid("cacfea32-0ca5-472a-bba8-f7e490f96b79"), "Lucas", "Niang" },
                    { new Guid("eb0508e0-d5d2-4121-836b-5091fff9c3c5"), "Laurent", "Duvernay-Tardif" },
                    { new Guid("58adafd6-94f2-4cf6-83b5-b7cdb4c5eda4"), "Alex", "Brown" },
                    { new Guid("3365810c-6329-416b-813c-308af3748873"), "Ben", "Niemann" },
                    { new Guid("645f1df9-d9f4-4058-b7b0-9e161c78872e"), "Dorian", "O'Daniel" },
                    { new Guid("9cac42fb-46ea-42ea-9c2b-1afb21782585"), "Damien", "Wilson" },
                    { new Guid("6dbb85e4-8e51-4aff-a8a1-5fe5b59ba6fb"), "Bashaud", "Breeland" },
                    { new Guid("5c7bb5a8-fbaf-4d4a-a93c-8a4460a032b7"), "Rashad", "Fenton" },
                    { new Guid("e8ca66a8-1864-4f1a-8ca2-7e26e0ce4cb8"), "Antonio", "Hamilton" },
                    { new Guid("35b3eec1-b740-4a55-a075-9265de9d4202"), "Thakarius", "Keyes" },
                    { new Guid("dc74f212-31c5-4088-beb6-c239c5b9e93f"), "Darius", "Harris" },
                    { new Guid("5571d4dc-4e14-410d-a5e3-60a7df224d65"), "Tyrann", "Mathieu" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("59d8d3b2-4ad0-46e9-b371-0514ea2c7160"), "Tedric", "Thompson" },
                    { new Guid("3d4d60b5-fc76-4956-8c32-d04c36d9bf01"), "Juan", "Thornhill" },
                    { new Guid("19d56fca-9375-4cd4-8a6b-5cde0d155830"), "Charvarius", "Ward" },
                    { new Guid("032cb520-70be-4f94-b831-7bc1ee253c19"), "Armani", "Watts" },
                    { new Guid("1646f978-889d-4fc0-a0df-a300a75b02b9"), "Harrison", "Butker" },
                    { new Guid("0a391839-5d6e-4d32-8c1f-d3384fade9ba"), "Tommy", "Townsend" },
                    { new Guid("c934c419-a833-4490-a7d0-61a791155a14"), "James", "Winchester" },
                    { new Guid("4fb555df-db98-4ed0-baa3-49f2df8a86cc"), "Daniel", "Sorensen" },
                    { new Guid("48d0df87-8ebb-471c-abd6-5204d1f85200"), "Darrin", "Paulo" },
                    { new Guid("0bd1264e-b527-4835-8b44-8f1b8c8203ff"), "Patrick", "Morris" },
                    { new Guid("abcfff00-f800-44b5-8e5e-fe29d30d35eb"), "Darius", "Kilgo" },
                    { new Guid("fb605aab-32ff-42f4-aeb8-fda5959eb9b1"), "Netane", "Muti" },
                    { new Guid("7ef44e49-e51f-4c4c-b193-6b723b12aa9f"), "Dalton", "Risner" },
                    { new Guid("df2cba04-e7a5-45eb-92a5-3e9369683067"), "Jake", "Rodgers" },
                    { new Guid("80e9524f-7b72-4fbb-a123-c35dbc2b1502"), "Austin", "Schlottmann" },
                    { new Guid("197ccc38-a342-47d8-abd7-57846dfe300f"), "McTelvin", "Agim" },
                    { new Guid("07307775-aae2-474e-a122-bcdbf07dfba3"), "Shelby", "Harris" },
                    { new Guid("96bb06ff-505b-4d60-b9fc-98e2ad10b043"), "Dre'Mont", "Jones" },
                    { new Guid("0d875805-df42-4789-96db-31df97a6c9cb"), "DeMarcus", "Walker" },
                    { new Guid("9cfc4dac-be0d-4e24-85de-9f9d95c87a6f"), "DeShawn", "Williams" },
                    { new Guid("407e811e-4ae4-435d-a171-9cab7f7f79f9"), "Sylvester", "Williams" },
                    { new Guid("20047b03-b7b9-4e8b-9eff-72e253f576bc"), "Jeremiah", "Attaochu" },
                    { new Guid("1110a514-f83a-43f5-a0f6-95ccf950b240"), "Austin", "Calitro" },
                    { new Guid("0fc1e6ca-58b7-4da0-8524-c78cd5a53822"), "Anthony", "Chickillo" },
                    { new Guid("fc97aef3-7db3-4c7e-bc48-9eb755ff4eb9"), "Bradley", "Chubb" },
                    { new Guid("316991aa-e13c-44b9-9262-d064beb2ee4c"), "Josey", "Jewell" },
                    { new Guid("ba5ee87e-6b47-4d85-a103-175d2b5a79b9"), "Demar", "Dotson" },
                    { new Guid("4622d300-90cf-4118-9e1d-4a01a0613774"), "Lloyd", "Cushenberry" },
                    { new Guid("49487e04-8740-4b9b-b965-06c493e0fa8b"), "Garett", "Bolles" },
                    { new Guid("04f35b5a-216d-4751-9ed0-b1fb54af1f7e"), "Calvin", "Anderson" },
                    { new Guid("bcb1bc34-67a9-4277-a882-d3e33ee3922c"), "Drew", "Lock" },
                    { new Guid("1e7fbb8b-5109-4733-99bf-e112b4b69a7b"), "Brett", "Rypien" },
                    { new Guid("90a90aef-d2fd-455a-acad-54cfe953cfb2"), "Jeremy", "Cox" },
                    { new Guid("92d9eb82-adc5-4b5c-81e4-f1a36d7b9a78"), "Royce", "Freeman" },
                    { new Guid("7468a95a-d85f-4dfc-a31f-033b45f1f1b6"), "Melvin", "Gordon" },
                    { new Guid("3f000ac4-d6e3-4c2f-ae10-2ae2260b2d3f"), "Phillip", "Lindsay" },
                    { new Guid("92bec89e-ce5e-4f4a-869b-73b052053972"), "Tyrie", "Cleveland" },
                    { new Guid("1a37172c-efea-4dd2-8c49-eb204369abfa"), "A.", "J. Johnson	" },
                    { new Guid("983f1db5-9fa8-4b5d-a387-b9e9fe008058"), "DaeSean", "Hamilton" },
                    { new Guid("d17250a6-d874-4303-b0b1-a237cce77708"), "Jerry", "Jeudy" },
                    { new Guid("8f30dc8b-693b-4123-a177-61c43217578e"), "Tim", "Patrick" },
                    { new Guid("3a6535f9-f6a9-4347-a051-fd967f23ce4a"), "Diontae", "Spencer" },
                    { new Guid("e360bf19-ba7d-4b74-be7f-6ff6606fd642"), "Jake", "Butt" },
                    { new Guid("9a205d0a-d51a-431e-a82f-dfa508f1f9fd"), "Noah", "Fant" },
                    { new Guid("c53dcc3e-c0fa-4b2b-a2dc-04d93f2f6e23"), "Albert", "Okwuegbunam" },
                    { new Guid("6f1070eb-51cb-4a12-8a5a-686e84fe5d88"), "Nick", "Vannett" },
                    { new Guid("0093a081-73ca-411b-b87b-a2990a5fd1c0"), "K.", "J. Hamler	" },
                    { new Guid("aa7c3b9b-7fc3-411b-9806-87925ae71fb2"), "Joseph", "Jones" },
                    { new Guid("8c105e38-caad-4707-a0db-c94fe5a5ccb1"), "Malik", "Reed" },
                    { new Guid("218dc790-89cf-46cd-8500-e9760312f843"), "Essang", "Bassey" },
                    { new Guid("df6acb52-3be3-4208-b030-928155286445"), "Ja'Wuan", "James" },
                    { new Guid("54b9be09-30fa-4281-9031-aa863469ed60"), "Von", "Miller" },
                    { new Guid("de97b0e4-ff23-4c31-865b-475aa23e0dbb"), "Kyle", "Peko" },
                    { new Guid("cd3d0131-525b-4e5b-9405-e2243d65558e"), "Mike", "Purcell" },
                    { new Guid("8c0adc80-b3ae-45b0-b5b8-b1d4955cd6ba"), "Justin", "Strnad" },
                    { new Guid("ef9fb694-10b8-4c05-9424-8d22d04b4a83"), "Courtland", "Sutton" },
                    { new Guid("57fe13b1-7868-44e4-82a5-8bf3f29f924d"), "Derrek", "Tuszka" },
                    { new Guid("1735ccc4-1a71-406a-9521-1ee26f30d6a7"), "Joel", "Heath" },
                    { new Guid("b8af057e-c9db-4240-ad19-91aa2f0eb1bd"), "Elijah", "Wilkinson" },
                    { new Guid("6b543f17-7e06-4f41-9a8b-9d920abab2db"), "Trinity", "Benson" },
                    { new Guid("453b7f15-f962-459f-9895-e648866597e9"), "Blake", "Bortles" },
                    { new Guid("e2e5c744-10b9-4f99-b1c4-88107958381d"), "Nigel", "Bradham" },
                    { new Guid("2c369973-eae5-4617-a4bc-879e0c500ac0"), "Fred", "Brown" },
                    { new Guid("f39104aa-257b-47ef-8498-65059658fbdc"), "Chris", "Cooper" },
                    { new Guid("d4c664c5-b3d8-4ebc-9ca1-0b78150b2032"), "Damarea", "Crockett" },
                    { new Guid("cbd194a7-7b02-4bb5-9090-fae579040e94"), "Alijah", "Holder" },
                    { new Guid("330e3e9d-10ad-469d-9b1a-4da37560c8ca"), "Quinn", "Bailey" },
                    { new Guid("e17a4dbc-0e03-44b6-90e1-12aac9705a97"), "Emmanuel", "Smith" },
                    { new Guid("288bea50-5732-44ba-801f-e80479fb0b01"), "Jonathan", "Harris" },
                    { new Guid("e1b06cd6-026a-4637-9fc3-30a5d0d10a26"), "Austin", "Fort" },
                    { new Guid("cae565b0-2f50-4071-b9d2-5475fc75610d"), "A.", "J. Bouye	" },
                    { new Guid("4219e1cf-da10-4e1f-a644-a4c65443eabc"), "Bryce", "Callahan" },
                    { new Guid("b6c9ff2c-7aaf-4b89-9eda-66efc13e6c64"), "Duke", "Dawson" },
                    { new Guid("235269fa-365b-4e13-801d-7223136899af"), "Davontae", "Harris" },
                    { new Guid("9e56d66e-723d-4a0b-944b-134e3d171603"), "Kareem", "Jackson" },
                    { new Guid("f25025cd-f604-4489-9d58-436f838f3dde"), "P.", "J. Locke	" },
                    { new Guid("b71e8d66-f169-49ca-b017-a060c7bdc9fb"), "Trey", "Marshall" },
                    { new Guid("275659d6-97d9-4283-92aa-9cdac5515bb9"), "Graham", "Glasgow" },
                    { new Guid("ef902294-19b6-47f0-b5cb-177521fdbeb5"), "Michael", "Ojemudia" },
                    { new Guid("983cefbc-8790-466d-9912-94e3c92291f2"), "Jacob", "Bobenmoyer" },
                    { new Guid("0eb1f0fd-4b5e-4286-9ccf-5ec5da6758ea"), "Sam", "Martin" },
                    { new Guid("3bbff52f-77ff-4e68-9c7a-0259eb15572f"), "Brandon", "McManus" },
                    { new Guid("b2adff06-24bb-458b-a1c7-f6fe82c4be6a"), "Mark", "Barron" },
                    { new Guid("b5a32cb9-b0a2-4101-8a74-8bc300405d85"), "Andrew", "Beck" },
                    { new Guid("0c9700f4-4bd7-4a65-a21d-224e300f1b68"), "LeVante", "Bellamy" },
                    { new Guid("69e1dfb0-32e1-4997-8250-18477df1cb26"), "Jurrell", "Casey" },
                    { new Guid("0d46ce37-b4e4-4bb2-ba34-f47d439fdcdb"), "Justin", "Simmons" },
                    { new Guid("29e03145-0fca-4d47-98f5-ea7563055bdd"), "Tim", "Ward" },
                    { new Guid("706239c9-99cb-46d9-af6c-9c212f25f04e"), "Chad", "Williams" },
                    { new Guid("24b41626-30fd-43f4-a0b7-d307fe4cdddd"), "Darryl", "Williams" },
                    { new Guid("a5f72d85-5cf3-4116-9144-d1dc7b3cd539"), "Storm", "Norton" },
                    { new Guid("e73d5660-4113-4969-966d-e951f02a0932"), "Trey", "Pipkins" },
                    { new Guid("e7ae915c-4b10-4855-ab06-19a9968abf32"), "Scott", "Quessenberry" },
                    { new Guid("f0d1dc21-e3bb-4964-9256-421159ec8964"), "Tyree", "St. Louis	" },
                    { new Guid("a40ddb0b-e489-40f1-a6df-a73f61ab983f"), "Sam", "Tevi" },
                    { new Guid("6e02d603-c88b-4ffe-af1d-ed290785e8f8"), "Cole", "Toner" },
                    { new Guid("ac15aacb-6e07-4f93-8cf3-c7ad13f9d5fb"), "Trai", "Turner" },
                    { new Guid("6f6a6355-7e42-4858-9872-c6ac8a58463d"), "Joey", "Bosa" },
                    { new Guid("ee6ba024-7bd4-4760-b7b9-71e9faac8638"), "Cortez", "Broughton" },
                    { new Guid("f44f93b5-8f1f-4d55-b4cc-d8f4948ebae5"), "Melvin", "Ingram" },
                    { new Guid("9eba4692-c766-485a-9c45-58ab37abb4c4"), "Justin", "Jones" },
                    { new Guid("7df10a1d-6ac4-47b4-847d-2ef715cc9b8d"), "Linval", "Joseph" },
                    { new Guid("05db6b72-1ddc-4873-919b-c6854fac3781"), "Isaac", "Rochell" },
                    { new Guid("b8b3ece2-d081-4d86-8cbd-1fa7c3235c61"), "Damion", "Square" },
                    { new Guid("f789ab82-f45d-4510-8d97-2dfaada3b753"), "Jerry", "Tillery" },
                    { new Guid("140574e3-93d2-4a47-b8a3-d8a9d1ed3fb1"), "Forrest", "Lamp" },
                    { new Guid("ec450ede-cb67-4364-952b-19a5221ff3cf"), "Dan", "Feeney" },
                    { new Guid("654f619a-1e30-42a4-8834-f6a65a734c3f"), "Bryan", "Bulaga" },
                    { new Guid("7149b3a6-3886-4ee2-aac8-85cfeb0ad791"), "Donald", "Parham" },
                    { new Guid("f73e4cc8-678b-4778-98da-b606f9e77abb"), "Javin", "White" },
                    { new Guid("998a7fe2-1905-4d9a-8f2c-d6404c50e174"), "Justin", "Herbert" },
                    { new Guid("fdfcc84f-9e5e-4a07-85c7-c3bbcbf2f35b"), "Easton", "Stick" },
                    { new Guid("972f3aa6-eb75-447d-84ab-fd86bd28eef5"), "Tyrod", "Taylor" },
                    { new Guid("c30f259e-a2a6-4406-902c-484eec3db0d1"), "Justin", "Jackson" },
                    { new Guid("5fa77458-52f1-4a8c-abf9-122b7e7374d3"), "Joshua", "Kelley" },
                    { new Guid("12a50074-a0c7-42d0-a5aa-e8987a4f2cac"), "Gabe", "Nabers" },
                    { new Guid("c845ab6e-ae2b-49fb-a63e-b1b0e74af72a"), "Emeke", "Egbule" },
                    { new Guid("8a62f2b0-0cc4-4fd4-87e0-139f6cc40ee9"), "Troymaine", "Pope" },
                    { new Guid("42fd0511-08b6-49f9-a24d-12c48a2b5bdd"), "Jalen", "Guyton" },
                    { new Guid("b5e55ad5-6851-416c-8779-aba54af8ae56"), "K.", "J. Hill	" },
                    { new Guid("9f47cb08-53bb-41d8-999c-cebba03276ad"), "Tyron", "Johnson" },
                    { new Guid("b04438d8-0498-4b25-852c-a75382021c8b"), "Joe", "Reed" },
                    { new Guid("512deb95-fb20-4efe-9636-b1ea2893b478"), "Mike", "Williams" },
                    { new Guid("bac874a7-16b3-4b84-82ba-ceef2fb529f5"), "Stephen", "Anderson" },
                    { new Guid("a229d19a-88d6-41f8-9787-c87d3e0999d1"), "Hunter", "Henry" },
                    { new Guid("4db26b2f-62f7-4c9c-ba01-885e161e3d6b"), "Keenan", "Allen" },
                    { new Guid("dfa3816e-f7b7-4033-9b44-a0e401125a9c"), "Malik", "Jefferson" },
                    { new Guid("23c4d70f-e8d9-4141-9661-6f3597846d2f"), "Kenneth", "Murray" },
                    { new Guid("542cc175-f6cb-4c6d-96e1-e1051e6e6a5d"), "Uchenna", "Nwosu" },
                    { new Guid("07c69f67-5724-45e7-a0f1-ddd4e3080b97"), "Mike", "Pouncey" },
                    { new Guid("f000367b-2aae-4e3a-9d7a-9590c4b64a1b"), "Drue", "Tranquill" },
                    { new Guid("f0f8409d-00fb-4222-b9cc-55615c4dbed7"), "Kalen", "Ballage" },
                    { new Guid("47c719ec-5d0e-4a41-9be1-2f8fc76dfdc8"), "B.", "J. Bello	" },
                    { new Guid("9eef6ba6-8ca7-4b91-b76d-4c6f22bf9de1"), "Darius", "Bradwell" },
                    { new Guid("45320226-b3c1-42d1-894f-fb8cfc5f53dc"), "John", "Brannon" },
                    { new Guid("7c9bf8a3-5bd8-4f91-ba37-e3b25fe584b5"), "Cole", "Christiansen" },
                    { new Guid("aa5d2ba1-b62d-47d8-8752-e320ee9c7dc5"), "Derwin", "James" },
                    { new Guid("9270fdb3-729e-46eb-b8fc-a09d80a7d58d"), "Jeff", "Cotton" },
                    { new Guid("61ae2941-20be-4c1d-9492-dc57a92a1973"), "Joe", "Gaziano" },
                    { new Guid("6984eb83-2af8-4565-b49d-5d7fd8967198"), "Nate", "Gilliam" },
                    { new Guid("f7aae71c-d090-4266-ae16-6e2adbce34c7"), "Ryan", "Hunter" },
                    { new Guid("98de75ee-c14b-4cb1-8ed4-2a63c1400d23"), "Jessie", "Lemonier" },
                    { new Guid("8562b57f-9a93-42a7-8936-f33e7184fc5a"), "Quenton", "Meeks" },
                    { new Guid("1707fb0e-23d1-4484-943b-d6b306df0421"), "Jason", "Moore" },
                    { new Guid("9dea8960-e731-49c2-9b4b-ef34f508d393"), "T.", "J. Smith	" },
                    { new Guid("dc5b5b93-5156-4493-9e8f-989453580686"), "Breiden", "Fehoko" },
                    { new Guid("1a0184d2-95ef-4062-9bba-69592850a533"), "Breeland", "Speaks" },
                    { new Guid("0d19ebad-faca-47b8-ba50-071c71fc47e7"), "Chris", "Harris Jr.	" },
                    { new Guid("e0ac6e4e-e932-4d9a-98c9-67c8bac54b9d"), "Virgil", "Green" },
                    { new Guid("6a3d2f9a-5c6e-44d1-be22-f6848de6bdba"), "Denzel", "Perryman" },
                    { new Guid("98fd40cf-3da2-4441-b2b1-f5619ce65e89"), "Nick", "Vigil" },
                    { new Guid("374199b2-79c5-44c0-a4af-abacbe1e0934"), "Kyzir", "White" },
                    { new Guid("b3e6c04f-f3ae-4c20-b2b0-f5d54d1ea43b"), "Jahleel", "Addae" },
                    { new Guid("b88fe674-e471-48a0-b690-f90eb6fef3c9"), "Nasir", "Adderley" },
                    { new Guid("e462f647-a0c1-4dcd-bc4f-365c34300a32"), "Tevaughn", "Campbell" },
                    { new Guid("c92c8b22-0d75-42d1-8136-e6ad962cd097"), "Michael", "Davis" },
                    { new Guid("50932545-6cf2-48c5-a678-a1ff124b9d5b"), "Ryan", "Groy" },
                    { new Guid("c264284a-41f0-4c22-8cb8-3ee0c72b0ca4"), "Brandon", "Facyson" },
                    { new Guid("4bb47367-9901-45a5-985a-626199a78027"), "Casey", "Hayward" },
                    { new Guid("caa1a469-a588-4a20-ad6d-ce30b8f1962f"), "Rayshawn", "Jenkins" },
                    { new Guid("dee9b66f-10e9-4782-8c95-02984cf2d0cc"), "Michael", "Badgley" },
                    { new Guid("0b5d3f9f-6f2e-4c41-9681-4ae6b7b82e01"), "Ty", "Long" },
                    { new Guid("7eb43795-3750-43b0-aa77-a8c6d5d24311"), "Cole", "Mazza" },
                    { new Guid("5565551d-491d-4c95-9e30-26e79c1ccd8e"), "Asmar", "Bilal" },
                    { new Guid("5b79bd2d-12f6-47e6-ac2c-47c18910bf67"), "Austin", "Ekeler" },
                    { new Guid("a104ef7d-e572-48d2-aa61-25b19d8ac5ab"), "Alohi", "Gilman" },
                    { new Guid("9a797d5b-afa3-426e-a213-2b6959e60efc"), "Jeff", "Driskel" },
                    { new Guid("69fbc05d-09ef-4431-b81f-304dd8635024"), "Chris", "Smith" },
                    { new Guid("8ba6cf29-3d02-4935-b471-1bb39ddc8c09"), "Kamaal", "Seymour" },
                    { new Guid("c150d8f5-897b-4c29-9a33-3ff436337fee"), "Rodney", "Hudson" },
                    { new Guid("57dd96b8-a0bc-4bbb-a164-284f08784846"), "Gabe", "Jackson" },
                    { new Guid("e5ee0423-6aa9-4638-9bf8-b5c71fa16892"), "Andre", "James" },
                    { new Guid("6a37fcc5-8fca-4b2c-b2ab-28f270c73f2f"), "Kolton", "Miller" },
                    { new Guid("6c92a1f5-97a3-4cf4-b941-7a27e6cb6595"), "Patrick", "Omameh" },
                    { new Guid("cab0ec64-b8ef-464a-bc6f-6ca28f6cae5f"), "Brandon", "Parker" },
                    { new Guid("95031240-065d-488f-aba3-7cb32addc71a"), "John", "Simpson" },
                    { new Guid("99189bb3-852b-4d08-aad2-42887e642b51"), "Sam", "Young" },
                    { new Guid("245601a1-b281-4c3b-a2fa-36a93630208b"), "Maliek", "Collins" },
                    { new Guid("b78898d4-6c3c-4bf5-af1d-5b1af9c769c5"), "Maxx", "Crosby" },
                    { new Guid("bab0fdf8-2338-4d4f-88e6-56ce73a663bc"), "Clelin", "Ferrell" },
                    { new Guid("44f9cc5b-f487-40dc-ad3b-16d42d32c9a8"), "Johnathan", "Hankins" },
                    { new Guid("fa0221af-c895-4685-9af2-c1f8e4a5b5db"), "Maurice", "Hurst Jr.	" },
                    { new Guid("855e8b93-ad32-4770-837c-740bd6b6adde"), "Arden", "Key" },
                    { new Guid("c9ad191b-be99-4a4e-be0c-713047f372d3"), "Carl", "Nassib" },
                    { new Guid("ccdfc905-781d-4ad3-96c9-3c53c6fdd262"), "Denzelle", "Good" },
                    { new Guid("1c5e8c34-891c-41f6-bba9-4145a83816c2"), "Trent", "Brown" },
                    { new Guid("859ca597-1504-4467-8da6-8569af18ae1a"), "Jason", "Witten" },
                    { new Guid("daa1a3ba-215f-4a5a-a065-43f1010e7ad5"), "Darren", "Waller" },
                    { new Guid("a2ab71a9-0958-408f-aaef-047e1acd1c3f"), "Bryan", "Witzmann" },
                    { new Guid("dd0af169-4310-42a0-b009-02515ceb484d"), "Derek", "Carr" },
                    { new Guid("c225840d-47ff-43d1-960c-3f0f5aca0c15"), "Marcus", "Mariota" },
                    { new Guid("78434b7e-073f-43d0-b83c-6a93686d7d8a"), "Nathan", "Peterman" },
                    { new Guid("be7d03c9-1b87-4991-9950-5661645a0e24"), "Devontae", "Booker" },
                    { new Guid("d5d454e7-e58f-4966-be5e-53c44a5ca1e4"), "Alec", "Ingold" },
                    { new Guid("bc7136a3-e4f3-4984-9d43-31f6464ec9cf"), "Josh", "Jacobs" },
                    { new Guid("52f8f6f6-924f-4f50-8dcd-8a7f707814a2"), "Kendal", "Vickers" },
                    { new Guid("d3eeeaae-2b3a-43b6-b287-66a70e899a3d"), "Jalen", "Richard" },
                    { new Guid("2ec84263-5f3f-4a9c-8fdd-118c41cf6fd8"), "Bryan", "Edwards" },
                    { new Guid("52c0c5a4-e6b3-4fee-98ab-77fef7fff179"), "Rico", "Gafford" },
                    { new Guid("b7f14152-ba77-4772-bfdb-5cb06de7fcb0"), "Zay", "Jones" },
                    { new Guid("cdf9a7f2-189a-40e2-9b26-291ba0911a79"), "Hunter", "Renfrow" },
                    { new Guid("dedeae33-fe67-40de-ac16-2f516b43ebc4"), "Henry", "Ruggs" },
                    { new Guid("f26a85b6-394c-43be-b58d-9748ada6d16a"), "Derek", "Carrier" },
                    { new Guid("0ec1f662-d012-4339-a1f3-c294a2a2c744"), "Foster", "Moreau" },
                    { new Guid("b810ca28-0766-4c85-8114-81c151e9bfaa"), "Nelson", "Agholor" },
                    { new Guid("c0fdabbc-0db8-41ba-9893-5521cde2a492"), "Nick", "Kwiatkoski" },
                    { new Guid("8a2eabeb-ae6e-4324-9751-00a9ebddd65d"), "Cory", "Littleton" },
                    { new Guid("2c239751-c9c2-4b76-b355-3b2f3772b839"), "Raekwon", "McMillan" },
                    { new Guid("51800256-9a42-49ab-83b0-951ce111707a"), "Nick", "O'Leary" },
                    { new Guid("2dc5e339-6497-4328-aba2-5fa1f23ac2be"), "Daniel", "Ross" },
                    { new Guid("c204cd83-1992-45f5-8dcb-f5092a35b916"), "Jeremiah", "Valoaga" },
                    { new Guid("ba30e3ee-08a0-4ce8-8144-6cd321d6d093"), "Tyrell", "Williams" },
                    { new Guid("5791b6e4-2d38-4be2-b45e-63c87d38c9c2"), "Marcell", "Ateman" },
                    { new Guid("f6a0a9ef-1ca3-4171-b89c-acad3d2ac894"), "Nick", "Bowers" },
                    { new Guid("2d26f7e0-69a1-4cf1-9dd0-a936fea451c2"), "Robert", "Davis" },
                    { new Guid("85731df0-9b3c-4285-8e86-910e6c3b39b7"), "Tanner", "Muse" },
                    { new Guid("f1c0a654-8bb7-4f52-bdab-b181dae30cac"), "Keelan", "Doss" },
                    { new Guid("71e57ed1-2652-4a69-8291-c461451cdef8"), "David", "Irving" },
                    { new Guid("1316d542-0c27-472b-9c8b-c2035b210ef0"), "Datone", "Jones" },
                    { new Guid("d8f4f0d0-53c5-47e5-98dd-bb229c0c1118"), "Jaryd", "Jones-Smith" },
                    { new Guid("c31050e5-d253-409a-a0f8-ab35fdbb7029"), "Dylan", "Mabin" },
                    { new Guid("c297700a-2d86-4c62-af51-447407727c69"), "Erik", "Magnuson" },
                    { new Guid("74f561b8-2936-4cef-ae12-655281218aac"), "James", "Onwualu" },
                    { new Guid("d5b48064-4b57-4554-b3ce-fc9bb4cda364"), "Theo", "Riddick" },
                    { new Guid("d3097dad-cb63-428e-9608-3a3c8c7cbb09"), "Dominik", "Eberle" },
                    { new Guid("9f4037ac-cee6-4aaf-aa56-bd0044e40083"), "Kemah", "Siverand" },
                    { new Guid("29ece9b0-8b8b-4c74-9af6-6b1074655f11"), "D.", "J. Killings	" },
                    { new Guid("2f6e9d3e-1f44-48da-b480-ba8d7a52a60b"), "Ukeme", "Eligwe" },
                    { new Guid("5db7b6b6-6ab5-48f1-97ff-90230c30e604"), "Nicholas", "Morrow" },
                    { new Guid("77be7d01-3338-4815-95b9-2cdcc57d86af"), "Kyle", "Wilber" },
                    { new Guid("003edf3d-a16d-4535-b811-0742741d7f30"), "Johnathan", "Abram" },
                    { new Guid("272fb445-182b-424b-b858-6c83aff28f05"), "Erik", "Harris" },
                    { new Guid("5483c6f5-3541-4456-a100-79c90d19938a"), "Jeff", "Heath" },
                    { new Guid("5d803a45-26c9-42c9-843e-5d5b0661ae30"), "Isaiah", "Johnson" },
                    { new Guid("6dc30a38-8a70-4b0d-a835-57114ba48dc6"), "Lamarcus", "Joyner" },
                    { new Guid("1e97289c-4dcc-4a9f-9015-b6ebac18c28a"), "Richie", "Incognito" },
                    { new Guid("a93d8edd-7723-4d43-b713-a13cab6e54b2"), "Nevin", "Lawson" },
                    { new Guid("f64ddf7d-631a-431e-9808-0a37caf2d8e2"), "Trayvon", "Mullen" },
                    { new Guid("c1b22814-b2d7-4ed9-82a7-e9f7f4e0fe6a"), "Keisean", "Nixon" },
                    { new Guid("0e207a77-9366-4f45-bf0e-4ad8b96f9823"), "Amik", "Robertson" },
                    { new Guid("57e5c33a-eac5-4846-a2a2-9ad253cd5a4f"), "Daniel", "Carlson" },
                    { new Guid("39f06c9d-8d71-4a0f-b9c9-f9bf9c1bbe0e"), "A.", "J. Cole	" },
                    { new Guid("007e9e03-309c-475c-ba3e-88e801aac176"), "Trent", "Sieg" },
                    { new Guid("99cd4907-6e77-4bcf-a731-cf0264115bc3"), "Damon", "Arnette" },
                    { new Guid("2e113c46-db09-484a-880a-10e089a22d58"), "Dallin", "Leavitt" },
                    { new Guid("c5b6f03c-25b3-4945-bb6e-3828f3bbec9f"), "Teair", "Tart" },
                    { new Guid("d2cf1b13-26e0-43a6-80da-9f30420cdc6a"), "Tuzar", "Skipper" },
                    { new Guid("793688f5-1003-4600-ac6a-be6830a1ffaf"), "Trevor", "Siemian" },
                    { new Guid("32f1349d-c099-4be0-9652-89fa7adf92ba"), "Jack", "Doyle" },
                    { new Guid("33f6499a-599d-4404-851c-ad79fe4e0aad"), "Noah", "Togiai" },
                    { new Guid("77f49145-730e-4868-83ef-1eea5acc8d97"), "Anthony", "Castonzo" },
                    { new Guid("5bcdf342-892c-4cc1-97de-cb54fcb65652"), "Le'Raven", "Clark" },
                    { new Guid("149030d8-3b54-4187-9dba-42331265142d"), "Mark", "Glowinski" },
                    { new Guid("357a00ac-2301-4042-932f-ed29d1b55ecc"), "Chaz", "Green" },
                    { new Guid("cc55362c-a58e-41be-87ae-b237e6a4fcac"), "Ryan", "Kelly" },
                    { new Guid("ef012960-8364-4971-9c42-64c5739851bb"), "Quenton", "Nelson" },
                    { new Guid("f4f9d076-6064-4e9f-ac0d-db9468fde629"), "Danny", "Pinter" },
                    { new Guid("3c59937e-5e68-48c8-b176-206ee4b4f322"), "Braden", "Smith" },
                    { new Guid("74900c09-2c3f-4c4c-ac65-47383f19851d"), "Denico", "Autry" },
                    { new Guid("e79ff803-3b39-425d-8fe7-55bbb2082a6b"), "Ben", "Banogu" },
                    { new Guid("f541bbdc-c25a-49e3-987b-da8bda83b968"), "DeForest", "Buckner" },
                    { new Guid("0d32ff1f-fd11-4f5b-b7cb-ef53887b3f1f"), "Ron'Dell", "Carter" },
                    { new Guid("53d61cb7-b0bc-495a-a5b7-fc41c6b61cb6"), "Sheldon", "Day" },
                    { new Guid("e9ac2e9a-74c9-457e-ba95-17883a3b95ed"), "Trey", "Burton" },
                    { new Guid("e04d7305-9a87-4382-8920-7db2960f6a96"), "Mo", "Alie-Cox" },
                    { new Guid("4a080b27-2851-4b7b-939f-856a1536145c"), "Michael", "Pittman Jr.	" },
                    { new Guid("d200d2c6-cbdf-4d12-91b2-c36bfbe2e874"), "Dezmon", "Patmon" },
                    { new Guid("f6388bcf-6226-448c-9770-c1636445026f"), "Jonathan", "Owens" },
                    { new Guid("22965467-04a3-490f-903d-3e57ac4d6982"), "Scottie", "Phillips" },
                    { new Guid("4dd3dc4f-6333-404f-b78f-9e6a24457b42"), "C.", "J. Prosise	" },
                    { new Guid("99ee33eb-8fcd-4854-b1c7-4b7cd65cf8ef"), "Damion", "Ratley" },
                    { new Guid("51c43138-aaa1-4828-a3be-71987d21fed5"), "Devin", "Smith" },
                    { new Guid("99969ee3-108f-454a-a1ee-042c2d657d33"), "", "" },
                    { new Guid("aeafd791-f0bd-400f-9afb-99cdabd3be9b"), "Jacoby", "Brissett" },
                    { new Guid("e72d3c28-015f-48e5-a204-a2f9812f7624"), "Justin", "Houston" },
                    { new Guid("89630fed-706c-4f92-8d53-30df488b55dd"), "Jacob", "Eason" },
                    { new Guid("52caa8ce-7738-4c76-a634-c330c4c2bbc3"), "Nyheim", "Hines" },
                    { new Guid("8ea7cc24-6690-450d-b2d0-acb18d530d9d"), "Jonathan", "Taylor" },
                    { new Guid("bdf302e7-d137-45d0-8c14-b2e9e969b592"), "Jordan", "Wilkins" },
                    { new Guid("f04a796b-4259-4bb5-8712-c16fdc10a4d9"), "Ashton", "Dulin" },
                    { new Guid("11773dc0-6b92-40f4-b084-70ebabd00801"), "T.", "Y. Hilton	" },
                    { new Guid("b6d12aed-f40c-420c-8c8a-c180ffa86b50"), "Marcus", "Johnson" },
                    { new Guid("72c30e02-c89e-4314-aefc-7660128865ab"), "Zach", "Pascal" },
                    { new Guid("ca13e272-a99d-40fe-af53-8603d08487f1"), "Philip", "Rivers" },
                    { new Guid("76fe15ed-0614-4b2a-9a2e-0cbd6b3287cb"), "Tyquan", "Lewis" },
                    { new Guid("e1df3191-f897-40a3-8d2a-8dd325dbdc94"), "Al", "Muhammad" },
                    { new Guid("da086af1-db7a-43e8-ac6e-5aea29203270"), "Taylor", "Stallworth" },
                    { new Guid("5ef1fd64-3121-4354-a7a4-341e54b86cfb"), "Matthew", "Adams" },
                    { new Guid("71c138a8-4c43-4c26-aab0-b6cdf2b90375"), "Parris", "Campbell" },
                    { new Guid("f7363442-8152-4e33-9095-51bb5a9787d5"), "Malik", "Hooker" },
                    { new Guid("40471908-44d3-42df-bbed-c4e3a5dd3131"), "Marlon", "Mack" },
                    { new Guid("1ee05b7c-cd97-4bf6-8a4b-51c5f6b64102"), "Rolan", "Milligan" },
                    { new Guid("c9eaef61-6ee5-4736-a9c7-452c8f667b31"), "Skai", "Moore" },
                    { new Guid("7977be09-3af6-4f2c-ba0a-4e2c28ed5310"), "Marvell", "Tell" },
                    { new Guid("7cdc1a5c-698f-4113-87d7-3fc07972e1c0"), "Rigoberto", "Sanchez" },
                    { new Guid("0e7323a4-c19a-48bd-abea-23f726253cee"), "Kemoko", "Turay" },
                    { new Guid("1b2370f9-65c2-4c7b-9e6d-81ce5d1aa552"), "Ibraheim", "Campbell" },
                    { new Guid("b49a7d5d-bc40-4e18-8d79-80aed2bd20c7"), "Andre", "Chachere" },
                    { new Guid("563065ed-40bb-4d71-aa3c-fd7e17912717"), "Kameron", "Cline" },
                    { new Guid("a7c51cd5-0dff-45d3-8bd5-b5d51b06545b"), "Jake", "Eldrenkamp" },
                    { new Guid("b70d66d4-25aa-4455-9459-7645913fcb90"), "Matt", "Gay" },
                    { new Guid("6857a42d-522b-4419-a7c8-b3cb7d8b68f1"), "Farrod", "Green" },
                    { new Guid("1ff92128-e257-44bf-a615-3da737b30b31"), "DeMichael", "Harris" },
                    { new Guid("1f0a6896-311d-4315-af6a-556356c67101"), "Darius", "Anderson" },
                    { new Guid("62202bc0-dece-4d18-9c09-d1c612b76d9c"), "Elijah", "Nkansah" },
                    { new Guid("e9bc000d-fb1c-40fd-87db-e5db1e9d409c"), "Luke", "Rhodes" },
                    { new Guid("1d20df36-4b95-420d-9d59-4239dde1f799"), "Rock", "Ya-Sin" },
                    { new Guid("2e567d7b-759e-455a-b845-8d65946bcb3e"), "Grover", "Stewart" },
                    { new Guid("4f76fa85-5ec6-49d6-a624-8d1c2cbaf258"), "Zaire", "Franklin" },
                    { new Guid("d61ee0d3-1327-4eaa-a208-5640a843f606"), "Jordan", "Glasgow" },
                    { new Guid("5351aab1-617d-46ed-a130-e9d9069ced23"), "Darius", "Leonard" },
                    { new Guid("d554e9fb-7759-4fbb-8864-6fa6a5f98d05"), "Bobby", "Okereke" },
                    { new Guid("d7a6b001-b700-4f0a-8fb8-645c2a6b4882"), "E.", "J. Speed	" },
                    { new Guid("70e68923-9214-475d-ae91-ed1dcfd16557"), "Anthony", "Walker Jr.	" },
                    { new Guid("57de0546-cf72-45f5-9781-8bf284a25366"), "Rodrigo", "Blankenship" },
                    { new Guid("8a754a6b-16a1-4768-98d1-132e07236f02"), "Julian", "Blackmon" },
                    { new Guid("9bb64927-876d-446a-a7d5-762b1406934d"), "Kenny", "Moore" },
                    { new Guid("c380103f-fb71-4197-bf6f-53004c9d8c65"), "George", "Odum" },
                    { new Guid("e5da040a-ce9c-472a-a499-7983dc6f5a3e"), "Xavier", "Rhodes" },
                    { new Guid("bf342526-7918-4434-8385-f8ecfd6c5f6c"), "Isaiah", "Rodgers" },
                    { new Guid("5bae1761-e283-42e9-a1f1-a832c4546078"), "Tremon", "Smith" },
                    { new Guid("5ee02790-b6c1-4f3c-9429-4e99fe77e08b"), "Khari", "Willis" },
                    { new Guid("c7fc240c-de4e-4494-8c9f-f0f0d6ad7a7b"), "Tavon", "Wilson" },
                    { new Guid("9488e80b-f0ce-40e8-b200-526f8f474401"), "T.", "J. Carrie	" },
                    { new Guid("435da7f0-a5b6-49f8-863b-a960a25462f2"), "Hale", "Hentges" },
                    { new Guid("9be64d9f-0f43-4e7d-98f9-a6ba0315797e"), "Steven", "Mitchell" },
                    { new Guid("2730bca6-ef6d-410c-9bc4-8e794999db3a"), "Brett", "Maher" },
                    { new Guid("36612fcf-7d44-4d46-81ad-c7e2ef1aeefe"), "Will", "Fuller" },
                    { new Guid("6ebf4789-9c10-4c77-bcf7-8b61f2f0b43a"), "Kenny", "Stills" },
                    { new Guid("1467eaa2-416f-4d11-98b7-775ef5a5b27c"), "Jordan", "Akins" },
                    { new Guid("1e63963c-d010-49e8-b252-ee8f344df561"), "Pharaoh", "Brown" },
                    { new Guid("ffe96e11-f6f9-45c8-919d-c3ce24169622"), "Darren", "Fells" },
                    { new Guid("9e54cdff-4e51-4415-95b5-3bdc9bd6169e"), "Zach", "Fulton" },
                    { new Guid("f82dfa9b-4a32-4f72-9594-2bba3edd9afc"), "Charlie", "Heck" },
                    { new Guid("a9010d0f-87e5-4acf-bc9e-a04c8394fd45"), "Tytus", "Howard" },
                    { new Guid("8b25c4b3-3cc1-442e-842e-5178a12b6030"), "Roderick", "Johnson" },
                    { new Guid("e32eca19-1d28-4378-9475-3e55ac9d81cf"), "Senio", "Kelemete" },
                    { new Guid("3e332afc-8d2b-4915-b6af-b7266dc54ddc"), "Nick", "Martin" },
                    { new Guid("5cd3005f-efab-43b1-a40d-93216ed9ab55"), "Brent", "Qvale" },
                    { new Guid("355f0220-0766-40f6-8774-d00a7b02aba2"), "Laremy", "Tunsil" },
                    { new Guid("3512202f-55f2-41e8-bcd2-f90ce94b865d"), "Ross", "Blacklock" },
                    { new Guid("e4e292b9-0999-490f-828c-3fd37c6120f9"), "Brandon", "Dunn" },
                    { new Guid("c5226f5b-d25a-4af0-8648-1cb38c61ce81"), "Keke", "Coutee" },
                    { new Guid("f1a022ce-aa0d-488c-ac7b-c3a2220ad79c"), "Isaiah", "Coulter" },
                    { new Guid("4fb7fbfa-97f4-4649-a95f-8a95ac1ade22"), "Brandin", "Cooks" },
                    { new Guid("bc5fede4-800d-4e06-b30d-a8952b64768c"), "Randall", "Cobb" },
                    { new Guid("5aa4e4c2-1c64-4a47-99a0-ae79e2e8107a"), "Anthony", "Johnson" },
                    { new Guid("840f13ae-94cf-4fd4-a3aa-dc53abe2b359"), "Jarron", "Jones" },
                    { new Guid("38b34efd-fc76-4e2c-bc0d-f8c15736ad4b"), "Kevin", "Rader" },
                    { new Guid("0b241785-4925-4e33-b5ff-5d0ecab52e17"), "Wendell", "Smallwood" },
                    { new Guid("51223049-11ba-418f-acf0-eeea6570fd6d"), "Calvin", "Taylor" },
                    { new Guid("47cec6a8-691a-40b4-a22b-5a7b915c7173"), "Corliss", "Waitman" },
                    { new Guid("697d6f77-93ba-47f3-85fd-68c37805a898"), "Brandon", "Walton" },
                    { new Guid("53650fed-d522-4aa3-a135-738d7f18b00e"), "P.", "J. Hall	" },
                    { new Guid("ca5a47a1-4d07-488a-879c-42a741875acc"), "Cody", "White" },
                    { new Guid("67832800-8f58-4c3a-a2e0-a59ce624d644"), "A.", "J. McCarron	" },
                    { new Guid("51ef10f0-857a-4560-ace7-97d946a74bb4"), "Deshaun", "Watson" },
                    { new Guid("cf9b7f8b-ad52-4594-a009-0b65f31e604d"), "Cullen", "Gillaspia" },
                    { new Guid("50e556cc-464d-4f48-b982-a934705458d0"), "Buddy", "Howell" },
                    { new Guid("4e7f167d-d933-4e83-9ff0-b611adedf350"), "David", "Johnson" },
                    { new Guid("127919a8-9da6-4875-98b4-dab7b00c048e"), "Duke", "Johnson" },
                    { new Guid("604ba30c-337e-4ddb-b735-33a4111a36fa"), "DeAndre", "Carter" },
                    { new Guid("8c57a9d4-463c-4318-b458-65f0e1e2f4c7"), "Ray", "Wilborn" },
                    { new Guid("bdcfe13c-addf-4c09-9a8e-564e3f96e377"), "Charles", "Omenihu" },
                    { new Guid("13ba8b99-dbe9-4d02-a4f5-795190ec3707"), "Carlos", "Watkins" },
                    { new Guid("52999a96-0b7a-40dc-87cb-be1d3d6557ae"), "J.", "J. Watt	" },
                    { new Guid("2190ac6c-7a7b-4ac5-9145-827e69b72b1c"), "Kaʻimi", "Fairbairn" },
                    { new Guid("9c6e43d3-80c5-4df2-86c0-fe908a205904"), "Jon", "Weeks" },
                    { new Guid("92b21fda-0ff6-4d48-99f4-74ad276cd093"), "Gareon", "Conley" },
                    { new Guid("09f607ea-fd66-499f-9ef0-1517177092c0"), "Duke", "Ejiofor" },
                    { new Guid("309f4a17-b273-46a8-ba64-faf90c7bbe04"), "Benardrick", "McKinney" },
                    { new Guid("d96de214-ac08-42cc-99b4-367745ea02d7"), "A.", "J. Moore	" },
                    { new Guid("50a18923-1810-4604-bffb-5af8126f50bd"), "Max", "Scharping" },
                    { new Guid("e677feb8-569a-4b67-8030-0f4b57deadef"), "Bryan", "Anger" },
                    { new Guid("6863f95c-6295-4fdf-a5b7-659492e6220f"), "Eddie", "Vanderdoes" },
                    { new Guid("168dcf11-a172-4a7e-876f-9f923ecd3320"), "Auzoyah", "Alufohai" },
                    { new Guid("72326b49-a0d4-4e21-a851-5330579471a7"), "Davin", "Bellamy" },
                    { new Guid("decc49ac-e19f-497a-8f19-2cc18bb96734"), "Anthony", "Chesley" },
                    { new Guid("d353dfdc-8074-47c4-94d8-4ce8dade249e"), "Emmanuel", "Ellerbee" },
                    { new Guid("cdebbb1d-5607-40c8-9b59-78730c15c9cc"), "Nate", "HallI" },
                    { new Guid("ddab155e-06cd-4f5f-92e5-e43b1cd7cb8d"), "Chad", "Hansen" },
                    { new Guid("8dbe92a4-cb40-459d-b5b3-f6be05e352a3"), "Corey", "Liuget" },
                    { new Guid("7ed77bae-689c-4d71-b483-f9df659d7f21"), "Kahale", "Warring" },
                    { new Guid("1b2218ec-13c1-4a8f-8b7e-c55050d9d9a2"), "Greg", "Mancz" },
                    { new Guid("10fb8bde-9e24-4e28-b946-b5bf268427b5"), "Michael", "Thomas" },
                    { new Guid("5dd73ccc-4c0a-45f1-be56-916f054fef2d"), "Justin", "Reid" },
                    { new Guid("45c218c1-f070-41e5-948a-d39ef8f23015"), "Tyrell", "Adams" },
                    { new Guid("06e50489-3120-4f53-9398-9a1b0fac3e11"), "Dylan", "Cole" },
                    { new Guid("fbee6396-b8df-4408-8a14-b6acd5968ec5"), "Zach", "Cunningham" },
                    { new Guid("325a90ae-3858-4a6d-930f-9fa3d9855e1e"), "Kyle", "Emanuel" },
                    { new Guid("3fe339ee-4e1e-400b-af46-d5852d630e2c"), "Jonathan", "Greenard" },
                    { new Guid("469f9993-4372-4478-80f2-47d525ffa4af"), "Peter", "Kalambayi" },
                    { new Guid("7912caad-ebdd-44a9-abfe-d546b107c0d6"), "Jacob", "Martin" },
                    { new Guid("43542bdb-7908-475a-b52f-9532bbdda05a"), "Bradley", "Roby" },
                    { new Guid("19e6fdd6-9c63-4e22-a30b-32615a8b615b"), "Whitney", "Mercilus" },
                    { new Guid("cd1d729d-ac60-4289-a982-4ec1a080058f"), "Cornell", "Armstrong" },
                    { new Guid("2eb625d9-8b13-49c5-b413-50100f031bc1"), "Keion", "Crossen" },
                    { new Guid("7b081a22-43c2-41c5-a84b-3a0d4bba7f51"), "Phillip", "Gaines" },
                    { new Guid("091ac95b-7271-4229-99f6-80a8559082f4"), "Vernon", "Hargreaves" },
                    { new Guid("84fc19e3-c856-4255-96c2-7960e991cf3c"), "Lonnie", "Johnson Jr.	" },
                    { new Guid("65b16725-8ade-497d-bf77-8bc24f54cb98"), "Eric", "Murray" },
                    { new Guid("fc229e02-af1d-43b9-9fc2-aece8b5c1c9e"), "John", "Reid" },
                    { new Guid("eca205be-e23a-46c6-860f-c475ed41a69a"), "Brennan", "Scarlett" },
                    { new Guid("fc322296-531b-4c4c-8056-0784b90cc848"), "Jayrone", "Elliott" },
                    { new Guid("eb911dc8-5d03-44a0-883e-4eacf5f54675"), "Joey", "Hunt" },
                    { new Guid("672572a4-14c6-4493-86ab-4c253cb76ddc"), "Cassius", "Marsh" },
                    { new Guid("0f8968db-082c-4443-80b1-b653ba2ff38e"), "Nate", "Davis" },
                    { new Guid("8a74b954-f470-41b3-9c45-9cc8f1668f72"), "Jamil", "Douglas" },
                    { new Guid("31e97b7d-3f97-4f5d-9cce-05e94ffde451"), "Ben", "Jones" },
                    { new Guid("c9e34314-02bd-4e5c-9a21-c7db0a074775"), "Dennis", "Kelly" },
                    { new Guid("50fe9fe9-c724-4235-a6ec-e8522cf89a4e"), "Daniel", "Munyer" },
                    { new Guid("708dc28e-6e6d-478e-9b4c-a49d6c6622c4"), "David", "Quessenberry" },
                    { new Guid("f2375dbb-5c1a-41c6-b888-482c4445060e"), "Rodger", "Saffold" },
                    { new Guid("d5ba2b0f-3c22-4cf0-8d6d-98dc8faa231e"), "Ty", "Sambrailo" },
                    { new Guid("ea33aea8-4e0c-43e9-a96c-728d8b402499"), "Isaiah", "Wilson" },
                    { new Guid("ad14af31-547d-400a-8bf9-30c10341e0d3"), "Jack", "Crawford" },
                    { new Guid("734b58c2-9630-4adc-b5d3-4a30c0829954"), "Matt", "Dickerson" },
                    { new Guid("a0fe104b-6544-4d38-bb7f-ec0a55b39c69"), "DaQuan", "Jones" },
                    { new Guid("231df3d0-a3ee-4ded-b0b9-ca116593f42a"), "Larrell", "Murchison" },
                    { new Guid("eac75822-a429-429d-83db-5c818f6e9f36"), "Jeffery", "Simmons" },
                    { new Guid("a114850c-4eeb-4249-bac1-d630b994f461"), "Daren", "Bates" },
                    { new Guid("eb2aa5b8-245e-467b-ac4e-1ca728c7c80e"), "Aaron", "Brewer" },
                    { new Guid("ec2ef0e1-4e09-47bf-b498-e4671a2e3eb8"), "Geoff", "Swaim" },
                    { new Guid("34de44b7-4b21-4ae1-b002-65c695bd4b13"), "Jonnu", "Smith" },
                    { new Guid("8f52ad90-7b8d-4aba-834b-22a80d5f43af"), "MyCole", "Pruitt" },
                    { new Guid("d4204181-f538-4e6f-b6d3-2f5b5dfefc30"), "Josh", "Nurse" },
                    { new Guid("011e1a3e-ee56-4c7a-92a7-93000a830f4f"), "Austen", "Pleasants" },
                    { new Guid("a17c1385-1b6d-47bd-85d9-ae0be38b685e"), "Trey", "Quinn" },
                    { new Guid("6f0c7f86-89dc-4c83-87b4-b3f72d43ecde"), "Eric", "Saubert" },
                    { new Guid("324fa4be-37da-415e-9ed0-6b6fb9a1369e"), "Tre'Vour", "Wallace-Sims" },
                    { new Guid("0ce4d577-0bf8-4451-a0f7-a02565d6e44b"), "Ryan", "Tannehill" },
                    { new Guid("4c30df84-0750-4725-9bb3-44ff3d5c1692"), "Logan", "Woodside" },
                    { new Guid("c4e8c84d-20c8-4066-9e56-e79aedbf2c33"), "Vic", "Beasley" },
                    { new Guid("f7c50b0d-d10f-4647-b632-805c0be99e77"), "Khari", "Blasingame" },
                    { new Guid("81458d9f-175a-4f6f-8264-9400cedc28cf"), "Jeremy", "McNichols" },
                    { new Guid("fe09d484-ff54-499a-bf15-d9b7e19f4961"), "A.", "J. Brown	" },
                    { new Guid("8932f3b7-f844-41cd-aeeb-443a221e8a5c"), "Corey", "Davis" },
                    { new Guid("cb0d6035-7843-47f9-91b9-35c39590a626"), "Adam", "Humphries" },
                    { new Guid("7ead26bd-d927-4955-9eac-fc949fbc9089"), "Kalif", "Raymond" },
                    { new Guid("23fa2a1c-e681-462c-a5a9-c38348b26633"), "Nick", "Westbrook-Ikhine" },
                    { new Guid("17d82f6a-7c5b-4a1d-8360-d0620a2996ed"), "Anthony", "Firkser" },
                    { new Guid("dece371c-ece4-4191-b126-e4d4f3a6d1a0"), "Derrick", "Henry" },
                    { new Guid("f13616c1-bc66-4ac9-af5d-4f4cc083ab71"), "Jayon", "Brown" },
                    { new Guid("db8c8a4c-069b-41ae-a409-2cd927720858"), "Jadeveon", "Clowney" },
                    { new Guid("6aa31df6-d8d4-4809-938d-1865a02c90c9"), "Nick", "Dzubnar" },
                    { new Guid("7e196d92-9c4b-41c8-9ac8-c4221de7ed45"), "Taylor", "Lewan" },
                    { new Guid("ba3cd572-f261-40b7-9922-4d150d696487"), "Anthony", "McKinney" },
                    { new Guid("45de16d3-be17-4dee-b22e-81d93c6351eb"), "Senorise", "Perry" },
                    { new Guid("234df961-36e4-4319-a09a-470ed80a177c"), "Paul", "Adams" },
                    { new Guid("fcea594d-4243-4a76-a679-5c88e7e748f2"), "Cameron", "Batson" },
                    { new Guid("4c722491-3722-4e78-b143-0797a12de541"), "Breon", "Borders" },
                    { new Guid("8a3a9192-836c-4c6f-a611-c74e077a8ea2"), "Will", "Compton" },
                    { new Guid("fc8259bb-6f1d-4e2c-8b07-0cf04579ae23"), "Adoree'", "Jackson" },
                    { new Guid("2018e66b-a324-4877-a85b-c27cdedd4c42"), "D'Onta", "Foreman" },
                    { new Guid("6077b135-b8e7-4c06-99bd-ae270f8687ba"), "Cody", "Hollister" },
                    { new Guid("6817232e-76e9-42a7-86c5-e2f480a50b87"), "Tommy", "Hudson" },
                    { new Guid("bb1e8407-68c9-4aa9-adf1-4b0ab6ce9c19"), "Brandon", "Kemp" },
                    { new Guid("9063eed0-219a-43d7-830e-7de595e46926"), "Tucker", "McCann" },
                    { new Guid("5d30ef12-db14-4cf5-b31f-eb6524a835bd"), "Matt", "Overton" },
                    { new Guid("27aa1cd3-aade-4268-9978-e7930c271dbb"), "Wyatt", "Ray" },
                    { new Guid("8aae6a0c-4ef3-423b-839d-b74dd49c73e8"), "Chester", "Rogers" },
                    { new Guid("cf7486f0-ff53-4653-b16c-cbf12465caad"), "Parker", "Hesse" },
                    { new Guid("05cb8660-8c4b-49cd-be5a-738812a52139"), "Bruce", "Miller" },
                    { new Guid("144741dd-6bcc-42a6-892d-9663b22d0b2d"), "Kristian", "Fulton" },
                    { new Guid("b6a663ac-68e5-455f-990a-55938e3c555b"), "Brett", "Kern" },
                    { new Guid("66d7d5c7-8c41-4b67-be2b-c37d8d012253"), "Rashaan", "Evans" },
                    { new Guid("e84b97fb-1955-4970-a65e-fcc561e3f73e"), "Harold", "Landry" },
                    { new Guid("a35ec934-228a-4cfb-938a-48ff2d67be26"), "David", "Long Jr.	" },
                    { new Guid("79faf396-d122-4f58-b090-a18f67286e58"), "Derick", "Roberson" },
                    { new Guid("39798984-7e0f-4482-ac70-e985dac78114"), "Malcolm", "Butler" },
                    { new Guid("2889bd26-ebbd-419e-b09c-59e385cd6cb8"), "Kevin", "Byard" },
                    { new Guid("0b11f3c0-3fd0-4d8c-9e3b-7e6306fd887f"), "Dane", "Cruikshank" },
                    { new Guid("a4d41f62-7451-4f75-9806-df86d623bb19"), "Darrynton", "Evans" },
                    { new Guid("28125e12-e7f2-4744-9f3d-382dfd3da14f"), "Amani", "Hooker" },
                    { new Guid("a2375a14-7214-451d-b46c-921e00b7e62e"), "Joshua", "Kalu" },
                    { new Guid("44bccc13-aaed-4018-8cc5-255d0399cbcd"), "Desmond", "King" },
                    { new Guid("baff93a6-af7e-4308-b6ad-76355d2160bd"), "Christopher", "Milton" },
                    { new Guid("fb09807b-c0df-432a-918d-b76011e8ffa9"), "Kareem", "Orr" },
                    { new Guid("bb02aaff-cfae-4626-a72c-3f649bf13b22"), "Tye", "Smith" },
                    { new Guid("ce71a369-b343-4a98-9609-21eab0254c9f"), "Kenny", "Vaccaro" },
                    { new Guid("16a0e211-33a3-4caa-a027-7761d6a72fa2"), "Stephen", "Gostkowski" },
                    { new Guid("1665b738-ae65-4ddb-9c01-6af44324ec0f"), "Chris", "Jackson" },
                    { new Guid("68621676-5a37-4089-bead-2b605624fff7"), "Daurice", "Fountain" },
                    { new Guid("0727432c-0e76-4a26-9d13-6c7021fa5d6a"), "Doug", "Middleton" },
                    { new Guid("c2f61eb6-d6ac-4124-b1a3-44942983024d"), "K.", "C. McDermott	" },
                    { new Guid("ac234845-2fd3-485a-b3f0-5953333d26c8"), "Ben", "Bartch" },
                    { new Guid("c8feec1b-4265-486e-a413-9436e4a1b06b"), "A.", "J. Cann	" },
                    { new Guid("7891eb26-c105-4b3a-8df8-f0c7d8dc5cd0"), "Brandon", "Linder" },
                    { new Guid("f9af168e-58d7-4ffc-876a-18eaa194effe"), "Andrew", "Norwell" },
                    { new Guid("ccc25b82-8899-4a9e-a108-bb840ae1ccaa"), "Will", "Richardson" },
                    { new Guid("e215a0d1-b07c-4aea-b80e-27ba1cf31874"), "Cam", "Robinson" },
                    { new Guid("32c89179-f186-49a5-8e99-3761c05b9ec7"), "Tyler", "Shatley" },
                    { new Guid("1d1299a8-9434-4509-9d6a-95c9c0e6fb5f"), "Jawaan", "Taylor" },
                    { new Guid("4cb7181d-c281-487d-847a-ed7582dbf89f"), "Josh", "Allen" },
                    { new Guid("ae8caf88-edc4-48ae-8f64-8f2724535b23"), "Taven", "Bryan" },
                    { new Guid("c7dff3e7-ed57-498d-aee2-fe2c020ca3a0"), "K'Lavon", "Chaisson" },
                    { new Guid("ae3b5ef5-cbff-415c-848e-47ebd9e98a05"), "Doug", "Costin" },
                    { new Guid("22fc96c3-6fdc-407a-b073-0115eb4c7d80"), "Daniel", "Ekuale" },
                    { new Guid("8a941993-3634-4457-85c7-8e8ddb320b5f"), "Adam", "Gotsis" },
                    { new Guid("1a404a82-1cee-444f-9ec5-0589d056c96d"), "DaVon", "Hamilton" },
                    { new Guid("94dd1a2f-4b57-40b8-8956-46933047f0b8"), "James", "O'Shaughnessy" },
                    { new Guid("11ee22ee-2b2e-4db2-b991-6731af5cf3b4"), "Ben", "Ellefson" },
                    { new Guid("cb8ecb34-d569-47de-840f-1d887d888941"), "Tyler", "Eifert" },
                    { new Guid("ec79b0a7-dfc5-4f8f-a48d-d74ae7a72af9"), "Tyler", "Davis" },
                    { new Guid("22fd89e2-28ba-4089-bd1c-e1fc706c819f"), "Carter", "O'Donnell" },
                    { new Guid("eefc6309-a426-4801-934a-d8b1509ad973"), "Will", "Sunderland" },
                    { new Guid("518ddba5-af1e-46cc-bde1-43605b4b5fd6"), "Chris", "Williams" },
                    { new Guid("2acc0d8a-3a0c-488b-a33b-874e502fe514"), "Robert", "Windsor" },
                    { new Guid("3574f093-70f2-457d-bdfe-ee687362268f"), "Mike", "Glennon" },
                    { new Guid("024427de-112f-4f52-ab79-ac2b2ce3f452"), "Jake", "Luton" },
                    { new Guid("270ab0b0-65ba-4e58-b793-fabdba16b2df"), "Gardner", "Minshew" },
                    { new Guid("f2889fd4-c578-4d94-8410-181e0445c1ce"), "Aaron", "Lynch" },
                    { new Guid("0c555be3-d863-428c-be4e-24d214439102"), "Dare", "Ogunbowale" },
                    { new Guid("fbd5d2fc-9aa3-4c45-b2a9-c3fdeb1d827a"), "James", "Robinson" },
                    { new Guid("e711cda7-f983-4de8-9c50-e7ac125f3caf"), "Chris", "Thompson" },
                    { new Guid("bf3365dd-2dc0-4733-b2a2-0958033d21a9"), "D.", "J. Chark	" },
                    { new Guid("1a3b9978-9c5b-44a6-8824-989516dc7ad9"), "Keelan", "Cole" },
                    { new Guid("2a213620-ff3a-445b-a315-e804ccfcb52b"), "Chris", "Conley" },
                    { new Guid("f248a96e-1dba-4dc4-b2d1-19afb1002085"), "Collin", "Johnson" },
                    { new Guid("e26700f5-c1bd-442b-ab14-aaa7f54d131e"), "Laviska", "Shenault" },
                    { new Guid("f3e5369f-289c-4ea5-83ce-8c552362c00a"), "Devine", "Ozigbo" },
                    { new Guid("be9fbb7c-4a09-43d5-b179-515a4566a792"), "Caraun", "Reid" },
                    { new Guid("f3fdc226-8dbd-4f6b-a29c-345738477b91"), "Dawuane", "Smoot" },
                    { new Guid("c611c586-cf4d-489a-b450-79fdf3a75a20"), "Dakota", "Allen" },
                    { new Guid("f438e72a-649f-4127-ba23-50bf8a3db11a"), "Leon", "Jacobs" },
                    { new Guid("674c5960-5dce-4a77-b1c2-b15bf4140b6d"), "Abry", "Jones" },
                    { new Guid("a8bf77ee-2e59-4c45-a923-35d186ee02d5"), "Lerentee", "McCray" },
                    { new Guid("cb570d0e-a5e5-42f3-8417-d27a4aa7a071"), "Rashaan", "Melvin" },
                    { new Guid("f672412b-63ea-42ce-af46-940b0f93ccd5"), "Josh", "Oliver" },
                    { new Guid("17509a57-7dc6-49ed-8565-84db24e6158c"), "Dontavius", "Russell" },
                    { new Guid("ae4f2993-4027-41c5-8cd5-074eba80a733"), "Dede", "Westbrook" },
                    { new Guid("7e8fd4b9-5984-447f-9d54-40f23b350b7d"), "D.", "J. Hayden	" },
                    { new Guid("87260e8a-da1b-45a8-bfcb-8c8d3de219b4"), "Andrew", "Wingard" },
                    { new Guid("ca6384fe-e669-479f-8384-520712916c52"), "Evan", "Boehm" },
                    { new Guid("cf49fa48-b990-4456-8d6f-ce0fba7cda15"), "Jon", "Brown" },
                    { new Guid("ce1627a9-7d75-433c-95a3-45309ea2cf4e"), "Nathan", "Cottrell" },
                    { new Guid("f99fc8b6-0963-477d-af69-ce1b5c54dc2e"), "Nate", "Evans" },
                    { new Guid("41411d86-72d6-4b1b-9c25-8b5bf5af9ab2"), "Joe", "Giles-Harris" },
                    { new Guid("b8b59117-8921-42ae-a1c3-ef2bd16c8b31"), "Terry", "Godwin" },
                    { new Guid("6a6412dc-c6c8-4eed-8e80-c798363cc6ca"), "Josh", "Hammond" },
                    { new Guid("151823af-dbfe-4a6b-bd5a-b9f463c81b58"), "Al", "Woods" },
                    { new Guid("5cfd1f9d-c0c3-4601-a8bf-f47658877828"), "Nate", "Meadors" },
                    { new Guid("1740ba69-60f7-4e80-a3fe-aa38d26a9eca"), "Ryquell", "Armstead" },
                    { new Guid("09c93a03-b5c9-4241-b673-830f9b6b1699"), "Josh", "Lambo" },
                    { new Guid("c8b6b7d9-29ae-43e8-8e5b-1498efebe9c5"), "Kamalei", "Correa" },
                    { new Guid("e1a298da-d6b0-4576-945f-f24e6ce0ca68"), "Myles", "Jack" },
                    { new Guid("e837e2dc-4479-4579-89bc-6d6cea462218"), "Shaquille", "Quarterman" },
                    { new Guid("fde138e1-011d-411a-82d0-84883bce4b7a"), "Joe", "Schobert" },
                    { new Guid("fecd52aa-ffee-4248-aa4f-f9c87464c225"), "Quincy", "Williams" },
                    { new Guid("b25de65a-f5b8-4fb8-91af-671cc0801fd8"), "Luq", "Barcoo" },
                    { new Guid("9bc51694-7d50-4266-82e0-e3050d4ab8dc"), "Chris", "Claybrooks" },
                    { new Guid("f8eadbdd-1b5f-4d8d-a1e2-c3057497296c"), "Ross", "Matiscik" },
                    { new Guid("d5476b29-e4ee-42a7-bfe3-e4e4ea17a225"), "C.", "J. Henderson	" },
                    { new Guid("a989bf1b-83dc-4041-9de2-3ee230576943"), "Josh", "Jones" },
                    { new Guid("90a26585-9dd1-44b9-8e6f-219bbe1d0bda"), "Sidney", "Jones" },
                    { new Guid("92ec4bea-a568-4253-ae22-4df6b3b97463"), "Josiah", "Scott" },
                    { new Guid("a1e0ce84-c784-46bb-a18e-d4564b8e6b04"), "Daniel", "Thomas" },
                    { new Guid("51015612-5f93-4185-a080-1e04d95fbf77"), "Brandon", "Watson" },
                    { new Guid("8d675c28-04ce-43a3-a46a-52a6d6a2cbdb"), "Jarrod", "Wilson" },
                    { new Guid("a911b542-d148-40ff-860f-ad4bf913911f"), "Logan", "Cooke" },
                    { new Guid("e9e5df62-9b53-445a-9b21-20d6948c96bc"), "Tre", "Herndon" },
                    { new Guid("f8593e1f-727d-4526-89dd-8d62874a9bbe"), "Matt", "Sokol" },
                    { new Guid("900605a4-7cd3-4fe6-bec8-06356f678c2e"), "Gavin", "Heslop" },
                    { new Guid("a1599cc7-3398-4f9b-9590-465baeb877be"), "Danny", "Etling" },
                    { new Guid("6154116c-0b94-47fa-a630-e7a81741dfcb"), "Kenny", "Golladay" },
                    { new Guid("9fdd4856-11d2-45e2-9be2-e6abd227430f"), "Marvin", "Hall" },
                    { new Guid("fd2b0ad9-6bd8-4648-a962-99c6b0b65ed5"), "Marvin", "Jones" },
                    { new Guid("a8e8dd65-23c1-4f8c-9fa0-1ee7583c6400"), "T.", "J. Hockenson	" },
                    { new Guid("853fcc11-b2d0-49ab-a0be-41b59656b84e"), "Jesse", "James" },
                    { new Guid("5c6bdb5d-19ed-4999-9458-b3ea2315ce60"), "Isaac", "Nauta" },
                    { new Guid("d7d61201-8657-4301-b17e-b496de9624ee"), "Oday", "Aboushi" },
                    { new Guid("c478dfb1-2f12-4757-9b2c-a705eb4481ae"), "Tyrell", "Crosby" },
                    { new Guid("ea60a624-8c12-47e3-a6c5-4c73337ad708"), "Joe", "DahlG" },
                    { new Guid("1edc2102-614e-4021-b11a-e6671bed4cb0"), "Taylor", "Decker" },
                    { new Guid("ea0cbfe3-48dc-4946-9f8b-41e74003d42f"), "Jonah", "Jackson" },
                    { new Guid("a88c9f0a-4d02-4188-9104-b108a19ccc99"), "Matt", "Nelson" },
                    { new Guid("0e6ca883-441e-4b9c-841e-e638dad9d024"), "Frank", "Ragnow" },
                    { new Guid("9f39082c-79b5-4b98-b050-fc921288ea79"), "Logan", "Stenberg" },
                    { new Guid("9855cde5-a553-43fd-aa88-407ea8e3601b"), "Halapoulivaati", "Vaitai" },
                    { new Guid("b07d6952-81cf-4404-9d17-1d2cef1d2c3c"), "Quintez", "Cephus" },
                    { new Guid("f6425cee-fe1b-4657-8c21-e609f4a80cf2"), "Danny", "Amendola" },
                    { new Guid("e766a91b-a717-48b1-8e96-618b38fbfafa"), "Jamal", "Agnew" },
                    { new Guid("228789a2-9bdb-4c90-868a-31c8e30d2bf6"), "Jonathan", "Williams" },
                    { new Guid("78e44518-7084-468c-97e7-1bf1a12709a1"), "Dwayne", "Harris" },
                    { new Guid("92d96135-e5ef-4191-a1e9-f2108534c57f"), "Jesper", "Horsted" },
                    { new Guid("3970ffbf-03aa-4060-b549-673d2b010ed5"), "Thomas", "Ives" },
                    { new Guid("68d4e873-f24a-4536-b20e-01a537316dc1"), "LaCale", "London" },
                    { new Guid("97686f05-bb69-42b4-a2df-0e0b206b39ab"), "Ledarius", "Mack" },
                    { new Guid("6806d9ff-56d9-438d-b430-b71cebfc9f05"), "Daniel", "McCullers" },
                    { new Guid("ff78e2ae-254a-4609-bc9b-75e33ea71142"), "Lamar", "Miller" },
                    { new Guid("0f4d63a6-199a-46d1-a7a1-38380fce06d6"), "Everson", "Griffen" },
                    { new Guid("8e6c1f4d-49f9-4ae4-8432-bd79a632b8c0"), "Aaron", "Neary" },
                    { new Guid("da631139-3a7b-4377-8f2b-e5286255f463"), "Badara", "Traore" },
                    { new Guid("0166b748-f89e-4f0b-b892-501d45b1dff9"), "David", "Blough" },
                    { new Guid("2cada024-2f3c-4a47-8a9f-ea4c2eb80e64"), "Chase", "Daniel" },
                    { new Guid("f5f7126d-6b82-4fb3-a5ca-f403f5e8b6be"), "Jason", "Cabinda" },
                    { new Guid("ded37dfe-1bf7-43de-8e88-b33109827916"), "Kerryon", "Johnson" },
                    { new Guid("7a83ac84-ee36-47f5-95d9-f00f643d6549"), "Adrian", "Peterson" },
                    { new Guid("95a32a47-c507-48d8-b178-bae7684bd83a"), "D'Andre", "Swift" },
                    { new Guid("f38c55d9-ee0f-4599-834f-009b89d173b5"), "Manti", "Te'oI" },
                    { new Guid("9384660e-b14f-4942-84f8-9f046fe7f149"), "Dieter", "Eiselen" },
                    { new Guid("d2d2cc27-a30b-4d6f-a060-47b2e29d0921"), "Da'Shawn", "Hand" },
                    { new Guid("65ec022a-2e5c-4293-af7b-0aa4660d6f0e"), "John", "Penisini" },
                    { new Guid("f0d271b6-4756-49fb-998e-1cba2e7dc8c2"), "Jack", "Fox" },
                    { new Guid("74369b2d-9fcd-45f2-8c41-b35395d42623"), "Don", "Muhlbach" },
                    { new Guid("9f54e760-371a-41a0-9bae-f4fa87f8eac3"), "Matt", "Prater" },
                    { new Guid("d7ec2ab3-7c55-4239-a7a4-63faf5897dc4"), "Geronimo", "Allison" },
                    { new Guid("86525474-ed9c-403f-9ffa-6eaa41e184d8"), "John", "Atkins" },
                    { new Guid("6b725184-fc89-411e-b556-895b229f532c"), "Nick", "Bawden" },
                    { new Guid("7f629c35-8339-4a56-972d-b5054d180cd2"), "Russell", "Bodine" },
                    { new Guid("ebd3e39e-fe8a-4f7c-b002-be524d5a8f2c"), "Austin", "Bryant" },
                    { new Guid("b4174cde-da76-42a1-86e4-bad31cae7e0b"), "Hunter", "Bryant" },
                    { new Guid("67c1e2fe-4a93-4a36-bbd6-7627265b7879"), "Jashon", "Cornell" },
                    { new Guid("02717352-a5fe-45c2-981f-83bb3380d410"), "Jarrad", "Davis" },
                    { new Guid("8cbc9287-165e-48ac-be28-4fb2e91979ae"), "Trey", "Flowers" },
                    { new Guid("92fce9dc-92a8-40a5-9517-a1ced24bbdc4"), "Julian", "Okwara" },
                    { new Guid("ee0a0868-671a-4ecc-af3a-09d24f0853da"), "Matthew", "Stafford" },
                    { new Guid("ac8f9226-30a6-4abc-bd34-07160610fddf"), "Beau", "Benzschawel" },
                    { new Guid("3f89609d-d177-4c76-bdb0-222c9339ec7e"), "Tracy", "Walker" },
                    { new Guid("54702189-3e86-4e70-9150-ffe863d52c88"), "Desmond", "Trufant" },
                    { new Guid("6d596b2f-f302-45fe-9a6d-a70adeed4506"), "Darryl", "Roberts" },
                    { new Guid("17a58da0-4325-4ead-b42c-f36e7d118eca"), "Amani", "Oruwariye" },
                    { new Guid("6492ce5b-9e1e-4c00-9915-0ca268cb0303"), "Danny", "Shelton" },
                    { new Guid("837918ca-f345-416d-8a83-96d1cc0ea1a3"), "Nick", "Williams" },
                    { new Guid("71e58a6d-9d51-4fdd-9d81-28b6b29105e6"), "Jamie", "Collins" },
                    { new Guid("7fadd438-bcd6-4fb7-bdc9-3e6b43578d00"), "Christian", "Jones" },
                    { new Guid("0fe1af25-e60e-45e3-8486-b69984971d39"), "Reggie", "Ragland" },
                    { new Guid("7eb3a07e-77be-4251-ac33-9ac9e3e4880c"), "Jalen", "Reeves-Maybin" },
                    { new Guid("02c6b2eb-62f3-4300-9888-4242af738e33"), "Jahlani", "Tavai" },
                    { new Guid("0e3f1675-8d34-4be4-b41f-d7a8d4367b8d"), "Romeo", "Okwara" },
                    { new Guid("90160b8e-54d5-4bea-93cb-5d9129cc435b"), "Justin", "Coleman" },
                    { new Guid("8e00cd37-2966-4f1f-b71d-93e6e88496fb"), "Duron", "Harmon" },
                    { new Guid("d4b78252-78a4-4cce-8ae2-6716e42d9dc3"), "Will", "Harris" },
                    { new Guid("31557c6a-94b4-4ad3-9f0d-24fee482854e"), "Jayron", "Kearse" },
                    { new Guid("d3ed7d19-637f-48e3-a354-1ed15abe101f"), "Miles", "Killebrew" },
                    { new Guid("65a06b6e-ead0-4352-9d22-367a0dcc4ebc"), "Tony", "McRae" },
                    { new Guid("45ed2b5d-5185-4aae-b9e5-f6dd1133691e"), "C.", "J. Moore	" },
                    { new Guid("4ab7873a-a5fc-461f-8b26-955292883656"), "Jeff", "Okudah" },
                    { new Guid("32237047-43a5-4168-90a1-973633e6ebaf"), "Mike", "Ford" },
                    { new Guid("1e58ce91-f03b-43ae-b990-7fef1326a0a3"), "Reggie", "Davis" },
                    { new Guid("a51ad70a-3ca5-40b6-93cc-79f35b09a4b5"), "Xavier", "Crawford" },
                    { new Guid("44415aa5-0a11-46b3-8590-513f8bfa6ded"), "Marqui", "Christian" },
                    { new Guid("66d9d0e9-8814-413d-b4b2-53cfc8dfacbb"), "Jimmy", "Graham" },
                    { new Guid("fc20ab69-65a9-46dc-a4cd-19cf6f928de9"), "Demetrius", "Harris" },
                    { new Guid("09f190c0-6236-45af-a76d-903822f132f1"), "J.", "P. Holtz	" },
                    { new Guid("14fba142-f247-47a2-9306-8495694916f1"), "Cole", "Kmet" },
                    { new Guid("8c010b38-fff2-4a25-83b8-053f7325fb25"), "Alex", "Bars" },
                    { new Guid("ebb66ea0-d005-4df4-9979-5e9a2e77c44b"), "Rashaad", "Coward" },
                    { new Guid("a4df1525-f89c-4d35-b96f-764bcd53aa87"), "Arlington", "Hambright" },
                    { new Guid("6fbf84ed-f047-4021-889f-1b657932c997"), "Charles", "Leno" },
                    { new Guid("5f5d6959-8c0f-4644-8d55-9e93cba1a7c0"), "Sam", "Mustipher" },
                    { new Guid("1655539e-9261-486b-9279-888da8565acd"), "Lachavious", "Simmons" },
                    { new Guid("1fb5d54f-df29-455d-a252-33c571c8c7c7"), "Cody", "Whitehair" },
                    { new Guid("9f89a24a-388c-4eec-9c00-39ea17e5c5de"), "Mario", "Edwards Jr.	" },
                    { new Guid("6bbfdb8a-5a95-401d-ab76-e7ecc52801fa"), "Akiem", "Hicks" },
                    { new Guid("3e04d162-1420-4025-8218-4cee087636c6"), "John", "Jenkins" },
                    { new Guid("191213dd-2b5e-4d18-9375-4a2ebf454eea"), "Bilal", "Nichols" },
                    { new Guid("565b6719-6534-4063-bf9e-70900104a405"), "Allen", "Robinson" },
                    { new Guid("68a07c04-c628-4a45-9b1c-63bc8d7d7543"), "Riley", "Ridley" },
                    { new Guid("9c0bd3c6-ff83-4a4b-b25a-f95df8776c80"), "Cordarrelle", "Patterson" },
                    { new Guid("0cd6ce3e-eb59-468d-bcae-472529c89a93"), "Darnell", "Mooney" },
                    { new Guid("8edeb496-b88b-4b31-bdb4-b5ffc6bf767c"), "Jordan", "Brown" },
                    { new Guid("5dbe2afc-15f6-440d-a7d7-4c28e146b457"), "Aaron", "Colvin" },
                    { new Guid("9c96e519-13a5-4ff4-84aa-f958269f0b8b"), "Trevor", "Davis" },
                    { new Guid("210a805c-2caa-496b-b8cb-3d90ee2c8229"), "Jordan", "Kunaszyk" },
                    { new Guid("6225fb30-b2cf-4ebc-a6d7-7841e3897042"), "Devaroe", "Lawrence" },
                    { new Guid("0408c941-e228-40b3-890e-02c6da5c3354"), "Cole", "Luke" },
                    { new Guid("82a33d9a-c7b4-41b8-aae9-c420cdd3b3f6"), "Steven", "Montez" },
                    { new Guid("fe7a525a-dfec-4b7f-a0d0-f5aebcc593df"), "Roy", "Robertson-Harris" },
                    { new Guid("5a51f2fe-349b-4090-83c6-0aec7513d889"), "Ross", "Pierschbacher" },
                    { new Guid("8b282c7e-cddd-4bd7-adf5-fa5f19eca90b"), "Kaare", "Vedvik" },
                    { new Guid("2513b551-6002-4f0c-9c23-dea5b51c9379"), "Nick", "Foles" },
                    { new Guid("ef74e5d3-4609-4565-b1b0-7964d5259aa4"), "Mitchell", "Trubisky" },
                    { new Guid("8e086dba-42b5-4e32-88f2-127146c9c3d2"), "David", "Montgomery" },
                    { new Guid("f50a52e8-e09d-4325-906f-4d6c97df7055"), "Ryan", "Nall" },
                    { new Guid("c5becb87-f94b-452b-954e-7413a2cd602c"), "Artavis", "Pierce" },
                    { new Guid("5bfd5224-a881-42c3-9b0a-ac6626ca2d27"), "Anthony", "Miller" },
                    { new Guid("036210c2-ca40-4531-a5dc-5e6b7207e8fa"), "David", "Steinmetz" },
                    { new Guid("8d526c8a-5d6f-4b5c-8034-0786015d12e0"), "Brent", "Urban" },
                    { new Guid("fb859999-fec8-4226-a991-d2ced2d28bc6"), "Trevis", "Gipson" },
                    { new Guid("5d2f9d91-c39c-4398-b38b-52b6043233d4"), "Joel", "IyiegbuniweI" },
                    { new Guid("b195e22a-7cf6-4069-9cbe-6b0dad324cc4"), "Artie", "Burns" },
                    { new Guid("36faa773-ced1-4300-80ea-d2b34dd295e5"), "Darion", "Clark" },
                    { new Guid("cae9c990-2f26-4554-9f90-40abc0eff87f"), "Tarik", "Cohen" },
                    { new Guid("d7f5e79b-9d6f-4bc2-a016-af2dec2439e6"), "James", "Daniels" },
                    { new Guid("db691fb9-1ea5-47ea-a926-0b0f03ef002f"), "Eddie", "Goldman" },
                    { new Guid("355a2097-1546-49d6-ab75-d81e0359c6f1"), "Germain", "Ifedi" },
                    { new Guid("ea528792-25ea-4617-b1a4-e298aa46a332"), "Michael", "Joseph" },
                    { new Guid("76f24c92-0eec-41fb-8808-dbe31a169ff7"), "Patrick", "Scales" },
                    { new Guid("633167e6-29d9-471e-91a6-aa7f0fb09825"), "Jordan", "Lucas" },
                    { new Guid("30431a30-63cd-408f-8752-757b60481e5b"), "Eddy", "PiñeiroK" },
                    { new Guid("c5fe9a2b-f4d6-4e6b-8cc3-879e1264d7c3"), "Tre", "Roberson" },
                    { new Guid("2956308e-f0ee-4536-9d93-bdc88e8e6057"), "Jason", "Spriggs" },
                    { new Guid("d60e437e-3ad6-4965-9b57-00c7725ba7be"), "Javon", "Wims" },
                    { new Guid("9aa93401-909b-49b7-bd06-77953ad870b6"), "Rodney", "Adams" },
                    { new Guid("bdbb130f-5183-442f-a83b-0e7369582082"), "Devante", "BondI" },
                    { new Guid("bf826ef4-92b9-449c-a4d5-bea05aaecd13"), "Tyler", "Bray" },
                    { new Guid("4ee6b96a-76d6-4493-9b91-412a19ddc3fb"), "Bobby", "Massie" },
                    { new Guid("41c24a5b-f9f1-45ea-b0df-683285dd10b8"), "Victor", "Bolden Jr.	" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("b3301042-2883-468c-b0a0-6a0ef61f71b3"), "Cairo", "Santos" },
                    { new Guid("1e934e9b-951a-4964-96c7-91b5a63764e8"), "Kindle", "Vildor" },
                    { new Guid("cff95efd-9fd2-4188-8b1e-0112798648ea"), "Khalil", "Mack" },
                    { new Guid("553561c1-ba40-4d63-9701-1fd4afb76c81"), "Barkevious", "Mingo" },
                    { new Guid("fcb05013-d502-4b3b-9a19-f17d1d549d5f"), "Robert", "Quinn" },
                    { new Guid("3bf0882a-4945-4d2a-8e68-aad44425e954"), "Roquan", "SmithI" },
                    { new Guid("0a5867fd-c7ba-433c-9294-bbc19d6c6b92"), "Danny", "TrevathanI" },
                    { new Guid("2a25b98b-68e6-4072-b4c9-2c6135612bdc"), "James", "Vaughters" },
                    { new Guid("09ff0410-de70-474b-96ff-ab653dae2545"), "Josh", "WoodsI" },
                    { new Guid("f9ecaeb3-e1ea-4d22-9764-5636e9c25972"), "Pat", "O'Donnell" },
                    { new Guid("76c0f31b-ed60-4c64-84d0-e345208af31e"), "Deon", "Bush" },
                    { new Guid("9ca695a1-114c-43fc-b9ea-25bb9f2373ed"), "Tashaun", "Gipson" },
                    { new Guid("13ce6f8a-e9a3-4d65-8d8b-0f029f999af5"), "DeAndre", "Houston-Carson" },
                    { new Guid("df2684f1-3676-41a6-8d73-09ae06a85cab"), "Eddie", "Jackson" },
                    { new Guid("2398c33e-4d6c-49e5-8205-b572f2f599f1"), "Jaylon", "Johnson" },
                    { new Guid("919313c8-c1d5-4339-988b-5013e109a1e1"), "Sherrick", "McManis" },
                    { new Guid("ed677140-f7fc-48dd-8d6b-b6cfb196937e"), "Duke", "Shelley" },
                    { new Guid("509c1ea2-5dd4-4ff4-99f2-fb318e7160c2"), "Buster", "Skrine" },
                    { new Guid("5c1ad701-b61a-4e0e-a983-04a90917ec86"), "Kyle", "Fuller" },
                    { new Guid("e5822290-db56-469a-bed8-9e825142a5c7"), "Jalen", "ElliottS" },
                    { new Guid("6bf30050-0789-472c-9111-e17fb203cf23"), "Frank", "Herron" },
                    { new Guid("8a49cee4-2b58-4da2-91e0-8c1da93808ef"), "Albert", "Huggins" },
                    { new Guid("5e6863c9-c16f-44c2-aa2c-116e689ea2d9"), "Dan", "Chisena" },
                    { new Guid("7522f388-80a0-4551-aba4-4207c0b05899"), "Justin", "Jefferson" },
                    { new Guid("4cac9757-1c08-4e74-b13c-83389fcb286d"), "Bisi", "Johnson" },
                    { new Guid("1e5d89e0-6650-4918-bee0-fefa03473e26"), "K.", "J. Osborn	" },
                    { new Guid("4ca9dac1-5c6e-498b-b46e-5bfb006cd3a2"), "Tajae", "Sharpe" },
                    { new Guid("b7a97c15-c4a4-4565-8fae-e5cb30c015a7"), "Adam", "Thielen" },
                    { new Guid("494dee22-cad3-4702-ac9d-c85689ec2421"), "Tyler", "Conklin" },
                    { new Guid("862bf854-ac06-471e-a08c-4a3c1c85074b"), "Kyle", "Rudolph" },
                    { new Guid("01995b03-c220-4c9e-bbc0-826adeebbde5"), "Irv", "Smith Jr.	" },
                    { new Guid("d7f4de76-f48e-40a6-bfe9-d40496fbc27b"), "Garrett", "Bradbury" },
                    { new Guid("5f8da906-72a3-4912-99e3-f52685873840"), "Ezra", "Cleveland" },
                    { new Guid("ccabf5e7-1f35-4436-8f2c-48ecec247823"), "Dakota", "Dozier" },
                    { new Guid("914a7c57-d885-473d-932b-d6418baec265"), "Rashod", "Hill" },
                    { new Guid("79b6ca9b-64a2-4f40-8ab0-f4aeb3d37a24"), "Brian", "O'Neill" },
                    { new Guid("dd5f8a33-6643-4b00-8fda-46b78447f6a2"), "Riley", "Reiff" },
                    { new Guid("3228ab1e-f864-4921-b97a-ebd20f62fab6"), "Chad", "Beebe" },
                    { new Guid("d31fbb91-916f-4533-b61e-586b60323ee4"), "Alexander", "Mattison" },
                    { new Guid("41c5138d-ae0d-4290-be04-c6d3db1fcaa5"), "C.", "J. Ham	" },
                    { new Guid("16667848-9295-4384-8b79-0a5c2dfa9524"), "Dalvin", "Cook" },
                    { new Guid("30a6dcc9-c3e0-43b3-bb75-8e523e719ce1"), "Nakia", "Griffin-Stewart" },
                    { new Guid("4c0b354d-fd42-4570-8946-3992987434bb"), "Jake", "Hanson" },
                    { new Guid("59705344-d4ae-4f16-8121-6436b3c5cec6"), "De'Jon", "HarrisI" },
                    { new Guid("05b4eca9-7e0a-4736-a8bb-9f646fc03b3e"), "Zack", "Johnson" },
                    { new Guid("2294da7e-c741-4960-9550-1361adb4c06f"), "Ryan", "Pope" },
                    { new Guid("4a8bbe32-3976-47a1-a754-14b7d1ce4eb5"), "Willington", "Previlon" },
                    { new Guid("3fdf9dc0-9194-40ae-8846-236d9fe5af60"), "KeiVarae", "Russell" },
                    { new Guid("ff1f2f81-ade1-4f80-9b21-47fcbcb312dc"), "Dru", "Samia" },
                    { new Guid("d4e3e850-0c77-49c6-a6d1-37c313780e93"), "Seth", "Roberts" },
                    { new Guid("bf7fb57b-fc53-442e-a91c-8c878ff58d4c"), "Delontae", "Scott" },
                    { new Guid("8446ff23-2127-44c4-b678-ff73204c8cae"), "Dexter", "Williams" },
                    { new Guid("b7593cad-af3d-4454-867d-4678c13c085f"), "Juwann", "Winfree" },
                    { new Guid("5112900b-5088-4605-a950-58159bcafa35"), "Kirk", "Cousins" },
                    { new Guid("ef352385-4915-4f9b-8f5a-0315209b82b3"), "Sean", "Mannion" },
                    { new Guid("9872fac0-2e50-45a4-9d8d-4696f3de1114"), "Ameer", "Abdullah" },
                    { new Guid("954d86d3-1b64-4003-bbc4-c5b0ebe172cf"), "Mike", "Boone" },
                    { new Guid("cd5080ab-3691-4c79-8423-1ecf6a42e69e"), "Stanford", "Samuels III	" },
                    { new Guid("4226751e-69c9-4658-bdda-90178c0a4e37"), "Oli", "Udoh" },
                    { new Guid("6d958861-29ef-4e86-bae0-7850f3a78d5f"), "Jordan", "Brailford" },
                    { new Guid("ab49ae69-bf6f-46e3-9428-347109372cbb"), "Jalyn", "Holmes" },
                    { new Guid("8e3baff1-2be0-46e8-a261-547a96aee13a"), "Curtis", "Riley" },
                    { new Guid("53fdd5ab-e9b5-4e7d-a0ed-0fab52edd386"), "Harrison", "Smith" },
                    { new Guid("f08584f0-f005-41b5-906f-972e16bca1fb"), "Dan", "Bailey" },
                    { new Guid("7e542b3e-3c32-407a-8dda-c33ad181d80f"), "Britton", "Colquitt" },
                    { new Guid("babb9f81-6378-4458-bf8e-db436e04d4fa"), "Austin", "Cutting" },
                    { new Guid("63b76099-2e40-41eb-b345-d56c398637da"), "Anthony", "Barr" },
                    { new Guid("5a53d3c0-a8d6-4f8c-adf2-93ccf72ec789"), "Todd", "Davis" },
                    { new Guid("d5103794-556f-47bd-aa85-164313340d67"), "Josh", "Metellus" },
                    { new Guid("afd3c81d-6b3d-48f6-a899-44e23ed28988"), "Myles", "Dorn" },
                    { new Guid("76107d51-2967-4ac8-9e89-ef84b83fe09d"), "Ben", "Gedeon" },
                    { new Guid("fbe6b8ab-a343-488c-b378-0c16130ced2e"), "Mike", "Hughes" },
                    { new Guid("4dad418f-af96-4f70-b5db-4ccdd7bf85de"), "Danielle", "Hunter" },
                    { new Guid("6a96c177-d742-420e-bcf6-feaa1f64b2a1"), "George", "IlokaS" },
                    { new Guid("c573b773-7b10-4495-a7fb-05c98adb96a3"), "Michael", "Pierce" },
                    { new Guid("ca7a92d5-7235-4f42-ac94-744351831810"), "Cameron", "Smith" },
                    { new Guid("0a02cc07-793d-4381-9d31-ab4e0e738450"), "Kenny", "Willekes" },
                    { new Guid("e1c1e119-8bdf-4ae8-a03c-199e21f6e9ad"), "Pat", "ElfleinG" },
                    { new Guid("afb4c23d-6fb9-4789-b6be-33c49b9f4fd5"), "Tipa", "Galeai" },
                    { new Guid("16de672d-fd62-4634-9752-9a0259d1bebd"), "Chris", "Jones" },
                    { new Guid("fded1c01-a429-45c1-be8b-ab839cd842da"), "Anthony", "Harris" },
                    { new Guid("62dd3bb8-7280-45b4-8302-dbddfaf3791b"), "Jaleel", "Johnson" },
                    { new Guid("aa19d0ab-f05f-4f4e-804e-3ece4afbbb17"), "James", "Lynch" },
                    { new Guid("fb3dfb42-e2cb-49db-ab23-7cfd99430e01"), "Ifeadi", "Odenigbo" },
                    { new Guid("31439a99-0726-458d-8bee-3c1b1543abcd"), "Shamar", "Stephen" },
                    { new Guid("fb17a46f-67cf-4c17-a78d-eddb29663605"), "Armon", "Watts" },
                    { new Guid("0f66c41e-b525-49ba-9f1a-38efc1e3863f"), "D.", "J. Wonnum	" },
                    { new Guid("80bc6ec5-923b-4c2d-8976-5df46ea025fc"), "Ryan", "Connelly" },
                    { new Guid("b2dd84f5-582a-467a-bbd6-5a5ed52558cf"), "Holton", "Hill" },
                    { new Guid("25fd944a-880f-4538-bf44-d76e4d9103ca"), "Troy", "Dye" },
                    { new Guid("014457dd-d396-451a-8c86-818fd71ebfad"), "Hardy", "Nickerson Jr.	" },
                    { new Guid("0595ca33-bc85-4aee-a7fb-788c4b02ee00"), "Eric", "Wilson" },
                    { new Guid("c65646ab-b31c-4445-a596-e07e6fe9d530"), "Kris", "Boyd" },
                    { new Guid("1bb3e742-2e48-4215-89a8-3751cbcaf140"), "Cameron", "Dantzler" },
                    { new Guid("e79a5670-b926-46b4-9b10-a45a0caa1e2a"), "Mark", "Fields" },
                    { new Guid("e83196ca-b820-4e59-b05c-b8fa4a9e7050"), "Jeff", "Gladney" },
                    { new Guid("26fbf624-c5c0-4f72-b9e5-b86701017d02"), "Harrison", "Hand" },
                    { new Guid("cfabde67-b98f-45cb-a9cf-3cc24479540e"), "Eric", "Kendricks" },
                    { new Guid("0efcf24b-a518-47b4-b490-22217ea01540"), "Marcus", "Baugh" },
                    { new Guid("87902838-cffb-4e12-b9b4-3817e7eb814b"), "Dominique", "Dafney" },
                    { new Guid("b55ba633-8c01-4767-8d0b-873072438774"), "Henry", "Black" },
                    { new Guid("249b2971-5033-4ac0-9677-a43054ce8c7c"), "Malik", "Taylor" },
                    { new Guid("b86b85d7-97e4-48a4-b3e0-1b02401f5330"), "Marquez", "Valdes-Scantling" },
                    { new Guid("0e142935-0613-4686-8336-83b13c85fd20"), "Marcedes", "Lewis" },
                    { new Guid("986d573f-3f2c-42ce-9559-ace5b4bd938e"), "John", "Lovett" },
                    { new Guid("f87cb6be-b125-4578-bd28-03951a18a990"), "Jace", "Sternberger" },
                    { new Guid("1415e875-f310-4cd8-a6ab-6427eda33ff3"), "Robert", "Tonyan" },
                    { new Guid("4befcbd5-1cc9-4591-adeb-085c53291f8a"), "David", "Bakhtiari" },
                    { new Guid("6b1a13d5-6ca0-4cb6-a46d-154a95f8dfd8"), "Elgton", "Jenkins" },
                    { new Guid("670a883f-988d-4fa9-b545-2f82faa05643"), "Corey", "Linsley" },
                    { new Guid("35f4d5b8-c065-4efc-9c9d-61b5a769db6d"), "Yosh", "Nijman" },
                    { new Guid("fddda2c6-f77e-463f-ba05-b51371480801"), "Lucas", "Patrick" },
                    { new Guid("b5ec25d7-7dba-449d-bda8-145cb7e10074"), "Jon", "Runyan Jr.	" },
                    { new Guid("75f6551d-d4a6-4db9-9732-344e5993e101"), "Billy", "Turner" },
                    { new Guid("e1bd48bc-7286-4132-bd53-4281bd0af89a"), "Rick", "Wagner" },
                    { new Guid("08f98b47-6fc5-4545-ba8d-1236af1b07d6"), "Montravius", "Adams" },
                    { new Guid("6d720d07-57f5-4453-a76a-fc6e24bcdc15"), "Equanimeous", "St. Brown	" },
                    { new Guid("9626c1ea-eb02-4420-89dc-fb65f4a18790"), "Darrius", "Shepherd" },
                    { new Guid("ce877397-45ca-408a-ba78-486fd336a2a3"), "Davante", "Adams" },
                    { new Guid("9eda237c-f116-411f-a803-3db5f51472bc"), "Aaron", "Jones" },
                    { new Guid("ec355648-5797-4a8c-ba3d-e1fdefb9f435"), "Tom", "Kennedy" },
                    { new Guid("c77edd9f-c97a-4450-8255-cd531dbefe03"), "Khari", "Lee" },
                    { new Guid("ebfbc8f8-5cba-42af-a231-4ff03f82d5a7"), "Kareem", "Martin" },
                    { new Guid("1b17d551-dce5-4bfd-b149-d04cb206e406"), "Marcus", "Martin" },
                    { new Guid("7d61a557-2d2f-429b-91f6-773196b23154"), "Anthony", "Pittman" },
                    { new Guid("059b39ce-f36b-4d3b-8bf4-4c2616f6c115"), "Bobby", "Price" },
                    { new Guid("7bc2d38a-78a6-43d6-a37e-393ce78c8d7d"), "Arryn", "Siposs" },
                    { new Guid("ae3939ac-045b-4537-ba76-b5b4bf41a5ab"), "Kenny", "Clark" },
                    { new Guid("7c9770ea-7c82-4ec4-bba1-62e818adf64b"), "Dan", "Skipper" },
                    { new Guid("387404aa-61d7-4f15-ac40-676f3e3109e9"), "Dee", "Virgin" },
                    { new Guid("7041420c-d283-4e63-872d-74076537568a"), "Kerrith", "Whyte" },
                    { new Guid("be3acb71-6168-4069-b57e-18cc11b6af2f"), "Steven", "Wirtel" },
                    { new Guid("f28f1d39-d505-4202-a486-08a11c0eafc7"), "Tim", "Boyle" },
                    { new Guid("78117748-e59f-4175-b17b-d1b1878d00f3"), "Jordan", "Love" },
                    { new Guid("ee7a457c-0555-4a8e-88c7-b09e2674d86f"), "Aaron", "Rodgers" },
                    { new Guid("3bb47eb3-91b3-40fc-9548-10acac7f35aa"), "Tyler", "Ervin" },
                    { new Guid("53091acc-c7e5-4517-b48a-48f1813fd204"), "Kevin", "Strong" },
                    { new Guid("b322fdde-9601-4ea2-99c0-9d2ad1d4a19d"), "Kingsley", "Keke" },
                    { new Guid("f9e87987-c075-4d31-ad72-7a5528133623"), "Tyler", "Lancaster" },
                    { new Guid("129b18ff-f563-49c0-9e1f-ba1bc0ef5871"), "Dean", "Lowry" },
                    { new Guid("5d9d1b7d-262a-482e-a70f-15d78d2525d1"), "Hunter", "Bradley" },
                    { new Guid("092fbaf9-e2e4-48ac-b055-9fa52f9ce515"), "Mason", "Crosby" },
                    { new Guid("510ce1ff-ba43-40b3-9e11-31043cd6d7c9"), "J.", "K. Scott	" },
                    { new Guid("a5df84fa-74a9-49d6-bb2d-a43a0c9a26cd"), "Josiah", "Deguara" },
                    { new Guid("15d2459f-a49b-45b0-b65c-55c798ec3c50"), "A.", "J. Dillon	" },
                    { new Guid("a74c867d-683f-44aa-9270-18cfdd669669"), "Kabion", "Ento" },
                    { new Guid("44a578d1-b1bc-4378-87c1-5bf1876588e9"), "Devin", "Funchess" },
                    { new Guid("bbebb884-f2d9-4348-9542-93c6de4819cf"), "Chandon", "Sullivan" },
                    { new Guid("df6032f5-1971-4d0a-b127-08ad1cdd62c2"), "Christian", "KirkseyI" },
                    { new Guid("640a9f34-b2d6-4431-8312-9e2fc442fb4b"), "Kamal", "MartinI" },
                    { new Guid("41742335-4502-460b-b281-4c8e7db8c9c4"), "Parry", "Nickerson" },
                    { new Guid("2ffacc4f-1026-4c40-bb4a-e1becf15368d"), "Simon", "Stepaniak" },
                    { new Guid("10c6c469-427e-41f1-8be5-5e3363e87ea2"), "Lane", "Taylor" },
                    { new Guid("8d716563-f39a-44cf-b3bc-28a0fe5f810b"), "Patrick", "Taylor" },
                    { new Guid("e0cf13d1-e5fb-40ef-be89-b9329c7893ba"), "Jamaal", "Williams" },
                    { new Guid("838a4585-7063-4006-abe4-844c85ef3f7f"), "Reggie", "Begelton" },
                    { new Guid("9a74faaf-1aba-4a31-b15e-e84a1baa0bcd"), "Allen", "Lazard" },
                    { new Guid("39dd4092-84bb-4977-b955-a90223d4a8db"), "Ben", "Braden" },
                    { new Guid("d6138a9c-5a43-47f6-93aa-1361148505a8"), "Vernon", "Scott" },
                    { new Guid("9ac148fd-cc0a-4654-a0ff-35104f898457"), "Will", "Redmond" },
                    { new Guid("cf4df162-2fa7-4427-bce6-10bbace4e6d6"), "Billy", "Winn" },
                    { new Guid("e3aa488d-f809-42d8-ab87-781f78f0a54c"), "Krys", "BarnesI" },
                    { new Guid("7fb36d74-5e69-4445-a060-2a3cb5839001"), "James", "BurgessI" },
                    { new Guid("bf0724d9-1723-45c1-b66e-1100418cf4e9"), "Oren", "Burks" },
                    { new Guid("0cffc583-9bfa-4df1-b37e-9d2ef20c0597"), "Jonathan", "Garvin" },
                    { new Guid("c0bb788b-b1c3-4739-8091-909099e58463"), "Rashan", "Gary" },
                    { new Guid("fcacf72e-e38b-403a-99bf-fe521452d75b"), "Randy", "Ramsey" },
                    { new Guid("5ba25868-3e33-4817-8433-6d0de715ef9b"), "Darnell", "Savage" },
                    { new Guid("25fe5dc3-ee8c-4963-ac39-e73cb0db1eda"), "Preston", "Smith" },
                    { new Guid("a104c68d-4104-4125-ba6d-6ac9b0b8d859"), "Ty", "SummersI" },
                    { new Guid("4c0056b5-d473-4617-bb9f-ba4bb8aec276"), "Jaire", "Alexander" },
                    { new Guid("868bec36-b6ac-4a4d-973c-ceb79d2a0f0d"), "Adrian", "Amos" },
                    { new Guid("fa4bd8fd-f175-4843-871f-57f6efe069c6"), "Raven", "Greene" },
                    { new Guid("ab981bff-f79f-4fce-93e1-164a6f2ae74e"), "Ka'dar", "Hollman" },
                    { new Guid("6c6ba42f-eba9-4877-97f2-3ef3e2a539d7"), "Josh", "Jackson" },
                    { new Guid("63eab8db-211a-400e-9688-2f6d9befd3a6"), "Kevin", "King" },
                    { new Guid("5cbfa000-9577-4672-b99a-1dc193451a8e"), "Za'Darius", "Smith" },
                    { new Guid("ed759a36-7d0a-4c58-8673-449decb9814c"), "Jeff", "Badet" },
                    { new Guid("a5d5ed26-0b26-4c24-91fd-ec6185493486"), "David", "Bada" },
                    { new Guid("b913dae7-9a61-41ee-b8eb-d9c2a080696a"), "Greg", "Stroman" },
                    { new Guid("9571c5cd-bad5-4764-8dfe-a230f13c4f02"), "Cameron", "Fleming" },
                    { new Guid("5b70bd29-2e60-4fd1-98fc-cf83cc84e670"), "Nick", "Gates" },
                    { new Guid("8678dff2-962e-4e73-b2ce-a5b6655d19d6"), "Shane", "Lemieux" },
                    { new Guid("19c488db-dde2-4d59-b882-352847fe77df"), "Matt", "Peart" },
                    { new Guid("184bef81-13f9-4f18-95a5-f344a31fa97c"), "Spencer", "Pulley" },
                    { new Guid("026337c6-b6c8-4377-8b91-10a357b00aec"), "Andrew", "Thomas" },
                    { new Guid("3d81ece7-7044-4d0b-a6e3-3dda6a70d847"), "Kenny", "Wiggins" },
                    { new Guid("30225a5d-d0fc-4f84-9a20-37a011801b86"), "Kevin", "Zeitler" },
                    { new Guid("b50fda1e-3be5-4ab4-b48f-c61418df9c91"), "B.", "J. Hill	" },
                    { new Guid("20e1f191-166f-4845-84c8-7d726950fcf9"), "Austin", "Johnson" },
                    { new Guid("3a7b6c15-a007-433c-bcaf-3f7e6a521672"), "Dexter", "Lawrence" },
                    { new Guid("41768032-b533-4ca2-84d2-760db0b858e6"), "R.", "J. McIntosh	" },
                    { new Guid("9f33de00-81c2-4fe3-9059-f20559fe46b9"), "Dalvin", "Tomlinson" },
                    { new Guid("4149908c-e942-47da-bc57-d391b1a42292"), "Leonard", "Williams" },
                    { new Guid("57944d6c-0084-44c4-ac27-1ef47a1e0b77"), "Cam", "Brown" },
                    { new Guid("4f707c65-1574-4284-ae22-87129d591785"), "Jackson", "Barton" },
                    { new Guid("14a84e61-4086-434b-98e0-692e969e3a64"), "Eric", "Tomlinson" },
                    { new Guid("9ab07759-0228-4ebb-a3d9-150e0ce560ad"), "Levine", "Toilolo" },
                    { new Guid("1384f91d-c305-4602-a19d-6074c21d04e8"), "Kaden", "Smith" },
                    { new Guid("53a475ef-ae36-4a50-a47d-685a416678b4"), "Saivion", "Smith" },
                    { new Guid("5398db40-efec-4097-b7b7-a244a4e2a33f"), "William", "Sweet" },
                    { new Guid("b949ab13-74c2-4326-a63e-a55e3435177e"), "Chris", "Westry" },
                    { new Guid("3d7c073e-7b0c-4070-8539-ab6905c7598f"), "Daniel", "Jones" },
                    { new Guid("22e93676-89ba-4dcb-bb35-ec363aaee8a2"), "Colt", "McCoy" },
                    { new Guid("956b46c8-f270-494c-922a-210bfd2ac641"), "Devonta", "Freeman" },
                    { new Guid("b68e306c-6fbc-4b9d-99fe-32ef0abdde85"), "Wayne", "Gallman" },
                    { new Guid("2a20ea1f-4829-4444-b184-9653373a8392"), "T.", "J. Brunson	" },
                    { new Guid("1b85ec49-5dd7-459e-94b3-a7830b24e3a5"), "Dion", "Lewis" },
                    { new Guid("280c2306-d18e-4d03-8f17-e26a944fb2a6"), "C.", "J. Board	" },
                    { new Guid("f87e3b23-08e5-4047-a186-621d1c8b7961"), "Austin", "Mack" },
                    { new Guid("1f61f6ed-9744-4bb2-8404-c9fc54227220"), "Dante", "Pettis" },
                    { new Guid("a439b6e7-a24c-4903-b1f9-2b72c1123b2a"), "Sterling", "Shepard" },
                    { new Guid("1724c37e-334e-4c79-babc-8e78d6b5d3f1"), "Darius", "Slayton" },
                    { new Guid("d9411b1d-8678-450a-86bd-4ec4e6cfb425"), "Golden", "Tate" },
                    { new Guid("e7a5bc2e-a85a-4479-bd69-a4d8ab6737ef"), "Evan", "Engram" },
                    { new Guid("e3bfe4e0-1d1c-4d39-aaff-7a1e1a00fbbb"), "Elijhaa", "Penny" },
                    { new Guid("cc39a2e7-a90c-4668-b460-d34ca49f2b5f"), "Carter", "Coughlin" },
                    { new Guid("fccb089a-80a0-4da3-84be-8d2c55578279"), "Devante", "Downs" },
                    { new Guid("7e504324-0c41-4c62-90e9-93482934dc39"), "Kyler", "Fackrell" },
                    { new Guid("b6f27c86-e202-4b3f-aaa8-e6f269d43641"), "Adrian", "Colbert" },
                    { new Guid("009e4e5d-013a-48fd-aa0c-47c8ec76f11b"), "Cody", "Core" },
                    { new Guid("ffee17dc-f8fb-400f-aee2-387eface44cb"), "Tae", "Crowder" },
                    { new Guid("90cf7554-97cb-4912-a925-eb66b38f7fef"), "Will", "Hernandez" },
                    { new Guid("0f46328c-1803-49c9-8fb8-3313bed92862"), "JaQuarius", "Landrews" },
                    { new Guid("87e1ecb5-d608-4271-a815-c68f6daf3a8c"), "Xavier", "McKinney" },
                    { new Guid("a65fcaed-39ea-4044-9a7a-998621584cae"), "Da'Mari", "Scott" },
                    { new Guid("eb275999-6e82-403c-bc8c-7cb0a0878f06"), "Lorenzo", "Carter" },
                    { new Guid("296d2acb-e728-4312-9cc2-f94c262d9fbf"), "David", "Sills" },
                    { new Guid("9a8003f8-6a77-4239-b7bc-5245dcd384ee"), "Shakial", "Taylor" },
                    { new Guid("b6c4fa9c-2179-499f-a7e7-22fbd3cd4b4e"), "Brandon", "Williams" },
                    { new Guid("8ddf795e-629a-4cc3-9c7d-200c4f753797"), "Oshane", "Ximines" },
                    { new Guid("92ef9cf0-1879-4150-9f20-451c705f89d2"), "Alex", "Bachman" },
                    { new Guid("e449210d-1558-430f-85f4-5ec959d66364"), "Corey", "Coleman" },
                    { new Guid("15a0cd50-b417-4e2d-afb8-4623c7c77aa3"), "Derrick", "Dillon" },
                    { new Guid("681952e9-14d0-49ab-9361-1a1d71a208bd"), "Montre", "Hartage" },
                    { new Guid("a4f9df16-84dc-4088-b428-689012d828d6"), "Nate", "Solder" },
                    { new Guid("5529bdae-7b5b-409b-9bf9-90279c15750a"), "Eric", "Smith" },
                    { new Guid("dd619ec1-d460-4402-947c-26283ce1b5e7"), "Sam", "Bea" },
                    { new Guid("acba4ee6-b91d-4a76-a4ec-609addf2a029"), "Casey", "Kreiter" },
                    { new Guid("84e1d587-76e2-474d-9b51-17cafd167332"), "Trent", "Harris" },
                    { new Guid("495dedcd-4873-4020-8f00-5b3533c554c2"), "Blake", "Martinez" },
                    { new Guid("ad0785c0-ff8a-4949-8226-5d75ca0d3d0c"), "David", "Mayo" },
                    { new Guid("6434fef3-ab5f-4389-8fd4-a314bf28c8fc"), "Jabaal", "Sheard" },
                    { new Guid("3bb81b65-1909-4ae4-921d-b58fc9a5e498"), "Corey", "Ballentine" },
                    { new Guid("043ec789-e4d4-491e-a0f4-4f06a4809563"), "James", "Bradberry" },
                    { new Guid("7c38b638-7644-4f70-b201-aac019f25be2"), "Nate", "Ebner" },
                    { new Guid("219af152-e61b-495d-8c68-9e3c2bbf703d"), "Saquon", "Barkley" },
                    { new Guid("b4e85c1e-4160-4c27-bb65-cf78c0f0cb69"), "Madre", "Harper" },
                    { new Guid("167a7224-8c81-4853-baa6-59e939988605"), "Ryan", "Lewis" },
                    { new Guid("69f0be1b-2342-4bab-8b19-1e48677f65a4"), "Julian", "Love" },
                    { new Guid("40517b50-44ad-4d02-9041-6b1a0c1e82f3"), "Jabrill", "Peppers" },
                    { new Guid("8a1c25ce-10c1-4801-9438-dbd977d73df2"), "Logan", "Ryan" },
                    { new Guid("98b74e44-3d08-4f59-ab8f-bef3d594ec44"), "Isaac", "Yiadom" },
                    { new Guid("165cf65b-bd80-4a66-8b51-7f6625cec596"), "Riley", "Dixon" },
                    { new Guid("19b00a4a-8082-4365-a506-f16c7f2a4fef"), "Graham", "Gano" },
                    { new Guid("8e50929e-8ce7-45df-a3fb-f50c0f4634e3"), "Darnay", "Holmes" },
                    { new Guid("1f7cb198-a4df-4064-8430-f690c28dced5"), "Rysen", "John" },
                    { new Guid("db38863b-8bb4-4d2b-b3f3-3184709f6cfe"), "Cooper", "Rush" },
                    { new Guid("0c2364c3-00d0-4358-bc33-7d834396d265"), "Adam", "Redmond" },
                    { new Guid("7af73a58-5250-4ebb-81c9-f18a23bfa543"), "Connor", "Williams" },
                    { new Guid("3190a99e-fc95-4f7d-bbaa-d1874ec9b037"), "Bradlee", "Anae" },
                    { new Guid("1df7177c-184f-4861-8bb1-424695c39444"), "Eli", "Ankou" },
                    { new Guid("3cfb11de-02a7-4231-8e43-9b54a90e5024"), "Dorance", "Armstrong" },
                    { new Guid("e144532c-fe46-4902-99ca-0f21ce26262e"), "Tyrone", "Crawford" },
                    { new Guid("408a509a-9070-43b7-929e-85e068512ac7"), "Neville", "Gallimore" },
                    { new Guid("4544a017-52a8-4313-9b85-da2fbe3db23e"), "Randy", "Gregory" },
                    { new Guid("dbbd34f3-c54b-4040-b5e6-5df9da2722d0"), "Justin", "Hamilton" },
                    { new Guid("277bbc4c-b970-462e-8bbe-cc471ffc7ee0"), "DeMarcus", "Lawrence" },
                    { new Guid("5ffe98a8-7924-44a6-9df5-41d170e3257f"), "Aldon", "Smith" },
                    { new Guid("295f9de1-548a-4e95-ba4e-aba9a33fddba"), "Antwaun", "Woods" },
                    { new Guid("e6cfdba0-2b51-4be8-b37c-b00c211970ee"), "Francis", "Bernard" },
                    { new Guid("f0fd20a6-8864-4637-ad5e-1237dedc8b02"), "Luke", "Gifford" },
                    { new Guid("548cb996-3450-48a6-bd79-8e40917124e4"), "Sean", "Lee" },
                    { new Guid("a4700b58-7dff-4cca-822c-4c24f7374dd2"), "Justin", "March" },
                    { new Guid("853c3d69-13aa-40a6-9496-6a4f1ce0cda8"), "Terence", "Steele" },
                    { new Guid("a073a379-a3d4-45c4-8540-6990c134d753"), "Greg", "Senat" },
                    { new Guid("18b07116-9916-4a70-ace8-1d2180ab0737"), "Connor", "McGovern" },
                    { new Guid("1e78a4fd-1953-4528-b009-5b6d4aedcf1a"), "Zack", "Martin" },
                    { new Guid("6b6c340a-cb64-460b-8d34-4d5964df2701"), "Garrett", "Gilbert " },
                    { new Guid("fa3304f8-fd2c-42ac-9fc8-61c357b03262"), "Rico", "Dowdle " },
                    { new Guid("7d9fcb5c-5b79-4ebf-9691-251fc6343740"), "Ezekiel", "Elliott " },
                    { new Guid("91d0f468-de6e-47cc-94f0-f95fd463563d"), "Tony", "Pollard" },
                    { new Guid("747f0331-54d9-4624-a3ee-720bce5973c5"), "Noah", "Brown" },
                    { new Guid("6b50f1d0-36d3-4015-9d03-57436d927a56"), "Amari", "Cooper" },
                    { new Guid("274ed940-6ee0-446b-ad8d-53fbda01a4f3"), "Michael", "Gallup " },
                    { new Guid("6ff4bc4b-05b5-40b5-ab45-e16bf2bfa113"), "Jaylon", "Smith" },
                    { new Guid("7212d680-34bf-4b4a-a592-d43ad6745cf9"), "CeeDee", "Lamb" },
                    { new Guid("50ff4449-33b4-4bf7-80a4-3cebbd4eadb0"), "Cedrick", "Wilson Jr." },
                    { new Guid("84b89f88-6bd4-4914-8ece-292721c623f0"), "Blake", "Bell" },
                    { new Guid("8b03b9d4-b75e-4cea-8c67-753b88d6522a"), "Sean", "McKeon" },
                    { new Guid("738c96f7-1587-4104-9132-d6676b3bab3b"), "Dalton", "Schultz" },
                    { new Guid("692a8481-2d80-4db2-8f7f-dff5369900bb"), "Tyler", "Biadasz" },
                    { new Guid("519e0a6b-6cfd-4dcf-bf7f-4cdca8138505"), "Cameron", "Erving" },
                    { new Guid("7e87e8c4-ef78-4990-8999-aebef56e0fb9"), "Joe", "Looney" },
                    { new Guid("68414c92-4aac-4a00-8b4d-4180586af012"), "Malik", "Turner" },
                    { new Guid("1766ffb1-41bb-4ff5-b376-3cbe7c81a8ae"), "Joe", "Thomas" },
                    { new Guid("578783b1-85ff-41a9-9746-9982d5efdd24"), "Leighton", "Vander Esch	" },
                    { new Guid("9ada7b1c-a660-4636-9af8-0583655f3be9"), "Anthony", "Brown" },
                    { new Guid("45e24c33-0747-4dfd-93af-34f02ccefb3f"), "Azur", "Kamara" },
                    { new Guid("32d311ca-0207-4984-bd69-36431043f9e4"), "Brandon", "Knight" },
                    { new Guid("82a9743d-5670-487d-b104-959be3290c0b"), "Jamize", "Olawale" },
                    { new Guid("571c0061-0eff-4e6f-b998-e1b2b3870ef3"), "Dak", "Prescott" },
                    { new Guid("47aa8369-fb6f-46cf-8ea6-e3c7d77df384"), "Tyron", "Smith" },
                    { new Guid("c1916274-6700-4c9a-bef3-75da72fa93b1"), "Isaac", "Alarcón" },
                    { new Guid("44097f00-6932-41de-8a6f-72ae1eca6676"), "Deante", "Burton" },
                    { new Guid("186033df-71a2-418d-ae67-6bc35960eb89"), "Chris", "Jones" },
                    { new Guid("0587152a-7e76-4945-a8be-b6501605e992"), "Ladarius", "Hamilton" },
                    { new Guid("63216b47-89dd-429d-9bac-7373a3f7e8c5"), "Cole", "Hikutini" },
                    { new Guid("23886d3e-a93d-4e5b-a5b1-1912bc183e29"), "Jon'Vea", "Johnson" },
                    { new Guid("d555945f-f45d-4b69-b6f7-a6ab9cd40e8c"), "Chris", "Lacy" },
                    { new Guid("ce5f237e-3207-4bd5-bb17-d157e2af9f0e"), "Jordan", "Mills" },
                    { new Guid("0717ae5e-c113-4a06-8f0d-4adbdb57ff63"), "Sewo", "Olonilua" },
                    { new Guid("f79962b7-5287-4fa7-b7cb-baa365c520fc"), "Walter", "Palmore" },
                    { new Guid("edb622d6-bb75-48c8-9632-dad08ef69c8b"), "Aaron", "Parker" },
                    { new Guid("46d3fc33-19e1-4925-91b5-b6d85e636380"), "Marcus", "Henry" },
                    { new Guid("ffc8da45-045a-46ec-8ec6-f71cc8e89b9b"), "Rashard", "Robinson" },
                    { new Guid("4f542ae2-f86e-44a1-91a1-e4b1ade3f7a7"), "Blake", "Jarwin" },
                    { new Guid("c0b0217b-903f-44b5-b4ce-ee67248a3580"), "Trysten", "Hill" },
                    { new Guid("4a67d737-6653-49a6-a20f-d279edd5b290"), "Trevon", "Diggs" },
                    { new Guid("7f403e98-058f-4748-9d69-65a873d9a67e"), "C.", "J. Goodwin	" },
                    { new Guid("6d6a517f-5e49-4694-9a7b-495476fde883"), "Jourdan", "Lewis" },
                    { new Guid("467a9606-d0a4-4aee-b7f3-ce2fe0d46faa"), "Steven", "Parker" },
                    { new Guid("61ba498d-2e7b-4c93-b41b-481d5490c1a9"), "Reggie", "Robinson" },
                    { new Guid("ae9a1f1b-9fdc-45a9-8190-01ff658dedee"), "Darian", "Thompson" },
                    { new Guid("d2210f0d-c460-47d7-a66f-3ad6aaa9c758"), "Donovan", "Wilson" },
                    { new Guid("2149525c-3329-49f8-8c7c-74fb22230be2"), "Mitch", "Hyatt" },
                    { new Guid("9bbe4333-bafe-48a4-afc2-ac28c56eb694"), "Xavier", "Woods" },
                    { new Guid("43c09cff-bcc0-4551-a83d-d2dd0698bdf2"), "Hunter", "Niswander" },
                    { new Guid("a34dce6f-1670-4b38-b574-c012c7c2f581"), "Greg", "Zuerlein" },
                    { new Guid("ef93f2e0-be4b-447b-9f83-d095367ef8fb"), "Chidobe", "Awuzie" },
                    { new Guid("8c6bf198-1fb3-4035-b74f-a77612df44f1"), "Maurice", "Canady" },
                    { new Guid("0433ecad-4e6d-4bf1-983f-b7e83c3d0bfb"), "La'el", "Collins" },
                    { new Guid("d270fc85-19b2-4e26-ba24-aa083a8bec39"), "Andy", "Dalton" },
                    { new Guid("949f41b2-862c-4155-a9b8-136183c07bb6"), "Stephen", "Guidry" },
                    { new Guid("15661a34-8d1f-4b6d-8954-f8702e102098"), "L.", "P. Ladouceur	" },
                    { new Guid("aa76cc1e-c853-458b-8afa-f421a4b85126"), "Abdullah", "Anderson" },
                    { new Guid("b895b322-c8cb-4312-9837-187083fbd3b9"), "Niko", "Lalos" },
                    { new Guid("eaf6cd32-9384-4dcd-a5ea-81dd3e2faa2b"), "Alfred", "Morris" },
                    { new Guid("ea0e0d42-4b0c-4d7b-b158-72545f106161"), "Isaiah", "Wright" },
                    { new Guid("a1041371-7ebf-487e-83e3-474956f28618"), "Temarrick", "Hemingway" },
                    { new Guid("2b6c4271-e670-4d87-b75a-8b42b7a84a49"), "Jeremy", "Sprinkle" },
                    { new Guid("36a1b77a-803c-4f79-8de6-8aac4dbf09b6"), "Logan", "Thomas" },
                    { new Guid("7ac7b8ee-87b8-4a1c-9aac-805475b230c8"), "Geron", "Christian" },
                    { new Guid("2d641910-9af2-49ed-be87-10ac82bff43a"), "Keith", "Ismael" },
                    { new Guid("6855f1cc-41d5-47e1-ad6a-1fd0a9539a4d"), "Cornelius", "Lucas" },
                    { new Guid("b0169e51-67be-4861-905a-b5c604ef9059"), "Wes", "Martin" },
                    { new Guid("565bb8b9-26a2-4caa-b604-f96da4577d89"), "Morgan", "Moses" },
                    { new Guid("e11fd458-edc6-4d40-8d01-d891a8f01eff"), "Chase", "Roullier" },
                    { new Guid("fd5767bf-5fb3-4d35-8abe-9edba077f1d1"), "David", "Sharpe" },
                    { new Guid("950fe5c0-25ad-4976-b77b-09e2e2ace223"), "Brandon", "Scherff" },
                    { new Guid("70a34b02-1fc8-4ca4-9e3a-67f39d8064dc"), "Wes", "Schweitzer" },
                    { new Guid("4227da80-3725-4517-8d1b-de022e8b1a77"), "Ryan", "Anderson" },
                    { new Guid("1e9baccb-3f41-423d-abc4-d53cd64134ad"), "Jonathan", "Allen" },
                    { new Guid("e9056ba7-1a5e-4d63-ba20-44c0aa8dd2ec"), "Cam", "Sims" },
                    { new Guid("a3074f62-fc1d-40ed-8af6-bbc9894c6dd9"), "Terry", "McLaurin" },
                    { new Guid("289a7966-9580-4f6c-b6a5-cbdcc213042e"), "Dontrelle", "Inman" },
                    { new Guid("ed55d679-a322-4550-8e74-00b8083a1cd5"), "Robert", "Foster" },
                    { new Guid("b482b6cd-b3e9-4ef9-9243-35f9518a66dc"), "Josh", "McCown" },
                    { new Guid("67b3463c-b6e3-411a-9aea-fe2b4227e582"), "T.", "Y. McGill	" },
                    { new Guid("ed526d33-1cec-4a48-826e-9f4ca93bb3ca"), "Shareef", "Miller" },
                    { new Guid("d6057fe7-c25b-45b4-bf65-931f444e8908"), "Joe", "Ostman" },
                    { new Guid("1fae6c2b-f6d4-4141-948f-346e1c90ded6"), "Elijah", "Riley" },
                    { new Guid("c6acef4b-45ef-4332-9f63-9fcb8527a51e"), "Rashad", "Smith" },
                    { new Guid("3de6aa4a-055c-4f08-b2fa-7e945336a998"), "Prince", "Tega Wanogho	" },
                    { new Guid("48bd5422-2d56-4c86-81c8-180b0c4ce497"), "Ryan", "Kerrigan" },
                    { new Guid("bea4a18b-e475-4992-b95e-cf82a2b10543"), "Raequan", "Williams" },
                    { new Guid("3d6859b2-c136-4e29-9bd7-658b379f75a4"), "Kyle", "Allen" },
                    { new Guid("91a0752e-c042-4349-963d-ae9befb52bec"), "Dwayne", "Haskins" },
                    { new Guid("e428ac3c-8be7-4ba7-b26d-fbd012ce8be5"), "Alex", "Smith" },
                    { new Guid("9bcc0737-4c63-44b3-8854-1d6a926af1a1"), "Peyton", "Barber" },
                    { new Guid("188a6c8b-c3a9-425a-b057-9d8f2ba5fde5"), "Antonio", "Gibson" },
                    { new Guid("ea2b57ea-ff06-475a-a7c0-4c4472194225"), "J.", "D. McKissic	" },
                    { new Guid("3cb8189c-4ab2-4cef-80bc-873b1eba2967"), "Tony", "Brown" },
                    { new Guid("f88069e7-4aea-49c8-b4e3-23c400d03b95"), "Caleb", "Wilson" },
                    { new Guid("006b3488-c04f-4a66-9f12-33c26586ec01"), "Nate", "Orchard" },
                    { new Guid("ee2322d3-a46d-4cb3-99e1-521f9eb536c2"), "Daron", "Payne" },
                    { new Guid("ff68cf48-d566-431d-a11c-1748721ac245"), "Tim", "Settle" },
                    { new Guid("7eee784b-3f90-440a-a6af-68556c7004af"), "Dustin", "Hopkins" },
                    { new Guid("2ee949f7-3297-4462-8068-cb874da3d442"), "Nick", "Sundberg" },
                    { new Guid("c58596f2-6a05-4728-b542-0a9656c0ff6f"), "Tress", "Way" },
                    { new Guid("5c0b8a97-1b60-4138-b285-1df388d35c1e"), "Caleb", "Brantley" },
                    { new Guid("b7ce8065-c6c8-4bac-b5c8-3e5be7905bbe"), "Saahdiq", "Charles" },
                    { new Guid("39476e30-499d-4661-bcae-ec7f72cce13b"), "Landon", "Collins" },
                    { new Guid("80cd85fb-b23b-4a72-a894-c07927623d75"), "Reuben", "Foster" },
                    { new Guid("849621a4-705b-4f73-8eb9-65193744df39"), "Jeremy", "Reaves" },
                    { new Guid("4e8e13ae-06c1-4b92-b586-4d8dd89b36f0"), "Antonio", "Gandy-Golden" },
                    { new Guid("23ca6aaa-c609-4b8c-938e-d7a55e0f68dd"), "Kelvin", "Harmon" },
                    { new Guid("b7b3aa99-64ea-4408-abbc-3d3e3f194dd5"), "Josh", "Harvey-Clemons" },
                    { new Guid("c027744f-c469-4058-884f-af761b811cff"), "Matt", "Ioannidis" },
                    { new Guid("ad3e061c-1d23-4fe6-9dda-9dcb11176dd3"), "Michael", "Liedtke" },
                    { new Guid("13fc2254-3836-480e-b764-636edbd4a519"), "Bryce", "Love" },
                    { new Guid("705f4500-e614-4334-9bbd-07595354b3ae"), "Thaddeus", "Moss" },
                    { new Guid("8ca877d2-34b6-4366-abd9-eadade91d943"), "Steven", "Sims" },
                    { new Guid("921173e7-9038-4a7f-a9e8-c7581577d8a9"), "Emanuel", "Hall" },
                    { new Guid("46374a62-9cfe-4cac-a897-21b10c8333b6"), "Matt", "Leo" },
                    { new Guid("8fd020d0-5790-4965-b115-c0c996ed744e"), "Jimmy", "Moreland" },
                    { new Guid("d8701210-5d07-4979-8492-dbc73b99b842"), "Danny", "Johnson" },
                    { new Guid("b87ec41e-d8d4-40f3-aef4-dcfadfead9eb"), "James", "Smith-Williams" },
                    { new Guid("f6eb55cf-2e01-497d-9760-3b8555439b6e"), "Montez", "Sweat" },
                    { new Guid("77b84426-d0e6-4240-9d9d-22c2b96fd0cc"), "Casey", "Toohill" },
                    { new Guid("b5deb319-9c64-47e5-b81d-dd19f4aa9bd2"), "Chase", "Young" },
                    { new Guid("cb853f53-fcae-48dc-8c54-40f6155085af"), "Jon", "Bostic" },
                    { new Guid("e6564ccd-e411-4ade-ab76-2875bafda88f"), "Thomas", "Davis Sr.	" },
                    { new Guid("12365214-4df7-471d-9200-a49a88a3e230"), "Shaun", "Dion Hamilton	" },
                    { new Guid("2dee8d97-8cce-4b41-a0e1-7edd177273b7"), "Fabian", "Moreau" },
                    { new Guid("ff2deb2b-147e-49ec-9ef8-17a0a6573a40"), "Cole", "Holcomb" },
                    { new Guid("ce476c67-0779-42be-a6fa-35f9406ff6e9"), "Jared", "Norris" },
                    { new Guid("e7a7b880-66b7-41f1-a6f5-d42e54fd3db3"), "Kevin", "Pierre-Louis" },
                    { new Guid("b1737833-f6ba-4e20-aaae-a63ff4762484"), "Troy", "Apke" },
                    { new Guid("6dc7747b-39a4-4ca7-a8bd-2fcd31c0ab9f"), "Kamren", "Curl" },
                    { new Guid("3fa1b76b-f7e2-49a5-b8ef-7f0cf5bd884c"), "Ronald", "Darby" },
                    { new Guid("2e91172a-87a3-4a82-8af0-1e7394ac39e6"), "Deshazor", "Everett" },
                    { new Guid("fea4d434-310f-4274-9fbb-a8dd07e46391"), "Kendall", "Fuller" },
                    { new Guid("50cc8deb-9cdd-4718-8979-7fa347da138a"), "Khaleke", "Hudson" },
                    { new Guid("49d77d93-fa82-46a4-b1e4-a7e8eb5891fd"), "David", "Moa" },
                    { new Guid("7b20bae3-f0a0-406b-9494-149fe485b322"), "Adrian", "Killins" },
                    { new Guid("3bbf164d-23a3-4bd5-a14e-97e5554c7dc5"), "Elijah", "Holyfield" },
                    { new Guid("709146ea-5030-4a0b-860b-9e7ced1f449d"), "Jalen", "Reagor" },
                    { new Guid("7062fcd7-52a5-4426-a6f2-ec04fdf4069f"), "Greg", "WardPR" },
                    { new Guid("83de593b-fdbf-4dc6-b52d-b4adcc1bce36"), "Quez", "Watkins" },
                    { new Guid("9145f35b-545b-4b30-bea9-196910349576"), "Dallas", "Goedert" },
                    { new Guid("9c920f7e-a517-4e4a-9f60-32d30b428926"), "Richard", "Rodgers II	" },
                    { new Guid("6ab7152e-37a8-4d4b-9aad-0dabc6ba290c"), "Jack", "Driscoll" },
                    { new Guid("307fa9ee-b883-4c4e-acdf-eaf8f99514bb"), "Nate", "Herbig" },
                    { new Guid("c2062890-198e-4306-af60-b0e32f77336f"), "Lane", "Johnson" },
                    { new Guid("a0b63a73-9c73-43d4-adcb-17e4bc7473d6"), "Luke", "Juriga" },
                    { new Guid("2bb5457d-c840-488a-aa5f-a5a2607c5477"), "Jason", "Kelce" },
                    { new Guid("9f6370b7-4006-4463-934e-1b68273dbe99"), "Jordan", "Mailata" },
                    { new Guid("0d41104c-0c85-4bb3-9fcb-1c303ae52da7"), "Sua", "Opeta" },
                    { new Guid("3e26fb47-817e-42ca-a55d-38844232c966"), "Jason", "Peters" },
                    { new Guid("69d55ebf-a9a3-4f17-82e4-9b1b7b0ee032"), "Matt", "Pryor" },
                    { new Guid("cd33697f-95ca-43ec-af3c-897ddb0b52da"), "Brett", "Toth" },
                    { new Guid("9d2d2ace-f74f-430a-b74a-1a024efa401e"), "Alshon", "Jeffery" },
                    { new Guid("0c5a286a-1c64-42b5-b8d2-cea52737d10b"), "John", "Hightower" },
                    { new Guid("79f6a2ce-d0b5-4ffa-99a9-94ff907b434c"), "Travis", "Fulgham" },
                    { new Guid("578c9cc2-6c83-4ba3-8c8f-7203204faa18"), "J.", "J. Arcega-Whiteside	" },
                    { new Guid("d52326b8-fbcc-4391-aaa3-b1619e5418c2"), "Kyle", "Murphy" },
                    { new Guid("d0d22a29-c27c-4a14-8cd0-3c85946bd0dc"), "Sandro", "Platzgummer" },
                    { new Guid("18419068-f2f6-4b81-b342-d39ec97295ae"), "Ryan", "Santoso" },
                    { new Guid("1d3a131a-bdc4-49c3-bbea-4f8d2bc47f8e"), "Chad", "Slade" },
                    { new Guid("74d96f59-1629-4da4-bd07-069d2f7865ec"), "Clayton", "Thorson" },
                    { new Guid("67b6010b-19ce-442e-95ad-5ff7269b8e37"), "Carson", "Tinker" },
                    { new Guid("f4f10819-e691-494e-a117-1b355c5cf11e"), "Binjimen", "Victor" },
                    { new Guid("092b1df7-e14c-4f41-8f25-0c847387cc29"), "Derek", "Barnett" },
                    { new Guid("c74609cb-4bc1-4104-8110-297b14f9221c"), "Jarren", "Williams" },
                    { new Guid("93b3c51b-cb53-437d-b29a-4d340013aa45"), "Jalen", "Hurts" },
                    { new Guid("fbfa4c75-3657-488e-a204-6bc5038429fe"), "Nate", "Sudfeld" },
                    { new Guid("aa638eca-53c2-41cf-bb69-7d3e794c7285"), "Carson", "Wentz" },
                    { new Guid("a2ef58d3-eac0-4302-ad1c-c2658feeedde"), "Corey", "Clement" },
                    { new Guid("8fc8f3b8-937d-4e0e-ac03-bae68ca4a7fa"), "Jason", "Huntley" },
                    { new Guid("b2460ecc-0354-4ef0-ba64-af51cd7c6345"), "Miles", "Sanders" },
                    { new Guid("f500661a-472c-44c9-b556-74288a484534"), "Boston", "Scott" },
                    { new Guid("172ef478-2cbf-4baf-b375-e8d4f84568c8"), "Chris", "Williamson" },
                    { new Guid("438beb42-fa1b-466f-b734-7fe9ae39e148"), "Fletcher", "Cox" },
                    { new Guid("3878b085-c519-431e-bd86-61bdb0eb531c"), "Vinny", "Curry" },
                    { new Guid("5590056e-88df-438b-ada2-244f4871fb75"), "Brandon", "Graham" },
                    { new Guid("e236b7a3-155b-49b2-bb94-078feee960ae"), "Cameron", "Johnston" },
                    { new Guid("a8f03ae1-0952-4fd5-9556-60ad9957cf54"), "Rick", "Lovato" },
                    { new Guid("57747b74-7231-48c3-9a13-55046e36b38f"), "Genard", "Avery" },
                    { new Guid("13926811-403d-424a-bd7c-1b83bfbd75b5"), "Brandon", "Brooks" },
                    { new Guid("d9d701cf-d87e-41de-aec6-524e68ac5d8b"), "Andre", "Dillard" },
                    { new Guid("bfc45a01-2d1b-4024-8994-5f6ae720f25a"), "Zach", "Ertz" },
                    { new Guid("27e6b1e1-02fa-402a-b831-49fedda0c7c1"), "Nathan", "Gerry" },
                    { new Guid("67a02f41-45c4-4ab6-843b-601a8c58266e"), "Jake", "Elliott" },
                    { new Guid("488f2090-6ef8-4939-942d-1264cfa33785"), "Marquise", "Goodwin" },
                    { new Guid("4bd61705-ad37-48ef-a759-6a367fc4a6ed"), "Joshua", "Perkins" },
                    { new Guid("4a19df05-273d-42ed-b2e0-e9e524ce83c2"), "Hassan", "Ridgeway" },
                    { new Guid("fe7c72ff-d88f-4c2d-8ba7-be590b60f17b"), "Isaac", "Seumalo" },
                    { new Guid("2d6824a3-bab4-4cf7-9eda-9a6e26a35c64"), "Grayland", "Arnold" },
                    { new Guid("ae0b481b-09c0-4ecf-9079-9feec18c3f19"), "Jamon", "Brown" },
                    { new Guid("7fa2175e-e6bd-4280-9caa-c5ad1e9f0d43"), "Deontay", "Burnett" },
                    { new Guid("467cebe9-6a68-4951-9a52-8c6f3095a436"), "Hakeem", "Butler" },
                    { new Guid("5307aa78-c828-4d75-9d31-a0c67b239aae"), "DeSean", "Jackson" },
                    { new Guid("3eac329f-9602-407f-a9e0-966d0e054efc"), "Michael", "Jacquet" },
                    { new Guid("cb6e6c35-3ea0-4862-8b6e-68f44ca9b82c"), "K'Von", "Wallace" },
                    { new Guid("6313afa2-ff36-461b-b9a3-c079b88507ae"), "Nickell", "Robey-Coleman" },
                    { new Guid("6a99351c-4ceb-4abf-afaf-bbbd4ab845da"), "Javon", "Hargrave" },
                    { new Guid("cb1c6f76-a776-41e0-973c-6b067f5dc56e"), "Malik", "Jackson" },
                    { new Guid("f28ed722-f7bd-431b-a7a9-1ae9da057082"), "Josh", "Sweat" },
                    { new Guid("92b2fd51-9118-4fd5-8e02-1e3dedc80a4f"), "Shaun", "Bradley" },
                    { new Guid("7bd7af6a-6dda-418a-b107-dadb01205ca3"), "T.", "J. Edwards	" },
                    { new Guid("e63134c4-3a48-4d95-8e67-5ded041f10a9"), "Duke", "Riley" },
                    { new Guid("5325046d-f10c-491a-8c69-deb474f58c3a"), "Alex", "Singleton" },
                    { new Guid("bad5b8e6-f0f7-47f7-97a6-77bcf2e2111c"), "Darius", "Slay" },
                    { new Guid("244ba5ed-dc9a-41e6-a606-cbcbf70e06a1"), "Davion", "Taylor" },
                    { new Guid("8dfb2905-ba31-40e9-ae98-f06139c0c1b1"), "Rudy", "Ford" },
                    { new Guid("930ba253-d277-462f-8e9c-ff480bafb88b"), "Craig", "James" },
                    { new Guid("dff84952-4989-4a47-8650-9ea27dc440da"), "Cre'Von", "LeBlanc" },
                    { new Guid("69e94e69-1712-4c94-8ab5-d0a17546dc96"), "Avonte", "Maddox" },
                    { new Guid("83c74c96-6efd-4a15-abd2-9acc81e9279a"), "Rodney", "McLeod" },
                    { new Guid("da3cd723-bad4-44a6-bc3b-c4ac58721d75"), "Jalen", "Mills" },
                    { new Guid("b498ef2c-2468-41da-b6cd-b8c4ff012acc"), "Will", "Parks" },
                    { new Guid("58ce1d85-5e46-4787-a899-1df5a81a8045"), "Marcus", "Epps" },
                    { new Guid("8dbf63ff-2a08-4c06-9c93-f9ec86443338"), "Aaron", "Fuller" },
                    { new Guid("f04a8bf6-120a-4e4a-bd75-cff3f25fb314"), "Jake", "Bargas" },
                    { new Guid("a9871ed8-8ae6-48d2-b510-958d851a3672"), "Jake", "Browning" },
                    { new Guid("c178d6ec-33ef-475f-b210-8de8229e70ce"), "David", "Edwards" },
                    { new Guid("0d33f178-4ca6-4647-b4bd-54d278171053"), "Bobby", "Evans" },
                    { new Guid("91a5427d-c17a-42d2-be17-409fdc5a8f39"), "Rob", "Havenstein" },
                    { new Guid("bd526949-34cb-44e7-8a85-97d0f78d056d"), "Coleman", "Shelton" },
                    { new Guid("7ec07db1-db68-4eda-bb97-02718e0cb612"), "Andrew", "Whitworth" },
                    { new Guid("d311c7f2-2e86-4ce8-affb-5e7bd3bf7631"), "Michael", "Brockers" },
                    { new Guid("4c4e6cd9-ee8f-457c-b717-a9e871ee3da8"), "Aaron", "Donald" },
                    { new Guid("1caf84d7-cff6-4642-9be0-ae04c04043a7"), "Morgan", "Fox" },
                    { new Guid("171d5e0d-4c27-41e8-a501-554f8e574859"), "Greg", "Gaines" },
                    { new Guid("c88e474e-d282-4d92-9506-aaca9a804386"), "Sebastian", "Joseph-Day" },
                    { new Guid("0f92e235-a688-4773-a784-884247f1fca8"), "A'Shawn", "Robinson" },
                    { new Guid("bb78bbcc-feb7-41a7-8e45-acb1bf332df7"), "Samson", "Ebukam" },
                    { new Guid("23bb24e2-37d6-4e43-915d-1fcea2ed39ad"), "Leonard", "Floyd" },
                    { new Guid("8a5812a3-c2a0-406a-b32d-36b7a5dd75e1"), "Justin", "Hollins" },
                    { new Guid("679ad689-1139-4970-861e-ef22a0306535"), "Terrell", "Lewis" },
                    { new Guid("289d6740-4a51-46aa-b3ee-af060f2972ef"), "Austin", "Corbett" },
                    { new Guid("70c3c62d-4afd-494a-933d-ac466ba5bfda"), "Austin", "Blythe" },
                    { new Guid("673baaa0-409a-4069-9adf-543577229a8f"), "Tremayne", "Anchrum" },
                    { new Guid("668b73c5-e589-45fd-b694-5d7d3bef57b5"), "Brian", "Allen" },
                    { new Guid("40a42d52-6ce0-4ede-a109-64dd26095373"), "John", "Wolford" },
                    { new Guid("40b80e75-88b5-479a-a9f8-a4c82668e62c"), "Cam", "Akers" },
                    { new Guid("5e45cfed-067e-4b6c-a0f3-ce10a656b9c0"), "Raymond", "Calais" },
                    { new Guid("b522db4c-8654-4186-9424-9867f7bcb3c9"), "Malcolm", "Brown" },
                    { new Guid("7a6a8385-b32e-42fc-a17e-a67137fb0697"), "Darrell", "Henderson" },
                    { new Guid("52b03fdf-f204-4afc-9a8b-56578298a519"), "Xavier", "Jones" },
                    { new Guid("197df3d2-a99e-4042-a7e3-9e5caa8d6366"), "Trishton", "Jackson" },
                    { new Guid("5a21c04d-76b6-417f-bd56-069f13770920"), "Micah", "Kiser" },
                    { new Guid("c2059c30-a8c5-4dd5-a39a-bd4a21b834ef"), "Van", "Jefferson" },
                    { new Guid("ad3eb053-e496-40eb-842f-276ff4d59033"), "Josh", "Reynolds" },
                    { new Guid("49252077-0d4f-4294-acd1-63a0218d481d"), "Nsimba", "Webster" },
                    { new Guid("6f4aa61c-d5c7-4683-a2c4-690fbc07d417"), "Robert", "Woods" },
                    { new Guid("1527702a-0d2f-4f47-86af-bd7eae35281e"), "Gerald", "Everett" },
                    { new Guid("60450d47-85a8-4c84-9e19-ea9523cd4da9"), "Tyler", "Higbee" },
                    { new Guid("17023e99-682f-4a35-b102-3e6a75504ba6"), "Brycen", "Hopkins" },
                    { new Guid("5fcec144-55cd-46aa-bfd4-ec8b8ab4d64c"), "Johnny", "Mundt" },
                    { new Guid("4d585fe2-c14d-4d05-bb7c-cf5132e4f609"), "Cooper", "Kupp" },
                    { new Guid("6a7830e7-896a-40b7-8eb0-30cffb807aa9"), "Jared", "Goff" },
                    { new Guid("01a33f08-e5c7-46c8-8290-de814a097307"), "Natrez", "Patrick" },
                    { new Guid("76254a47-259d-482c-89c5-0ee2172d74c7"), "Troy", "Reeder" },
                    { new Guid("c911f9b5-963d-45fd-b01e-9bc5abec7682"), "Kendall", "Blanton" },
                    { new Guid("a5eb6ecc-77ca-45d3-ac60-30364c414108"), "Cohl", "Cabral" },
                    { new Guid("dbf77cef-df1d-4d89-8c08-f927f023325d"), "Marquise", "Copeland" },
                    { new Guid("10cd8761-c01a-4521-8a9b-0738db6d8e33"), "Donte", "Deayon" },
                    { new Guid("15856734-5cdb-49b6-b0a0-6b300a11a914"), "Jamil", "Demby" },
                    { new Guid("612dadd4-94cc-4baa-b777-3a9b48275bb6"), "Michael", "Hoecht" },
                    { new Guid("1718f503-8462-4557-ab7b-9fc4eda01c30"), "Jeremiah", "Kolone" },
                    { new Guid("9c8e4e39-fd86-4410-b46e-cc6a15a243b7"), "J.", "J. Koski	" },
                    { new Guid("1311d035-92cf-4030-aa1f-dae22546a6be"), "Austin", "MacGinnis" },
                    { new Guid("b3ef802c-ed72-4e74-b3c6-b758a56eb699"), "Tyrique", "McGhee" },
                    { new Guid("e1c0bef9-4448-4fce-a732-1c93f6bca07f"), "Derrick", "Moncrief" },
                    { new Guid("6d1bfc84-699c-4cab-9e25-676a8bd1c9ce"), "Bryce", "Perkins" },
                    { new Guid("f17bfb80-7e45-46a6-aa45-33d07408d80d"), "J.", "R. Reed	" },
                    { new Guid("19412bc2-de52-4b47-bb89-a2c95382cc9d"), "Christian", "Rozeboom" },
                    { new Guid("e11e8d67-49b7-483d-aa73-1e8c0a85d8b0"), "Jonah", "Williams" },
                    { new Guid("08464785-17f8-4e17-8033-5edd65a41de4"), "Daniel", "BituliI" },
                    { new Guid("f449f3ee-d7b7-4f1f-a04e-3654c1690069"), "Eric", "Banks" },
                    { new Guid("eaaecc8a-71af-427f-9daf-21cb9797b0b6"), "Ogbonnia", "Okoronkwo" },
                    { new Guid("44c5b0d0-702b-4d3c-889d-5e239a2f20c5"), "Joseph", "Noteboom" },
                    { new Guid("8446719f-310c-4818-9b79-90bcaf70c0d3"), "Kenny", "Young" },
                    { new Guid("53526803-6a34-43f8-b8c8-58b11ee4577e"), "Troy", "Hill" },
                    { new Guid("e9523143-25b5-478f-8765-7354dfb40e26"), "JuJu", "Hughes" },
                    { new Guid("241e9b75-7e27-44dd-9fd4-12a2a3c0cd4b"), "John", "Johnson" },
                    { new Guid("703c0473-f361-47ff-815b-9ee40e4fc1f9"), "David", "Long" },
                    { new Guid("e4fc1a1b-cbf0-4df4-a39d-12e3dc8d5238"), "Jalen", "Ramsey" },
                    { new Guid("bf94cab2-5f38-4e98-ac53-a3e861fc62dc"), "Taylor", "Rapp" },
                    { new Guid("81fa7e76-510d-4dfe-b86e-548aa128b544"), "Jachai", "Polite" },
                    { new Guid("a817e7a2-603f-4567-b5b3-56a6e3aa3452"), "Nick", "Scott" },
                    { new Guid("503e58e3-11ca-4a52-b32d-a447a23f2ed2"), "Kai", "Forbath" },
                    { new Guid("a8511c32-1364-46c1-8fe1-030523a3fdb1"), "Johnny", "Hekker" },
                    { new Guid("b2c2f786-66f0-4abb-8996-0f721d86219d"), "Jacob", "McQuaide" },
                    { new Guid("a8cd5325-c2d4-4a1d-8167-307295650b7e"), "Chandler", "Brewer" },
                    { new Guid("d9670c4b-aec6-4e3b-8981-0b6096afa584"), "Terrell", "Burgess" },
                    { new Guid("76db41d4-ca2f-44fa-ad85-1e50686d6b76"), "Jordan", "Fuller" },
                    { new Guid("59d39f04-a41b-454f-88c5-d03a77dcb66b"), "Travin", "Howard" },
                    { new Guid("1e2b52d5-b718-41e3-a01e-152ed8ea4f49"), "Darious", "Williams" },
                    { new Guid("a1d44253-14a5-41e2-ba1b-de6dcb2cbffd"), "Jace", "Whittaker" },
                    { new Guid("369940af-7845-4e32-98d9-1608d4b3bd33"), "Evan", "Weaver" },
                    { new Guid("16a3c844-9ba7-45c5-a540-2cf8c5df1154"), "JoJo", "Ward" },
                    { new Guid("4042536f-4193-421a-a26c-2382ce47e5eb"), "Lamont", "Gaillard" },
                    { new Guid("358da52a-61b8-44f2-9d44-02a600ada4e9"), "Max", "Garcia" },
                    { new Guid("f62de6d5-daad-44b9-85d5-50d37512d2ee"), "D.", "J. Humphries	" },
                    { new Guid("cbb9bb7b-07a7-44f1-9722-d78e9ddbb3f0"), "Josh", "Jones" },
                    { new Guid("bc79e05e-12db-4c50-8c2d-65f4892d35d7"), "Joshua", "Miles" },
                    { new Guid("8d056d48-e3a1-4be2-9f51-663fbe8600a9"), "Justin", "Murray" },
                    { new Guid("0041af1d-867f-44d0-871d-460832b9ba37"), "Justin", "Pugh" },
                    { new Guid("67ecc956-0c5a-49ef-b7ad-80c85a2532ee"), "Angelo", "Blackson" },
                    { new Guid("3412d739-da1b-4d94-a05d-9822bad87a96"), "Leki", "Fotu" },
                    { new Guid("0944a530-8673-4d8b-ae03-0de3068ca10c"), "Josh", "Mauro" },
                    { new Guid("ad9bb07c-aea3-4911-8b40-c93469178916"), "Corey", "Peters" },
                    { new Guid("dfd0ec4f-b83c-42ae-897f-3b39df98bb43"), "Jordan", "Phillips" },
                    { new Guid("983f59a6-06db-4dfa-a9e5-6af32e439574"), "De'Vondre", "CampbellI" },
                    { new Guid("abd3a85f-8c2d-4020-a9cd-73af0b96c0e4"), "Kylie", "Fitts" },
                    { new Guid("43d115ea-a4f1-447d-b1cf-c9696167e119"), "Dennis", "Gardeck" },
                    { new Guid("711567cd-e908-410e-89f4-a9ddef4d8afb"), "Mason", "Cole" },
                    { new Guid("98effb1f-091a-4b47-a625-6cb97cbeccab"), "Kelvin", "Beachum" },
                    { new Guid("8c68a470-d586-4f53-a941-8e609250a507"), "Jordan", "Thomas" },
                    { new Guid("93c33158-974a-4993-8e9b-5d18583e3487"), "Darrell", "Daniels" },
                    { new Guid("3e6f045e-3a8a-422f-988b-7a9e0b2a494e"), "Aca'Cedric", "Ware" },
                    { new Guid("4fb8ca50-06dc-490c-9b79-e4524931f862"), "Mazzi", "Wilkins" },
                    { new Guid("b00ff22d-00ff-47a3-929d-5ac5a87a225c"), "Brett", "Hundley" },
                    { new Guid("08a58065-d808-4cc2-a984-a78984a4e746"), "Kyler", "Murray" },
                    { new Guid("0920aa26-58f4-4e2d-89d8-90a9deb0071c"), "Chris", "Streveler" },
                    { new Guid("c885a20c-5ed0-480a-a991-f67b6c3e5341"), "Eno", "Benjamin" },
                    { new Guid("8797172d-03e5-4737-938f-cee3710dbca9"), "Kenyan", "Drake" },
                    { new Guid("a3327b74-e65e-4576-8300-3838786900a1"), "Markus", "Golden" },
                    { new Guid("e80d15e2-f7a8-4ef2-9677-75ec719a3c05"), "Chase", "Edmonds" },
                    { new Guid("e03597c9-144c-4ace-9d4c-31572c383226"), "Larry", "Fitzgerald" },
                    { new Guid("a456b8fd-293e-48a0-9496-ba978ce68abf"), "DeAndre", "Hopkins" },
                    { new Guid("e0edbdba-914e-4765-bbf8-d1e38b9966b6"), "Andy", "Isabella" },
                    { new Guid("ce3f1b64-2267-4511-a5fb-b43980db724a"), "KeeSean", "Johnson" },
                    { new Guid("22aaa8cb-cbb3-426e-9abf-c8d9b25de325"), "Christian", "Kirk" },
                    { new Guid("2fcff443-ce4a-4969-8773-dff5fd055c11"), "Trent", "Sherfield" },
                    { new Guid("a9dcf548-8c40-4b81-960a-19f4acb96c6c"), "Dan", "Arnold" },
                    { new Guid("4d4ce24d-c9b9-4a29-84df-3f702ddf863f"), "Jonathan", "Ward" },
                    { new Guid("ad52b8fe-2029-4bc8-bf55-495ff42b2dee"), "Jordan", "HicksI" },
                    { new Guid("94cfb638-cea9-4c9b-8423-8b2151f3ec4d"), "Haason", "Reddick" },
                    { new Guid("82a39b44-943b-4446-8d51-90cecc4d583c"), "Isaiah", "SimmonsI" },
                    { new Guid("2a0ce5b4-fa6a-4244-ace1-fb0273c57fed"), "Rashard", "Lawrence" },
                    { new Guid("84f9ac5c-1ced-4dfa-8e9c-85599704a39b"), "Byron", "Murphy" },
                    { new Guid("29a563cc-ab22-4046-b5d6-8a078520408c"), "J.", "R. Sweezy	" },
                    { new Guid("b90ae148-3ad3-4239-a2e5-27911924f109"), "Maxx", "Williams" },
                    { new Guid("c9f61ddb-0439-47aa-ae6c-f5450bb89a04"), "Prince", "Amukamara" },
                    { new Guid("8fd4c7d6-27ef-4697-893e-16bba278918d"), "Evan", "Baylis" },
                    { new Guid("77299625-a243-45ab-9863-1e976f4edb7f"), "Trevon", "Coley" },
                    { new Guid("7e2ff257-6b6f-4fdc-8213-2cfa357befed"), "Devon", "Kennard" },
                    { new Guid("ced9f2f6-251a-4613-af9b-8e77b60da898"), "Michael", "Dogbe" },
                    { new Guid("22883634-6749-4164-8089-40d55f7f782a"), "Reggie", "Gilbert" },
                    { new Guid("67015a1f-0432-41f0-9cd8-239a60332e19"), "Rick", "Leonard" },
                    { new Guid("6ca664b4-44b0-4c41-9ba3-7105251fde2b"), "Koda", "Martin" },
                    { new Guid("f46fada8-12ba-429b-be08-12d1124bbc59"), "Khalfani", "Muhammad" },
                    { new Guid("ebbb4393-f8d0-41a6-a7c3-c740d1ddd95e"), "Mike", "Nugent" },
                    { new Guid("ab8cdf90-1bbe-4a2c-9279-55863ebe4f7e"), "A.", "J. Richardson	" },
                    { new Guid("bcc2f55b-3375-41ca-afa4-896039d2e09c"), "Reggie", "Walker" },
                    { new Guid("662e114b-4c01-439d-a32f-fc5a17bc958f"), "D.", "J. Foster	" },
                    { new Guid("a7603512-6e27-4eb5-9e1a-7466501d25fd"), "C.", "J. Beathard	" },
                    { new Guid("7c8dc5ca-af9c-4d9c-90fa-a563bfbb3fd4"), "Chandler", "Jones" },
                    { new Guid("a5b0ce48-8c47-4dfa-bba3-be84267d43b1"), "Marcus", "Gilbert" },
                    { new Guid("5d7fe380-90c1-4957-836a-739bf8a4a84c"), "Zeke", "TurnerI" },
                    { new Guid("6384fc82-9d14-4ee1-a21a-dcbe678de37c"), "Tanner", "VallejoI" },
                    { new Guid("53934c89-1fd5-4aeb-a591-72e7c0a6afd0"), "Budda", "Baker" },
                    { new Guid("597771bf-232b-4738-b886-cad27b3a04fb"), "Chris", "Banjo" },
                    { new Guid("92dcb251-24e3-4367-ac04-a6fcafe97f4a"), "De'Vante", "Bausby" },
                    { new Guid("3bb7f075-9aa2-4c7d-a59f-f47b452ffbae"), "Dre", "Kirkpatrick" },
                    { new Guid("59bed8f2-1293-4f13-9625-f07d00e9e3e1"), "Kevin", "Peterson" },
                    { new Guid("1f8fe313-829c-4190-9f4c-e65aa3304242"), "Isaiah", "Irving" },
                    { new Guid("027dd796-5166-4eab-aa07-3433fd09efd1"), "Patrick", "Peterson" },
                    { new Guid("47a4c1a2-fe07-4136-b5a1-3e60a49252fe"), "Jalen", "Thompson" },
                    { new Guid("bfc6d27a-f990-4edd-8883-8868b84480f6"), "Charles", "Washington" },
                    { new Guid("f74f8c63-cf46-4eb3-a6c6-e38241f72350"), "Aaron", "Brewer" },
                    { new Guid("bf4b5e96-6ee4-4702-9a33-9bcc7cedfa4b"), "Zane", "GonzalezK" },
                    { new Guid("cb523118-008a-4f82-b38e-1f8e0db05c11"), "Andy", "LeeP" },
                    { new Guid("8176552d-0d7e-404c-b42e-a8891f95fde5"), "Robert", "Alford" },
                    { new Guid("07deeea8-7bea-4f28-9b84-5970f613b9c3"), "Zach", "Allen" },
                    { new Guid("8489eb26-5416-41aa-bfd4-ae8623d5bfcf"), "Deionte", "Thompson" },
                    { new Guid("6b12475c-92af-4201-91b9-5530eba876fc"), "Jimmy", "Garoppolo" },
                    { new Guid("c1f3560d-3ee0-4721-b249-f7103209da02"), "Nick", "Mullens" },
                    { new Guid("4f8ace56-67fa-4fdc-a7d9-5dc3f17eb4c9"), "Tevin", "Coleman" },
                    { new Guid("6045510a-7e2c-46dd-948f-7c9fab21e01c"), "Duane", "Brown" },
                    { new Guid("6fb813bb-bace-48fc-87d0-fc28c7271c26"), "Kyle", "Fuller" },
                    { new Guid("19d75950-80b8-4b60-8a44-67968f203642"), "Mike", "Iupati" },
                    { new Guid("2647ec00-b81c-404a-a793-655ba8b53e96"), "Jamarco", "Jones" },
                    { new Guid("2bf4b82f-1e4d-483e-af96-04928057cbfe"), "Damien", "Lewis" },
                    { new Guid("58d845cd-9e6a-4a3c-8eda-2bdf121d42e1"), "Cedric", "Ogbuehi" },
                    { new Guid("f9a908c4-f644-4e62-847b-e95d14ed151e"), "Ethan", "Pocic" },
                    { new Guid("8d0c6f65-3c32-4b84-935a-1fb1bf053d05"), "Brandon", "Shell" },
                    { new Guid("be4a5db6-704e-4b68-81d5-b503b4647e68"), "Jordan", "Simmons" },
                    { new Guid("982c0803-0afb-492e-97fb-0cde898f2a59"), "Jonathan", "Bullard" },
                    { new Guid("6276b1fa-5d2b-44a5-89bd-e80d7757c8bf"), "Carlos", "Dunlap" },
                    { new Guid("954e0df3-0885-4891-9c24-0bd295945dce"), "L.", "J. Collier	" },
                    { new Guid("2088a684-2479-4b71-867d-1f47b86b7c43"), "Poona", "Ford" },
                    { new Guid("b4727e1e-5106-46ba-94b7-e3de099a4174"), "Benson", "Mayowa" },
                    { new Guid("5b1d0f1c-68d7-485e-950e-a055522e75d8"), "Bryan", "Mone" },
                    { new Guid("03078c01-b3ca-4f63-907c-d84145543cd9"), "Luke", "Willson" },
                    { new Guid("0a0b3211-b8d4-460c-86fd-9411a1a8e5d3"), "Colby", "Parkinson" },
                    { new Guid("ccb5eb74-6750-4292-a14a-074c4fb4cdbe"), "Greg", "Olsen" },
                    { new Guid("75465597-7b14-44dd-a7ae-2bad59f5dd51"), "Jacob", "Hollister" },
                    { new Guid("88023332-9e12-46e6-aee5-66567663d2c3"), "Dakoda", "Shepley" },
                    { new Guid("0ac14001-bfde-4427-981a-57f7dfa32a8e"), "Austin", "Walter" },
                    { new Guid("23a9d27c-90c6-400c-8546-f54c2f6ba830"), "Kevin", "White" },
                    { new Guid("3e94a331-5239-4fd4-9ad3-2076b7228095"), "Geno", "Smith" },
                    { new Guid("4459316e-e7a2-4801-8252-94fe347e0327"), "Russell", "Wilson" },
                    { new Guid("4316f1d6-d59d-4d03-bddb-3decd1404a46"), "Nick", "Bellore" },
                    { new Guid("7b80714b-26e9-4dda-b490-416122412b9b"), "Chris", "Carson" },
                    { new Guid("e5d65f54-db3c-40e2-8814-0a73cdb16d38"), "Jarran", "Reed" },
                    { new Guid("0bcaa0ed-7d35-488c-95ca-3bd08866b785"), "DeeJay", "Dallas" },
                    { new Guid("5eb42127-8b33-4f81-a6ff-3907e487d3c6"), "Carlos", "Hyde" },
                    { new Guid("5946396a-b015-46a1-b28d-b21abe65e96e"), "Penny", "Hart" },
                    { new Guid("23229d30-1d3f-44d7-a2e1-121bad4d20f4"), "Tyler", "Lockett" },
                    { new Guid("349a8f03-00d4-40c3-b64c-e48e065bf741"), "DK", "Metcalf" },
                    { new Guid("a9f90898-1fad-4d65-a130-e753a2e03d39"), "David", "Moore" },
                    { new Guid("c5a36fc5-2ed1-4d97-b0e9-efcd8445a673"), "Freddie", "Swain" },
                    { new Guid("01d57222-197d-4c3b-877f-a19b227ca538"), "Will", "Dissly" },
                    { new Guid("048cc06f-c8ea-403d-bc4d-e0f4b7cec843"), "Travis", "Homer" },
                    { new Guid("befa767d-b529-4070-9d76-cd474e582226"), "Alton", "Robinson" },
                    { new Guid("9528ec90-3bc0-4d11-bb68-68ef062515dd"), "Cody", "Barton" },
                    { new Guid("a2d11284-f2f8-4aee-af79-87c30eb60d1b"), "Jordyn", "Brooks" },
                    { new Guid("457ede52-14f0-465c-8322-424556365842"), "Josh", "Gordon" },
                    { new Guid("65287605-d6e7-4c06-92bf-2d5d7bfa4208"), "Rasheem", "Green" },
                    { new Guid("53f56f5d-f8cc-417e-a370-3a017063276c"), "Phil", "Haynes" },
                    { new Guid("3d06e2c7-04b8-4ae2-bf14-30eeb1eee251"), "Lano", "Hill" },
                    { new Guid("a2335a46-3101-44bd-90f9-19696f3fb75b"), "Bruce", "Irvin" },
                    { new Guid("fe62d2ee-f72a-46fc-acaa-671f8ca4a671"), "Branden", "Jackson" },
                    { new Guid("e8afc9ba-c6f0-4e04-a17a-faf7de2169c9"), "Damontre", "Moore" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("194aa592-a1f5-48a1-a722-427f2190939d"), "Phillip", "Dorsett" },
                    { new Guid("e7527524-3b66-4c42-bf3a-1a794623315d"), "Rashaad", "Penny" },
                    { new Guid("b5b83ba7-3dd6-4fe9-8d33-2923205a36f8"), "Neiko", "Thorpe" },
                    { new Guid("f25ad708-ef52-46ff-9631-49a1451c1904"), "Chance", "Warmack" },
                    { new Guid("a7366b19-d04f-4d00-a80e-3ca8a18f1611"), "DeMarkus", "Acy" },
                    { new Guid("b7fadc2d-47a5-4931-a85b-48dabb1490b2"), "Ray", "Armstrong" },
                    { new Guid("38f29e8b-153b-4720-8969-195f41229779"), "Tommy", "Champion" },
                    { new Guid("20c159be-e7ee-4111-8b4d-545896ec8445"), "Michael", "Divinity" },
                    { new Guid("6652740b-6ce3-494d-a398-21556b15f828"), "Damon", "Harrison" },
                    { new Guid("d7e7d1e8-ca95-48e8-9345-246e73e3a7bf"), "Darrell", "Taylor" },
                    { new Guid("60feb630-7c88-4c61-be49-c4ecab9d8c2d"), "Parnell", "Motley" },
                    { new Guid("74494ed3-1692-46ad-9e2c-e41c78fb486c"), "Patrick", "Carr" },
                    { new Guid("cad141a6-5c7e-41f7-8f87-50a4f2cd78d1"), "Tyler", "Ott" },
                    { new Guid("163108c4-bafd-4f05-a3fa-10eb9aa28c64"), "Ben", "Burr-Kirven" },
                    { new Guid("dc946c4a-26af-44a1-8451-dbfbe8c1ed4d"), "Shaquem", "Griffin" },
                    { new Guid("2a58d078-e6ed-4852-8705-0e3d5f66ae7c"), "Bobby", "Wagner" },
                    { new Guid("d729a8fb-6481-4427-b6fe-6480d14c901e"), "K.", "J. Wright	" },
                    { new Guid("13313b82-8933-46a0-9b9a-bac2a32972bd"), "Jamal", "Adams" },
                    { new Guid("f9f77b1f-699e-4e68-b5d9-0d4bff191e47"), "Ugo", "Amadi" },
                    { new Guid("a35af192-e459-40ac-b922-451aab1cf7e5"), "Quandre", "Diggs" },
                    { new Guid("edbf6ec2-b369-4703-b016-2a2bbecebc01"), "Marquise", "Blair" },
                    { new Guid("701d20b5-4916-4f06-a3b3-699abfd79109"), "Quinton", "Dunbar" },
                    { new Guid("e80b0a07-9008-48d8-aa3b-f557c775488e"), "Shaquill", "Griffin" },
                    { new Guid("ca8d14fa-5058-432b-a811-db31a5aa6565"), "Ryan", "Neal" },
                    { new Guid("bb409a86-6c80-454b-8264-a84b9e70b77d"), "Damarious", "Randall" },
                    { new Guid("38d5a165-8528-4782-8e02-27aa58387a85"), "D.", "J. Reed	" },
                    { new Guid("6a01291f-b646-42cb-84fe-e0deb1e909d0"), "Linden", "Stephens" },
                    { new Guid("8ade5680-bf55-457d-82fb-e0bddbf66248"), "Michael", "Dickson" },
                    { new Guid("a262e29e-5996-4d70-9578-40e5a7f069b8"), "Jason", "Myers" },
                    { new Guid("0221c801-665c-4122-80c5-cb25b9bc72c9"), "Tre", "Flowers" },
                    { new Guid("b4f4d3dd-d7e9-4232-b0b9-248dd92f93ce"), "Kobe", "Smith" },
                    { new Guid("d5fc2206-1258-4260-aef1-6c21bbe96bad"), "Jared", "Mayden" },
                    { new Guid("6d7fd446-598c-45ce-8989-7ff58ed714aa"), "Josh", "Hokit" },
                    { new Guid("c2ae484b-879e-4470-8952-0a2471ac226e"), "Kerry", "Hyder" },
                    { new Guid("76b6b305-8aee-4cf0-8b41-348df57da80f"), "Dion", "Jordan" },
                    { new Guid("d008a234-4e12-4abd-b739-0bf16a3a7fb1"), "D.", "J. Jones	" },
                    { new Guid("34199549-f5f7-4ad5-bac2-afbc75f3fd83"), "Javon", "Kinlaw" },
                    { new Guid("d7c86d66-94a6-4627-9c86-e878793ea2a7"), "Kentavius", "Street" },
                    { new Guid("6da57b89-3da0-4976-86e5-fcd74ad5f9e8"), "Jordan", "Willis" },
                    { new Guid("a30e30b0-b4b8-49cd-9aea-e93447e8c520"), "Azeez", "Al-Shaair" },
                    { new Guid("852fcdfc-9d25-4e89-a357-abd4809355f4"), "Demetrius", "Flannigan-Fowles" },
                    { new Guid("418c2b1c-628b-48b2-a949-d84ab65e8b55"), "Dre", "Greenlaw" },
                    { new Guid("47e05ef7-b203-4fde-b295-e91ceb5760ce"), "Joe", "Walker" },
                    { new Guid("b9b8cee8-1584-48ce-b8f6-4ebf4bf9bd32"), "Fred", "Warner" },
                    { new Guid("38be8de2-6097-4e1d-b4b2-cbcbf5a00108"), "Marcell", "Harris" },
                    { new Guid("23566621-63a9-44f0-a46a-83c3b139acb3"), "Dontae", "Johnson" },
                    { new Guid("74a2a9d8-427f-4e65-95fa-c031cfaaae65"), "Tarvarius", "Moore" },
                    { new Guid("02ed742d-8db9-4841-949a-aa93f6cbd577"), "Emmanuel", "Moseley" },
                    { new Guid("43a01e45-ef29-458a-952d-1d435aa6ce95"), "Kevin", "Givens" },
                    { new Guid("831533a5-8975-4a1b-981f-5e8b1b902799"), "Arik", "Armstead" },
                    { new Guid("8e6c042c-0824-4ab0-86a1-aac052aa8d57"), "Trent", "Williams" },
                    { new Guid("ff9760fe-82a3-4598-aee5-dba9fb5424e9"), "Laken", "Tomlinson" },
                    { new Guid("2903bea3-0c28-4b48-98ef-67d5e43b263f"), "JaMycal", "Hasty" },
                    { new Guid("1d170640-a6da-45a0-a635-84cb792e3023"), "Kyle", "Juszczyk" },
                    { new Guid("d3c1e946-1190-4101-ae9f-b7b74a8ec0de"), "Jerick", "McKinnon" },
                    { new Guid("bba23fec-8ecd-4f92-8da2-bf140ea2319b"), "Brandon", "Aiyuk" },
                    { new Guid("dc545396-be74-409e-b4b3-a7b93561495d"), "Richie", "James" },
                    { new Guid("9a53ea32-bfe1-4cfa-acc7-532687621c53"), "Deebo", "Samuel" },
                    { new Guid("ff88b0b1-0377-414c-93e5-29b76812f52a"), "Trent", "Taylor" },
                    { new Guid("e1426358-35c8-4a3f-a90b-17a00bfe6e2e"), "Jaquiski", "Tartt" },
                    { new Guid("d19f331a-4d58-4f0f-9948-06cf8b695658"), "Ross", "Dwelley" },
                    { new Guid("021ee729-f964-419f-9eba-8734fca37fff"), "Charlie", "Woerner" },
                    { new Guid("eebe2699-2e98-4f3b-819f-f2a6c453000a"), "Daniel", "Brunskill" },
                    { new Guid("6eecca5a-342f-494c-9b52-3bd6b511438a"), "Tom", "Compton" },
                    { new Guid("98d1d2e1-375e-487d-b9d0-eda0ed515b71"), "Hroniss", "Grasu" },
                    { new Guid("0d056e62-b9ff-4fd5-a500-efbbb5f0b2e5"), "Mike", "McGlinchey" },
                    { new Guid("18c79bf1-eae3-41bf-889d-0ac886a3d2b4"), "Colton", "McKivitz" },
                    { new Guid("d274f155-0ef9-4252-98a4-7db849570df3"), "Justin", "Skule" },
                    { new Guid("9d543e57-9a64-42b4-bb16-7fd00c9dc4b6"), "George", "Kittle" },
                    { new Guid("b71db00c-f4ee-4637-a23f-9dc613cff7b6"), "Jamar", "Taylor" },
                    { new Guid("70c419b4-b2d1-48fa-b9ec-f6b410fc3e32"), "Jason", "Verrett" },
                    { new Guid("9f9cd531-22ee-431e-b365-42e2d366eee0"), "Jimmie", "Ward" },
                    { new Guid("014531a4-339c-44fe-a9cb-9734c2b7abb5"), "Weston", "Richburg" },
                    { new Guid("beebc1ee-59e4-409b-9e52-dbcb264feefe"), "Richard", "Sherman" },
                    { new Guid("a7122385-469a-49a5-8500-3048b5f8267f"), "Solomon", "Thomas" },
                    { new Guid("21202022-4161-4dc2-96ef-a4ee04009628"), "Chris", "Thompson" },
                    { new Guid("40e875ab-3017-4205-90d0-8818cf5c3c3f"), "Jeff", "Wilson" },
                    { new Guid("55528b77-7549-471c-8ce6-c3c50b65aab4"), "Alex", "Barrett" },
                    { new Guid("fef8d287-04c8-4a39-a93b-39078e889192"), "Tony", "Bergstrom" },
                    { new Guid("0b7ac581-fa0e-476a-85f3-4510fa696981"), "Jordan", "Reed" },
                    { new Guid("84819748-a576-4c11-a035-78ff7b0224c4"), "River", "Cracraft" },
                    { new Guid("3c0cea85-9e12-44b4-9265-c04846b194a3"), "Darrion", "Daniels" },
                    { new Guid("44c4fb35-82dc-4a8a-a65b-749be1ab5d69"), "Chris", "Finke" },
                    { new Guid("7a5102ad-df09-493c-a572-0249d803fb0d"), "Jonas", "Griffith" },
                    { new Guid("e9cc0590-eaa8-4326-baf1-99105dcf1b77"), "Chase", "Harrell" },
                    { new Guid("ae584a76-e447-413d-9e0e-48fcb1d255af"), "Tim", "Harris" },
                    { new Guid("62ea142b-7a7b-4d47-9a3f-dc050372611d"), "Daniel", "Helm" },
                    { new Guid("3725b782-713f-4466-b0d5-731c2bac63de"), "Willie", "Henry" },
                    { new Guid("b83863b1-ad38-43af-a12c-ed3e4b5fbc5e"), "Johnathan", "Cyprien" },
                    { new Guid("f2e6276c-aa27-4cbc-a157-b6d686e8cfe8"), "Jauan", "Jennings" },
                    { new Guid("9020aea5-ee23-4ad7-a0eb-1561bbf95d7c"), "Mark", "Nzeocha" },
                    { new Guid("e96ea279-2a47-432d-8969-4594949d445b"), "Jalen", "Hurd" },
                    { new Guid("a34f8f00-b7e6-48d2-a428-d9310e6dd0ee"), "Ken", "Webster" },
                    { new Guid("67a26674-a8a1-411f-9a0d-cfa081e766c4"), "K'Waun", "Williams" },
                    { new Guid("340ba5b8-ddac-47c0-9f73-571565c62f31"), "Ahkello", "Witherspoon" },
                    { new Guid("c5983220-74a3-4602-9bb2-174808bb1f3c"), "Robbie", "Gould" },
                    { new Guid("75863eeb-95cf-4616-b34c-e981844523df"), "Taybor", "Pepper" },
                    { new Guid("7009907f-a6b5-4fa2-bbd3-7f53bb7983dd"), "Mitch", "Wishnowsky" },
                    { new Guid("a581f90a-773f-4c68-ba01-fe4d85ca004a"), "Kiko", "Alonso" },
                    { new Guid("e77358d1-281a-4cd9-b3e0-42d2aebd6100"), "Raheem", "Mostert" },
                    { new Guid("341f8441-e8e7-422f-9744-769ebab36893"), "Ezekiel", "Ansah" },
                    { new Guid("9284c1d8-f105-4149-9b43-5b067dacadc0"), "Ronald", "Blair" },
                    { new Guid("7afc1470-b18a-42c1-94f2-3b9ec799cea0"), "Nick", "Bosa" },
                    { new Guid("97447172-49c8-4985-b25d-a6e7fa12a168"), "Kendrick", "Bourne" },
                    { new Guid("35fbd942-bc94-4d79-b6b3-8c22008366a7"), "Jake", "Brendel" },
                    { new Guid("b72a33e2-e966-45c4-9c21-5fbd641fd23e"), "Shon", "Coleman" },
                    { new Guid("4de78e0d-0d93-44c3-b79d-bd1856a19965"), "Dee", "Ford" },
                    { new Guid("d636f0a4-fb73-489c-a754-e52c3a4e2259"), "Ben", "Garland" },
                    { new Guid("e813486b-06d0-46c7-bd4d-681a1165f58e"), "Travis", "Benjamin" },
                    { new Guid("7c7ca17d-79a4-4f48-97cc-024fd5b87f89"), "Josh", "Rosen" },
                    { new Guid("672ff9fa-0d14-46fb-aa13-589202349e2e"), "Benning", "Potoa'e" },
                    { new Guid("6926146d-4e0d-4820-b61e-5ccb0a9c0e98"), "Josh", "Pearson" },
                    { new Guid("de21f529-e2f6-4518-883b-0c90e295339c"), "Tyler", "Larsen" },
                    { new Guid("59253232-8d1c-4b9b-a244-f04e01ad8a29"), "Greg", "Little" },
                    { new Guid("5a2fcf24-1f6b-42ab-8e29-662cff689b45"), "John", "Miller" },
                    { new Guid("46db27cc-77ab-4a8f-b1a5-067a8da00caa"), "Taylor", "Moton" },
                    { new Guid("ff3c6c80-6d48-4eb0-b7d3-035d70387f92"), "Russell", "Okung" },
                    { new Guid("a4f6d755-ad2c-4aae-8887-7c5b04869a0d"), "Matt", "Paradis" },
                    { new Guid("78ae0898-4e6a-4797-b896-fee8ebe6680a"), "Chris", "Reed" },
                    { new Guid("757631f2-3767-4292-b919-13148022e002"), "Michael", "Schofield" },
                    { new Guid("caef84c9-b2b0-4461-9c14-fe85e571173e"), "Trent", "Scott" },
                    { new Guid("efdc135e-4088-4c20-809d-29e9868205df"), "Sam", "Tecklenburg" },
                    { new Guid("7d2fa3a4-1b05-46a6-8366-e3d852cba67f"), "Derrick", "Brown" },
                    { new Guid("5e288231-b428-4330-8469-0e028a3ec57a"), "Brian", "Burns" },
                    { new Guid("3ddebf60-c07a-4b3e-9c34-3e8333873d80"), "Woodrow", "Hamilton" },
                    { new Guid("2ef53f72-1554-4a9a-afec-12146cd420a3"), "Marquis", "Haynes" },
                    { new Guid("c87005fc-995a-41f3-80be-ac9ce41fe62b"), "Zach", "Kerr" },
                    { new Guid("915d6cc2-4be4-414f-9d40-80855cc098be"), "Dennis", "Daley" },
                    { new Guid("9ecc69f3-5e30-4db4-b676-cc0ef5f59733"), "Colin", "Thompson" },
                    { new Guid("68a7e35c-51d1-4d46-92d6-b4b3fa0aae9c"), "Ian", "Thomas" },
                    { new Guid("e65383c5-5137-4445-a477-9927c1c78e4e"), "Chris", "Manhertz" },
                    { new Guid("071c5df0-63e3-4157-aba3-fb97ab8573f0"), "Chris", "Rowland" },
                    { new Guid("9ee01b02-f38a-4487-a65e-cb9032168bb8"), "Chris", "Slayton" },
                    { new Guid("365c47bb-7f80-4c43-9885-87153532aa50"), "Pita", "Taumoepenu" },
                    { new Guid("8d0275a9-4c0d-48fe-9a9c-83a3cd401e51"), "Laquon", "Treadwell" },
                    { new Guid("cf94850f-9514-4a23-860b-b6fb718dbaea"), "Willie", "Wright" },
                    { new Guid("8df35a5c-59d6-43a4-a362-e0e823874514"), "Teddy", "Bridgewater" },
                    { new Guid("2c10d5d1-65f7-4102-99cc-19c414312e40"), "Will", "Grier" },
                    { new Guid("091c4c5c-b470-43d8-b48c-d154d8db599f"), "Austin", "Larkin" },
                    { new Guid("a4a070be-90c5-42f5-bbba-b90fbe77e2b5"), "P.", "J. Walker	" },
                    { new Guid("f4e31a9c-b272-4e6b-907e-254de5f4c3bb"), "Trenton", "Cannon" },
                    { new Guid("68e42520-81ee-40ea-a1d1-41265a864535"), "Mike", "Davis" },
                    { new Guid("183450fe-fdcc-4a08-b5d5-bd72b6e63687"), "Robby", "Anderson" },
                    { new Guid("0b214506-0d10-447d-85e2-e7f10b987f7b"), "Pharoh", "Cooper" },
                    { new Guid("fee186de-225a-4ec0-bbea-5a08eba2ba44"), "D.", "J. Moore	" },
                    { new Guid("ab019500-fde7-453d-8970-2702ef5dea21"), "Curtis", "Samuel" },
                    { new Guid("35df4a9b-4a18-417f-a4f4-26ba9b7bba9d"), "Brandon", "Zylstra" },
                    { new Guid("a94d1bd8-8655-4f92-99fb-5c3f04ea7398"), "Alexander", "Armah" },
                    { new Guid("da1d05ea-d42a-4035-b3ca-f8ccd30c8add"), "Efe", "Obada" },
                    { new Guid("5815054e-93fa-4c76-b09b-dbaa9ec75563"), "Bravvion", "Roy" },
                    { new Guid("279a1461-f0a0-4e03-98e1-5e9409d3081b"), "Stephen", "Weatherly" },
                    { new Guid("c725e20f-3073-495f-a0a4-af920ce5e8b7"), "Juston", "Burris" },
                    { new Guid("2ad59724-3b86-4490-af04-c70df0175ff3"), "Yetur", "Gross-Matos" },
                    { new Guid("53cb164b-0308-4c93-a6b4-839663e82cf2"), "Keith", "Kirkwood" },
                    { new Guid("b3c2d6cf-af08-491c-8661-a9ef607f2a6d"), "Jordan", "Mack" },
                    { new Guid("2cb04d33-2eb9-4a06-a123-a2d3276253f1"), "Christian", "McCaffrey" },
                    { new Guid("c30b4e52-e4e7-483b-bea3-688c0cedfa7a"), "Christian", "Miller" },
                    { new Guid("c9c39661-857c-441c-9465-da6cea5982c1"), "Michael", "Palardy" },
                    { new Guid("fda8ed95-7cca-4a6d-a5c4-6c9583f7149b"), "Omar", "Bayless" },
                    { new Guid("fd708043-3ab3-4663-9b54-1cdbd43b6d28"), "Kawann", "Short" },
                    { new Guid("79ecbd02-21c8-4af2-800f-63be33c6b8d3"), "Seth", "DeValve" },
                    { new Guid("73cd3829-fd27-4da5-a7bf-a55fd5e707f5"), "Shelton", "Gibson" },
                    { new Guid("67385d4f-2122-47c8-9239-1e79088a580d"), "Pete", "Guerriero" },
                    { new Guid("83e2f315-e7f8-466f-b237-575a98afcebc"), "Bruce", "Hector" },
                    { new Guid("fc491c74-b75d-4ef6-89ea-cc9b6ffc845f"), "Mike", "Horton" },
                    { new Guid("1684af44-bcdf-4183-a3c0-0daf5d4ed14c"), "Ishmael", "Hyman" },
                    { new Guid("bec466ae-884e-4db4-bbeb-a533d3719ef3"), "Natrell", "Jamerson" },
                    { new Guid("78c9a979-3b07-4d5a-92c2-5a71dc8221e7"), "Reggie", "Bonnafon" },
                    { new Guid("f3c663a8-6485-4bf5-827c-648b0c5ce8cd"), "Edmond", "Robinson" },
                    { new Guid("139655a8-f99b-4d9f-ae74-0953144f3f85"), "Joey", "SlyeK" },
                    { new Guid("edf10465-25a5-41fc-a0ce-8b17ed856d6b"), "Joseph", "Charlton" },
                    { new Guid("f2746920-ca05-4299-9a65-1611d81efa34"), "Jermaine", "Carter" },
                    { new Guid("d3611eaf-d03d-499b-a848-768358e08658"), "Jeremy", "Chinn" },
                    { new Guid("1f255eb3-4869-44b4-8808-aff14df14141"), "Julian", "Stanford" },
                    { new Guid("a013f4c3-4301-4e0e-86c2-bafd226a7d0f"), "Adarius", "Taylor" },
                    { new Guid("abc552c2-7705-452b-a14b-0640629f64a1"), "Shaq", "Thompson" },
                    { new Guid("e370e5e8-82af-43d9-9244-8a7e59b24cc0"), "Tahir", "Whitehead" },
                    { new Guid("6db768e0-881e-404a-b733-5e5316dd6afa"), "Tre", "Boston" },
                    { new Guid("b776446a-b6e3-4495-8d06-5ee50e3428a5"), "J.", "J. Jansen	" },
                    { new Guid("d1f48729-e98b-45da-b337-c48beea7ecbb"), "Sean", "Chandler" },
                    { new Guid("1ff2446e-b74b-44a5-af5b-52332062f89e"), "Corn", "Elder" },
                    { new Guid("1473d3bd-d6ac-4cbd-8379-b7e9c9fba1cf"), "Sam", "Franklin" },
                    { new Guid("cef8851d-9924-4018-a917-a486f89cac63"), "Myles", "Hartsfield" },
                    { new Guid("54a278df-b713-4525-a7d0-562a2e182ba3"), "Donte", "Jackson" },
                    { new Guid("25690285-b0be-469f-a0eb-49129dd17e6e"), "Troy", "Pride" },
                    { new Guid("aed12965-013e-4137-9ee9-f83be09cd64a"), "Kenny", "Robinson" },
                    { new Guid("1d314c48-3dc7-47a6-8198-52d8e787a7b8"), "Stantley", "Thomas-Oliver" },
                    { new Guid("54c79cc5-e1a7-464c-9017-a9f924c223d4"), "Rasul", "Douglas" },
                    { new Guid("67e561fb-205f-424a-bbe8-28e412cdaf7c"), "Clay", "Johnston" },
                    { new Guid("75e05081-f781-4361-b008-d55ff005b6f9"), "Jared", "Pinkney" },
                    { new Guid("b08407d5-3685-4b29-bffa-687bbd0c035e"), "T.", "J. Green	" },
                    { new Guid("b5ffafa8-de11-45e6-9201-70f11711506d"), "Christian", "Blake" },
                    { new Guid("291cad90-b4be-47d7-b9fa-5d2e062c2e7e"), "Russell", "Gage" },
                    { new Guid("b9bacbce-a473-429c-9868-90bf092b21fd"), "Julio", "Jones" },
                    { new Guid("205100a7-8e70-4bd1-b7d8-8e3d590a3084"), "Brandon", "Powell" },
                    { new Guid("a04056b6-c19d-46cb-bb91-d7eadecfdff8"), "Calvin", "Ridley" },
                    { new Guid("ea784721-2bed-4cd4-8f9c-8a8f0e163bd1"), "Olamide", "Zaccheaus" },
                    { new Guid("5b7ecf19-fab2-4720-9105-3d6a1794cafb"), "Jaeden", "Graham" },
                    { new Guid("7afcf943-e66e-4e92-9d51-14d4bb6571d7"), "Hayden", "Hurst" },
                    { new Guid("6f07b30d-542f-44bf-8625-c526d9a3d98a"), "Luke", "Stocker" },
                    { new Guid("4cdcef02-25af-4503-9b32-b9b67e1c3de7"), "James", "Carpenter" },
                    { new Guid("ed06006d-5b56-4423-ad79-47fedbf02f56"), "Matt", "Gono" },
                    { new Guid("57a55a53-8242-427a-a591-a7ccbb540f08"), "Matt", "Hennessy" },
                    { new Guid("a6c68cd8-3932-4d0c-8d25-6d17e06a4f0b"), "Chris", "Lindstrom" },
                    { new Guid("93e803c1-f7c2-4c5f-8180-f0b081e663c4"), "Alex", "Mack" },
                    { new Guid("532e5e00-8723-4250-b165-7e6ff724843c"), "Jake", "Matthews" },
                    { new Guid("6764e1b1-b218-4b3b-888d-0199d6a67313"), "Keith", "Smith" },
                    { new Guid("09f36ef3-7f42-44e0-b319-290ec7930195"), "Ito", "Smith" },
                    { new Guid("0fa9df8f-31fe-4249-bbc0-85273d031434"), "Qadree", "Ollison" },
                    { new Guid("4eec9951-de44-41b1-b3a4-74a4b487ae34"), "Brian", "Hill" },
                    { new Guid("7d51d2d3-3028-4870-b7c6-4b4147210a7c"), "Aviante", "Collins" },
                    { new Guid("aad7ec51-d15a-4e2e-81c3-e473135c594b"), "Brandon", "Dillon" },
                    { new Guid("49d7c032-697e-4f4e-ac73-56e410feb796"), "Kyle", "Hinton" },
                    { new Guid("5c89a107-173c-4e21-b14e-95c213929409"), "Alexander", "Hollins" },
                    { new Guid("b2c7bd09-ac5d-4bf0-a2e0-471727490e39"), "Brett", "Jones" },
                    { new Guid("e045cfe8-12c5-40f8-86d8-500d272e0c2b"), "Luther", "Kirk" },
                    { new Guid("456b9dde-8981-47c6-9708-a423d6a0f28f"), "Blake", "Lynch" },
                    { new Guid("9cf53a13-3f2d-4f3a-9d34-6d86cd012fef"), "Justin", "McCray" },
                    { new Guid("9141c41f-1d90-4474-a1df-428bf635c765"), "Hercules", "Mata'afa" },
                    { new Guid("6a66920d-2664-473a-820c-e00dcbe1671d"), "Cale", "Garrett" },
                    { new Guid("12b5c1dc-1d02-43d2-b44e-57c12e90a555"), "Marcus", "Sayles" },
                    { new Guid("ed4ba96d-1485-4894-9a12-2b879b3ea497"), "Eddie", "Yarbrough" },
                    { new Guid("1947c650-5f1d-4b56-82a3-cc370f4d6362"), "", "" },
                    { new Guid("b3a795bd-a77b-4546-a545-ed5d78a06f31"), "Matt", "Ryan" },
                    { new Guid("30e89070-217f-4e97-8769-518338c74409"), "Matt", "Schaub" },
                    { new Guid("088fbc3d-c960-47f8-85f7-f9675665d97f"), "Todd", "Gurley" },
                    { new Guid("35850d3e-9c4e-4ce0-a427-c69d4cc2841f"), "Chase", "McLaughlin" },
                    { new Guid("84aff5cf-802f-43c0-8677-9f0a2dd5a663"), "Kaleb", "McGary" },
                    { new Guid("f2b9bbcb-fe5c-4f23-8ac3-a200be17200a"), "John", "Wetzel" },
                    { new Guid("4012ba9c-1a9f-4529-b0ef-6cf48c8afd75"), "Allen", "Bailey" },
                    { new Guid("3d07cafb-fe98-46a6-9a56-5f8e7f17c403"), "Isaiah", "Oliver" },
                    { new Guid("3084e1be-c421-4bff-9040-a717d6689e8e"), "Kendall", "Sheffield" },
                    { new Guid("4ffb0fe9-0cac-4e14-abff-a64b46d055e7"), "A.", "J. Terrell	" },
                    { new Guid("6142d97d-ba2c-4d5f-aea8-eb83a06af7dd"), "Blidi", "Wreh-Wilson" },
                    { new Guid("91cc0fc1-efad-49c9-9174-5409de524500"), "Josh", "Harris" },
                    { new Guid("4ec8ef2c-38b8-441b-9ca4-4ca36223ec06"), "Sterling", "Hofrichter" },
                    { new Guid("c9c575a2-03ab-4902-8707-5f163894ad99"), "Younghoe", "Koo" },
                    { new Guid("b5c5721b-9eec-43d8-a4a0-6334ffacb22b"), "Sharrod", "Neasman" },
                    { new Guid("c2cb8b37-ba9f-481b-a54a-2ec8d5bdb795"), "Darqueze", "Dennard" },
                    { new Guid("8a68f5f8-2fe6-4b89-8c10-4466460bf1ec"), "Delrick", "Abrams" },
                    { new Guid("504e66da-3fea-4ee5-8a10-a4bc03a2f669"), "Willie", "Beavers" },
                    { new Guid("57bb1bda-8933-4df5-8fd9-e9ed2292ff8b"), "Kurt", "Benkert" },
                    { new Guid("0a7d6269-09ba-400b-9150-5667768c5f67"), "Shyheim", "Carter" },
                    { new Guid("e0ec6095-8cda-456f-821d-cdccecc121d6"), "Austin", "Edwards" },
                    { new Guid("9748a2fe-5076-4307-8307-8738715b44ef"), "Elliott", "Fry" },
                    { new Guid("d3f0d7e2-a6a1-4a1a-9655-69bba547f1ad"), "Juwan", "Green" },
                    { new Guid("02f5a3fd-e414-4afb-8d96-f49eee9e4b99"), "Damontae", "Kazee" },
                    { new Guid("7377309c-d57a-4f6c-9fcc-a4ec735ccd68"), "Sean", "Harlow" },
                    { new Guid("903d5e40-9da4-4dbd-af24-4ec8d60d4357"), "Keanu", "Neal" },
                    { new Guid("8f67349b-397a-4bea-a9bc-f2953005554c"), "Jaylinn", "Hawkins" },
                    { new Guid("118b5360-de66-4d96-9240-89b099d30c4e"), "John", "Cominsky" },
                    { new Guid("3b1e242c-2802-49c2-b544-b92df71a794a"), "Marlon", "Davidson" },
                    { new Guid("5d817545-b591-41bb-8cf3-a8bfb82d3379"), "Tyeler", "Davison" },
                    { new Guid("5e48dd77-6934-4c7d-82f2-d1bfd9aa61fc"), "Dante", "Fowler" },
                    { new Guid("69ac64ec-0687-48b6-b6e4-a9ef7148cbc4"), "Charles", "Harris" },
                    { new Guid("e6341d18-b283-43bf-b6ed-4b5019f799d4"), "Grady", "Jarrett" },
                    { new Guid("bd224469-4680-42a3-9470-ccea58351f32"), "Takkarist", "McKinley" },
                    { new Guid("38f1008b-9ad4-46eb-9629-1cd736118ed4"), "Jordan", "Miller" },
                    { new Guid("62885050-5dd6-4200-9022-b42cd21c3616"), "Steven", "Means" },
                    { new Guid("41aaddd6-1281-430f-bdf2-bfb4fe2921e7"), "Jacob", "Tuioti-Mariner" },
                    { new Guid("8cbe21cf-241e-4532-a2bc-7edcb7e2b772"), "Deion", "Jones" },
                    { new Guid("89942bcd-be3b-4b89-a29f-213e3b04a476"), "Foyesade", "Oluokun" },
                    { new Guid("d8117718-c2de-42b9-b549-3b503000ea11"), "LaRoy", "Reynolds" },
                    { new Guid("962ed15f-6260-44c4-b261-26790aff7b57"), "Mykal", "Walker" },
                    { new Guid("81c45282-81e7-43bd-9b3b-879b3ef3a297"), "Ricardo", "Allen" },
                    { new Guid("646ca557-1b0d-4e42-97c4-5a8a7cc63873"), "Tyler", "Hall" },
                    { new Guid("030de647-8c70-47e2-afbe-5e0163e2175a"), "Deadrin", "Senat" },
                    { new Guid("86a1e0b6-7df5-4c5b-aaef-6e1cc0c05231"), "Blake", "Brande" },
                    { new Guid("bdded447-4eca-4ac8-862c-6bdcfe3f43e2"), "Matt", "Kaskey" },
                    { new Guid("c62b6a20-bce3-44a1-bb52-6a9b95f82f1a"), "Aaron", "Monteiro" },
                    { new Guid("bc3e87e3-937e-47fe-b5c2-07705cbf289a"), "Rob", "Gronkowski" },
                    { new Guid("6fc9e1ab-526e-4233-afc8-5677a9806d1e"), "Tanner", "Hudson" },
                    { new Guid("1580fd06-b5e4-4def-afe9-b2f8bf22a760"), "Alex", "Cappa" },
                    { new Guid("65b9cc29-9b35-402e-a6cd-f730ae78bca9"), "Joe", "Haeg" },
                    { new Guid("49f5fe33-42fd-4fa9-914b-a74de92c4712"), "Ryan", "Jensen" },
                    { new Guid("b31cfe76-7f12-49fb-9653-c9910b1738cd"), "Ali", "Marpet" },
                    { new Guid("783b9fab-6dc2-4c0c-9881-c682a764df9d"), "A.", "Q. Shipley	" },
                    { new Guid("18dac2c5-fc20-4839-b3c8-a1b904fb6178"), "Donovan", "Smith" },
                    { new Guid("847aabf2-fc8a-4e8a-9541-d183d55df569"), "Aaron", "Stinnie" },
                    { new Guid("62500c5c-a5f0-4944-8bbf-3736795e816e"), "Josh", "Wells" },
                    { new Guid("f306ddf7-eed0-4856-8067-50d02a80ee55"), "Tristan", "Wirfs" },
                    { new Guid("4c432547-288c-49d9-8543-235e638c34c9"), "Khalil", "Davis" },
                    { new Guid("a065ee9a-e9a1-429f-95ce-2aa39ecf5325"), "William", "Gholston" },
                    { new Guid("47e8ff0d-8b58-4df9-a22e-88b00cd81ad4"), "Steve", "McLendon" },
                    { new Guid("c9bf1063-8746-4d40-85c6-00d6464e980b"), "Rakeem", "Nuñez-Roches" },
                    { new Guid("e6cd51e5-1fa0-4322-9d9d-6f5216ac5f45"), "Cameron", "Brate" },
                    { new Guid("154deb9d-1fed-4ec6-8d4a-432346101369"), "Antony", "Auclair" },
                    { new Guid("d38860df-3a24-47f2-bbbc-ef155cdcd411"), "Justin", "Watson" },
                    { new Guid("a342696e-0792-462b-b1c0-374d2aadb592"), "Scotty", "Miller" },
                    { new Guid("ea30475c-5979-45fb-b52b-7c9a0f9a8d1f"), "Cameron", "Tom" },
                    { new Guid("1ce7969f-6551-4f67-8a2a-76630e159001"), "Keith", "Washington Jr.	" },
                    { new Guid("eb84d9aa-68e2-46f7-8bc6-1cc149c4abd9"), "Marcus", "Willoughby" },
                    { new Guid("fbf42092-da40-4db9-817d-de4dce8ae22f"), "Anthony", "Zettel" },
                    { new Guid("9f2fdb64-3cf6-404f-9c40-1e2894bec6b4"), "Tom", "Brady" },
                    { new Guid("b1c33313-8e8c-4d47-80fc-fec4cc2dc361"), "Blaine", "Gabbert" },
                    { new Guid("bc85996e-ca39-418f-8bb3-4ce38f35447f"), "Ryan", "Griffin" },
                    { new Guid("82ed7514-6fe5-4b92-89c1-76c026f85cde"), "Pat", "O'Connor" },
                    { new Guid("b25c4b9e-023a-48e4-a6eb-50966aca3882"), "Leonard", "Fournette" },
                    { new Guid("05edfcb1-7343-4c98-bb07-192e2f3d237a"), "LeSean", "McCoy" },
                    { new Guid("ff71cfd4-5155-419a-a577-78f863507941"), "Ke'Shawn", "Vaughn" },
                    { new Guid("b4838edb-a293-4a76-9ee3-e9b01706e19f"), "Antonio", "Brown" },
                    { new Guid("bd1b1fbc-fee5-4317-b922-0b720a0f7304"), "Mike", "Evans" },
                    { new Guid("900326d8-3770-41c8-b15a-33b58da51fce"), "Chris", "Godwin" },
                    { new Guid("25ab0ea3-a962-4c89-8af5-9d008c4e910e"), "Tyler", "Johnson" },
                    { new Guid("201b6849-e2a7-4f7b-8d25-3ed280a33832"), "Jaydon", "Mickens" },
                    { new Guid("d3069edf-8662-421d-accb-4bfb23a12b19"), "Ronald", "Jones" },
                    { new Guid("d0c50ff5-1ca2-44be-9ff5-2938017059b6"), "Ndamukong", "Suh" },
                    { new Guid("232e37e8-14dc-448a-bdf5-3551b7590af7"), "Shaquil", "Barrett" },
                    { new Guid("a01a2c6a-c3ea-4deb-aedb-0e85bc67fd9b"), "Lavonte", "DavidI" },
                    { new Guid("ca7ce328-5bf7-4311-a442-cbd79d678bd5"), "John", "Franklin III	" },
                    { new Guid("4eff7bd5-4a3d-4537-bace-5c59a5234306"), "O.", "J. Howard	" },
                    { new Guid("24228f46-3a6b-46ac-a1e9-114dc633f0c5"), "T.", "J. Logan	" },
                    { new Guid("1838da45-7cd9-4387-9189-6c4459455bb8"), "Brad", "Seaton" },
                    { new Guid("e667db9a-5cb1-4fe1-9669-ddc7777e3775"), "Vita", "Vea" },
                    { new Guid("4ab4297f-f13e-4d79-8e2c-53dae8671189"), "Zack", "Bailey" },
                    { new Guid("410ad653-99ec-47fe-b1ed-35ca3047f0ed"), "Kenjon", "Barner" },
                    { new Guid("70c596a3-ad80-461c-9839-8ef41ef8c6ac"), "Justin", "Evans" },
                    { new Guid("417015f6-bc6f-42be-90cc-1240c012dfdb"), "Quinton", "Bell" },
                    { new Guid("871c7f14-2afe-4792-8333-dcb69c9fb38a"), "John", "Hurst" },
                    { new Guid("b6ab87ca-de8a-4ce7-8473-a8dc24b42e8b"), "Travis", "Jonsen" },
                    { new Guid("40839275-4bb7-4748-aa86-81c9c76adb00"), "Greg", "Joseph" },
                    { new Guid("4857a090-78a5-46d9-ad13-468026fef6d8"), "Jeremiah", "Ledbetter" },
                    { new Guid("ae10d0f9-22e0-402d-80bf-06a0b18be14f"), "Nick", "Leverett" },
                    { new Guid("73d479e7-b249-4c28-b344-99b968036815"), "Codey", "McElroy" },
                    { new Guid("7608d294-310f-45ce-8ff3-f4c82f931142"), "Herb", "Miller" },
                    { new Guid("17e0351e-4bfe-462e-9681-f5cfdc986087"), "Javon", "Hagan" },
                    { new Guid("c73aca3a-401a-4998-b946-0a5c3b8322bc"), "Calvin", "Throckmorton" },
                    { new Guid("1b4d59a1-3a5f-4aba-a47d-41cc70deb71e"), "Jack", "CichyI" },
                    { new Guid("a2bef0e3-b7c8-48c0-ace8-30b82faa467e"), "Ryan", "SuccopK" },
                    { new Guid("bffa9500-55d3-4d6a-af0e-bbc6d23f3902"), "Cam", "Gill" },
                    { new Guid("ad10e0f6-5687-4b9a-ad2b-eb38c86902f4"), "Kevin", "MinterI" },
                    { new Guid("a958ce7a-d801-4138-8f06-ab920b023e98"), "Anthony", "Nelson" },
                    { new Guid("bc9a5292-d970-47e7-9058-6a8d8efe516b"), "Jason", "Pierre-Paul" },
                    { new Guid("03cccb6e-fe6c-4ab7-9b8f-66e0410379cf"), "Chapelle", "RussellI" },
                    { new Guid("6c7ff418-5da6-4a68-af3e-3aeef6573f4f"), "Devin", "WhiteI" },
                    { new Guid("d7036124-c3d6-431e-a9a6-32a5530e7806"), "Andrew", "Adams" },
                    { new Guid("623065bc-a803-4c18-84fe-d6883618878a"), "Zach", "Triner" },
                    { new Guid("973da691-59ec-4f48-a493-9217c5326e5e"), "Ross", "Cockrell" },
                    { new Guid("b371b5e0-6fc0-459e-bd5a-d3d350a1e6b7"), "Jamel", "Dean" },
                    { new Guid("8e4d589c-5c1f-45f0-8eb2-f5150ac25167"), "Mike", "Edwards" },
                    { new Guid("9bf312b2-7864-4b2d-9578-7609629adc58"), "Sean", "Murphy-Bunting" },
                    { new Guid("e59e0340-98cc-4846-8d6b-c1400821db27"), "Ryan", "Smith" },
                    { new Guid("1ef14c07-d177-4b3d-a679-e60eef8ef35e"), "Jordan", "Whitehead" },
                    { new Guid("548ec1ee-937b-484a-87bf-54005a648dcd"), "Antoine", "Winfield Jr.	" },
                    { new Guid("ddfa2bdd-637c-48c1-a92e-c7bc1af4c38b"), "Bradley", "PinionP" },
                    { new Guid("b66e3880-7000-4e8d-9321-3d5ea67d8031"), "Carlton", "Davis" },
                    { new Guid("1c2ddbf7-6c26-4185-8a4b-66146543a47b"), "Marken", "Michel" },
                    { new Guid("b7bb33b5-ffc4-404b-9e4e-8086b428318c"), "Tommy", "Stevens" },
                    { new Guid("17e09997-0c33-4260-8a01-a7f1cad1bcdc"), "Juwan", "Johnson" },
                    { new Guid("db66cb7c-a42b-4a49-85f6-644c6bf706e2"), "Nick", "Easton" },
                    { new Guid("aee5e706-3aaf-42df-b6d5-a59fb73a9ff5"), "Ethan", "Greenidge" },
                    { new Guid("a99464b4-a16a-41a8-ace4-ff13f30268b3"), "James", "Hurst" },
                    { new Guid("ef070716-9855-4d57-82b4-857ab43c9c65"), "Derrick", "Kelly" },
                    { new Guid("7f06e2b2-7060-4e88-ae0e-d28782788de9"), "Erik", "McCoy" },
                    { new Guid("49e534b6-9d3f-4fe7-b573-bf4f220dae8f"), "Andrus", "Peat" },
                    { new Guid("c8086921-8341-4c16-8080-33895ebe7387"), "Ryan", "Ramczyk" },
                    { new Guid("07d4a7e4-3f94-4e64-9c97-53d989ab64a3"), "Cesar", "Ruiz" },
                    { new Guid("a4718610-a062-4b97-ada0-40a612608bb9"), "Malcom", "Brown" },
                    { new Guid("fdfd0906-af5e-40e8-b979-4697b704e752"), "Marcus", "Davenport" },
                    { new Guid("59070b5a-046f-4e87-b43f-78bc852992cc"), "Carl", "Granderson" },
                    { new Guid("3d25bfc4-a8a0-4cdb-8bea-01ccedac0b54"), "Trey", "Hendrickson" },
                    { new Guid("1174c4d8-bd67-4fc2-9b5a-602a512fc036"), "Cameron", "Jordan" },
                    { new Guid("ad1f0263-7db9-41ef-8005-a9bf6e376755"), "David", "Onyemata" },
                    { new Guid("04fcab81-2d23-4787-a7ca-5d4018db8844"), "Sheldon", "Rankins" },
                    { new Guid("38431957-5cfd-4f08-b2c3-87d93afc72ce"), "Terron", "Armstead" },
                    { new Guid("aebd6c0a-ec2d-4210-b5e3-d7c29d3dbaee"), "Adam", "Trautman" },
                    { new Guid("c9781e37-9db1-4199-a4de-db5e0f916b20"), "Josh", "Hill" },
                    { new Guid("63c5a1ec-0e7e-4205-a5cc-cda79cd937a1"), "Jared", "Cook" },
                    { new Guid("9ede86e8-29d1-4524-8db6-2edd0ec39945"), "Chris", "Orr" },
                    { new Guid("75725042-3045-4a87-a9cd-041c36df8a39"), "Mike", "Panasiuk" },
                    { new Guid("1f327733-7673-4eaa-ac81-b1580c69d270"), "Giovanni", "Ricci" },
                    { new Guid("a042694c-7c24-49b5-bff6-c402604dca0c"), "Greg", "Roberts" },
                    { new Guid("62749c57-c458-4533-85db-3361fa22eec8"), "Rodney", "Smith" },
                    { new Guid("e39f4c31-ab42-47f3-99a0-93472abfb468"), "Drew", "Brees" },
                    { new Guid("86ccb6a5-4e6d-430d-85f8-5ee82b0c3181"), "Taysom", "Hill" },
                    { new Guid("28c167ae-1b92-48ce-b7c6-cd77617169f8"), "Malcolm", "Roach" },
                    { new Guid("95374729-15ea-4b73-a79e-9d4e9c918478"), "Jameis", "Winston" },
                    { new Guid("f433d33a-ae72-4983-ab5f-6be8dd18ed95"), "Alvin", "Kamara" },
                    { new Guid("7a37d7ed-e35f-459e-849e-bde73a746f8f"), "Latavius", "Murray" },
                    { new Guid("ea39ea4d-8f33-45e1-a6b5-8bf36537068d"), "Dwayne", "Washington" },
                    { new Guid("aea8c3a3-79e6-4793-ba53-3ed4da8a172b"), "Marquez", "Callaway" },
                    { new Guid("68e076d9-2fc4-42e3-8eb1-30293819da10"), "Deonte", "Harris" },
                    { new Guid("936488ed-4098-43b4-9272-c68dff0eece3"), "Tre'Quan", "Smith" },
                    { new Guid("ee9af6bb-6452-45ac-a04d-f499aaaa2acd"), "Michael", "Thomas" },
                    { new Guid("994f927d-864e-45a6-972e-ceaa65e69e73"), "Michael", "Burton" },
                    { new Guid("947033f3-693d-4462-ae92-0d738b6938f4"), "Shy", "Tuttle" },
                    { new Guid("7095a3e3-f532-4089-8f1f-4846dcf3272b"), "Kwon", "Alexander" },
                    { new Guid("32d73fe5-4428-420d-a65d-e25c1bb2a2fb"), "Alex", "Anzalone" },
                    { new Guid("a1f3c2d1-c558-423d-b499-10403ba68b54"), "Bennie", "Fowler" },
                    { new Guid("f79de131-e023-4c48-acc5-c09958b5be10"), "Blake", "Gillikin" },
                    { new Guid("5c969134-cd78-4b2d-a1c7-d472c6031216"), "Chase", "Hansen" },
                    { new Guid("fe7f0639-d8cd-48fd-85a5-ad669b6680ff"), "Ty", "Montgomery" },
                    { new Guid("d4491291-ca89-4ee1-8a6e-bebe9e6c07a2"), "Emmanuel", "Sanders" },
                    { new Guid("c7e1f089-71ce-48e4-8fe8-12bc85a3a5bd"), "Noah", "Spence" },
                    { new Guid("6c4e79ce-aff8-42fc-8bf7-2474c06ee494"), "Jason", "Vander Laan	" },
                    { new Guid("802d4e40-d4e3-44ae-a17b-dc01639bb980"), "Jalen", "Dalton" },
                    { new Guid("e80d7eb8-a848-4612-aff4-63d974cefffe"), "Cole", "Wick" },
                    { new Guid("00632da0-700c-4550-86b3-bb19f381ce0b"), "Austin", "Carr" },
                    { new Guid("1ad37c6d-e772-4a76-8b68-04e603929e8c"), "Will", "Clapp" },
                    { new Guid("230ae2cd-7c1e-4463-8b21-7b1a72a3ffff"), "Will", "Clarke" },
                    { new Guid("d32d5328-de6a-4c6f-88b6-23022c36b54a"), "Andrew", "Dowell" },
                    { new Guid("88718a70-7591-4ea5-b5fe-db15b64d84d0"), "Garrett", "Griffin" },
                    { new Guid("3f621045-3563-421d-a564-75dd7f4073f4"), "Grant", "Haley" },
                    { new Guid("6a4c352e-79a1-4362-a48e-285a9fda1813"), "Lil'Jordan", "Humphrey" },
                    { new Guid("dd9ab82c-d3e5-4ec3-bc2d-5315d68802c6"), "Joe", "Bachie" },
                    { new Guid("f0d11d11-e8b2-4171-b557-1ad79b1a6c37"), "Tony", "Jones Jr.	" },
                    { new Guid("3b24b055-436e-4967-96e0-d8b21d5848f2"), "Johnson", "Bademosi" },
                    { new Guid("8ed66a2c-db9f-4ec3-b7d6-bbf9e3759722"), "Thomas", "Morstead" },
                    { new Guid("f5386ff8-9b2e-49bc-aec8-a7f6deb7f32b"), "Zack", "Baun" },
                    { new Guid("5394a08a-95f2-4699-b129-06e28b5ff5a3"), "Demario", "Davis" },
                    { new Guid("1b7a000d-f1e0-4425-8f76-991ca8965917"), "Kaden", "Elliss" },
                    { new Guid("da71a87d-6d56-41a7-8a68-9bcc615d52f2"), "Craig", "Robertson" },
                    { new Guid("cdd50b54-f2d9-49a8-8be0-4d164db02a9b"), "Ken", "Crawley" },
                    { new Guid("0dc6f738-8b89-40b1-96b3-4851c914b2f2"), "C.", "J. Gardner-Johnson	" },
                    { new Guid("d0000118-f4d4-47cb-830e-8ce65365def4"), "J.", "T. Gray	" },
                    { new Guid("9ac4fbe5-876e-4958-97d7-5dab94b48052"), "Zach", "Wood" },
                    { new Guid("4080862b-1bcd-4697-8643-beade892b107"), "Justin", "Hardee" },
                    { new Guid("3c7401f5-ff16-4b2d-8ac1-90c2e1d5af91"), "Malcolm", "Jenkins" },
                    { new Guid("a9812387-a24b-4199-98db-bc83e539f028"), "Marshon", "Lattimore" },
                    { new Guid("2406157e-9577-4103-88da-51ad7bedf968"), "Patrick", "Robinson" },
                    { new Guid("d9b7783a-103d-45a6-9932-b3a48cde9c26"), "D.", "J. Swearinger	" },
                    { new Guid("1dfd40f1-6cfa-4b74-9f0c-1e3cefb6219b"), "Marcus", "Williams" },
                    { new Guid("e68ae8e9-4a6f-42fd-82a5-d4910b834611"), "P.", "J. Williams	" },
                    { new Guid("6aaf37fa-af31-4d26-9edc-551ff954cfd8"), "Wil", "Lutz" },
                    { new Guid("0bf62a09-1a1c-46ba-9704-c95cee887633"), "Janoris", "Jenkins" },
                    { new Guid("4ae9bff6-abc1-4459-8717-1b05d485034a"), "Donte", " Vaughn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("003edf3d-a16d-4535-b811-0742741d7f30"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0041af1d-867f-44d0-871d-460832b9ba37"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("00597953-6477-4162-94f5-f6b08defc25d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("00632da0-700c-4550-86b3-bb19f381ce0b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("006b3488-c04f-4a66-9f12-33c26586ec01"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("007e9e03-309c-475c-ba3e-88e801aac176"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0093a081-73ca-411b-b87b-a2990a5fd1c0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("009e4e5d-013a-48fd-aa0c-47c8ec76f11b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("00ec3685-64b6-4b5f-8f0e-44c356d87371"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("011e1a3e-ee56-4c7a-92a7-93000a830f4f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("014457dd-d396-451a-8c86-818fd71ebfad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("014531a4-339c-44fe-a9cb-9734c2b7abb5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0166b748-f89e-4f0b-b892-501d45b1dff9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("01995b03-c220-4c9e-bbc0-826adeebbde5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("01a33f08-e5c7-46c8-8290-de814a097307"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("01d45597-ece1-4f11-b81a-1f7f1c91709e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("01d57222-197d-4c3b-877f-a19b227ca538"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("021ee729-f964-419f-9eba-8734fca37fff"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0221c801-665c-4122-80c5-cb25b9bc72c9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("024427de-112f-4f52-ab79-ac2b2ce3f452"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("025a661d-79f9-40bc-930b-ad12a3b6cace"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("025abf90-8275-4aa0-81fc-edf5f34335b2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("026337c6-b6c8-4377-8b91-10a357b00aec"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("02717352-a5fe-45c2-981f-83bb3380d410"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("027dd796-5166-4eab-aa07-3433fd09efd1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0286b8a5-869e-4189-9652-b80f978d9230"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("02c6b2eb-62f3-4300-9888-4242af738e33"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("02e49c08-62ed-4cfd-983b-3e713037124e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("02ed742d-8db9-4841-949a-aa93f6cbd577"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("02f16099-357d-4a4a-80dd-31beea226cce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("02f5a3fd-e414-4afb-8d96-f49eee9e4b99"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("02fda7f0-395d-46ab-951f-c8f9f9e77ea2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("030129ca-fe76-4262-9abc-22e9fd89b10e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("03078c01-b3ca-4f63-907c-d84145543cd9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("030de647-8c70-47e2-afbe-5e0163e2175a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("032cb520-70be-4f94-b831-7bc1ee253c19"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("03394028-aa86-4e61-a1ca-79e3defb67c4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("036210c2-ca40-4531-a5dc-5e6b7207e8fa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("03ccaf05-a4ed-4999-864b-5e71f5f9836d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("03cccb6e-fe6c-4ab7-9b8f-66e0410379cf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0408c941-e228-40b3-890e-02c6da5c3354"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0433ecad-4e6d-4bf1-983f-b7e83c3d0bfb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("043ec789-e4d4-491e-a0f4-4f06a4809563"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("048cc06f-c8ea-403d-bc4d-e0f4b7cec843"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("04974c3d-80bd-4be2-8a76-64154248c660"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("04c35e5c-ca51-4433-88ed-a50f92a8edd1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("04f35b5a-216d-4751-9ed0-b1fb54af1f7e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("04fcab81-2d23-4787-a7ca-5d4018db8844"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("051f791e-f303-4b75-b9e6-f0f925e9af22"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("052972bf-78cb-4b9f-b472-84c7cdd45ff5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("052c9daa-8b9e-469f-9969-782f473a2811"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0587152a-7e76-4945-a8be-b6501605e992"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0595ca33-bc85-4aee-a7fb-788c4b02ee00"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("059b39ce-f36b-4d3b-8bf4-4c2616f6c115"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("05b4eca9-7e0a-4736-a8bb-9f646fc03b3e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("05cb8660-8c4b-49cd-be5a-738812a52139"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("05db6b72-1ddc-4873-919b-c6854fac3781"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("05edfcb1-7343-4c98-bb07-192e2f3d237a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("06512ea6-a6c5-481d-a3a5-2a9cd4fedd85"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("069220b2-ea2f-4e9f-a7e6-5db8a2f335da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0696680d-63e2-4ed9-85f1-410b2cbc69f2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("06d05ebf-955f-43f2-9d38-d1807f7ec85d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("06e069ac-f9dc-43d2-a86e-0fb2af2edd30"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("06e50489-3120-4f53-9398-9a1b0fac3e11"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0717ae5e-c113-4a06-8f0d-4adbdb57ff63"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("071c5df0-63e3-4157-aba3-fb97ab8573f0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0727432c-0e76-4a26-9d13-6c7021fa5d6a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("07307775-aae2-474e-a122-bcdbf07dfba3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("076f63d4-2368-4222-8353-6d670b1c0df1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("07c69f67-5724-45e7-a0f1-ddd4e3080b97"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("07d4a7e4-3f94-4e64-9c97-53d989ab64a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("07deeea8-7bea-4f28-9b84-5970f613b9c3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("08464785-17f8-4e17-8033-5edd65a41de4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("088fbc3d-c960-47f8-85f7-f9675665d97f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("08a58065-d808-4cc2-a984-a78984a4e746"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("08a6e0b8-ae1c-4970-b41f-15c27c20cea5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("08d4e328-b24d-4ae0-bb9d-aecc465a51f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("08f98b47-6fc5-4545-ba8d-1236af1b07d6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("091ac95b-7271-4229-99f6-80a8559082f4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("091c4c5c-b470-43d8-b48c-d154d8db599f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0920aa26-58f4-4e2d-89d8-90a9deb0071c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("092b1df7-e14c-4f41-8f25-0c847387cc29"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("092fbaf9-e2e4-48ac-b055-9fa52f9ce515"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0944a530-8673-4d8b-ae03-0de3068ca10c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("09c93a03-b5c9-4241-b673-830f9b6b1699"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("09f190c0-6236-45af-a76d-903822f132f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("09f36ef3-7f42-44e0-b319-290ec7930195"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("09f607ea-fd66-499f-9ef0-1517177092c0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("09ff0410-de70-474b-96ff-ab653dae2545"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0a02cc07-793d-4381-9d31-ab4e0e738450"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0a0b3211-b8d4-460c-86fd-9411a1a8e5d3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0a2be22c-18ca-48d7-84b8-d1406256d754"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0a391839-5d6e-4d32-8c1f-d3384fade9ba"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0a5867fd-c7ba-433c-9294-bbc19d6c6b92"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0a7d6269-09ba-400b-9150-5667768c5f67"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0ac14001-bfde-4427-981a-57f7dfa32a8e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0b11f3c0-3fd0-4d8c-9e3b-7e6306fd887f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0b214506-0d10-447d-85e2-e7f10b987f7b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0b241785-4925-4e33-b5ff-5d0ecab52e17"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0b5d3f9f-6f2e-4c41-9681-4ae6b7b82e01"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0b7ac581-fa0e-476a-85f3-4510fa696981"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0b7d52ef-d887-442f-b56e-7a0036999bf8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0b9531bf-a8d2-4f23-9eef-954a2053e7eb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0bcaa0ed-7d35-488c-95ca-3bd08866b785"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0bd1264e-b527-4835-8b44-8f1b8c8203ff"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0bf62a09-1a1c-46ba-9704-c95cee887633"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0c2364c3-00d0-4358-bc33-7d834396d265"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0c555be3-d863-428c-be4e-24d214439102"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0c5a286a-1c64-42b5-b8d2-cea52737d10b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0c9700f4-4bd7-4a65-a21d-224e300f1b68"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0ca5c1cf-afe9-488f-95a2-afaea5ced2b1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0cd6ce3e-eb59-468d-bcae-472529c89a93"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0ce4d577-0bf8-4451-a0f7-a02565d6e44b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0cffc583-9bfa-4df1-b37e-9d2ef20c0597"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0d056e62-b9ff-4fd5-a500-efbbb5f0b2e5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0d19ebad-faca-47b8-ba50-071c71fc47e7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0d32ff1f-fd11-4f5b-b7cb-ef53887b3f1f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0d33f178-4ca6-4647-b4bd-54d278171053"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0d41104c-0c85-4bb3-9fcb-1c303ae52da7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0d46ce37-b4e4-4bb2-ba34-f47d439fdcdb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0d7b9cc8-e6fb-40be-bc13-51566d6ffcdb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0d7cf538-2b5c-464f-8fc4-9d54d7a6b287"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0d875805-df42-4789-96db-31df97a6c9cb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0dbd3cfe-4a80-4b81-8ba6-076fb768dd76"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0dc6f738-8b89-40b1-96b3-4851c914b2f2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0e142935-0613-4686-8336-83b13c85fd20"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0e207a77-9366-4f45-bf0e-4ad8b96f9823"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0e3f1675-8d34-4be4-b41f-d7a8d4367b8d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0e63704e-169b-4f44-aa59-3f19838ead69"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0e6ca883-441e-4b9c-841e-e638dad9d024"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0e7323a4-c19a-48bd-abea-23f726253cee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0eb1f0fd-4b5e-4286-9ccf-5ec5da6758ea"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0ebd199c-94d6-4e34-a28b-34d43ee8b0da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0ec1f662-d012-4339-a1f3-c294a2a2c744"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0ee154fd-5202-46c2-816e-504013386cfa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0efcf24b-a518-47b4-b490-22217ea01540"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0f13d6d0-b9d9-4688-97fd-bfd0385b30ae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0f46328c-1803-49c9-8fb8-3313bed92862"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0f4d63a6-199a-46d1-a7a1-38380fce06d6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0f66c41e-b525-49ba-9f1a-38efc1e3863f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0f7c1720-f5a9-4d68-8f5a-36ebf140c71c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0f8968db-082c-4443-80b1-b653ba2ff38e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0f8cfcc3-6ecb-4f91-8d31-cc52ce04eb7c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0f92e235-a688-4773-a784-884247f1fca8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0fa9df8f-31fe-4249-bbc0-85273d031434"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0fc1e6ca-58b7-4da0-8524-c78cd5a53822"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("0fe1af25-e60e-45e3-8486-b69984971d39"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1029e948-2ee7-4719-8d5c-b5a09af85f90"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("102ef4bf-b3ff-4ad2-8654-ba74d2905827"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("105ff179-4df8-4462-b6af-7820b707e405"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("10c6c469-427e-41f1-8be5-5e3363e87ea2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("10cd8761-c01a-4521-8a9b-0738db6d8e33"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("10fb8bde-9e24-4e28-b946-b5bf268427b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1110a514-f83a-43f5-a0f6-95ccf950b240"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1174c4d8-bd67-4fc2-9b5a-602a512fc036"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("11773dc0-6b92-40f4-b084-70ebabd00801"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("118b5360-de66-4d96-9240-89b099d30c4e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("11ee22ee-2b2e-4db2-b991-6731af5cf3b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("12365214-4df7-471d-9200-a49a88a3e230"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("126450ba-7805-4349-9d39-ae8a52796105"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("127679dc-6fd1-4931-bddf-8d6888a4cc83"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("127919a8-9da6-4875-98b4-dab7b00c048e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("129b18ff-f563-49c0-9e1f-ba1bc0ef5871"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("12a34ffa-f8ce-4178-8244-78ca67169866"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("12a50074-a0c7-42d0-a5aa-e8987a4f2cac"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("12b5c1dc-1d02-43d2-b44e-57c12e90a555"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1311d035-92cf-4030-aa1f-dae22546a6be"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1316d542-0c27-472b-9c8b-c2035b210ef0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1330b19f-802c-491c-90c8-f2c97d41d5c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("13313b82-8933-46a0-9b9a-bac2a32972bd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1384f91d-c305-4602-a19d-6074c21d04e8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("13918111-c1c2-427e-ac0d-849bcfb9f47a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("13926811-403d-424a-bd7c-1b83bfbd75b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("139655a8-f99b-4d9f-ae74-0953144f3f85"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("13ba8b99-dbe9-4d02-a4f5-795190ec3707"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("13ce6f8a-e9a3-4d65-8d8b-0f029f999af5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("13fc2254-3836-480e-b764-636edbd4a519"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("140574e3-93d2-4a47-b8a3-d8a9d1ed3fb1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1415e875-f310-4cd8-a6ab-6427eda33ff3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("141a5a2d-9539-4dc9-94f9-c484a71852df"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1439ac4d-b17e-427b-9142-8c42fca7aef2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("144741dd-6bcc-42a6-892d-9663b22d0b2d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1467eaa2-416f-4d11-98b7-775ef5a5b27c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1473d3bd-d6ac-4cbd-8379-b7e9c9fba1cf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("149030d8-3b54-4187-9dba-42331265142d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1497ec48-737e-4b9b-ae78-dc1ce534947b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("14a84e61-4086-434b-98e0-692e969e3a64"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("14b9a794-c6e8-4d8b-aff2-9a511d6892b2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("14ecd02d-8172-4b05-85e7-65297eeaffe6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("14f70e31-0172-4a46-8a2f-9cfd0c9161d3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("14fba142-f247-47a2-9306-8495694916f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1516f8ca-0394-4e07-a0bd-8f7af48a1b55"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("151823af-dbfe-4a6b-bd5a-b9f463c81b58"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1527702a-0d2f-4f47-86af-bd7eae35281e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("154deb9d-1fed-4ec6-8d4a-432346101369"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("15661a34-8d1f-4b6d-8954-f8702e102098"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1580fd06-b5e4-4def-afe9-b2f8bf22a760"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("15856734-5cdb-49b6-b0a0-6b300a11a914"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("159b8906-7892-470a-a4c2-391a2ecd7a2d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("15a0cd50-b417-4e2d-afb8-4623c7c77aa3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("15a19300-daac-4794-8630-3e4c3646b6a5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("15d2459f-a49b-45b0-b65c-55c798ec3c50"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("163108c4-bafd-4f05-a3fa-10eb9aa28c64"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1646f978-889d-4fc0-a0df-a300a75b02b9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1655539e-9261-486b-9279-888da8565acd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("165cf65b-bd80-4a66-8b51-7f6625cec596"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1665b738-ae65-4ddb-9c01-6af44324ec0f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("16667848-9295-4384-8b79-0a5c2dfa9524"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("167a7224-8c81-4853-baa6-59e939988605"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1684af44-bcdf-4183-a3c0-0daf5d4ed14c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1687ffe0-34e7-4186-87dc-e8d81fc2868a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("168dcf11-a172-4a7e-876f-9f923ecd3320"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("16a0e211-33a3-4caa-a027-7761d6a72fa2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("16a3c844-9ba7-45c5-a540-2cf8c5df1154"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("16c174dd-a969-47bb-8f20-de26ee8e09fe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("16de672d-fd62-4634-9752-9a0259d1bebd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17023e99-682f-4a35-b102-3e6a75504ba6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1707fb0e-23d1-4484-943b-d6b306df0421"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1718f503-8462-4557-ab7b-9fc4eda01c30"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("171d5e0d-4c27-41e8-a501-554f8e574859"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1724c37e-334e-4c79-babc-8e78d6b5d3f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("172ef478-2cbf-4baf-b375-e8d4f84568c8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1735ccc4-1a71-406a-9521-1ee26f30d6a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1740ba69-60f7-4e80-a3fe-aa38d26a9eca"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17509a57-7dc6-49ed-8565-84db24e6158c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1766ffb1-41bb-4ff5-b376-3cbe7c81a8ae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17a58da0-4325-4ead-b42c-f36e7d118eca"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17a806c6-97f2-4289-a870-75c3eaca2520"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17b63d8e-6b6d-4fb5-bc98-3c075b9f7a03"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17bca71c-0984-4863-8263-ea48870b0079"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17d82f6a-7c5b-4a1d-8360-d0620a2996ed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17e0351e-4bfe-462e-9681-f5cfdc986087"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17e09997-0c33-4260-8a01-a7f1cad1bcdc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("17e37f93-9091-4030-baf6-e60fddb670b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("183450fe-fdcc-4a08-b5d5-bd72b6e63687"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1838da45-7cd9-4387-9189-6c4459455bb8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("18419068-f2f6-4b81-b342-d39ec97295ae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("184bef81-13f9-4f18-95a5-f344a31fa97c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("186033df-71a2-418d-ae67-6bc35960eb89"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("18772e3e-0d95-4845-a971-55134995ca69"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("188a6c8b-c3a9-425a-b057-9d8f2ba5fde5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("18b07116-9916-4a70-ace8-1d2180ab0737"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("18c79bf1-eae3-41bf-889d-0ac886a3d2b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("18dac2c5-fc20-4839-b3c8-a1b904fb6178"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("191213dd-2b5e-4d18-9375-4a2ebf454eea"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("192612a5-4975-4d01-a7b0-3e9e723e7a2b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1926ab71-5513-4320-b0f8-7661627f7c27"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("19412bc2-de52-4b47-bb89-a2c95382cc9d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1947c650-5f1d-4b56-82a3-cc370f4d6362"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("194aa592-a1f5-48a1-a722-427f2190939d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("197ccc38-a342-47d8-abd7-57846dfe300f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("197df3d2-a99e-4042-a7e3-9e5caa8d6366"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("19b00a4a-8082-4365-a506-f16c7f2a4fef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("19c488db-dde2-4d59-b882-352847fe77df"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("19d56fca-9375-4cd4-8a6b-5cde0d155830"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("19d75950-80b8-4b60-8a44-67968f203642"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("19e6fdd6-9c63-4e22-a30b-32615a8b615b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1a0184d2-95ef-4062-9bba-69592850a533"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1a37172c-efea-4dd2-8c49-eb204369abfa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1a3b9978-9c5b-44a6-8824-989516dc7ad9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1a404a82-1cee-444f-9ec5-0589d056c96d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1a659b1e-c5fd-47d2-aa56-33c3d3ee0704"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1aa5809d-6ad7-4ff7-a442-2567c9956d35"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1ad37c6d-e772-4a76-8b68-04e603929e8c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1b17d551-dce5-4bfd-b149-d04cb206e406"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1b2218ec-13c1-4a8f-8b7e-c55050d9d9a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1b2370f9-65c2-4c7b-9e6d-81ce5d1aa552"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1b2e6713-f7f3-4dd1-ae63-d58841c086b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1b4d59a1-3a5f-4aba-a47d-41cc70deb71e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1b70e392-c67d-4d4c-86b5-9baccf32ad62"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1b79a8a9-64e9-46de-8651-9364d60d436c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1b7a000d-f1e0-4425-8f76-991ca8965917"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1b85ec49-5dd7-459e-94b3-a7830b24e3a5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1bb3e742-2e48-4215-89a8-3751cbcaf140"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1c1d49ce-9035-4743-8db4-67ed894e4178"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1c2b0328-54f6-4431-8e63-e3ecdabc16f9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1c2ddbf7-6c26-4185-8a4b-66146543a47b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1c5e8c34-891c-41f6-bba9-4145a83816c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1c75ad82-0833-4cca-89b9-16590b2a4ee5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1c94f6d1-90a3-4169-868b-076248cb3ad3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1caf84d7-cff6-4642-9be0-ae04c04043a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1cb98b16-62b6-4f91-93c5-01867377d121"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1cd2d302-2b9b-4120-b506-2ff1800c95ce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1ce7969f-6551-4f67-8a2a-76630e159001"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1d1299a8-9434-4509-9d6a-95c9c0e6fb5f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1d170640-a6da-45a0-a635-84cb792e3023"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1d20df36-4b95-420d-9d59-4239dde1f799"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1d303f73-120a-4821-9ab2-fe3e2ed13e1f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1d314c48-3dc7-47a6-8198-52d8e787a7b8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1d3a131a-bdc4-49c3-bbea-4f8d2bc47f8e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1d4ce6f0-9122-4482-93bf-4f649bb48010"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1d5041f8-d94c-4d54-adac-faeae19c5bbb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1dc8ca3f-b4d3-4732-9537-440ce0cc414d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1deff829-cae0-4a42-b209-b6a8e8ae6368"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1df7177c-184f-4861-8bb1-424695c39444"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1dfd40f1-6cfa-4b74-9f0c-1e3cefb6219b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e2b52d5-b718-41e3-a01e-152ed8ea4f49"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e58ce91-f03b-43ae-b990-7fef1326a0a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e5a952f-7d75-4f5d-8a99-4d7672a81df0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e5d89e0-6650-4918-bee0-fefa03473e26"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e63963c-d010-49e8-b252-ee8f344df561"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e78a4fd-1953-4528-b009-5b6d4aedcf1a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e7f9be8-b3af-4646-a381-004365bf9fda"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e7fbb8b-5109-4733-99bf-e112b4b69a7b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e934e9b-951a-4964-96c7-91b5a63764e8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e97289c-4dcc-4a9f-9015-b6ebac18c28a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1e9baccb-3f41-423d-abc4-d53cd64134ad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1edc2102-614e-4021-b11a-e6671bed4cb0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1ee05b7c-cd97-4bf6-8a4b-51c5f6b64102"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1ef14c07-d177-4b3d-a679-e60eef8ef35e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1f0a6896-311d-4315-af6a-556356c67101"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1f11d13d-9eea-42e3-a399-7041f2009986"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1f255eb3-4869-44b4-8808-aff14df14141"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1f327733-7673-4eaa-ac81-b1580c69d270"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1f61f6ed-9744-4bb2-8404-c9fc54227220"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1f7cb198-a4df-4064-8430-f690c28dced5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1f8fe313-829c-4190-9f4c-e65aa3304242"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1fa85acb-2d97-41a0-a80c-01ba2d9cd2b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1fae6c2b-f6d4-4141-948f-346e1c90ded6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1fb5d54f-df29-455d-a252-33c571c8c7c7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1ff2446e-b74b-44a5-af5b-52332062f89e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("1ff92128-e257-44bf-a615-3da737b30b31"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("200151ed-5c9a-46f2-98e8-3f78f1adffce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("20047b03-b7b9-4e8b-9eff-72e253f576bc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2018e66b-a324-4877-a85b-c27cdedd4c42"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("201b6849-e2a7-4f7b-8d25-3ed280a33832"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("205100a7-8e70-4bd1-b7d8-8e3d590a3084"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2088a684-2479-4b71-867d-1f47b86b7c43"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("20a42ab4-d334-4a39-9322-7438b97c9e73"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("20b4681b-6178-47d3-9ac9-8bd97349ec0d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("20c159be-e7ee-4111-8b4d-545896ec8445"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("20cf7204-e680-44d0-8037-d748f5b574a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("20e1f191-166f-4845-84c8-7d726950fcf9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("210a805c-2caa-496b-b8cb-3d90ee2c8229"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("21202022-4161-4dc2-96ef-a4ee04009628"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2149525c-3329-49f8-8c7c-74fb22230be2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("218dc790-89cf-46cd-8500-e9760312f843"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2190ac6c-7a7b-4ac5-9145-827e69b72b1c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("219af152-e61b-495d-8c68-9e3c2bbf703d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("22342546-3a4d-4a78-886c-dec224838dc7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("228789a2-9bdb-4c90-868a-31c8e30d2bf6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("22883634-6749-4164-8089-40d55f7f782a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2294da7e-c741-4960-9550-1361adb4c06f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("22965467-04a3-490f-903d-3e57ac4d6982"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("22aaa8cb-cbb3-426e-9abf-c8d9b25de325"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("22e93676-89ba-4dcb-bb35-ec363aaee8a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("22f7f325-adf2-4363-a6ca-23d6893c5c73"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("22fc77dc-b37a-4bae-854e-08ff889a5a5c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("22fc96c3-6fdc-407a-b073-0115eb4c7d80"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("22fd89e2-28ba-4089-bd1c-e1fc706c819f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2306fade-76df-4efb-94c1-cce61ef94246"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("230ae2cd-7c1e-4463-8b21-7b1a72a3ffff"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("231df3d0-a3ee-4ded-b0b9-ca116593f42a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("23229d30-1d3f-44d7-a2e1-121bad4d20f4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("232e37e8-14dc-448a-bdf5-3551b7590af7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("23413a2d-0f31-4989-8e27-026d2ffa3f72"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("234df961-36e4-4319-a09a-470ed80a177c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("235269fa-365b-4e13-801d-7223136899af"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("23566621-63a9-44f0-a46a-83c3b139acb3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2362e2bc-15e0-42b4-85c8-f3cd13fb89bd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("23886d3e-a93d-4e5b-a5b1-1912bc183e29"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2398c33e-4d6c-49e5-8205-b572f2f599f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("23a9d27c-90c6-400c-8546-f54c2f6ba830"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("23bb24e2-37d6-4e43-915d-1fcea2ed39ad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("23c4d70f-e8d9-4141-9661-6f3597846d2f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("23ca6aaa-c609-4b8c-938e-d7a55e0f68dd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("23fa2a1c-e681-462c-a5a9-c38348b26633"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2406157e-9577-4103-88da-51ad7bedf968"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("241e9b75-7e27-44dd-9fd4-12a2a3c0cd4b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("24228f46-3a6b-46ac-a1e9-114dc633f0c5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("244ba5ed-dc9a-41e6-a606-cbcbf70e06a1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("245601a1-b281-4c3b-a2fa-36a93630208b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("249b2971-5033-4ac0-9677-a43054ce8c7c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("24b41626-30fd-43f4-a0b7-d307fe4cdddd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2513b551-6002-4f0c-9c23-dea5b51c9379"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("25690285-b0be-469f-a0eb-49129dd17e6e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("258d4180-6e32-4b2d-b674-d5d5e13fc489"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("25ab0ea3-a962-4c89-8af5-9d008c4e910e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("25fd944a-880f-4538-bf44-d76e4d9103ca"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("25fe5dc3-ee8c-4963-ac39-e73cb0db1eda"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("26129beb-1132-4d09-bb48-34714b075672"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("261e2afc-0c31-4fb0-9f91-2e890151dcd3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("263cf925-6837-41b3-861e-4ac14c6281ba"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("26439e33-8e05-43c4-85e0-c8b1686642e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2647ec00-b81c-404a-a793-655ba8b53e96"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("26857d9d-c53c-4c27-be2e-ec5c735cd19c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("26fbf624-c5c0-4f72-b9e5-b86701017d02"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("270ab0b0-65ba-4e58-b793-fabdba16b2df"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("272fb445-182b-424b-b858-6c83aff28f05"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2730bca6-ef6d-410c-9bc4-8e794999db3a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("274ed940-6ee0-446b-ad8d-53fbda01a4f3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("275659d6-97d9-4283-92aa-9cdac5515bb9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2760da8f-4794-422c-84c2-1affefaa4291"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("277bbc4c-b970-462e-8bbe-cc471ffc7ee0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("279a1461-f0a0-4e03-98e1-5e9409d3081b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("27aa1cd3-aade-4268-9978-e7930c271dbb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("27c6bfb8-7363-4306-9ced-f42e8548d4ac"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("27e6b1e1-02fa-402a-b831-49fedda0c7c1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("280bfc1a-d64b-4dd3-b900-a0757a2855b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("280c2306-d18e-4d03-8f17-e26a944fb2a6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("28125e12-e7f2-4744-9f3d-382dfd3da14f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2812a87e-dd0d-45ca-83f6-940a3de782ea"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2863f172-36a7-4122-8fbb-b82856c2e5aa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2889bd26-ebbd-419e-b09c-59e385cd6cb8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("288bea50-5732-44ba-801f-e80479fb0b01"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("289543d0-c0bc-4320-a056-7e7f7ef1d625"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("289a7966-9580-4f6c-b6a5-cbdcc213042e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("289d6740-4a51-46aa-b3ee-af060f2972ef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("28c167ae-1b92-48ce-b7c6-cd77617169f8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2903bea3-0c28-4b48-98ef-67d5e43b263f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("291cad90-b4be-47d7-b9fa-5d2e062c2e7e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2943013a-d4ac-4062-8e7c-1c4fad921427"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2949f409-1614-457d-aa82-7ed6e19a1fa6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2956308e-f0ee-4536-9d93-bdc88e8e6057"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("295f9de1-548a-4e95-ba4e-aba9a33fddba"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("296d2acb-e728-4312-9cc2-f94c262d9fbf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("29837f4c-a3df-4dc6-abf3-5d7d6b9cf891"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("29a563cc-ab22-4046-b5d6-8a078520408c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("29b54c3c-415f-4911-80b0-4b1602444550"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("29e03145-0fca-4d47-98f5-ea7563055bdd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("29ece9b0-8b8b-4c74-9af6-6b1074655f11"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2a0ce5b4-fa6a-4244-ace1-fb0273c57fed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2a20ea1f-4829-4444-b184-9653373a8392"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2a213620-ff3a-445b-a315-e804ccfcb52b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2a25b98b-68e6-4072-b4c9-2c6135612bdc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2a58d078-e6ed-4852-8705-0e3d5f66ae7c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2a7dfc7a-2922-4dd9-a194-ff06f8b2c975"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2a8dd67c-f4e2-49c0-929a-fa09908a07a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2ac3f78f-8cd1-400e-bd63-edc0daf02dae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2acc0d8a-3a0c-488b-a33b-874e502fe514"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2ad59724-3b86-4490-af04-c70df0175ff3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2b6c4271-e670-4d87-b75a-8b42b7a84a49"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2b7acf0a-40b0-4b98-a74b-89d8d073ff87"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2b7ebebe-f642-443e-9d30-aac4b1700be5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2bb5457d-c840-488a-aa5f-a5a2607c5477"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2bc773e6-895e-439c-9260-3a7de5dd3761"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2bd70d3b-4386-4034-934b-ae383cab5993"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2bf29afd-2584-4246-9807-7defbae3869a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2bf4b82f-1e4d-483e-af96-04928057cbfe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2bfde9ef-42bd-44c3-8b5a-6c600d93bfa0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2c09f0bf-43ca-4e8b-98b0-df397902cca0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2c10d5d1-65f7-4102-99cc-19c414312e40"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2c239751-c9c2-4b76-b355-3b2f3772b839"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2c270a6c-be40-4956-a702-650f14adb918"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2c369973-eae5-4617-a4bc-879e0c500ac0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2c9c55ab-7c24-49bb-9fda-21b7a7c83ffc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2ca40a67-0942-4b2a-9a32-c8d6dfb6999a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2cada024-2f3c-4a47-8a9f-ea4c2eb80e64"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2cb04d33-2eb9-4a06-a123-a2d3276253f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2ccaa608-9e05-4b6c-aae8-cd134ae11ae3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2d26f7e0-69a1-4cf1-9dd0-a936fea451c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2d641910-9af2-49ed-be87-10ac82bff43a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2d6824a3-bab4-4cf7-9eda-9a6e26a35c64"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2da8a8cc-205b-4977-a3a0-e419b13d61a8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2dbaea0c-1e50-4d26-bb92-905c34c2305d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2dc5e339-6497-4328-aba2-5fa1f23ac2be"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2dee8d97-8cce-4b41-a0e1-7edd177273b7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2e113c46-db09-484a-880a-10e089a22d58"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2e567d7b-759e-455a-b845-8d65946bcb3e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2e9088e1-43ca-4a32-b8e3-fef10aae8c62"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2e91172a-87a3-4a82-8af0-1e7394ac39e6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2eb625d9-8b13-49c5-b413-50100f031bc1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2eb870f4-efc0-4875-afad-f00207081eed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2ec84263-5f3f-4a9c-8fdd-118c41cf6fd8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2ee949f7-3297-4462-8068-cb874da3d442"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2ef4a61b-cf4e-409a-82fe-6362be4eece2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2ef53f72-1554-4a9a-afec-12146cd420a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2f6e9d3e-1f44-48da-b480-ba8d7a52a60b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2fa4e910-5e84-459d-b9b3-d13b8ad266e2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2fcff443-ce4a-4969-8773-dff5fd055c11"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("2ffacc4f-1026-4c40-bb4a-e1becf15368d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("30225a5d-d0fc-4f84-9a20-37a011801b86"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("30431a30-63cd-408f-8752-757b60481e5b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("30440fbb-4801-42b6-a9f0-2a9239095482"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("304b17c5-b594-4320-a865-9adb56537b77"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("307ab349-5d48-45e9-811a-119a73d44c81"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("307fa9ee-b883-4c4e-acdf-eaf8f99514bb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3084e1be-c421-4bff-9040-a717d6689e8e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("309f4a17-b273-46a8-ba64-faf90c7bbe04"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("30a6dcc9-c3e0-43b3-bb75-8e523e719ce1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("30e89070-217f-4e97-8769-518338c74409"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("31439a99-0726-458d-8bee-3c1b1543abcd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("31557c6a-94b4-4ad3-9f0d-24fee482854e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("316991aa-e13c-44b9-9262-d064beb2ee4c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3171f61c-d87c-4b7a-abdd-1c9ce57eaf70"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3190a99e-fc95-4f7d-bbaa-d1874ec9b037"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("31cc1aeb-1763-4d80-96f5-476fe0f8895b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("31e97b7d-3f97-4f5d-9cce-05e94ffde451"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("32237047-43a5-4168-90a1-973633e6ebaf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3228ab1e-f864-4921-b97a-ebd20f62fab6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("324fa4be-37da-415e-9ed0-6b6fb9a1369e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("325a90ae-3858-4a6d-930f-9fa3d9855e1e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("32781c93-a124-4571-8c48-b13e8abc8c63"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("32c89179-f186-49a5-8e99-3761c05b9ec7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("32cbff25-1b6e-4981-bf81-8d81b84cdf90"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("32d311ca-0207-4984-bd69-36431043f9e4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("32d73fe5-4428-420d-a65d-e25c1bb2a2fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("32f1349d-c099-4be0-9652-89fa7adf92ba"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("32f7c2ed-c059-4375-a7a5-09e98e0f08d4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("330e3e9d-10ad-469d-9b1a-4da37560c8ca"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("33429b30-c79b-4a68-823b-215ab672139e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3365810c-6329-416b-813c-308af3748873"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("33f6499a-599d-4404-851c-ad79fe4e0aad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("340ba5b8-ddac-47c0-9f73-571565c62f31"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3412d739-da1b-4d94-a05d-9822bad87a96"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("34199549-f5f7-4ad5-bac2-afbc75f3fd83"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("341f8441-e8e7-422f-9744-769ebab36893"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("349a8f03-00d4-40c3-b64c-e48e065bf741"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("34de44b7-4b21-4ae1-b002-65c695bd4b13"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3512202f-55f2-41e8-bcd2-f90ce94b865d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3535da52-08a5-42c3-9bb9-0541a0a52b65"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("355a2097-1546-49d6-ab75-d81e0359c6f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("355f0220-0766-40f6-8774-d00a7b02aba2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3574f093-70f2-457d-bdfe-ee687362268f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("357a00ac-2301-4042-932f-ed29d1b55ecc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("35850d3e-9c4e-4ce0-a427-c69d4cc2841f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("358da52a-61b8-44f2-9d44-02a600ada4e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3599b0bb-29fc-4c37-aaba-dee7c498a812"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("35b3eec1-b740-4a55-a075-9265de9d4202"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("35c9c443-8fd8-40b3-9216-7c122990395c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("35df4a9b-4a18-417f-a4f4-26ba9b7bba9d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("35f4d5b8-c065-4efc-9c9d-61b5a769db6d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("35fbd942-bc94-4d79-b6b3-8c22008366a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("361232dc-6241-4ea5-b0bb-02ed6696763b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("365c47bb-7f80-4c43-9885-87153532aa50"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("36612fcf-7d44-4d46-81ad-c7e2ef1aeefe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("367cebdb-7918-4556-80be-d536fdec1b22"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("369940af-7845-4e32-98d9-1608d4b3bd33"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("369f7164-9c72-41a6-bfe4-9151f7248c29"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("36a1b77a-803c-4f79-8de6-8aac4dbf09b6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("36faa773-ced1-4300-80ea-d2b34dd295e5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3725b782-713f-4466-b0d5-731c2bac63de"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("374199b2-79c5-44c0-a4af-abacbe1e0934"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("375ac66a-578e-4c06-a3ca-a6cf6fbcc87d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("37b8241b-dfcc-4574-854b-9f380d6d2780"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("38431957-5cfd-4f08-b2c3-87d93afc72ce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("385b8c93-bf76-4fd4-af44-e53008d2a1f3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("387404aa-61d7-4f15-ac40-676f3e3109e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3878b085-c519-431e-bd86-61bdb0eb531c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("38b34efd-fc76-4e2c-bc0d-f8c15736ad4b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("38be8de2-6097-4e1d-b4b2-cbcbf5a00108"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("38d5a165-8528-4782-8e02-27aa58387a85"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("38f1008b-9ad4-46eb-9629-1cd736118ed4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("38f29e8b-153b-4720-8969-195f41229779"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("39197659-aafc-4e59-b06b-8ff1a37824a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("39476e30-499d-4661-bcae-ec7f72cce13b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3970ffbf-03aa-4060-b549-673d2b010ed5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("39798984-7e0f-4482-ac70-e985dac78114"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("39dd4092-84bb-4977-b955-a90223d4a8db"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("39f06c9d-8d71-4a0f-b9c9-f9bf9c1bbe0e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3a3ca7dc-6a13-4c4e-a55a-9b8c172a1282"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3a6535f9-f6a9-4347-a051-fd967f23ce4a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3a7b6c15-a007-433c-bcaf-3f7e6a521672"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3aaf89dc-2526-4a16-b027-55afb5b9fa53"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3ac3eaab-cb29-4871-b4bc-7be5080dda74"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3af5307c-9eff-4cbb-9ca5-3ed52f4ef22a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3b0acf1f-6716-486f-af5e-9a376c3de8c6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3b1e242c-2802-49c2-b544-b92df71a794a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3b24b055-436e-4967-96e0-d8b21d5848f2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3b256809-93bb-4cc6-8a3c-b695c2dad660"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3b3d37cd-3c5f-4acf-8ec4-19178f04e96f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3b73f8fa-52bb-42f2-83a7-da233b319367"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3b891bb3-a739-459f-9389-f0fb0e2d1983"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3bb47eb3-91b3-40fc-9548-10acac7f35aa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3bb7f075-9aa2-4c7d-a59f-f47b452ffbae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3bb81b65-1909-4ae4-921d-b58fc9a5e498"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3bbf164d-23a3-4bd5-a14e-97e5554c7dc5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3bbff52f-77ff-4e68-9c7a-0259eb15572f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3bf0882a-4945-4d2a-8e68-aad44425e954"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3c0cea85-9e12-44b4-9265-c04846b194a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3c170a10-37ab-414a-885d-b87f1e2d9d84"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3c2e9316-2532-4025-b4fc-8203d628dd11"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3c59937e-5e68-48c8-b176-206ee4b4f322"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3c7401f5-ff16-4b2d-8ac1-90c2e1d5af91"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3c7dc368-4cec-4c41-9b62-5a8d03028b18"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3c916a03-48a1-41e8-88a3-1bc5e6e1c369"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3cb8189c-4ab2-4cef-80bc-873b1eba2967"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3cc9172c-b22d-40d3-b464-91e901a94204"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3ce78a23-3bdb-4e95-b13d-e0362426524a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3cfb11de-02a7-4231-8e43-9b54a90e5024"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3d06e2c7-04b8-4ae2-bf14-30eeb1eee251"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3d07cafb-fe98-46a6-9a56-5f8e7f17c403"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3d25bfc4-a8a0-4cdb-8bea-01ccedac0b54"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3d4d60b5-fc76-4956-8c32-d04c36d9bf01"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3d6859b2-c136-4e29-9bd7-658b379f75a4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3d7c073e-7b0c-4070-8539-ab6905c7598f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3d81ece7-7044-4d0b-a6e3-3dda6a70d847"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3d8ae12d-f8d4-45c0-ad72-117f26754cc5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3ddebf60-c07a-4b3e-9c34-3e8333873d80"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3de6aa4a-055c-4f08-b2fa-7e945336a998"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3e04d162-1420-4025-8218-4cee087636c6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3e1e943e-b30c-48b2-8c8c-f0badb84eae4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3e26fb47-817e-42ca-a55d-38844232c966"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3e332afc-8d2b-4915-b6af-b7266dc54ddc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3e6f045e-3a8a-422f-988b-7a9e0b2a494e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3e94a331-5239-4fd4-9ad3-2076b7228095"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3eac329f-9602-407f-a9e0-966d0e054efc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3f000ac4-d6e3-4c2f-ae10-2ae2260b2d3f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3f621045-3563-421d-a564-75dd7f4073f4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3f89609d-d177-4c76-bdb0-222c9339ec7e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3fa1b76b-f7e2-49a5-b8ef-7f0cf5bd884c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3fdf9dc0-9194-40ae-8846-236d9fe5af60"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3fe339ee-4e1e-400b-af46-d5852d630e2c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("3fea86af-6ec9-49a2-90f4-88c5b3f57bf8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4012ba9c-1a9f-4529-b0ef-6cf48c8afd75"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4042536f-4193-421a-a26c-2382ce47e5eb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("40471908-44d3-42df-bbed-c4e3a5dd3131"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("40517b50-44ad-4d02-9041-6b1a0c1e82f3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("406813d1-73f0-4006-8250-08cae9c88211"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("407e811e-4ae4-435d-a171-9cab7f7f79f9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4080862b-1bcd-4697-8643-beade892b107"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("40839275-4bb7-4748-aa86-81c9c76adb00"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("408a509a-9070-43b7-929e-85e068512ac7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("408caea6-c4d2-4ebb-9e7b-7914009c1d64"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("40a42d52-6ce0-4ede-a109-64dd26095373"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("40b80e75-88b5-479a-a9f8-a4c82668e62c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("40e875ab-3017-4205-90d0-8818cf5c3c3f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("410a266d-74c8-4b04-bbd3-3a7c66135f5c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("410ad653-99ec-47fe-b1ed-35ca3047f0ed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("41411d86-72d6-4b1b-9c25-8b5bf5af9ab2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4149908c-e942-47da-bc57-d391b1a42292"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("417015f6-bc6f-42be-90cc-1240c012dfdb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("41742335-4502-460b-b281-4c8e7db8c9c4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("41768032-b533-4ca2-84d2-760db0b858e6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("418c2b1c-628b-48b2-a949-d84ab65e8b55"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("41a6d627-de3d-45e7-9272-7d177b16809d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("41aaddd6-1281-430f-bdf2-bfb4fe2921e7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("41c24a5b-f9f1-45ea-b0df-683285dd10b8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("41c30755-558d-4a9b-aeee-5bd721bd7f0a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("41c5138d-ae0d-4290-be04-c6d3db1fcaa5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4219e1cf-da10-4e1f-a644-a4c65443eabc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4226751e-69c9-4658-bdda-90178c0a4e37"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4227da80-3725-4517-8d1b-de022e8b1a77"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4261e0d0-05d5-42c4-bbd4-df629407143a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("42fd0511-08b6-49f9-a24d-12c48a2b5bdd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4316f1d6-d59d-4d03-bddb-3decd1404a46"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("43542bdb-7908-475a-b52f-9532bbdda05a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("435da7f0-a5b6-49f8-863b-a960a25462f2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4360fe14-b6a4-461a-a2f4-dd801b11c913"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4366bf7e-fd28-47a4-a018-dce927054387"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("437372f3-9d92-482a-b00b-24d1748e5faa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("438beb42-fa1b-466f-b734-7fe9ae39e148"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("43a01e45-ef29-458a-952d-1d435aa6ce95"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("43c09cff-bcc0-4551-a83d-d2dd0698bdf2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("43d115ea-a4f1-447d-b1cf-c9696167e119"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("44097f00-6932-41de-8a6f-72ae1eca6676"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4422ea1b-0245-45ae-8fd6-81dd6faf2a37"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("44415aa5-0a11-46b3-8590-513f8bfa6ded"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4459316e-e7a2-4801-8252-94fe347e0327"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("44a578d1-b1bc-4378-87c1-5bf1876588e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("44bccc13-aaed-4018-8cc5-255d0399cbcd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("44c4fb35-82dc-4a8a-a65b-749be1ab5d69"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("44c5b0d0-702b-4d3c-889d-5e239a2f20c5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("44f9cc5b-f487-40dc-ad3b-16d42d32c9a8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("45320226-b3c1-42d1-894f-fb8cfc5f53dc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("453b7f15-f962-459f-9895-e648866597e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4544a017-52a8-4313-9b85-da2fbe3db23e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("456b9dde-8981-47c6-9708-a423d6a0f28f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("457ede52-14f0-465c-8322-424556365842"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("45ae430e-b088-4a45-b56d-dca18be3e9f9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("45be1a9f-8962-453e-8312-77d403c897a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("45c218c1-f070-41e5-948a-d39ef8f23015"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("45cdaf1a-ea3e-4f50-9a2b-6d412f65ba3e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("45de16d3-be17-4dee-b22e-81d93c6351eb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("45e24c33-0747-4dfd-93af-34f02ccefb3f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("45ed2b5d-5185-4aae-b9e5-f6dd1133691e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("461b8bfc-9594-4a25-9f70-c52ad79141b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4622d300-90cf-4118-9e1d-4a01a0613774"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("46374a62-9cfe-4cac-a897-21b10c8333b6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("467a9606-d0a4-4aee-b7f3-ce2fe0d46faa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("467cebe9-6a68-4951-9a52-8c6f3095a436"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("46866023-93ec-4c85-9c21-42ff8059abee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("469f9993-4372-4478-80f2-47d525ffa4af"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("46d3fc33-19e1-4925-91b5-b6d85e636380"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("46db27cc-77ab-4a8f-b1a5-067a8da00caa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("470c0cf0-8b4c-455b-bb18-46c2d4309468"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("470dc025-4192-466c-95c1-fe95032eaa64"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4737cd4e-aa5c-4521-a8a2-2c357c901dd6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("47a4c1a2-fe07-4136-b5a1-3e60a49252fe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("47aa8369-fb6f-46cf-8ea6-e3c7d77df384"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("47c719ec-5d0e-4a41-9be1-2f8fc76dfdc8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("47cec6a8-691a-40b4-a22b-5a7b915c7173"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("47e05ef7-b203-4fde-b295-e91ceb5760ce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("47e8ff0d-8b58-4df9-a22e-88b00cd81ad4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4844e877-6060-4081-917b-e4ca27720638"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4850ff50-0717-4bac-b621-2243ef4d6c92"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4857a090-78a5-46d9-ad13-468026fef6d8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("488369b9-531d-4f2e-93c7-d603a586d6f8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("488f2090-6ef8-4939-942d-1264cfa33785"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("48944a31-5ed5-48ae-876a-87966596fa45"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("48aa5a4c-ead5-4e08-bd9c-d7d4240d7d7f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("48bd5422-2d56-4c86-81c8-180b0c4ce497"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("48d0df87-8ebb-471c-abd6-5204d1f85200"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("48df5e3d-b831-4441-b41e-22ed9475de83"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("49252077-0d4f-4294-acd1-63a0218d481d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("49487e04-8740-4b9b-b965-06c493e0fa8b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("494dee22-cad3-4702-ac9d-c85689ec2421"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("495dedcd-4873-4020-8f00-5b3533c554c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4961f102-f827-4850-a2b0-33df455d2866"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("498bb4f5-16fa-4e27-b7e5-5a78b0a4fee0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("49d46aec-9cce-46f1-b058-b4eeb7b49ec5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("49d77d93-fa82-46a4-b1e4-a7e8eb5891fd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("49d7c032-697e-4f4e-ac73-56e410feb796"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("49e534b6-9d3f-4fe7-b573-bf4f220dae8f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("49f5fe33-42fd-4fa9-914b-a74de92c4712"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4a080b27-2851-4b7b-939f-856a1536145c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4a19df05-273d-42ed-b2e0-e9e524ce83c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4a3402c2-a4c8-49b0-ad38-21d9cfc790e1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4a38e059-b05a-41d7-bea5-b6a6c3b09d2c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4a47d13f-802a-4e88-91d5-8a0372993a31"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4a67d737-6653-49a6-a20f-d279edd5b290"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4a8bbe32-3976-47a1-a754-14b7d1ce4eb5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4ab4297f-f13e-4d79-8e2c-53dae8671189"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4ab7873a-a5fc-461f-8b26-955292883656"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4ae9bff6-abc1-4459-8717-1b05d485034a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4b3a3b89-8ab8-4aff-b6ba-16a477ff8f69"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4bb47367-9901-45a5-985a-626199a78027"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4bd61705-ad37-48ef-a759-6a367fc4a6ed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4be59e21-ec9f-47a1-9b5b-ba28a8478efd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4be5ed79-6a40-48d9-87de-525ac06c0fad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4befcbd5-1cc9-4591-adeb-085c53291f8a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4bf07e37-f994-4d88-b1a4-56bc4d1b16ef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4c0056b5-d473-4617-bb9f-ba4bb8aec276"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4c0b354d-fd42-4570-8946-3992987434bb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4c2e23ea-3ee2-48b9-a565-eb7f1a6685a0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4c30df84-0750-4725-9bb3-44ff3d5c1692"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4c432547-288c-49d9-8543-235e638c34c9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4c4e6cd9-ee8f-457c-b717-a9e871ee3da8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4c722491-3722-4e78-b143-0797a12de541"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4ca04f2d-01d0-4d73-85d2-1aaca7f11daf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4ca9dac1-5c6e-498b-b46e-5bfb006cd3a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4cac9757-1c08-4e74-b13c-83389fcb286d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4cb7181d-c281-487d-847a-ed7582dbf89f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4cdcef02-25af-4503-9b32-b9b67e1c3de7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4d3b4061-3f38-4349-ad06-7592b98f3e30"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4d4ce24d-c9b9-4a29-84df-3f702ddf863f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4d585fe2-c14d-4d05-bb7c-cf5132e4f609"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4d7b87ad-fed6-464f-b00e-5345f7c0f266"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4dad418f-af96-4f70-b5db-4ccdd7bf85de"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4db26b2f-62f7-4c9c-ba01-885e161e3d6b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4dd3dc4f-6333-404f-b78f-9e6a24457b42"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4de78e0d-0d93-44c3-b79d-bd1856a19965"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4df412e0-81a0-44f3-8ce9-741bb10f0df9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4e2e4dbf-c0a8-45d3-a04f-96e397cfc224"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4e54ae5e-8d08-4aa5-ab81-e9f87e381a2c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4e7f167d-d933-4e83-9ff0-b611adedf350"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4e8e13ae-06c1-4b92-b586-4d8dd89b36f0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4ec8ef2c-38b8-441b-9ca4-4ca36223ec06"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4ee6b96a-76d6-4493-9b91-412a19ddc3fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4eec9951-de44-41b1-b3a4-74a4b487ae34"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4eff7bd5-4a3d-4537-bace-5c59a5234306"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4f3e726d-1b40-42a4-8840-f7801ff59158"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4f400028-cee9-4506-aef6-051a70c4b4ab"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4f542ae2-f86e-44a1-91a1-e4b1ade3f7a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4f595a34-973c-4243-9f0d-e2c9fbc96b00"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4f5b77f7-4b28-4298-848a-1389237c3314"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4f707c65-1574-4284-ae22-87129d591785"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4f73cd28-01f7-4336-8eeb-4a265dfc1c2e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4f76fa85-5ec6-49d6-a624-8d1c2cbaf258"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4f8ace56-67fa-4fdc-a7d9-5dc3f17eb4c9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4fb555df-db98-4ed0-baa3-49f2df8a86cc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4fb7fbfa-97f4-4649-a95f-8a95ac1ade22"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4fb8ca50-06dc-490c-9b79-e4524931f862"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("4ffb0fe9-0cac-4e14-abff-a64b46d055e7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("50052cae-357b-4fc3-8bf0-d7009f55271d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("503e58e3-11ca-4a52-b32d-a447a23f2ed2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("504cfc20-cb57-4aa4-a7ba-171dbc396975"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("504e66da-3fea-4ee5-8a10-a4bc03a2f669"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("50932545-6cf2-48c5-a678-a1ff124b9d5b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("509c1ea2-5dd4-4ff4-99f2-fb318e7160c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("50a18923-1810-4604-bffb-5af8126f50bd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("50a1eee2-b942-4cad-8a7e-2c291e59d365"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("50cc8deb-9cdd-4718-8979-7fa347da138a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("50e556cc-464d-4f48-b982-a934705458d0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("50fe9fe9-c724-4235-a6ec-e8522cf89a4e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("50ff4449-33b4-4bf7-80a4-3cebbd4eadb0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("51015612-5f93-4185-a080-1e04d95fbf77"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("510ce1ff-ba43-40b3-9e11-31043cd6d7c9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5112900b-5088-4605-a950-58159bcafa35"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("51131c34-3d7c-4909-8895-83406b9be2b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("51223049-11ba-418f-acf0-eeea6570fd6d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("512deb95-fb20-4efe-9636-b1ea2893b478"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("51590752-18ed-46fc-8633-de14c5f5f2a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("51800256-9a42-49ab-83b0-951ce111707a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("518ddba5-af1e-46cc-bde1-43605b4b5fd6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("519e0a6b-6cfd-4dcf-bf7f-4cdca8138505"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("51c3aa4e-74f9-4aca-bab3-4cb139ffcace"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("51c43138-aaa1-4828-a3be-71987d21fed5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("51ef10f0-857a-4560-ace7-97d946a74bb4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("51efc953-5719-4c44-9ac6-5c35630252a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("52999a96-0b7a-40dc-87cb-be1d3d6557ae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5299bedf-6497-4228-9d44-28aa67dd2feb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("52b03fdf-f204-4afc-9a8b-56578298a519"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("52c0c5a4-e6b3-4fee-98ab-77fef7fff179"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("52caa8ce-7738-4c76-a634-c330c4c2bbc3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("52f8f6f6-924f-4f50-8dcd-8a7f707814a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5307aa78-c828-4d75-9d31-a0c67b239aae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("53091acc-c7e5-4517-b48a-48f1813fd204"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("530a7a57-bd1b-47c8-a475-ac09ee4376c7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5325046d-f10c-491a-8c69-deb474f58c3a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("532e5e00-8723-4250-b165-7e6ff724843c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5351aab1-617d-46ed-a130-e9d9069ced23"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("53526803-6a34-43f8-b8c8-58b11ee4577e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("536350fa-a92c-4452-84f4-cf9377b61669"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("53650fed-d522-4aa3-a135-738d7f18b00e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("536b4b44-615f-4cdf-983c-483ba2d02b88"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("53934c89-1fd5-4aeb-a591-72e7c0a6afd0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5394a08a-95f2-4699-b129-06e28b5ff5a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5398db40-efec-4097-b7b7-a244a4e2a33f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("53a475ef-ae36-4a50-a47d-685a416678b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("53cb164b-0308-4c93-a6b4-839663e82cf2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("53d61cb7-b0bc-495a-a5b7-fc41c6b61cb6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("53f56f5d-f8cc-417e-a370-3a017063276c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("53fdd5ab-e9b5-4e7d-a0ed-0fab52edd386"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("542cc175-f6cb-4c6d-96e1-e1051e6e6a5d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("54702189-3e86-4e70-9150-ffe863d52c88"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5483c6f5-3541-4456-a100-79c90d19938a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("548cb996-3450-48a6-bd79-8e40917124e4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("548ec1ee-937b-484a-87bf-54005a648dcd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("549ecf40-d423-4b44-956b-0c152b3190bf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("54a278df-b713-4525-a7d0-562a2e182ba3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("54b9be09-30fa-4281-9031-aa863469ed60"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("54c79cc5-e1a7-464c-9017-a9f924c223d4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("551df27a-a538-48ca-95a1-7e6e4e867d80"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5529bdae-7b5b-409b-9bf9-90279c15750a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("553561c1-ba40-4d63-9701-1fd4afb76c81"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("55359a08-1ceb-4f1c-bfbd-a14c1ba80da3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("55528b77-7549-471c-8ce6-c3c50b65aab4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5565551d-491d-4c95-9e30-26e79c1ccd8e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5571d4dc-4e14-410d-a5e3-60a7df224d65"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5590056e-88df-438b-ada2-244f4871fb75"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("55acaebe-a194-4544-81d5-996ff2681a6c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("55c845dc-10d5-4331-b6ce-b779870b5068"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("563065ed-40bb-4d71-aa3c-fd7e17912717"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("565b6719-6534-4063-bf9e-70900104a405"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("565bb8b9-26a2-4caa-b604-f96da4577d89"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("56a6de63-5ede-4d14-b4aa-726b9b2cf97c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("570857f5-0306-45ff-be7d-5bdf97c31180"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("571c0061-0eff-4e6f-b998-e1b2b3870ef3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5755634b-018e-4489-b231-5472e3e5238a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("577332bb-07d9-409e-8a82-bcfeabfcb16b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("57747b74-7231-48c3-9a13-55046e36b38f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("578783b1-85ff-41a9-9746-9982d5efdd24"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("578c9cc2-6c83-4ba3-8c8f-7203204faa18"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5791b6e4-2d38-4be2-b45e-63c87d38c9c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("57944d6c-0084-44c4-ac27-1ef47a1e0b77"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("57a55a53-8242-427a-a591-a7ccbb540f08"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("57bb1bda-8933-4df5-8fd9-e9ed2292ff8b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("57dd96b8-a0bc-4bbb-a164-284f08784846"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("57de0546-cf72-45f5-9781-8bf284a25366"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("57e5c33a-eac5-4846-a2a2-9ad253cd5a4f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("57fe13b1-7868-44e4-82a5-8bf3f29f924d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5815054e-93fa-4c76-b09b-dbaa9ec75563"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("58405e79-4ae5-4357-87f3-6d2559d5c1a1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("58adafd6-94f2-4cf6-83b5-b7cdb4c5eda4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("58af1095-35f1-48d8-8490-179e8354d730"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("58c82d80-ffd3-4507-bdad-d91b5228d21f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("58ce1d85-5e46-4787-a899-1df5a81a8045"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("58d845cd-9e6a-4a3c-8eda-2bdf121d42e1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("590450bf-4f94-4620-8517-72a72e6b88e4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("59070b5a-046f-4e87-b43f-78bc852992cc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("59253232-8d1c-4b9b-a244-f04e01ad8a29"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5946396a-b015-46a1-b28d-b21abe65e96e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("59705344-d4ae-4f16-8121-6436b3c5cec6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("597771bf-232b-4738-b886-cad27b3a04fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5988d88c-29a0-4748-8a96-cc365f378a63"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("59bed8f2-1293-4f13-9625-f07d00e9e3e1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("59d39f04-a41b-454f-88c5-d03a77dcb66b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("59d8d3b2-4ad0-46e9-b371-0514ea2c7160"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("59f0667b-b65f-45ec-93c5-2fe1940a2049"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5a1af098-ffa8-4c7d-80d8-f415410b7fd6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5a21c04d-76b6-417f-bd56-069f13770920"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5a2fcf24-1f6b-42ab-8e29-662cff689b45"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5a51f2fe-349b-4090-83c6-0aec7513d889"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5a53d3c0-a8d6-4f8c-adf2-93ccf72ec789"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5a94f953-d802-43e0-845a-72ec1d4dcadd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5aa4e4c2-1c64-4a47-99a0-ae79e2e8107a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5b00ab33-39d0-48ce-9a4c-ff62b34a92ec"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5b1d0f1c-68d7-485e-950e-a055522e75d8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5b1dd940-9be6-4b09-a5c6-008d5b9f6f82"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5b568cec-0130-4388-944f-30b76b4a32c3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5b598f08-71aa-44bc-9d27-5b331c41677f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5b70bd29-2e60-4fd1-98fc-cf83cc84e670"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5b79bd2d-12f6-47e6-ac2c-47c18910bf67"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5b7ecf19-fab2-4720-9105-3d6a1794cafb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5ba25868-3e33-4817-8433-6d0de715ef9b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5ba63ebd-3023-4027-8f4f-3f515cafe6a8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5bae1761-e283-42e9-a1f1-a832c4546078"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5bcdf342-892c-4cc1-97de-cb54fcb65652"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5bfd5224-a881-42c3-9b0a-ac6626ca2d27"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5c0b8a97-1b60-4138-b285-1df388d35c1e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5c1ad701-b61a-4e0e-a983-04a90917ec86"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5c300968-bcab-41f3-8455-c46d3a76da71"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5c67a64b-06be-4766-b2e6-4eee7d756086"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5c6bdb5d-19ed-4999-9458-b3ea2315ce60"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5c7bb5a8-fbaf-4d4a-a93c-8a4460a032b7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5c89a107-173c-4e21-b14e-95c213929409"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5c969134-cd78-4b2d-a1c7-d472c6031216"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5c97a667-c237-4b11-ad83-07727fab622b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5cb2bb95-0762-468b-bc32-aaeda7667cbf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5cbfa000-9577-4672-b99a-1dc193451a8e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5cd3005f-efab-43b1-a40d-93216ed9ab55"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5cfd1f9d-c0c3-4601-a8bf-f47658877828"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d04e82d-d864-4be3-8baf-081068c32861"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d2f9d91-c39c-4398-b38b-52b6043233d4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d30ef12-db14-4cf5-b31f-eb6524a835bd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d3ed2f6-8fa7-4b37-bc71-cc9e8ea3134e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d6a54ad-9bca-4b40-9285-dde7f5f3863d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d7e29a0-a05c-459f-943a-8fd9d237b77f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d7fe380-90c1-4957-836a-739bf8a4a84c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d803a45-26c9-42c9-843e-5d5b0661ae30"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d817545-b591-41bb-8cf3-a8bfb82d3379"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5d9d1b7d-262a-482e-a70f-15d78d2525d1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5db7b6b6-6ab5-48f1-97ff-90230c30e604"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5dbe2afc-15f6-440d-a7d7-4c28e146b457"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5dc0531d-939f-47e8-af86-ce7cc6e45377"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5dd73ccc-4c0a-45f1-be56-916f054fef2d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5e0923f9-dc07-43d2-8630-8508e586e545"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5e288231-b428-4330-8469-0e028a3ec57a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5e45cfed-067e-4b6c-a0f3-ce10a656b9c0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5e48dd77-6934-4c7d-82f2-d1bfd9aa61fc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5e6863c9-c16f-44c2-aa2c-116e689ea2d9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5e8490ed-1507-4621-85ae-380fbd3f9068"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5e97876e-2c93-4ce1-84f9-147bfe123573"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5eb42127-8b33-4f81-a6ff-3907e487d3c6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5ee02790-b6c1-4f3c-9429-4e99fe77e08b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5ef1fd64-3121-4354-a7a4-341e54b86cfb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5f440bc8-f7d3-42f6-ae1e-184f7dad8be4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5f5d6959-8c0f-4644-8d55-9e93cba1a7c0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5f8da906-72a3-4912-99e3-f52685873840"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5f9ed096-786b-49e9-af23-e79305838208"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5fa77458-52f1-4a8c-abf9-122b7e7374d3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5fae93af-6b1b-456f-b522-916ae2c74202"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5fc4bdfb-73cd-4e7c-9dab-979b71363e49"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5fcec144-55cd-46aa-bfd4-ec8b8ab4d64c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("5ffe98a8-7924-44a6-9df5-41d170e3257f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("60450d47-85a8-4c84-9e19-ea9523cd4da9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6045510a-7e2c-46dd-948f-7c9fab21e01c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("604ba30c-337e-4ddb-b735-33a4111a36fa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("604e2495-b67d-4de8-a3b3-a38dbdb2f70c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6059fce0-19cb-4ae9-93d4-45dd23028258"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6077b135-b8e7-4c06-99bd-ae270f8687ba"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("609dd626-2706-474b-855a-5d801140bf89"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("60feb630-7c88-4c61-be49-c4ecab9d8c2d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("612dadd4-94cc-4baa-b777-3a9b48275bb6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("612e5796-4080-4b79-8e8f-968e67044461"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6134bc26-0c31-4434-b0b8-60ab738aa76a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6142d97d-ba2c-4d5f-aea8-eb83a06af7dd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6151f64d-c5c6-430c-9348-5cef9b236aa8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6154116c-0b94-47fa-a630-e7a81741dfcb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6155b425-ac97-4f70-94d3-c3503f37f4f5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("616295ba-c53c-40e5-bb47-c7763551e56a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("619dca0c-6c75-41f1-9a0b-2f3a9c2ea1d6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("61ae2941-20be-4c1d-9492-dc57a92a1973"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("61ba498d-2e7b-4c93-b41b-481d5490c1a9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("61c7ebb4-fb44-4ebb-9c8d-ffc143ed856f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("61db301d-af31-4bf5-a992-1688a015959c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("61f8bff5-0e8a-445f-817c-462512027e79"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("62202bc0-dece-4d18-9c09-d1c612b76d9c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6225fb30-b2cf-4ebc-a6d7-7841e3897042"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("623065bc-a803-4c18-84fe-d6883618878a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("62500c5c-a5f0-4944-8bbf-3736795e816e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("62749c57-c458-4533-85db-3361fa22eec8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6276b1fa-5d2b-44a5-89bd-e80d7757c8bf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("62885050-5dd6-4200-9022-b42cd21c3616"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6289440e-694b-4d27-b068-2a3fb658e26d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("629bbc91-c771-4044-b397-f6b29c85dad1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("62dd3bb8-7280-45b4-8302-dbddfaf3791b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("62ea142b-7a7b-4d47-9a3f-dc050372611d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6313afa2-ff36-461b-b9a3-c079b88507ae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("63216b47-89dd-429d-9bac-7373a3f7e8c5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("633167e6-29d9-471e-91a6-aa7f0fb09825"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6357da48-f6eb-4746-a550-e205f8890d94"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6384fc82-9d14-4ee1-a21a-dcbe678de37c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("639b7803-f3a2-41c9-b9b1-d58ea741e2da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("63b76099-2e40-41eb-b345-d56c398637da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("63c5a1ec-0e7e-4205-a5cc-cda79cd937a1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("63c93967-4ab0-44ad-b945-03b00ee7877b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("63eab8db-211a-400e-9688-2f6d9befd3a6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("63fe347e-f49a-485c-ac6a-8ac774e6eff4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("640a9f34-b2d6-4431-8312-9e2fc442fb4b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6434fef3-ab5f-4389-8fd4-a314bf28c8fc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("645f1df9-d9f4-4058-b7b0-9e161c78872e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("646ca557-1b0d-4e42-97c4-5a8a7cc63873"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6472ffc2-d035-4f05-8358-b359527430f6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6492ce5b-9e1e-4c00-9915-0ca268cb0303"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("64b50162-1891-4f19-a0f6-1c9d14ae0c28"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("64f5f8c6-3a57-45d0-9765-381e9ac434eb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("650243dd-4a8c-418c-90a3-2f6ff2780334"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("65287605-d6e7-4c06-92bf-2d5d7bfa4208"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("654f619a-1e30-42a4-8834-f6a65a734c3f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("656b1115-f152-4879-b9c3-0449cca9c57b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("65a06b6e-ead0-4352-9d22-367a0dcc4ebc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("65b16725-8ade-497d-bf77-8bc24f54cb98"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("65b9cc29-9b35-402e-a6cd-f730ae78bca9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("65ec022a-2e5c-4293-af7b-0aa4660d6f0e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("66235640-b839-433d-9e3a-7757dbf99a59"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("662e114b-4c01-439d-a32f-fc5a17bc958f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6652740b-6ce3-494d-a398-21556b15f828"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("668b73c5-e589-45fd-b694-5d7d3bef57b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("66d7d5c7-8c41-4b67-be2b-c37d8d012253"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("66d9d0e9-8814-413d-b4b2-53cfc8dfacbb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67015a1f-0432-41f0-9cd8-239a60332e19"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("670a883f-988d-4fa9-b545-2f82faa05643"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("672572a4-14c6-4493-86ab-4c253cb76ddc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("672ff9fa-0d14-46fb-aa13-589202349e2e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67385d4f-2122-47c8-9239-1e79088a580d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("673baaa0-409a-4069-9adf-543577229a8f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6742fa69-94bf-4b5d-b4d2-218ce2d7d322"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("674c5960-5dce-4a77-b1c2-b15bf4140b6d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6764e1b1-b218-4b3b-888d-0199d6a67313"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("676945c4-8766-4e98-89ad-ce43e7461979"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67832800-8f58-4c3a-a2e0-a59ce624d644"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("679ad689-1139-4970-861e-ef22a0306535"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67a02f41-45c4-4ab6-843b-601a8c58266e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67a26674-a8a1-411f-9a0d-cfa081e766c4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67b3463c-b6e3-411a-9aea-fe2b4227e582"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67b6010b-19ce-442e-95ad-5ff7269b8e37"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67c1e2fe-4a93-4a36-bbd6-7627265b7879"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67e561fb-205f-424a-bbe8-28e412cdaf7c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("67ecc956-0c5a-49ef-b7ad-80c85a2532ee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6806d9ff-56d9-438d-b430-b71cebfc9f05"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6817232e-76e9-42a7-86c5-e2f480a50b87"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("681952e9-14d0-49ab-9361-1a1d71a208bd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("68329502-7240-4af8-a8ad-0c30e3ee9d61"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("68414c92-4aac-4a00-8b4d-4180586af012"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6855f1cc-41d5-47e1-ad6a-1fd0a9539a4d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6857a42d-522b-4419-a7c8-b3cb7d8b68f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("68621676-5a37-4089-bead-2b605624fff7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6863f95c-6295-4fdf-a5b7-659492e6220f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("686975a8-4ce8-4b5d-976a-7eba0dedae1f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6885afe6-bb0e-4be9-94cb-831b679d20a1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("68a07c04-c628-4a45-9b1c-63bc8d7d7543"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("68a7e35c-51d1-4d46-92d6-b4b3fa0aae9c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("68d4e873-f24a-4536-b20e-01a537316dc1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("68e076d9-2fc4-42e3-8eb1-30293819da10"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("68e42520-81ee-40ea-a1d1-41265a864535"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6926146d-4e0d-4820-b61e-5ccb0a9c0e98"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("692a8481-2d80-4db2-8f7f-dff5369900bb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("69712b5f-6ab9-4965-b4a7-dfe7e79dc24f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("697d6f77-93ba-47f3-85fd-68c37805a898"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6984eb83-2af8-4565-b49d-5d7fd8967198"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("69a20be7-2788-45e9-a3b1-82012832e633"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("69ac64ec-0687-48b6-b6e4-a9ef7148cbc4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("69d55ebf-a9a3-4f17-82e4-9b1b7b0ee032"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("69e1dfb0-32e1-4997-8250-18477df1cb26"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("69e94e69-1712-4c94-8ab5-d0a17546dc96"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("69f09636-101e-4eb0-a989-8c06f3b9529e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("69f0be1b-2342-4bab-8b19-1e48677f65a4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("69fbc05d-09ef-4431-b81f-304dd8635024"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a01291f-b646-42cb-84fe-e0deb1e909d0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a27590b-b03e-44f2-89f1-17defa65c28a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a37fcc5-8fca-4b2c-b2ab-28f270c73f2f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a3d2f9a-5c6e-44d1-be22-f6848de6bdba"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a4c352e-79a1-4362-a48e-285a9fda1813"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a6412dc-c6c8-4eed-8e80-c798363cc6ca"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a66920d-2664-473a-820c-e00dcbe1671d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a7830e7-896a-40b7-8eb0-30cffb807aa9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a7f7115-7963-45b6-8c1b-d52de4348ea0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a96c177-d742-420e-bcf6-feaa1f64b2a1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a99351c-4ceb-4abf-afaf-bbbd4ab845da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6aa31df6-d8d4-4809-938d-1865a02c90c9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6aaf37fa-af31-4d26-9edc-551ff954cfd8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6ab7152e-37a8-4d4b-9aad-0dabc6ba290c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6b12475c-92af-4201-91b9-5530eba876fc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6b1a13d5-6ca0-4cb6-a46d-154a95f8dfd8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6b50f1d0-36d3-4015-9d03-57436d927a56"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6b543f17-7e06-4f41-9a8b-9d920abab2db"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6b6c340a-cb64-460b-8d34-4d5964df2701"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6b725184-fc89-411e-b556-895b229f532c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6b8ae4d5-d63a-4d6f-a78d-4b9ee2cbb6da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6bbfdb8a-5a95-401d-ab76-e7ecc52801fa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6bd6f707-d41c-4fca-bba7-efd24bee8b7e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6bf30050-0789-472c-9111-e17fb203cf23"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6c4e79ce-aff8-42fc-8bf7-2474c06ee494"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6c53bd99-5fef-48cd-9ce6-300555a84540"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6c6ba42f-eba9-4877-97f2-3ef3e2a539d7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6c7ff418-5da6-4a68-af3e-3aeef6573f4f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6c813fbb-84e8-47b1-992a-85e9dea4cb31"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6c92a1f5-97a3-4cf4-b941-7a27e6cb6595"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6ca664b4-44b0-4c41-9ba3-7105251fde2b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6cc19ae9-27da-4149-8e8c-1983c0ca987b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6ce3b7e1-c233-429a-9f13-30179819c1f4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6d1bfc84-699c-4cab-9e25-676a8bd1c9ce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6d596b2f-f302-45fe-9a6d-a70adeed4506"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6d6a517f-5e49-4694-9a7b-495476fde883"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6d720d07-57f5-4453-a76a-fc6e24bcdc15"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6d7fd446-598c-45ce-8989-7ff58ed714aa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6d958861-29ef-4e86-bae0-7850f3a78d5f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6da57b89-3da0-4976-86e5-fcd74ad5f9e8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6db768e0-881e-404a-b733-5e5316dd6afa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6db9c929-e0f2-4b10-b178-86f0decc6ddb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6dbb85e4-8e51-4aff-a8a1-5fe5b59ba6fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6dc30a38-8a70-4b0d-a835-57114ba48dc6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6dc7747b-39a4-4ca7-a8bd-2fcd31c0ab9f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6e02d603-c88b-4ffe-af1d-ed290785e8f8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6e360a89-9b9d-459f-aa4c-19b31fbc64d7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6ebf4789-9c10-4c77-bcf7-8b61f2f0b43a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6ece0883-7694-4419-b1a2-fe6bb8586309"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6ede238c-5d1b-4b0b-911f-631f02564766"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6eecca5a-342f-494c-9b52-3bd6b511438a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6f07b30d-542f-44bf-8625-c526d9a3d98a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6f0c7f86-89dc-4c83-87b4-b3f72d43ecde"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6f1070eb-51cb-4a12-8a5a-686e84fe5d88"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6f260854-dc34-4533-8125-f14e453d9c3e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6f4aa61c-d5c7-4683-a2c4-690fbc07d417"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6f6a6355-7e42-4858-9872-c6ac8a58463d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6fb813bb-bace-48fc-87d0-fc28c7271c26"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6fbf84ed-f047-4021-889f-1b657932c997"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6fc9e1ab-526e-4233-afc8-5677a9806d1e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6fe0f087-6baf-431c-ba4b-f9802664e697"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("6ff4bc4b-05b5-40b5-ab45-e16bf2bfa113"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7009907f-a6b5-4fa2-bbd3-7f53bb7983dd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("701d20b5-4916-4f06-a3b3-699abfd79109"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("703c0473-f361-47ff-815b-9ee40e4fc1f9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7041420c-d283-4e63-872d-74076537568a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("704fa66d-30b3-40f0-96e7-90387da063a9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("705f4500-e614-4334-9bbd-07595354b3ae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("706239c9-99cb-46d9-af6c-9c212f25f04e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7062fcd7-52a5-4426-a6f2-ec04fdf4069f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("708a8322-5002-43c0-aea7-c569b67e66fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("708dc28e-6e6d-478e-9b4c-a49d6c6622c4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("709146ea-5030-4a0b-860b-9e7ced1f449d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7095a3e3-f532-4089-8f1f-4846dcf3272b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("70a34b02-1fc8-4ca4-9e3a-67f39d8064dc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("70c34502-3327-4cdc-ac7f-4208401738fd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("70c3c62d-4afd-494a-933d-ac466ba5bfda"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("70c419b4-b2d1-48fa-b9ec-f6b410fc3e32"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("70c596a3-ad80-461c-9839-8ef41ef8c6ac"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("70e68923-9214-475d-ae91-ed1dcfd16557"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("711567cd-e908-410e-89f4-a9ddef4d8afb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("712e017d-0553-43ea-945a-f40af9fd9170"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("71395053-19ec-4859-8dab-01f42361d86a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7149b3a6-3886-4ee2-aac8-85cfeb0ad791"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7179998c-4d02-41f1-921b-2f623ed3fe97"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("71c138a8-4c43-4c26-aab0-b6cdf2b90375"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("71c95012-4a17-464b-b738-ce01f2cefa64"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("71e57ed1-2652-4a69-8291-c461451cdef8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("71e58a6d-9d51-4fdd-9d81-28b6b29105e6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("71f079e2-78ed-4cf0-acfd-401d7746bf2d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7212d680-34bf-4b4a-a592-d43ad6745cf9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7212df9f-2d4a-4ff8-b19f-2c9cf646132a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("72326b49-a0d4-4e21-a851-5330579471a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("72904567-185a-4696-bc9e-d96f7f518d2f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("72c30e02-c89e-4314-aefc-7660128865ab"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("72ea336c-611f-417c-b4c1-0534851fcbb5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("72eb173d-d8ab-4a13-bd3e-98724fa8d49d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("731a8622-910f-4580-b15c-befec0604e6d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("733a90bc-6a95-4cab-8771-0bec924ffd6e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("734b58c2-9630-4adc-b5d3-4a30c0829954"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7377309c-d57a-4f6c-9fcc-a4ec735ccd68"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("738c96f7-1587-4104-9132-d6676b3bab3b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("73cd3829-fd27-4da5-a7bf-a55fd5e707f5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("73d479e7-b249-4c28-b344-99b968036815"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("740c80f9-6ea0-4d74-8817-3b94785f85a5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("74369b2d-9fcd-45f2-8c41-b35395d42623"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("74494ed3-1692-46ad-9e2c-e41c78fb486c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7468a95a-d85f-4dfc-a31f-033b45f1f1b6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("747f0331-54d9-4624-a3ee-720bce5973c5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("74900c09-2c3f-4c4c-ac65-47383f19851d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("74a2a9d8-427f-4e65-95fa-c031cfaaae65"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("74b8bf60-a049-407a-b31f-b469681ff7e7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("74d96f59-1629-4da4-bd07-069d2f7865ec"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("74edcfb4-a21c-408e-a072-0a74b57e9d3c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("74f561b8-2936-4cef-ae12-655281218aac"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7522f388-80a0-4551-aba4-4207c0b05899"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("75465597-7b14-44dd-a7ae-2bad59f5dd51"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("75725042-3045-4a87-a9cd-041c36df8a39"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("757631f2-3767-4292-b919-13148022e002"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("75863eeb-95cf-4616-b34c-e981844523df"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("75c2bf54-7487-4b66-962e-3d2b7ffe1154"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("75c54823-912f-4864-961b-d334e2813268"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("75dcfd87-afa6-40fd-9f4d-08507171f8ed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("75e05081-f781-4361-b008-d55ff005b6f9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("75f6551d-d4a6-4db9-9732-344e5993e101"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7608d294-310f-45ce-8ff3-f4c82f931142"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76107d51-2967-4ac8-9e89-ef84b83fe09d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76254a47-259d-482c-89c5-0ee2172d74c7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("766733f9-b626-49fc-bc74-1e2a630a687c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7676065e-6b49-4e6e-8d80-1673ba4a9c2a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76a8be55-f675-4ef7-a5be-1ad32e9bc207"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76b052b7-2778-4b8e-bc5d-4f966a21c777"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76b2cf83-292a-4106-bfab-0ea46afb0271"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76b6b305-8aee-4cf0-8b41-348df57da80f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76c0f31b-ed60-4c64-84d0-e345208af31e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76db41d4-ca2f-44fa-ad85-1e50686d6b76"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76f20e09-5fcb-4e7f-bee3-61877f5158e4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76f24c92-0eec-41fb-8808-dbe31a169ff7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("76fe15ed-0614-4b2a-9a2e-0cbd6b3287cb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("77299625-a243-45ab-9863-1e976f4edb7f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("77b84426-d0e6-4240-9d9d-22c2b96fd0cc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("77be7d01-3338-4815-95b9-2cdcc57d86af"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("77f49145-730e-4868-83ef-1eea5acc8d97"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("78117748-e59f-4175-b17b-d1b1878d00f3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("781e6d7e-d343-4d7d-8306-a995e6f68e60"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("783b9fab-6dc2-4c0c-9881-c682a764df9d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("78434b7e-073f-43d0-b83c-6a93686d7d8a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7863af2b-d8f3-4fae-8b46-e7232144e308"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("78905f13-ed3d-4c4d-a1b0-5a504bf61662"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7891eb26-c105-4b3a-8df8-f0c7d8dc5cd0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("78ae0898-4e6a-4797-b896-fee8ebe6680a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("78c9a979-3b07-4d5a-92c2-5a71dc8221e7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("78e44518-7084-468c-97e7-1bf1a12709a1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7912caad-ebdd-44a9-abfe-d546b107c0d6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("793688f5-1003-4600-ac6a-be6830a1ffaf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7937b123-ff1c-4139-9714-d1b7b5ddd490"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7977be09-3af6-4f2c-ba0a-4e2c28ed5310"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("79b6ca9b-64a2-4f40-8ab0-f4aeb3d37a24"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("79b9283c-d891-4033-aa4c-34da98f8d15f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("79ecbd02-21c8-4af2-800f-63be33c6b8d3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("79f6a2ce-d0b5-4ffa-99a9-94ff907b434c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("79faf396-d122-4f58-b090-a18f67286e58"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7a37d7ed-e35f-459e-849e-bde73a746f8f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7a5102ad-df09-493c-a572-0249d803fb0d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7a6a8385-b32e-42fc-a17e-a67137fb0697"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7a83ac84-ee36-47f5-95d9-f00f643d6549"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7ab7e4b1-5177-42e8-a6b9-2b39f501ec05"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7ac04186-06ff-4872-a486-aef584513243"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7ac7b8ee-87b8-4a1c-9aac-805475b230c8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7af73a58-5250-4ebb-81c9-f18a23bfa543"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7afc1470-b18a-42c1-94f2-3b9ec799cea0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7afcf943-e66e-4e92-9d51-14d4bb6571d7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7b081a22-43c2-41c5-a84b-3a0d4bba7f51"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7b20bae3-f0a0-406b-9494-149fe485b322"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7b51355b-081d-4688-a6fd-69bcfbb307a6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7b80714b-26e9-4dda-b490-416122412b9b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7bc2d38a-78a6-43d6-a37e-393ce78c8d7d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7bd7af6a-6dda-418a-b107-dadb01205ca3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7c38b638-7644-4f70-b201-aac019f25be2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7c5dd6b4-ffca-45dd-8b16-4be120d285c7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7c7ca17d-79a4-4f48-97cc-024fd5b87f89"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7c8dc5ca-af9c-4d9c-90fa-a563bfbb3fd4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7c9770ea-7c82-4ec4-bba1-62e818adf64b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7c9bf8a3-5bd8-4f91-ba37-e3b25fe584b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7cdc1a5c-698f-4113-87d7-3fc07972e1c0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7d09e25a-7eaf-4778-804e-91953f89e22c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7d2584eb-ea45-472e-8d47-26fc3e13d7b7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7d26a2fa-72d8-4457-a266-7a08faee451d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7d2fa3a4-1b05-46a6-8366-e3d852cba67f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7d51d2d3-3028-4870-b7c6-4b4147210a7c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7d61a557-2d2f-429b-91f6-773196b23154"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7d9fcb5c-5b79-4ebf-9691-251fc6343740"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7df10a1d-6ac4-47b4-847d-2ef715cc9b8d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7e196d92-9c4b-41c8-9ac8-c4221de7ed45"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7e2ff257-6b6f-4fdc-8213-2cfa357befed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7e504324-0c41-4c62-90e9-93482934dc39"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7e509006-439f-49e6-a7dd-61cfb297b37f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7e542b3e-3c32-407a-8dda-c33ad181d80f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7e6609d1-40f2-4969-afb9-1140747de4b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7e87e8c4-ef78-4990-8999-aebef56e0fb9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7e8fd4b9-5984-447f-9d54-40f23b350b7d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7ead26bd-d927-4955-9eac-fc949fbc9089"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7eb3a07e-77be-4251-ac33-9ac9e3e4880c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7eb43795-3750-43b0-aa77-a8c6d5d24311"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7eb4e5ba-d3de-4f99-b0bc-f4f29cda4483"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7ec07db1-db68-4eda-bb97-02718e0cb612"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7ed77bae-689c-4d71-b483-f9df659d7f21"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7eee784b-3f90-440a-a6af-68556c7004af"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7ef44e49-e51f-4c4c-b193-6b723b12aa9f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7f0683e3-5406-499c-8f40-de92e9f99310"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7f06e2b2-7060-4e88-ae0e-d28782788de9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7f1a5070-7a04-45e7-ae35-039d313e8610"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7f403e98-058f-4748-9d69-65a873d9a67e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7f629c35-8339-4a56-972d-b5054d180cd2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7fa2175e-e6bd-4280-9caa-c5ad1e9f0d43"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7fadd438-bcd6-4fb7-bdc9-3e6b43578d00"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7fb36d74-5e69-4445-a060-2a3cb5839001"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7fbe5dcb-c381-4d41-8d1e-98ed564ce053"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("7ffe2ea0-56e2-414d-a583-21d70ab28e8e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("800a099b-18cd-4a38-a6f3-573ca7a1207a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("802d4e40-d4e3-44ae-a17b-dc01639bb980"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("802ff01b-4e82-4f91-9c4f-c19f7342893a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("807ead3c-cffb-4410-9c34-296440c93804"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("80bc6ec5-923b-4c2d-8976-5df46ea025fc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("80cd85fb-b23b-4a72-a894-c07927623d75"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("80e9524f-7b72-4fbb-a123-c35dbc2b1502"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("810fac6b-d519-40ca-8b9c-469e608e59d5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("811a6cc9-d6a0-4d82-bca7-294249e583a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("81404ea6-609c-4ea3-8095-2fd6961e0597"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("81458d9f-175a-4f6f-8264-9400cedc28cf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8176552d-0d7e-404c-b42e-a8891f95fde5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("81c45282-81e7-43bd-9b3b-879b3ef3a297"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("81d9effa-1996-4aa4-ab49-1661875a7c09"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("81e1f020-70a8-4bec-a5b1-15f798149645"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("81fa7e76-510d-4dfe-b86e-548aa128b544"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("820c30f9-3419-4431-a203-82291472d59a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("820d80c1-ff75-4914-a0be-e827165f78de"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("82639716-60f9-4668-a331-39f33b224a84"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("82a33d9a-c7b4-41b8-aae9-c420cdd3b3f6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("82a39b44-943b-4446-8d51-90cecc4d583c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("82a9743d-5670-487d-b104-959be3290c0b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("82ed7514-6fe5-4b92-89c1-76c026f85cde"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("831533a5-8975-4a1b-981f-5e8b1b902799"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("837918ca-f345-416d-8a83-96d1cc0ea1a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("838a4585-7063-4006-abe4-844c85ef3f7f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("83c74c96-6efd-4a15-abd2-9acc81e9279a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("83d4b574-4e99-4c20-9685-e8dd09a45b8b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("83dcfa21-b540-4cb0-ada1-0b57c378f7a4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("83de593b-fdbf-4dc6-b52d-b4adcc1bce36"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("83e2f315-e7f8-466f-b237-575a98afcebc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("840f13ae-94cf-4fd4-a3aa-dc53abe2b359"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8446719f-310c-4818-9b79-90bcaf70c0d3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8446ff23-2127-44c4-b678-ff73204c8cae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("844aab2e-964e-4144-979e-593d229483ee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("847aabf2-fc8a-4e8a-9541-d183d55df569"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("84819748-a576-4c11-a035-78ff7b0224c4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8489eb26-5416-41aa-bfd4-ae8623d5bfcf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("849621a4-705b-4f73-8eb9-65193744df39"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("84aff5cf-802f-43c0-8677-9f0a2dd5a663"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("84b89f88-6bd4-4914-8ece-292721c623f0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("84e1d587-76e2-474d-9b51-17cafd167332"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("84f9ac5c-1ced-4dfa-8e9c-85599704a39b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("84fc19e3-c856-4255-96c2-7960e991cf3c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("850e5b25-88cb-4318-9298-be078dd99957"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("852fcdfc-9d25-4e89-a357-abd4809355f4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("853c3d69-13aa-40a6-9496-6a4f1ce0cda8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("853fcc11-b2d0-49ab-a0be-41b59656b84e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("855e8b93-ad32-4770-837c-740bd6b6adde"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8562b57f-9a93-42a7-8936-f33e7184fc5a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("85731df0-9b3c-4285-8e86-910e6c3b39b7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("859ca597-1504-4467-8da6-8569af18ae1a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("85b01393-d613-42e3-96d2-b33544229a6f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("85beff14-afde-429c-a4c4-3d31978c8f18"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("85dafa16-3262-4873-a686-c9ae81152bfc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("861ea605-9cea-413b-aa95-b52ce11e825a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("862bf854-ac06-471e-a08c-4a3c1c85074b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("86525474-ed9c-403f-9ffa-6eaa41e184d8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8665dfc9-fc43-4835-bc6d-6aae7695598b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8678dff2-962e-4e73-b2ce-a5b6655d19d6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("868bec36-b6ac-4a4d-973c-ceb79d2a0f0d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("86a1e0b6-7df5-4c5b-aaef-6e1cc0c05231"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("86b48d98-88f3-4d9e-9f3c-a8429788898a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("86ccb6a5-4e6d-430d-85f8-5ee82b0c3181"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("871c7f14-2afe-4792-8333-dcb69c9fb38a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("87260e8a-da1b-45a8-bfcb-8c8d3de219b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("87902838-cffb-4e12-b9b4-3817e7eb814b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8797172d-03e5-4737-938f-cee3710dbca9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("87e1ecb5-d608-4271-a815-c68f6daf3a8c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("88023332-9e12-46e6-aee5-66567663d2c3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("880793f3-f7ce-4ac3-8312-398989f80cff"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8811a6de-4de1-4ae5-9e03-d2cb8001ed7a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("881a1ff1-824b-4f3a-9bbe-5b1d92359b2d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("886f5986-09fe-4664-9787-744669e51520"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("88718a70-7591-4ea5-b5fe-db15b64d84d0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("887be17a-9273-4874-924a-0d359a048267"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("88d7f11f-fda1-4d63-86ed-64700dd35c58"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8932f3b7-f844-41cd-aeeb-443a221e8a5c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("894d6e3e-5fb2-4fce-a4db-5d04162980f9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("89630fed-706c-4f92-8d53-30df488b55dd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("896e1b92-8dd3-420d-876e-18931e1d0f4e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("89942bcd-be3b-4b89-a29f-213e3b04a476"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a071b2b-9763-40c7-bb03-41947b7cc223"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a1c25ce-10c1-4801-9438-dbd977d73df2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a2eabeb-ae6e-4324-9751-00a9ebddd65d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a3a9192-836c-4c6f-a611-c74e077a8ea2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a49cee4-2b58-4da2-91e0-8c1da93808ef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a5812a3-c2a0-406a-b32d-36b7a5dd75e1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a62f2b0-0cc4-4fd4-87e0-139f6cc40ee9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a68f5f8-2fe6-4b89-8c10-4466460bf1ec"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a74b954-f470-41b3-9c45-9cc8f1668f72"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a754a6b-16a1-4768-98d1-132e07236f02"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8a941993-3634-4457-85c7-8e8ddb320b5f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8aa2a31d-271f-4da3-bff9-78d853ad15ca"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8aae6a0c-4ef3-423b-839d-b74dd49c73e8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8ade5680-bf55-457d-82fb-e0bddbf66248"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8af04c69-a01b-40fa-89c6-19c52e9fa12e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8b03b9d4-b75e-4cea-8c67-753b88d6522a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8b25c4b3-3cc1-442e-842e-5178a12b6030"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8b282c7e-cddd-4bd7-adf5-fa5f19eca90b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8b601274-2348-4b52-bfc7-56fe47a55a6c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8b9e24fa-0a51-4710-a9b5-7a433740cde7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8ba6cf29-3d02-4935-b471-1bb39ddc8c09"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c010b38-fff2-4a25-83b8-053f7325fb25"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c0adc80-b3ae-45b0-b5b8-b1d4955cd6ba"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c105e38-caad-4707-a0db-c94fe5a5ccb1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c328756-3d18-4d91-a89d-c55e94621fb3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c57a9d4-463c-4318-b458-65f0e1e2f4c7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c5e473f-0dae-434b-8e32-5464d28954f6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c68a470-d586-4f53-a941-8e609250a507"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c6bf198-1fb3-4035-b74f-a77612df44f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c71d9b1-e981-4332-be29-87377ea2cd38"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8ca877d2-34b6-4366-abd9-eadade91d943"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8cbc9287-165e-48ac-be28-4fb2e91979ae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8cbe21cf-241e-4532-a2bc-7edcb7e2b772"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8d0275a9-4c0d-48fe-9a9c-83a3cd401e51"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8d056d48-e3a1-4be2-9f51-663fbe8600a9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8d0c6f65-3c32-4b84-935a-1fb1bf053d05"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8d526c8a-5d6f-4b5c-8034-0786015d12e0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8d675c28-04ce-43a3-a46a-52a6d6a2cbdb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8d716563-f39a-44cf-b3bc-28a0fe5f810b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8dbe92a4-cb40-459d-b5b3-f6be05e352a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8dbf63ff-2a08-4c06-9c93-f9ec86443338"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8ddf795e-629a-4cc3-9c7d-200c4f753797"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8df35a5c-59d6-43a4-a362-e0e823874514"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8df5a2c9-6a4f-4c14-942c-e88614761576"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8dfb2905-ba31-40e9-ae98-f06139c0c1b1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8e00cd37-2966-4f1f-b71d-93e6e88496fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8e086dba-42b5-4e32-88f2-127146c9c3d2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8e224273-bdc2-4e69-bb16-6b3164c68130"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8e3baff1-2be0-46e8-a261-547a96aee13a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8e4d589c-5c1f-45f0-8eb2-f5150ac25167"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8e50929e-8ce7-45df-a3fb-f50c0f4634e3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8e6c042c-0824-4ab0-86a1-aac052aa8d57"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8e6c1f4d-49f9-4ae4-8432-bd79a632b8c0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8ea7cc24-6690-450d-b2d0-acb18d530d9d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8ed66a2c-db9f-4ec3-b7d6-bbf9e3759722"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8edeb496-b88b-4b31-bdb4-b5ffc6bf767c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8f30dc8b-693b-4123-a177-61c43217578e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8f4e06ee-ed4d-44f6-ba71-9732e53b2b2a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8f52ad90-7b8d-4aba-834b-22a80d5f43af"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8f67349b-397a-4bea-a9bc-f2953005554c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8fc8f3b8-937d-4e0e-ac03-bae68ca4a7fa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8fd020d0-5790-4965-b115-c0c996ed744e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8fd4c7d6-27ef-4697-893e-16bba278918d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("8fd84ea5-2bd9-4294-a6a6-58cc59b6a01c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("900326d8-3770-41c8-b15a-33b58da51fce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("900605a4-7cd3-4fe6-bec8-06356f678c2e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("90160b8e-54d5-4bea-93cb-5d9129cc435b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9020aea5-ee23-4ad7-a0eb-1561bbf95d7c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("903d5e40-9da4-4dbd-af24-4ec8d60d4357"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9062ed48-ac45-48f9-a41d-0f2ab6ce876c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9063eed0-219a-43d7-830e-7de595e46926"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9077383e-581d-4cda-bdb9-e4e6689b9a95"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("90a26585-9dd1-44b9-8e6f-219bbe1d0bda"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("90a90aef-d2fd-455a-acad-54cfe953cfb2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("90cf7554-97cb-4912-a925-eb66b38f7fef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9141c41f-1d90-4474-a1df-428bf635c765"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9145f35b-545b-4b30-bea9-196910349576"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("914a7c57-d885-473d-932b-d6418baec265"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("915d6cc2-4be4-414f-9d40-80855cc098be"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("917be108-d164-4c2c-b1e5-f9d81ed548e2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("919313c8-c1d5-4339-988b-5013e109a1e1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("919887eb-3c47-448f-8972-f85af2dc000f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("91a0752e-c042-4349-963d-ae9befb52bec"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("91a5427d-c17a-42d2-be17-409fdc5a8f39"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("91abe9ca-8882-4e5a-9c44-076544fe4112"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("91cc0fc1-efad-49c9-9174-5409de524500"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("91d0f468-de6e-47cc-94f0-f95fd463563d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("921173e7-9038-4a7f-a9e8-c7581577d8a9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9270fdb3-729e-46eb-b8fc-a09d80a7d58d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9284c1d8-f105-4149-9b43-5b067dacadc0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("92b21fda-0ff6-4d48-99f4-74ad276cd093"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("92b2fd51-9118-4fd5-8e02-1e3dedc80a4f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("92bec89e-ce5e-4f4a-869b-73b052053972"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("92d96135-e5ef-4191-a1e9-f2108534c57f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("92d9eb82-adc5-4b5c-81e4-f1a36d7b9a78"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("92dcb251-24e3-4367-ac04-a6fcafe97f4a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("92ec4bea-a568-4253-ae22-4df6b3b97463"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("92ef9cf0-1879-4150-9f20-451c705f89d2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("92fce9dc-92a8-40a5-9517-a1ced24bbdc4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("930ba253-d277-462f-8e9c-ff480bafb88b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("932db2d2-b6ce-45c5-815d-c6b239fa4f08"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9332c80c-393d-43b1-bfdd-f349db438d77"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("936488ed-4098-43b4-9272-c68dff0eece3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9370e93f-c311-46d7-8c3a-ce5b89ba9c05"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9384660e-b14f-4942-84f8-9f046fe7f149"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("93b3c51b-cb53-437d-b29a-4d340013aa45"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("93c33158-974a-4993-8e9b-5d18583e3487"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("93dc0081-e2de-4e61-adff-080f101d44de"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("93e803c1-f7c2-4c5f-8180-f0b081e663c4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("945bbf0c-4a9b-4322-9c94-a1dab1a4cbfc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("947033f3-693d-4462-ae92-0d738b6938f4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9488e80b-f0ce-40e8-b200-526f8f474401"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("949f41b2-862c-4155-a9b8-136183c07bb6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("94cfb638-cea9-4c9b-8423-8b2151f3ec4d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("94d5ccce-7b4f-4aa3-bb1d-5966131db750"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("94dd1a2f-4b57-40b8-8956-46933047f0b8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("95031240-065d-488f-aba3-7cb32addc71a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("950fe5c0-25ad-4976-b77b-09e2e2ace223"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9528ec90-3bc0-4d11-bb68-68ef062515dd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("95374729-15ea-4b73-a79e-9d4e9c918478"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("954d86d3-1b64-4003-bbc4-c5b0ebe172cf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("954e0df3-0885-4891-9c24-0bd295945dce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("956b46c8-f270-494c-922a-210bfd2ac641"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9571c5cd-bad5-4764-8dfe-a230f13c4f02"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9583b3e5-22aa-466a-b745-68d35a537732"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("95a32a47-c507-48d8-b178-bae7684bd83a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("95bdd71b-208b-43a0-b29e-9950911a4cd4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("95bf8e04-51ed-4ebc-b95c-f9fdf66addd9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9626c1ea-eb02-4420-89dc-fb65f4a18790"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("962b770c-9bbb-4566-b3f7-ff5707e631b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("962ed15f-6260-44c4-b261-26790aff7b57"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("96bb06ff-505b-4d60-b9fc-98e2ad10b043"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("970d90cc-b8f8-458d-84a2-2de17fa5a95b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("972f3aa6-eb75-447d-84ab-fd86bd28eef5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("973da691-59ec-4f48-a493-9217c5326e5e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("97447172-49c8-4985-b25d-a6e7fa12a168"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9748a2fe-5076-4307-8307-8738715b44ef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("97686f05-bb69-42b4-a2df-0e0b206b39ab"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("978bb326-1519-4f72-b276-2ab298575d41"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9799661e-c931-4ec6-bae7-dfbdc12f34ea"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("982c0803-0afb-492e-97fb-0cde898f2a59"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("983cefbc-8790-466d-9912-94e3c92291f2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("983f1db5-9fa8-4b5d-a387-b9e9fe008058"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("983f59a6-06db-4dfa-a9e5-6af32e439574"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9855cde5-a553-43fd-aa88-407ea8e3601b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("986d573f-3f2c-42ce-9559-ace5b4bd938e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9872fac0-2e50-45a4-9d8d-4696f3de1114"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("98833b3c-6aed-47b7-941b-12c18fd5b178"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("989c9646-b2f6-4889-b529-bbfd2ae82585"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("98b74e44-3d08-4f59-ab8f-bef3d594ec44"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("98d1d2e1-375e-487d-b9d0-eda0ed515b71"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("98de75ee-c14b-4cb1-8ed4-2a63c1400d23"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("98effb1f-091a-4b47-a625-6cb97cbeccab"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("98fd40cf-3da2-4441-b2b1-f5619ce65e89"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("99189bb3-852b-4d08-aad2-42887e642b51"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("99486ad8-4284-4aa9-92b0-56ad3c5c6549"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("994f927d-864e-45a6-972e-ceaa65e69e73"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("996137b6-892a-4e0a-987f-2d97d67ed9dd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("996c1c65-bb6c-4ad6-909f-4f59db516bc7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("998a7fe2-1905-4d9a-8f2c-d6404c50e174"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("99969ee3-108f-454a-a1ee-042c2d657d33"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("99b27443-60a7-4e7b-93f4-44d0a7a19ca7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("99cd4907-6e77-4bcf-a731-cf0264115bc3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("99ee33eb-8fcd-4854-b1c7-4b7cd65cf8ef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("99f5074b-f88c-46df-ac7b-0e5048a2b2e0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9a205d0a-d51a-431e-a82f-dfa508f1f9fd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9a53ea32-bfe1-4cfa-acc7-532687621c53"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9a74faaf-1aba-4a31-b15e-e84a1baa0bcd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9a797d5b-afa3-426e-a213-2b6959e60efc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9a8003f8-6a77-4239-b7bc-5245dcd384ee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9aa93401-909b-49b7-bd06-77953ad870b6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9aaa9d7d-d989-4ff9-a8e8-8daa676b3ac9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ab07759-0228-4ebb-a3d9-150e0ce560ad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ac148fd-cc0a-4654-a0ff-35104f898457"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ac4fbe5-876e-4958-97d7-5dab94b48052"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ad70e60-6c5e-40c0-9229-d16b865b8806"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ada7b1c-a660-4636-9af8-0583655f3be9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9b0cb0d6-3f21-4eaf-ae62-d050e071a024"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9b66ea3e-3e8f-4083-8120-06b1b33bf3bc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9bb64927-876d-446a-a7d5-762b1406934d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9bbe4333-bafe-48a4-afc2-ac28c56eb694"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9bc51694-7d50-4266-82e0-e3050d4ab8dc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9bcc0737-4c63-44b3-8854-1d6a926af1a1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9be64d9f-0f43-4e7d-98f9-a6ba0315797e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9bf312b2-7864-4b2d-9578-7609629adc58"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9c0bd3c6-ff83-4a4b-b25a-f95df8776c80"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9c6e43d3-80c5-4df2-86c0-fe908a205904"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9c72d668-15f2-439c-8c68-8fc5da6095e1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9c8e4e39-fd86-4410-b46e-cc6a15a243b7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9c920f7e-a517-4e4a-9f60-32d30b428926"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9c96e519-13a5-4ff4-84aa-f958269f0b8b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ca695a1-114c-43fc-b9ea-25bb9f2373ed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9cac42fb-46ea-42ea-9c2b-1afb21782585"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9cbbb04b-4690-4764-8c31-f03a980ed3ea"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9cc4d748-6902-498a-8cd6-05b79defd292"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ce252d6-73a8-4dc0-beaf-8abdf6f9815a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ce44592-d064-4851-bc69-6d066a991389"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9cf53a13-3f2d-4f3a-9d34-6d86cd012fef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9cfc4dac-be0d-4e24-85de-9f9d95c87a6f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9d01da8a-30de-4a72-be5a-e1519d7eaa97"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9d2d2ace-f74f-430a-b74a-1a024efa401e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9d543e57-9a64-42b4-bb16-7fd00c9dc4b6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9dea8960-e731-49c2-9b4b-ef34f508d393"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9e54cdff-4e51-4415-95b5-3bdc9bd6169e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9e56d66e-723d-4a0b-944b-134e3d171603"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9e66098c-3ead-4f64-8a38-ac5db0b90260"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9eba4692-c766-485a-9c45-58ab37abb4c4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ec738c9-1258-4b88-a550-9c683a78d08b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ecc69f3-5e30-4db4-b676-cc0ef5f59733"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9eda237c-f116-411f-a803-3db5f51472bc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ede86e8-29d1-4524-8db6-2edd0ec39945"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ee01b02-f38a-4487-a65e-cb9032168bb8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9eef6ba6-8ca7-4b91-b76d-4c6f22bf9de1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f07a59a-eedd-467a-acee-1c6cc7fb42c3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f0a38dd-dfa6-4bfe-960b-0c72dfaf6091"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f2fdb64-3cf6-404f-9c40-1e2894bec6b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f33de00-81c2-4fe3-9059-f20559fe46b9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f39082c-79b5-4b98-b050-fc921288ea79"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f3b0ae4-becd-4cec-86cf-7646579b1a7f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f3e6626-c161-4829-9d65-4da8943028d2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f4037ac-cee6-4aaf-aa56-bd0044e40083"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f47cb08-53bb-41d8-999c-cebba03276ad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f54e760-371a-41a0-9bae-f4fa87f8eac3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f6370b7-4006-4463-934e-1b68273dbe99"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f82678d-cac8-434f-942b-b7b2db2f8ef1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f89a24a-388c-4eec-9c00-39ea17e5c5de"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f941614-c246-40e9-aad7-df654eb7e59b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9f9cd531-22ee-431e-b365-42e2d366eee0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("9fdd4856-11d2-45e2-9be2-e6abd227430f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a013f4c3-4301-4e0e-86c2-bafd226a7d0f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a01a2c6a-c3ea-4deb-aedb-0e85bc67fd9b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a04056b6-c19d-46cb-bb91-d7eadecfdff8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a042694c-7c24-49b5-bff6-c402604dca0c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a04a5a88-13d2-4f1e-ba7c-4c8563d58f51"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a065ee9a-e9a1-429f-95ce-2aa39ecf5325"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a073a379-a3d4-45c4-8540-6990c134d753"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a0b63a73-9c73-43d4-adcb-17e4bc7473d6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a0f1ebd2-d2a1-4b88-9c5c-0f30fab47b36"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a0fe104b-6544-4d38-bb7f-ec0a55b39c69"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a1041371-7ebf-487e-83e3-474956f28618"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a104c68d-4104-4125-ba6d-6ac9b0b8d859"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a104ef7d-e572-48d2-aa61-25b19d8ac5ab"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a114850c-4eeb-4249-bac1-d630b994f461"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a1599cc7-3398-4f9b-9590-465baeb877be"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a17b72b9-aa6b-4bfc-9c0a-a666adffdd13"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a17c1385-1b6d-47bd-85d9-ae0be38b685e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a1bbe6b7-af57-4f7f-ba6c-ba0d636d9192"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a1d30817-3302-4a05-a033-e3254606799a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a1d44253-14a5-41e2-ba1b-de6dcb2cbffd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a1e0ce84-c784-46bb-a18e-d4564b8e6b04"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a1f3c2d1-c558-423d-b499-10403ba68b54"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a229d19a-88d6-41f8-9787-c87d3e0999d1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a2335a46-3101-44bd-90f9-19696f3fb75b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a2375a14-7214-451d-b46c-921e00b7e62e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a262e29e-5996-4d70-9578-40e5a7f069b8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a2ab71a9-0958-408f-aaef-047e1acd1c3f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a2bef0e3-b7c8-48c0-ace8-30b82faa467e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a2d11284-f2f8-4aee-af79-87c30eb60d1b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a2ef58d3-eac0-4302-ad1c-c2658feeedde"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a3074f62-fc1d-40ed-8af6-bbc9894c6dd9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a30e30b0-b4b8-49cd-9aea-e93447e8c520"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a3327b74-e65e-4576-8300-3838786900a1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a342696e-0792-462b-b1c0-374d2aadb592"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a34dce6f-1670-4b38-b574-c012c7c2f581"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a34f8f00-b7e6-48d2-a428-d9310e6dd0ee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a35af192-e459-40ac-b922-451aab1cf7e5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a35ec934-228a-4cfb-938a-48ff2d67be26"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a3f911e4-d507-49e8-a5f6-72c4a8599aae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a3fdabc0-ac95-4cf0-b8e6-7016e258f365"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a40ddb0b-e489-40f1-a6df-a73f61ab983f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a439b6e7-a24c-4903-b1f9-2b72c1123b2a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a456b8fd-293e-48a0-9496-ba978ce68abf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a4700b58-7dff-4cca-822c-4c24f7374dd2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a4718610-a062-4b97-ada0-40a612608bb9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a4a070be-90c5-42f5-bbba-b90fbe77e2b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a4d41f62-7451-4f75-9806-df86d623bb19"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a4df1525-f89c-4d35-b96f-764bcd53aa87"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a4f6d755-ad2c-4aae-8887-7c5b04869a0d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a4f9df16-84dc-4088-b428-689012d828d6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a51ad70a-3ca5-40b6-93cc-79f35b09a4b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a552f2eb-1416-42fa-b41b-d1396f551e81"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a581f90a-773f-4c68-ba01-fe4d85ca004a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a5b0ce48-8c47-4dfa-bba3-be84267d43b1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a5d5ed26-0b26-4c24-91fd-ec6185493486"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a5df84fa-74a9-49d6-bb2d-a43a0c9a26cd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a5eb6ecc-77ca-45d3-ac60-30364c414108"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a5f72d85-5cf3-4116-9144-d1dc7b3cd539"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a636abc4-d739-4c4e-bdf9-624650864dc2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a65fcaed-39ea-4044-9a7a-998621584cae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a6c68cd8-3932-4d0c-8d25-6d17e06a4f0b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a7122385-469a-49a5-8500-3048b5f8267f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a7366b19-d04f-4d00-a80e-3ca8a18f1611"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a7462353-2699-445b-8fda-35436cbb3516"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a74c867d-683f-44aa-9270-18cfdd669669"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a7603512-6e27-4eb5-9e1a-7466501d25fd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a7971bb2-ce60-4084-935b-a039ba4972c1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a7a3abf9-946d-4691-bdb0-3c03e32a3073"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a7c51cd5-0dff-45d3-8bd5-b5d51b06545b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a817e7a2-603f-4567-b5b3-56a6e3aa3452"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a8511c32-1364-46c1-8fe1-030523a3fdb1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a87cd9a7-2d06-4ed4-9d17-a9be8bd124ea"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a88c9f0a-4d02-4188-9104-b108a19ccc99"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a8bf77ee-2e59-4c45-a923-35d186ee02d5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a8cd5325-c2d4-4a1d-8167-307295650b7e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a8e8dd65-23c1-4f8c-9fa0-1ee7583c6400"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a8f03ae1-0952-4fd5-9556-60ad9957cf54"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a9010d0f-87e5-4acf-bc9e-a04c8394fd45"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a911b542-d148-40ff-860f-ad4bf913911f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a93d8edd-7723-4d43-b713-a13cab6e54b2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a94ce79f-29f3-4931-b56c-0ab06414333a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a94d1bd8-8655-4f92-99fb-5c3f04ea7398"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a958ce7a-d801-4138-8f06-ab920b023e98"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a9812387-a24b-4199-98db-bc83e539f028"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a9871ed8-8ae6-48d2-b510-958d851a3672"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a989bf1b-83dc-4041-9de2-3ee230576943"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a99464b4-a16a-41a8-ace4-ff13f30268b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a9d9390d-8e81-4a90-beeb-dc0727a4d625"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a9db729a-7c34-45cc-a056-72ac23d2e1b1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a9dcf548-8c40-4b81-960a-19f4acb96c6c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("a9f90898-1fad-4d65-a130-e753a2e03d39"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aa19d0ab-f05f-4f4e-804e-3ece4afbbb17"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aa5c050a-166e-4cc8-a328-fe337d9445a6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aa5d2ba1-b62d-47d8-8752-e320ee9c7dc5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aa638eca-53c2-41cf-bb69-7d3e794c7285"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aa76cc1e-c853-458b-8afa-f421a4b85126"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aa7c3b9b-7fc3-411b-9806-87925ae71fb2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aad7ec51-d15a-4e2e-81c3-e473135c594b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ab019500-fde7-453d-8970-2702ef5dea21"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ab15e1e9-29cf-499b-a14e-bf73b5de6b1d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ab49ae69-bf6f-46e3-9428-347109372cbb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ab881637-e91c-4000-8ef7-ce7e31e6dc8b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ab8cdf90-1bbe-4a2c-9279-55863ebe4f7e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ab981bff-f79f-4fce-93e1-164a6f2ae74e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("abc552c2-7705-452b-a14b-0640629f64a1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("abcfff00-f800-44b5-8e5e-fe29d30d35eb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("abd3a85f-8c2d-4020-a9cd-73af0b96c0e4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("abf9816a-e6ae-471f-b95c-a54b23ebe999"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ac15aacb-6e07-4f93-8cf3-c7ad13f9d5fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ac234845-2fd3-485a-b3f0-5953333d26c8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ac454ace-5354-4b34-8411-415c92fa08d9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ac754c89-a8f1-4ae1-9138-b14c006568bd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ac8f9226-30a6-4abc-bd34-07160610fddf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("acba4ee6-b91d-4a76-a4ec-609addf2a029"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("acf6b72d-e6b2-4aa2-9336-45daf221c970"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ad0785c0-ff8a-4949-8226-5d75ca0d3d0c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ad10e0f6-5687-4b9a-ad2b-eb38c86902f4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ad14af31-547d-400a-8bf9-30c10341e0d3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ad1f0263-7db9-41ef-8005-a9bf6e376755"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ad3e061c-1d23-4fe6-9dda-9dcb11176dd3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ad3eb053-e496-40eb-842f-276ff4d59033"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ad52b8fe-2029-4bc8-bf55-495ff42b2dee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ad9bb07c-aea3-4911-8b40-c93469178916"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("adadcd5e-3747-46c7-9f58-45e295e6e5be"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae0b481b-09c0-4ecf-9079-9feec18c3f19"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae10d0f9-22e0-402d-80bf-06a0b18be14f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae3939ac-045b-4537-ba76-b5b4bf41a5ab"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae3b5ef5-cbff-415c-848e-47ebd9e98a05"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae4f2993-4027-41c5-8cd5-074eba80a733"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae584a76-e447-413d-9e0e-48fcb1d255af"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae8caf88-edc4-48ae-8f64-8f2724535b23"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae9a1f1b-9fdc-45a9-8190-01ff658dedee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae9d9779-263c-42cd-b1d9-77c8e25e09ca"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aea8c3a3-79e6-4793-ba53-3ed4da8a172b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aeafd791-f0bd-400f-9afb-99cdabd3be9b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aebd6c0a-ec2d-4210-b5e3-d7c29d3dbaee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aed12965-013e-4137-9ee9-f83be09cd64a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aee5e706-3aaf-42df-b6d5-a59fb73a9ff5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("aefe7cb5-86dd-4d9a-acbc-13837e56971e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("af69ba19-d8b8-4e08-9333-bf54644dd8d8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("af91b65f-d6a0-4e28-a63e-2993e3554ea9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("afb4c23d-6fb9-4789-b6be-33c49b9f4fd5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("afca41d1-ee5e-48e2-b499-ba7679538848"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("afd3c81d-6b3d-48f6-a899-44e23ed28988"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b00ff22d-00ff-47a3-929d-5ac5a87a225c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b0169e51-67be-4861-905a-b5c604ef9059"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b02c08ed-1022-4fb6-8214-22c5beb74adb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b04438d8-0498-4b25-852c-a75382021c8b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b07d6952-81cf-4404-9d17-1d2cef1d2c3c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b08407d5-3685-4b29-bffa-687bbd0c035e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b09eee37-233b-4bfe-b27f-7f007f630163"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b151b79e-4901-497b-a08e-c5d4ff655fc9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b1737833-f6ba-4e20-aaae-a63ff4762484"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b195e22a-7cf6-4069-9cbe-6b0dad324cc4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b1c33313-8e8c-4d47-80fc-fec4cc2dc361"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b1e13ea2-1321-4187-9c73-192920d3ad11"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b2460ecc-0354-4ef0-ba64-af51cd7c6345"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b25c4b9e-023a-48e4-a6eb-50966aca3882"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b25de65a-f5b8-4fb8-91af-671cc0801fd8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b27748f8-485d-46b3-9ccb-8f7204256474"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b2adff06-24bb-458b-a1c7-f6fe82c4be6a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b2c2f786-66f0-4abb-8996-0f721d86219d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b2c7bd09-ac5d-4bf0-a2e0-471727490e39"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b2dd84f5-582a-467a-bbd6-5a5ed52558cf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b31cfe76-7f12-49fb-9653-c9910b1738cd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b322fdde-9601-4ea2-99c0-9d2ad1d4a19d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b3301042-2883-468c-b0a0-6a0ef61f71b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b334db4f-925a-44db-a0b6-91bae98db2b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b3645af7-ec11-4a87-9d7a-e5ee842b3b3c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b369c7bb-b414-4ea3-a399-74c6c100763c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b371b5e0-6fc0-459e-bd5a-d3d350a1e6b7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b3a24793-ac43-4f2d-96f5-8302eb2d53f4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b3a795bd-a77b-4546-a545-ed5d78a06f31"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b3c2d6cf-af08-491c-8661-a9ef607f2a6d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b3e6c04f-f3ae-4c20-b2b0-f5d54d1ea43b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b3ef802c-ed72-4e74-b3c6-b758a56eb699"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b40a5bff-9d73-4a16-a4ac-54b41449bce2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b414d14d-dedf-4638-ac40-f614be044daa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b4174cde-da76-42a1-86e4-bad31cae7e0b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b43d604b-ca0f-4701-83c7-3e1efe8815f4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b455dbb8-a404-4daf-9708-47c531bf610c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b4727e1e-5106-46ba-94b7-e3de099a4174"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b482b6cd-b3e9-4ef9-9243-35f9518a66dc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b4838edb-a293-4a76-9ee3-e9b01706e19f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b485c765-ccca-4d23-9f8c-d045611a1b0d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b498ef2c-2468-41da-b6cd-b8c4ff012acc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b49a7d5d-bc40-4e18-8d79-80aed2bd20c7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b4b4eb74-301f-4a53-ab5f-9781405410f8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b4ccb57b-f35c-480d-a23c-7dc3bbe4554a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b4e85c1e-4160-4c27-bb65-cf78c0f0cb69"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b4ebcd22-a423-4a5e-a186-3a45bdd7ced8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b4f4d3dd-d7e9-4232-b0b9-248dd92f93ce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b50fda1e-3be5-4ab4-b48f-c61418df9c91"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b522db4c-8654-4186-9424-9867f7bcb3c9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b55ba633-8c01-4767-8d0b-873072438774"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b5a32cb9-b0a2-4101-8a74-8bc300405d85"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b5b83ba7-3dd6-4fe9-8d33-2923205a36f8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b5c5721b-9eec-43d8-a4a0-6334ffacb22b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b5deb319-9c64-47e5-b81d-dd19f4aa9bd2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b5e55ad5-6851-416c-8779-aba54af8ae56"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b5ec25d7-7dba-449d-bda8-145cb7e10074"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b5ffafa8-de11-45e6-9201-70f11711506d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b6595fba-3032-4341-87e9-aa6a49892e5b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b66e3880-7000-4e8d-9321-3d5ea67d8031"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b68e306c-6fbc-4b9d-99fe-32ef0abdde85"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b6a663ac-68e5-455f-990a-55938e3c555b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b6ab87ca-de8a-4ce7-8473-a8dc24b42e8b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b6c4fa9c-2179-499f-a7e7-22fbd3cd4b4e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b6c60217-8cb5-435b-9d21-19e79d847feb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b6c9ff2c-7aaf-4b89-9eda-66efc13e6c64"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b6d12aed-f40c-420c-8c8a-c180ffa86b50"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b6f27c86-e202-4b3f-aaa8-e6f269d43641"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b70d66d4-25aa-4455-9459-7645913fcb90"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b71db00c-f4ee-4637-a23f-9dc613cff7b6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b71e8d66-f169-49ca-b017-a060c7bdc9fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b72a33e2-e966-45c4-9c21-5fbd641fd23e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b7593cad-af3d-4454-867d-4678c13c085f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b776446a-b6e3-4495-8d06-5ee50e3428a5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b78898d4-6c3c-4bf5-af1d-5b1af9c769c5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b7a97c15-c4a4-4565-8fae-e5cb30c015a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b7b3aa99-64ea-4408-abbc-3d3e3f194dd5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b7bb33b5-ffc4-404b-9e4e-8086b428318c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b7ce8065-c6c8-4bac-b5c8-3e5be7905bbe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b7f14152-ba77-4772-bfdb-5cb06de7fcb0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b7fadc2d-47a5-4931-a85b-48dabb1490b2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b810ca28-0766-4c85-8114-81c151e9bfaa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b82f5ceb-494e-494b-a866-4c05bc586139"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b83863b1-ad38-43af-a12c-ed3e4b5fbc5e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b86b85d7-97e4-48a4-b3e0-1b02401f5330"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b87d5098-1551-43c2-bb73-34a1824436b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b87ec41e-d8d4-40f3-aef4-dcfadfead9eb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b8813cb3-e5c6-4986-8c98-fcf8f4bc126f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b88fe674-e471-48a0-b690-f90eb6fef3c9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b895b322-c8cb-4312-9837-187083fbd3b9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b8af057e-c9db-4240-ad19-91aa2f0eb1bd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b8b3ece2-d081-4d86-8cbd-1fa7c3235c61"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b8b59117-8921-42ae-a1c3-ef2bd16c8b31"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b90ae148-3ad3-4239-a2e5-27911924f109"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b913dae7-9a61-41ee-b8eb-d9c2a080696a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b949ab13-74c2-4326-a63e-a55e3435177e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b9b8cee8-1584-48ce-b8f6-4ebf4bf9bd32"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b9bacbce-a473-429c-9868-90bf092b21fd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("b9bf97c2-ec4a-46c0-a26e-cf6ea4e7eb39"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ba30e3ee-08a0-4ce8-8144-6cd321d6d093"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ba3b30b9-7cc3-412b-b379-c90e2fc7c303"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ba3cd572-f261-40b7-9922-4d150d696487"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ba4cf191-0974-45e2-8438-7f05e81e8f76"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ba5ee87e-6b47-4d85-a103-175d2b5a79b9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bab0fdf8-2338-4d4f-88e6-56ce73a663bc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("babb9f81-6378-4458-bf8e-db436e04d4fa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bac874a7-16b3-4b84-82ba-ceef2fb529f5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bad5b8e6-f0f7-47f7-97a6-77bcf2e2111c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("baff93a6-af7e-4308-b6ad-76355d2160bd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bb02aaff-cfae-4626-a72c-3f649bf13b22"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bb1e8407-68c9-4aa9-adf1-4b0ab6ce9c19"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bb409a86-6c80-454b-8264-a84b9e70b77d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bb78bbcc-feb7-41a7-8e45-acb1bf332df7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bba23fec-8ecd-4f92-8da2-bf140ea2319b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bbb66cf0-7942-4afa-8f9e-a97edb8d75d2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bbebb884-f2d9-4348-9542-93c6de4819cf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bc2d3028-46ff-44c3-9c1e-d5d67ff730c8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bc3e87e3-937e-47fe-b5c2-07705cbf289a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bc5fede4-800d-4e06-b30d-a8952b64768c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bc7136a3-e4f3-4984-9d43-31f6464ec9cf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bc79e05e-12db-4c50-8c2d-65f4892d35d7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bc85996e-ca39-418f-8bb3-4ce38f35447f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bc9a5292-d970-47e7-9058-6a8d8efe516b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bc9e1cb8-3b23-4563-ab18-dd5fafd36601"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bcb0a7c6-9bf0-4183-92dd-335fdc95484e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bcb1bc34-67a9-4277-a882-d3e33ee3922c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bcc2f55b-3375-41ca-afa4-896039d2e09c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bcf48e23-405d-4ea6-bde2-a2cb7e6f9361"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bd1b1fbc-fee5-4317-b922-0b720a0f7304"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bd224469-4680-42a3-9470-ccea58351f32"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bd3cb8b0-ab94-4533-96ea-4ff02538732a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bd526949-34cb-44e7-8a85-97d0f78d056d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bdbb130f-5183-442f-a83b-0e7369582082"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bdcfe13c-addf-4c09-9a8e-564e3f96e377"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bdded447-4eca-4ac8-862c-6bdcfe3f43e2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bdf302e7-d137-45d0-8c14-b2e9e969b592"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("be3acb71-6168-4069-b57e-18cc11b6af2f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("be426e0b-041d-433a-8c97-0260cc3c6ce9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("be4a5db6-704e-4b68-81d5-b503b4647e68"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("be7d03c9-1b87-4991-9950-5661645a0e24"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("be9fbb7c-4a09-43d5-b179-515a4566a792"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bea4a18b-e475-4992-b95e-cf82a2b10543"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bec466ae-884e-4db4-bbeb-a533d3719ef3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("beebc1ee-59e4-409b-9e52-dbcb264feefe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("befa767d-b529-4070-9d76-cd474e582226"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf0724d9-1723-45c1-b66e-1100418cf4e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf0e297a-a04f-4929-85e7-789c4ee4ccb8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf2999e4-a826-4584-b111-4390ed08b099"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf3365dd-2dc0-4733-b2a2-0958033d21a9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf342526-7918-4434-8385-f8ecfd6c5f6c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf342c6b-2df4-4912-9adf-837aedcc416f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf4b5e96-6ee4-4702-9a33-9bcc7cedfa4b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf5ad3b9-6bdd-46b6-bcd9-b09e06cb99b2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf7fb57b-fc53-442e-a91c-8c878ff58d4c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf826ef4-92b9-449c-a4d5-bea05aaecd13"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bf94cab2-5f38-4e98-ac53-a3e861fc62dc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bfc45a01-2d1b-4024-8994-5f6ae720f25a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bfc6d27a-f990-4edd-8883-8868b84480f6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("bffa9500-55d3-4d6a-af0e-bbc6d23f3902"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c01a65b9-a0f0-4522-be89-b02161db7850"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c027744f-c469-4058-884f-af761b811cff"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c047523b-f35d-49f4-b5a4-e2b9fa77aa3b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c05abaec-faba-41a2-ab6a-998f173cc9ad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c0782b15-dfa1-4003-8d55-169c6edf6eb6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c0a0c79c-08b9-4c2a-a5fb-7238a88e9120"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c0b0217b-903f-44b5-b4ce-ee67248a3580"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c0bb788b-b1c3-4739-8091-909099e58463"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c0eb365a-c88a-4ffc-ab6a-8ceaccfe2910"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c0fdabbc-0db8-41ba-9893-5521cde2a492"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c10b535a-2d9a-4f27-8524-547f2e164a31"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c150d8f5-897b-4c29-9a33-3ff436337fee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c178d6ec-33ef-475f-b210-8de8229e70ce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c1916274-6700-4c9a-bef3-75da72fa93b1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c1b22814-b2d7-4ed9-82a7-e9f7f4e0fe6a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c1e1e180-4081-49c6-a09b-7f6b903bd977"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c1f3560d-3ee0-4721-b249-f7103209da02"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c204cd83-1992-45f5-8dcb-f5092a35b916"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c2059c30-a8c5-4dd5-a39a-bd4a21b834ef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c2062890-198e-4306-af60-b0e32f77336f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c2142ceb-cb3f-42e8-aa6d-0425889759df"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c225840d-47ff-43d1-960c-3f0f5aca0c15"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c264284a-41f0-4c22-8cb8-3ee0c72b0ca4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c297700a-2d86-4c62-af51-447407727c69"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c29c72e4-17e3-4fc7-bbab-4663137441aa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c29e4818-f692-46f5-bc6d-72dd890a9481"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c2ae484b-879e-4470-8952-0a2471ac226e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c2afdb30-1e71-4158-b414-aea8ff7dc2e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c2cb8b37-ba9f-481b-a54a-2ec8d5bdb795"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c2efad17-5c5d-4de4-a85c-c42be7802f2d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c2f61eb6-d6ac-4124-b1a3-44942983024d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c30b4e52-e4e7-483b-bea3-688c0cedfa7a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c30f259e-a2a6-4406-902c-484eec3db0d1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c31050e5-d253-409a-a0f8-ab35fdbb7029"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c34ff5b6-eca0-4336-bc4d-270883d9d423"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c380103f-fb71-4197-bf6f-53004c9d8c65"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c3ca4946-e3af-4b37-97a1-bc2d812a1354"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c46a865b-060e-4c36-84ab-3a596853e9c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c478dfb1-2f12-4757-9b2c-a705eb4481ae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c4e8c84d-20c8-4066-9e56-e79aedbf2c33"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c5226f5b-d25a-4af0-8648-1cb38c61ce81"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c53dcc3e-c0fa-4b2b-a2dc-04d93f2f6e23"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c5610f2d-e661-4c58-9d52-5e6cf7461e74"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c573b773-7b10-4495-a7fb-05c98adb96a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c58596f2-6a05-4728-b542-0a9656c0ff6f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c5983220-74a3-4602-9bb2-174808bb1f3c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c5a36fc5-2ed1-4d97-b0e9-efcd8445a673"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c5a5d794-7d4b-490b-ac03-c7124bd50fb0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c5b6f03c-25b3-4945-bb6e-3828f3bbec9f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c5becb87-f94b-452b-954e-7413a2cd602c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c5fb09bd-01c0-4e46-9df8-3da6e342fdd8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c5fe9a2b-f4d6-4e6b-8cc3-879e1264d7c3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c611c586-cf4d-489a-b450-79fdf3a75a20"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c62b6a20-bce3-44a1-bb52-6a9b95f82f1a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c65646ab-b31c-4445-a596-e07e6fe9d530"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c680b667-cac9-498a-b053-c99f6e3895b8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c6acef4b-45ef-4332-9f63-9fcb8527a51e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c6d86478-9d09-46c9-9bc3-7840f94d08a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c725e20f-3073-495f-a0a4-af920ce5e8b7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c73aca3a-401a-4998-b946-0a5c3b8322bc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c74609cb-4bc1-4104-8110-297b14f9221c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c77edd9f-c97a-4450-8255-cd531dbefe03"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c7818484-6a45-4e4c-bd4f-b3ba48088cda"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c7dff3e7-ed57-498d-aee2-fe2c020ca3a0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c7e1f089-71ce-48e4-8fe8-12bc85a3a5bd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c7fc240c-de4e-4494-8c9f-f0f0d6ad7a7b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c8086921-8341-4c16-8080-33895ebe7387"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c83bfb96-4a1f-456f-b88d-e45e3869367d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c845ab6e-ae2b-49fb-a63e-b1b0e74af72a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c87005fc-995a-41f3-80be-ac9ce41fe62b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c87939f4-0837-43e3-9800-aae1ff053521"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c885a20c-5ed0-480a-a991-f67b6c3e5341"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c88e474e-d282-4d92-9506-aaca9a804386"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c8b6b7d9-29ae-43e8-8e5b-1498efebe9c5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c8feec1b-4265-486e-a413-9436e4a1b06b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c911f9b5-963d-45fd-b01e-9bc5abec7682"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9236136-8eaa-4015-b615-6cfb8c41e06e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c92c8b22-0d75-42d1-8136-e6ad962cd097"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c934c419-a833-4490-a7d0-61a791155a14"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9781e37-9db1-4199-a4de-db5e0f916b20"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9ad191b-be99-4a4e-be0c-713047f372d3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9bf1063-8746-4d40-85c6-00d6464e980b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9c39661-857c-441c-9465-da6cea5982c1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9c575a2-03ab-4902-8707-5f163894ad99"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9d6420e-b4c6-4f17-bba0-c7ec02411921"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9e34314-02bd-4e5c-9a21-c7db0a074775"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9eaef61-6ee5-4736-a9c7-452c8f667b31"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9f61ddb-0439-47aa-ae6c-f5450bb89a04"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("c9ffeb1f-3ae4-457f-bedc-15b6d1adaa6d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ca13e272-a99d-40fe-af53-8603d08487f1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ca1fbf01-8940-4437-93f7-98be96e70051"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ca5a47a1-4d07-488a-879c-42a741875acc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ca6384fe-e669-479f-8384-520712916c52"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ca7a92d5-7235-4f42-ac94-744351831810"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ca7ce328-5bf7-4311-a442-cbd79d678bd5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ca8d14fa-5058-432b-a811-db31a5aa6565"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("caa1a469-a588-4a20-ad6d-ce30b8f1962f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cab0ec64-b8ef-464a-bc6f-6ca28f6cae5f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cac74485-8aed-445b-b699-834c2e2212ed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cacfea32-0ca5-472a-bba8-f7e490f96b79"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cad141a6-5c7e-41f7-8f87-50a4f2cd78d1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cae565b0-2f50-4071-b9d2-5475fc75610d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cae9c990-2f26-4554-9f90-40abc0eff87f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("caef84c9-b2b0-4461-9c14-fe85e571173e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cb0d6035-7843-47f9-91b9-35c39590a626"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cb0e44b4-ccf0-4763-b461-7215d27c2746"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cb1c6f76-a776-41e0-973c-6b067f5dc56e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cb523118-008a-4f82-b38e-1f8e0db05c11"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cb570d0e-a5e5-42f3-8417-d27a4aa7a071"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cb598c19-575f-44d9-9595-5dd3cd390644"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cb6e6c35-3ea0-4862-8b6e-68f44ca9b82c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cb853f53-fcae-48dc-8c54-40f6155085af"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cb8ecb34-d569-47de-840f-1d887d888941"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cbb9bb7b-07a7-44f1-9722-d78e9ddbb3f0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cbd194a7-7b02-4bb5-9090-fae579040e94"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cc39a2e7-a90c-4668-b460-d34ca49f2b5f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cc55362c-a58e-41be-87ae-b237e6a4fcac"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ccabf5e7-1f35-4436-8f2c-48ecec247823"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ccb5eb74-6750-4292-a14a-074c4fb4cdbe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ccc25b82-8899-4a9e-a108-bb840ae1ccaa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ccdfc905-781d-4ad3-96c9-3c53c6fdd262"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ccea27e8-fae3-41f0-9685-324b051a9eb5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ccea9df4-977c-429b-8fe3-1fa619cb8389"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cd1d729d-ac60-4289-a982-4ec1a080058f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cd33697f-95ca-43ec-af3c-897ddb0b52da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cd3d0131-525b-4e5b-9405-e2243d65558e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cd50787d-aa01-477b-984f-433009b122d0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cd5080ab-3691-4c79-8423-1ecf6a42e69e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cd551efd-ba7a-475d-abff-8f4a0a27ba73"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cdd50b54-f2d9-49a8-8be0-4d164db02a9b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cdebbb1d-5607-40c8-9b59-78730c15c9cc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cdf9a7f2-189a-40e2-9b26-291ba0911a79"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cdfc8878-0995-471c-94ae-2990451949fc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ce1627a9-7d75-433c-95a3-45309ea2cf4e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ce1f7a63-a32b-49b2-9594-4910367bc32c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ce23e99c-bb2a-40eb-b458-a8d6c13b5556"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ce3f1b64-2267-4511-a5fb-b43980db724a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ce476c67-0779-42be-a6fa-35f9406ff6e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ce5f237e-3207-4bd5-bb17-d157e2af9f0e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ce71a369-b343-4a98-9609-21eab0254c9f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ce741659-47ca-43e6-b3d8-87689d710aec"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ce877397-45ca-408a-ba78-486fd336a2a3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ced9f2f6-251a-4613-af9b-8e77b60da898"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ceeb6a4f-51a1-47aa-8775-86ca07574d82"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cef8851d-9924-4018-a917-a486f89cac63"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cf49fa48-b990-4456-8d6f-ce0fba7cda15"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cf4df162-2fa7-4427-bce6-10bbace4e6d6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cf7486f0-ff53-4653-b16c-cbf12465caad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cf94850f-9514-4a23-860b-b6fb718dbaea"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cf9b7f8b-ad52-4594-a009-0b65f31e604d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cfabde67-b98f-45cb-a9cf-3cc24479540e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cfcae32d-ce59-49af-b6ab-266fcaef2a83"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("cff95efd-9fd2-4188-8b1e-0112798648ea"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d0000118-f4d4-47cb-830e-8ce65365def4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d008a234-4e12-4abd-b739-0bf16a3a7fb1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d01bd535-02d3-4bc4-a5ef-16494e769b53"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d0a0bba5-9faa-4304-9b27-a37b33e6369f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d0b97ab7-223c-40d8-976f-0ed42fb0e655"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d0c50ff5-1ca2-44be-9ff5-2938017059b6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d0c97ef6-6ecd-4917-b968-41ddb5f96d6c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d0cb45f2-92b7-47a7-b21b-0c880b47c97b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d0d22a29-c27c-4a14-8cd0-3c85946bd0dc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d17250a6-d874-4303-b0b1-a237cce77708"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d1736f9c-4a3f-4b91-afbb-31ec7fd4428e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d19c7736-da78-4d92-b056-de9a35393f3f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d19f331a-4d58-4f0f-9948-06cf8b695658"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d1f48729-e98b-45da-b337-c48beea7ecbb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d200d2c6-cbdf-4d12-91b2-c36bfbe2e874"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d2210f0d-c460-47d7-a66f-3ad6aaa9c758"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d2354f27-8390-4a44-a79b-e1600fc42bf3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d263e12a-0fc4-41cf-961b-4af0dac5c14d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d270fc85-19b2-4e26-ba24-aa083a8bec39"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d274f155-0ef9-4252-98a4-7db849570df3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d2c8db20-41e3-422c-81c9-3db2a50075fa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d2cf1b13-26e0-43a6-80da-9f30420cdc6a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d2d2cc27-a30b-4d6f-a060-47b2e29d0921"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d3069edf-8662-421d-accb-4bfb23a12b19"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d3097dad-cb63-428e-9608-3a3c8c7cbb09"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d311c7f2-2e86-4ce8-affb-5e7bd3bf7631"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d31fbb91-916f-4533-b61e-586b60323ee4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d32d5328-de6a-4c6f-88b6-23022c36b54a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d34b8ee1-c7c2-4578-be94-fdb97a7dd613"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d35189e5-4b69-42c7-ac19-cd6c587a87ea"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d353dfdc-8074-47c4-94d8-4ce8dade249e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d3611eaf-d03d-499b-a848-768358e08658"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d38860df-3a24-47f2-bbbc-ef155cdcd411"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d3907792-c7c0-4af1-89ef-061ba635301c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d3c1e946-1190-4101-ae9f-b7b74a8ec0de"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d3ed7d19-637f-48e3-a354-1ed15abe101f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d3eeeaae-2b3a-43b6-b287-66a70e899a3d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d3f0d7e2-a6a1-4a1a-9655-69bba547f1ad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d4204181-f538-4e6f-b6d3-2f5b5dfefc30"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d4491291-ca89-4ee1-8a6e-bebe9e6c07a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d4b78252-78a4-4cce-8ae2-6716e42d9dc3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d4c664c5-b3d8-4ebc-9ca1-0b78150b2032"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d4e3e850-0c77-49c6-a6d1-37c313780e93"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d5103794-556f-47bd-aa85-164313340d67"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d52326b8-fbcc-4391-aaa3-b1619e5418c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d5442e70-e970-4110-a7d3-5d1265ed441d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d5476b29-e4ee-42a7-bfe3-e4e4ea17a225"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d554e9fb-7759-4fbb-8864-6fa6a5f98d05"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d555945f-f45d-4b69-b6f7-a6ab9cd40e8c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d5b48064-4b57-4554-b3ce-fc9bb4cda364"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d5ba2b0f-3c22-4cf0-8d6d-98dc8faa231e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d5be58ff-f6fd-422c-bb3b-7b58595a39e0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d5d454e7-e58f-4966-be5e-53c44a5ca1e4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d5faa029-b848-4bdc-857c-178468559218"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d5fc2206-1258-4260-aef1-6c21bbe96bad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d6057fe7-c25b-45b4-bf65-931f444e8908"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d60e437e-3ad6-4965-9b57-00c7725ba7be"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d6138a9c-5a43-47f6-93aa-1361148505a8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d61ee0d3-1327-4eaa-a208-5640a843f606"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d632de6f-2ae0-40d8-968a-e28066eefe89"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d636f0a4-fb73-489c-a754-e52c3a4e2259"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d63c47e0-09b7-455d-9157-778251054c73"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d6f86bf4-3c5b-4ebd-81f7-92b98f6161d5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7036124-c3d6-431e-a9a6-32a5530e7806"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d729a8fb-6481-4427-b6fe-6480d14c901e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d73c6d6f-8caf-4311-a29d-ea27fd0ccd11"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d79bf1fa-d3da-4247-b9f4-4d1e355a9c33"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7a6b001-b700-4f0a-8fb8-645c2a6b4882"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7c442d9-f885-41d0-8ba0-83ca5ba40bce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7c86d66-94a6-4627-9c86-e878793ea2a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7d61201-8657-4301-b17e-b496de9624ee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7e7d1e8-ca95-48e8-9345-246e73e3a7bf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7ec2ab3-7c55-4239-a7a4-63faf5897dc4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7efc1ff-239b-4f6a-ac89-6efbf2f4612f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7f4de76-f48e-40a6-bfe9-d40496fbc27b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d7f5e79b-9d6f-4bc2-a016-af2dec2439e6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d8117718-c2de-42b9-b549-3b503000ea11"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d850a63d-25ad-4e25-9be7-a1bf59019f72"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d8701210-5d07-4979-8492-dbc73b99b842"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d8f4f0d0-53c5-47e5-98dd-bb229c0c1118"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d9411b1d-8678-450a-86bd-4ec4e6cfb425"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d96698fb-b3c6-4feb-9b42-bba3c59a856a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d9670c4b-aec6-4e3b-8981-0b6096afa584"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d96de214-ac08-42cc-99b4-367745ea02d7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d9745570-577d-499d-91b0-5418aa6b52d8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d9b7783a-103d-45a6-9932-b3a48cde9c26"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d9c240a9-dac9-47e0-aeed-9f438fbe85d7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d9d701cf-d87e-41de-aec6-524e68ac5d8b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("d9ec3469-1abd-4417-a24b-5555da999407"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("da086af1-db7a-43e8-ac6e-5aea29203270"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("da1d05ea-d42a-4035-b3ca-f8ccd30c8add"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("da3cd723-bad4-44a6-bc3b-c4ac58721d75"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("da631139-3a7b-4377-8f2b-e5286255f463"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("da6f97c6-3980-4e4c-94db-0c132acc884d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("da71a87d-6d56-41a7-8a68-9bcc615d52f2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("daa1a3ba-215f-4a5a-a065-43f1010e7ad5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dabde780-c168-4f84-b794-a5027b27682b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dafd7450-4120-4b07-9aef-b4e805715cb7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("db38863b-8bb4-4d2b-b3f3-3184709f6cfe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("db491426-bd23-4fa7-ba3c-e9ac0ba9bb33"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("db66cb7c-a42b-4a49-85f6-644c6bf706e2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("db691fb9-1ea5-47ea-a926-0b0f03ef002f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("db6ee2b3-7c1f-4c54-a435-ef992a115bb8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("db8c8a4c-069b-41ae-a409-2cd927720858"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dbbd34f3-c54b-4040-b5e6-5df9da2722d0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dbe7cd88-3425-46c3-806f-610c4f39a130"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dbf77cef-df1d-4d89-8c08-f927f023325d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dc13bbc7-b73c-4e4d-97e8-8a4d9c2e57a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dc3e8557-8bcb-4ec3-9430-83e4cf3024b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dc545396-be74-409e-b4b3-a7b93561495d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dc5b5b93-5156-4493-9e8f-989453580686"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dc74f212-31c5-4088-beb6-c239c5b9e93f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dc946c4a-26af-44a1-8451-dbfbe8c1ed4d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dcd1889a-5dcd-4376-af88-14dd5cefdf6a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dcfa17fe-01e9-47ee-98d1-e054953cccf2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dd0af169-4310-42a0-b009-02515ceb484d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dd3e31b7-4ff3-4087-8ba9-86c7c53d9c59"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dd4e9991-4d0d-4db0-afe7-a8747cb59861"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dd581e28-d2d8-4eb3-bb24-de499b4b9102"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dd5f8a33-6643-4b00-8fda-46b78447f6a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dd5fc73f-a1e9-41ec-8bd7-a2e998a0058c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dd619ec1-d460-4402-947c-26283ce1b5e7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dd7cb468-784e-43ce-b829-6ad093b5d3a2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dd9ab82c-d3e5-4ec3-bc2d-5315d68802c6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ddab155e-06cd-4f5f-92e5-e43b1cd7cb8d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ddf801d2-ed69-4660-b2b5-b30dea13b8c6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ddfa2bdd-637c-48c1-a92e-c7bc1af4c38b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("de21f529-e2f6-4518-883b-0c90e295339c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("de97b0e4-ff23-4c31-865b-475aa23e0dbb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("decc49ac-e19f-497a-8f19-2cc18bb96734"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dece371c-ece4-4191-b126-e4d4f3a6d1a0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ded37dfe-1bf7-43de-8e88-b33109827916"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dedeae33-fe67-40de-ac16-2f516b43ebc4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dee9b66f-10e9-4782-8c95-02984cf2d0cc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("df0b7e85-f8b2-417f-a5a6-13934740f788"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("df2684f1-3676-41a6-8d73-09ae06a85cab"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("df2cba04-e7a5-45eb-92a5-3e9369683067"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("df6032f5-1971-4d0a-b127-08ad1cdd62c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("df6acb52-3be3-4208-b030-928155286445"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dfa3816e-f7b7-4033-9b44-a0e401125a9c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dfceb466-caa7-4656-a53e-e0ce5e3de887"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dfd0ec4f-b83c-42ae-897f-3b39df98bb43"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("dff84952-4989-4a47-8650-9ea27dc440da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e03597c9-144c-4ace-9d4c-31572c383226"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e045cfe8-12c5-40f8-86d8-500d272e0c2b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e04d7305-9a87-4382-8920-7db2960f6a96"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e0691d53-c4a7-4dd0-858c-8efddf37256d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e0ac6e4e-e932-4d9a-98c9-67c8bac54b9d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e0cf13d1-e5fb-40ef-be89-b9329c7893ba"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e0ec6095-8cda-456f-821d-cdccecc121d6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e0edbdba-914e-4765-bbf8-d1e38b9966b6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e11e8d67-49b7-483d-aa73-1e8c0a85d8b0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e11fd458-edc6-4d40-8d01-d891a8f01eff"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1426358-35c8-4a3f-a90b-17a00bfe6e2e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e144532c-fe46-4902-99ca-0f21ce26262e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e17a4dbc-0e03-44b6-90e1-12aac9705a97"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1a298da-d6b0-4576-945f-f24e6ce0ca68"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1b06cd6-026a-4637-9fc3-30a5d0d10a26"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1bd48bc-7286-4132-bd53-4281bd0af89a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1bebd88-22cf-4047-9a5f-f1c4200ba798"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1c0bef9-4448-4fce-a732-1c93f6bca07f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1c1e119-8bdf-4ae8-a03c-199e21f6e9ad"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1cf96da-054c-4dba-98ff-d32c89d84a94"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1df3191-f897-40a3-8d2a-8dd325dbdc94"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e1fbd3cf-b1d1-4181-9808-07d381fb7363"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e215a0d1-b07c-4aea-b80e-27ba1cf31874"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e236b7a3-155b-49b2-bb94-078feee960ae"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e26700f5-c1bd-442b-ab14-aaa7f54d131e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e26fbb93-0c62-49b1-90e7-15028e4e7da2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e2e5c744-10b9-4f99-b1c4-88107958381d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e3229b40-9775-4f81-80d3-fa722894014f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e32eca19-1d28-4378-9475-3e55ac9d81cf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e360bf19-ba7d-4b74-be7f-6ff6606fd642"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e368e5a0-9264-4bf6-a278-efa5f71e9da7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e370e5e8-82af-43d9-9244-8a7e59b24cc0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e39f4c31-ab42-47f3-99a0-93472abfb468"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e3aa488d-f809-42d8-ab87-781f78f0a54c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e3bfe4e0-1d1c-4d39-aaff-7a1e1a00fbbb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e428ac3c-8be7-4ba7-b26d-fbd012ce8be5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e449210d-1558-430f-85f4-5ec959d66364"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e4616a58-21a7-4b94-9e2d-5cb5f774c5d4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e462f647-a0c1-4dcd-bc4f-365c34300a32"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e46917a1-1a35-4b21-8ee4-f9d615dc9dfd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e4a4dc60-6df6-4f1e-80cc-d5650ea0d9a5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e4e292b9-0999-490f-828c-3fd37c6120f9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e4eb1470-3fcc-4ca1-b085-5d1186a4553f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e4f1215f-8714-4e57-a3da-b61b80b75949"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e4fc1a1b-cbf0-4df4-a39d-12e3dc8d5238"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e5822290-db56-469a-bed8-9e825142a5c7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e59e0340-98cc-4846-8d6b-c1400821db27"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e5d65f54-db3c-40e2-8814-0a73cdb16d38"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e5da040a-ce9c-472a-a499-7983dc6f5a3e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e5ee0423-6aa9-4638-9bf8-b5c71fa16892"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e6267f23-a4d3-495b-9ad3-363608ca7834"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e63134c4-3a48-4d95-8e67-5ded041f10a9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e6341d18-b283-43bf-b6ed-4b5019f799d4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e63459f2-ec12-4502-a0e6-f88f9ace8508"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e63a78bf-02f7-481f-8349-b226c0f93b61"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e65383c5-5137-4445-a477-9927c1c78e4e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e6564ccd-e411-4ade-ab76-2875bafda88f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e667db9a-5cb1-4fe1-9669-ddc7777e3775"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e677feb8-569a-4b67-8030-0f4b57deadef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e68ae8e9-4a6f-42fd-82a5-d4910b834611"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e6bde487-67c4-4682-8ffa-934c62f380e7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e6cd51e5-1fa0-4322-9d9d-6f5216ac5f45"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e6cfdba0-2b51-4be8-b37c-b00c211970ee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e6d8496f-8c16-4faf-beab-f16e33a2c551"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e6df1d3b-cb46-4a71-86a1-84c4d279661f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e711cda7-f983-4de8-9c50-e7ac125f3caf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e72d3c28-015f-48e5-a204-a2f9812f7624"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e73d5660-4113-4969-966d-e951f02a0932"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e7527524-3b66-4c42-bf3a-1a794623315d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e766a91b-a717-48b1-8e96-618b38fbfafa"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e77358d1-281a-4cd9-b3e0-42d2aebd6100"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e774ccd0-5178-4d1d-aaa7-b2fdce6f81e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e79a5670-b926-46b4-9b10-a45a0caa1e2a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e79b226f-a87d-4cd2-8bf1-986d559c0959"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e79ff803-3b39-425d-8fe7-55bbb2082a6b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e7a5bc2e-a85a-4479-bd69-a4d8ab6737ef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e7a7b880-66b7-41f1-a6f5-d42e54fd3db3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e7ae915c-4b10-4855-ab06-19a9968abf32"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e7c85143-4736-4093-b6e5-ee73134293b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e8083851-a489-4210-9fa2-5e0ae1905c56"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e80b0a07-9008-48d8-aa3b-f557c775488e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e80d15e2-f7a8-4ef2-9677-75ec719a3c05"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e80d7eb8-a848-4612-aff4-63d974cefffe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e813486b-06d0-46c7-bd4d-681a1165f58e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e81d626c-6cac-452e-937b-825dffa5b2cb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e827f6d0-3fe2-4bb6-a9ca-f7a5edaeccee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e83196ca-b820-4e59-b05c-b8fa4a9e7050"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e8340b10-f358-413b-8456-b0b3769b2971"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e837e2dc-4479-4579-89bc-6d6cea462218"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e84b97fb-1955-4970-a65e-fcc561e3f73e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e851f98a-cf53-4c85-8000-ec9ea9a12c59"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e898b667-9ff6-4f52-9e9a-b82912a140f2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e8afc9ba-c6f0-4e04-a17a-faf7de2169c9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e8ca66a8-1864-4f1a-8ca2-7e26e0ce4cb8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e8f665ec-3092-4bca-ab8b-36c98d2b95c1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e9056ba7-1a5e-4d63-ba20-44c0aa8dd2ec"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e94994fa-68ae-49a6-afef-b1b70479d96c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e9523143-25b5-478f-8765-7354dfb40e26"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e96ea279-2a47-432d-8969-4594949d445b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e99e1470-ae92-42f5-9bc0-3ff3abcaac62"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e9a11d92-7b0d-413f-8c1b-5affdf19a25f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e9ac2e9a-74c9-457e-ba95-17883a3b95ed"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e9bc000d-fb1c-40fd-87db-e5db1e9d409c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e9cc0590-eaa8-4326-baf1-99105dcf1b77"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e9e5df62-9b53-445a-9b21-20d6948c96bc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e9ea1c59-f2d4-4360-a8f8-06cc22b6a2b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("e9eb1190-71b6-4cad-a2f4-8d135eb12754"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea0cbfe3-48dc-4946-9f8b-41e74003d42f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea0e0d42-4b0c-4d7b-b158-72545f106161"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea2b57ea-ff06-475a-a7c0-4c4472194225"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea30475c-5979-45fb-b52b-7c9a0f9a8d1f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea33aea8-4e0c-43e9-a96c-728d8b402499"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea39ea4d-8f33-45e1-a6b5-8bf36537068d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea3a5144-cb97-456c-bdc5-51821ba905ff"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea528792-25ea-4617-b1a4-e298aa46a332"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea60a624-8c12-47e3-a6c5-4c73337ad708"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea6f85fa-994a-4e4f-82a8-7d60987e6ed3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ea784721-2bed-4cd4-8f9c-8a8f0e163bd1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eaaecc8a-71af-427f-9daf-21cb9797b0b6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eac75822-a429-429d-83db-5c818f6e9f36"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eacc176d-0e01-4379-b009-0c3f5d634571"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eaf1fa8b-1ead-4eee-86eb-2f59b0a39593"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eaf6cd32-9384-4dcd-a5ea-81dd3e2faa2b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eb0508e0-d5d2-4121-836b-5091fff9c3c5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eb275999-6e82-403c-bc8c-7cb0a0878f06"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eb2aa5b8-245e-467b-ac4e-1ca728c7c80e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eb538e3d-8c99-450d-a7a9-af6dee77a659"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eb7c3665-9eb3-4866-a680-be659c9bc7bf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eb84d9aa-68e2-46f7-8bc6-1cc149c4abd9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eb911dc8-5d03-44a0-883e-4eacf5f54675"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ebb66ea0-d005-4df4-9979-5e9a2e77c44b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ebbb4393-f8d0-41a6-a7c3-c740d1ddd95e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ebd3e39e-fe8a-4f7c-b002-be524d5a8f2c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ebfbc8f8-5cba-42af-a231-4ff03f82d5a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ec15c795-1284-4710-a508-c7a83f4c58a7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ec2ef0e1-4e09-47bf-b498-e4671a2e3eb8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ec355648-5797-4a8c-ba3d-e1fdefb9f435"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ec450ede-cb67-4364-952b-19a5221ff3cf"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ec79b0a7-dfc5-4f8f-a48d-d74ae7a72af9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eca205be-e23a-46c6-860f-c475ed41a69a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ed06006d-5b56-4423-ad79-47fedbf02f56"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ed194d66-2cad-4c84-8ac6-ca8a640a694f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ed4ba96d-1485-4894-9a12-2b879b3ea497"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ed526d33-1cec-4a48-826e-9f4ca93bb3ca"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ed55d679-a322-4550-8e74-00b8083a1cd5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ed6250a5-4c8d-416e-bb6c-52f4ebcc7e78"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ed677140-f7fc-48dd-8d6b-b6cfb196937e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ed759a36-7d0a-4c58-8673-449decb9814c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ed8ab713-7f6a-48bb-9d04-6953e6bf6eef"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("edb622d6-bb75-48c8-9632-dad08ef69c8b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("edbf6ec2-b369-4703-b016-2a2bbecebc01"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ede5eba3-6790-4f74-8796-59325cc529dd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("edf10465-25a5-41fc-a0ce-8b17ed856d6b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ee0a0868-671a-4ecc-af3a-09d24f0853da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ee2322d3-a46d-4cb3-99e1-521f9eb536c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ee6ba024-7bd4-4760-b7b9-71e9faac8638"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ee7a457c-0555-4a8e-88c7-b09e2674d86f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ee98cae7-b92c-4ff7-b685-3b8761b9ee43"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ee9af6bb-6452-45ac-a04d-f499aaaa2acd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eebe2699-2e98-4f3b-819f-f2a6c453000a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("eefc6309-a426-4801-934a-d8b1509ad973"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ef012960-8364-4971-9c42-64c5739851bb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ef070716-9855-4d57-82b4-857ab43c9c65"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ef352385-4915-4f9b-8f5a-0315209b82b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ef3ee613-bd73-4eca-bb2b-a6a0bf1e739d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ef5d2672-3a15-4bd9-ba3a-b6c196e2ef29"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ef74e5d3-4609-4565-b1b0-7964d5259aa4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ef902294-19b6-47f0-b5cb-177521fdbeb5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ef93f2e0-be4b-447b-9f83-d095367ef8fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ef9fb694-10b8-4c05-9424-8d22d04b4a83"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("efad5bea-83e5-4946-b81d-eb0cecb417f5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("efdc135e-4088-4c20-809d-29e9868205df"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f000367b-2aae-4e3a-9d7a-9590c4b64a1b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f00da9b1-d340-4d84-a2e7-71546c204509"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f0415d9a-a440-4a7c-b470-1e4953536acd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f04a796b-4259-4bb5-8712-c16fdc10a4d9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f04a8bf6-120a-4e4a-bd75-cff3f25fb314"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f08584f0-f005-41b5-906f-972e16bca1fb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f0d11d11-e8b2-4171-b557-1ad79b1a6c37"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f0d1dc21-e3bb-4964-9256-421159ec8964"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f0d271b6-4756-49fb-998e-1cba2e7dc8c2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f0f8409d-00fb-4222-b9cc-55615c4dbed7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f0fd20a6-8864-4637-ad5e-1237dedc8b02"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f12c25ee-779a-4355-9990-56ad4222f243"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f13616c1-bc66-4ac9-af5d-4f4cc083ab71"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f143441d-bc70-4f58-a85f-3e1ed8849494"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f17bfb80-7e45-46a6-aa45-33d07408d80d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f1a022ce-aa0d-488c-ac7b-c3a2220ad79c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f1a4edc2-9b10-40d9-acb8-374aa603a756"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f1c0a654-8bb7-4f52-bdab-b181dae30cac"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f1dd44cf-804d-4445-9656-192aa282f73e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f2375dbb-5c1a-41c6-b888-482c4445060e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f248a96e-1dba-4dc4-b2d1-19afb1002085"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f25025cd-f604-4489-9d58-436f838f3dde"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f250c918-7023-4753-a237-d6bfe19a1882"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f25ad708-ef52-46ff-9631-49a1451c1904"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f25f9287-791c-451a-a320-48ecec37989c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f264916a-06c7-44a5-b67b-38e06751f382"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f26a85b6-394c-43be-b58d-9748ada6d16a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f2746920-ca05-4299-9a65-1611d81efa34"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f2889fd4-c578-4d94-8410-181e0445c1ce"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f28ed722-f7bd-431b-a7a9-1ae9da057082"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f28f1d39-d505-4202-a486-08a11c0eafc7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f2b9bbcb-fe5c-4f23-8ac3-a200be17200a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f2ddefb5-05f7-4b0a-8ab9-657aadeb5512"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f2e6276c-aa27-4cbc-a157-b6d686e8cfe8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f306ddf7-eed0-4856-8067-50d02a80ee55"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f38c55d9-ee0f-4599-834f-009b89d173b5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f39104aa-257b-47ef-8498-65059658fbdc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f3c663a8-6485-4bf5-827c-648b0c5ce8cd"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f3d7c64c-efaf-47fb-8d98-398bc61923c0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f3d968ac-accb-415c-95c6-63cbd64e7bb9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f3e5369f-289c-4ea5-83ce-8c552362c00a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f3fdc226-8dbd-4f6b-a29c-345738477b91"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f433d33a-ae72-4983-ab5f-6be8dd18ed95"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f438e72a-649f-4127-ba23-50bf8a3db11a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f449f3ee-d7b7-4f1f-a04e-3654c1690069"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f44f93b5-8f1f-4d55-b4cc-d8f4948ebae5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f46fada8-12ba-429b-be08-12d1124bbc59"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f4b7d8d6-0a9f-4219-9ce8-44e6c59132fc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f4e31a9c-b272-4e6b-907e-254de5f4c3bb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f4f10819-e691-494e-a117-1b355c5cf11e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f4f9d076-6064-4e9f-ac0d-db9468fde629"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f500661a-472c-44c9-b556-74288a484534"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f50a52e8-e09d-4325-906f-4d6c97df7055"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f5386ff8-9b2e-49bc-aec8-a7f6deb7f32b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f541bbdc-c25a-49e3-987b-da8bda83b968"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f54f9f2a-8c12-431b-8a27-f03d90644756"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f5935c4d-dd60-4927-943f-96c72e5b695e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f5c22fad-f5ca-4a77-b8aa-f561567bf6d9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f5e2e13d-ffe5-455c-999e-cea4ff3c0141"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f5f7126d-6b82-4fb3-a5ca-f403f5e8b6be"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f62de6d5-daad-44b9-85d5-50d37512d2ee"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f63163ac-5fa4-487a-93ef-998763afd1c3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f6388bcf-6226-448c-9770-c1636445026f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f6425cee-fe1b-4657-8c21-e609f4a80cf2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f64ddf7d-631a-431e-9808-0a37caf2d8e2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f672412b-63ea-42ce-af46-940b0f93ccd5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f6827c9c-f4cb-4af1-840e-71c7572d345b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f6a0a9ef-1ca3-4171-b89c-acad3d2ac894"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f6a6907d-16e9-45c2-9fad-7e81bc8fa292"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f6eb55cf-2e01-497d-9760-3b8555439b6e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f6f2aabb-ef3a-441b-b525-f07931c0d962"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f725790d-4f0c-48ca-ab3d-5770eb3ad05b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f7363442-8152-4e33-9095-51bb5a9787d5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f73e4cc8-678b-4778-98da-b606f9e77abb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f74f8c63-cf46-4eb3-a6c6-e38241f72350"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f76effdb-b466-47fb-9717-a4aabc196cb5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f789ab82-f45d-4510-8d97-2dfaada3b753"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f79962b7-5287-4fa7-b7cb-baa365c520fc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f79de131-e023-4c48-acc5-c09958b5be10"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f7a7a270-dc55-48ee-9b69-5e9a0a8952b3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f7aae71c-d090-4266-ae16-6e2adbce34c7"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f7c50b0d-d10f-4647-b632-805c0be99e77"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f82d9446-2e82-4477-998d-300922a69691"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f82dfa9b-4a32-4f72-9594-2bba3edd9afc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f847f52a-dc80-4db5-b330-f59c49895274"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f8593e1f-727d-4526-89dd-8d62874a9bbe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f873f3bb-7cf0-4d1e-9898-f3885f850a0f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f87cb6be-b125-4578-bd28-03951a18a990"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f87e3b23-08e5-4047-a186-621d1c8b7961"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f88069e7-4aea-49c8-b4e3-23c400d03b95"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f8eadbdd-1b5f-4d8d-a1e2-c3057497296c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f90ea56e-a67d-45e6-b5bf-259e9db47513"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f919ae0b-ed1d-4c00-8742-4c17bcba60c8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f99fc8b6-0963-477d-af69-ce1b5c54dc2e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f9a908c4-f644-4e62-847b-e95d14ed151e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f9af168e-58d7-4ffc-876a-18eaa194effe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f9e0f7a4-e630-4a1f-ae94-88a0b153cf07"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f9e87987-c075-4d31-ad72-7a5528133623"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f9ecaeb3-e1ea-4d22-9764-5636e9c25972"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f9f1f175-bb86-44d9-b43d-adc197aba95b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("f9f77b1f-699e-4e68-b5d9-0d4bff191e47"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fa0221af-c895-4685-9af2-c1f8e4a5b5db"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fa195091-d311-4d53-88c4-9fab4101e8e4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fa3304f8-fd2c-42ac-9fc8-61c357b03262"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fa37f76d-a84d-4098-a661-953f880700b0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fa4bd8fd-f175-4843-871f-57f6efe069c6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fae8a477-1ce0-477c-bb65-e9862474ffec"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("faff4063-b0f9-4815-8461-9e1853b108c9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fb09807b-c0df-432a-918d-b76011e8ffa9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fb17a46f-67cf-4c17-a78d-eddb29663605"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fb372fa4-ce00-4063-9963-badaf93a443d"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fb3dfb42-e2cb-49db-ab23-7cfd99430e01"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fb605aab-32ff-42f4-aeb8-fda5959eb9b1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fb859999-fec8-4226-a991-d2ced2d28bc6"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fba73656-b137-4a7a-94e0-6418545d1ff0"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fbc3abc7-8fb8-44f8-b76a-063c668c1728"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fbd5d2fc-9aa3-4c45-b2a9-c3fdeb1d827a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fbe6b8ab-a343-488c-b378-0c16130ced2e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fbee6396-b8df-4408-8a14-b6acd5968ec5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fbf42092-da40-4db9-817d-de4dce8ae22f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fbfa4c75-3657-488e-a204-6bc5038429fe"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fc17c28b-d94f-44b3-9197-5d60004f5378"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fc20ab69-65a9-46dc-a4cd-19cf6f928de9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fc229e02-af1d-43b9-9fc2-aece8b5c1c9e"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fc322296-531b-4c4c-8056-0784b90cc848"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fc491c74-b75d-4ef6-89ea-cc9b6ffc845f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fc4ac7a5-159b-4aec-97ef-7eab7eb27fbb"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fc8259bb-6f1d-4e2c-8b07-0cf04579ae23"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fc97aef3-7db3-4c7e-bc48-9eb755ff4eb9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fca83cda-d39c-4c8b-bd4f-4a8999e9863c"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fcacf72e-e38b-403a-99bf-fe521452d75b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fcb05013-d502-4b3b-9a19-f17d1d549d5f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fccb089a-80a0-4da3-84be-8d2c55578279"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fcd25da8-04b3-4c5a-9a76-39ceec9d4845"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fce05491-1586-48bb-b93a-4beeb0fa6a14"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fcea594d-4243-4a76-a679-5c88e7e748f2"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fcf4e831-2bd9-4bc3-8e55-9d520ddd8bba"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fd2b0ad9-6bd8-4648-a962-99c6b0b65ed5"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fd5767bf-5fb3-4d35-8abe-9edba077f1d1"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fd708043-3ab3-4663-9b54-1cdbd43b6d28"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fd7cd889-429f-496b-a592-cbb7b6dcf1f3"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fda8ed95-7cca-4a6d-a5c4-6c9583f7149b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fddda2c6-f77e-463f-ba05-b51371480801"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fde138e1-011d-411a-82d0-84883bce4b7a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fded1c01-a429-45c1-be8b-ab839cd842da"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fdfcc84f-9e5e-4a07-85c7-c3bbcbf2f35b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fdfd0906-af5e-40e8-b979-4697b704e752"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fe09d484-ff54-499a-bf15-d9b7e19f4961"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fe62d2ee-f72a-46fc-acaa-671f8ca4a671"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fe7a525a-dfec-4b7f-a0d0-f5aebcc593df"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fe7c72ff-d88f-4c2d-8ba7-be590b60f17b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fe7f0639-d8cd-48fd-85a5-ad669b6680ff"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fe87bdde-bdcd-4a82-844d-fc9bc13857c8"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fea4d434-310f-4274-9fbb-a8dd07e46391"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fea7c4ce-8e3f-47ad-8637-97a128c0d40f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fecd52aa-ffee-4248-aa4f-f9c87464c225"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fee186de-225a-4ec0-bbea-5a08eba2ba44"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("fef8d287-04c8-4a39-a93b-39078e889192"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ff1f2f81-ade1-4f80-9b21-47fcbcb312dc"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ff2deb2b-147e-49ec-9ef8-17a0a6573a40"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ff3c6c80-6d48-4eb0-b7d3-035d70387f92"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ff68cf48-d566-431d-a11c-1748721ac245"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ff71cfd4-5155-419a-a577-78f863507941"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ff78e2ae-254a-4609-bc9b-75e33ea71142"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ff84af82-6ebc-49e9-94aa-91019d4fd6b4"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ff88b0b1-0377-414c-93e5-29b76812f52a"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ff9760fe-82a3-4598-aee5-dba9fb5424e9"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ffc23aef-59a0-44e1-9165-6a9cd1c5008f"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ffc8da45-045a-46ec-8ec6-f71cc8e89b9b"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ffd6c575-773b-4055-a988-3bda79e70487"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ffe96e11-f6f9-45c8-919d-c3ce24169622"));

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: new Guid("ffee17dc-f8fb-400f-aee2-387eface44cb"));
        }
    }
}
