using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiddleEarth.Repository.Migrations
{
    public partial class InitializeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Realms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    RealmId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Realms_RealmId",
                        column: x => x.RealmId,
                        principalTable: "Realms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "characterFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Eyes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hair = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characterFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_characterFeatures_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWeapon",
                columns: table => new
                {
                    CharactersId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWeapon", x => new { x.CharactersId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_CharacterWeapon_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterWeapon_Weapons_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elves, who called themselves the Quendi (Q.: Speakers) and who in lore are commonly referred to as Eldar (Q.: People of the Stars), were the first and eldest of the Children of Ilúvatar, considered the fairest and wisest of the earthly race of Arda.", "Elves" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dwarves were a race of Middle-earth also known as the Khazâd (in their own tongue) or Casari, Naugrim, meaning 'Stunted People', and Gonnhirrim, the 'Masters of Stone'.", "Dwarves" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "During the time of The Lord of the Rings, Men in Middle-earth were located in many places, with the largest group of free men in the countries of Gondor and Rohan. When the island of Númenor fell, only the Faithful escaped and founded the twin kingdoms of Gondor and Arnor. The Faithful were known in Middle-earth as the Dúnedain, and as leaders of these kingdoms, they were able to lead the resistance to Sauron, and preserve the Men of the West as Free People. There were also free men at the village of Bree, at Esgaroth, in Drúadan Forest (home to wild men known as Drúedain or Woses), and in the icy regions of Forochel. Those who served evil powers, such as the men of Dunland, Rhûn, Harad, and Umbar, were not considered free men. Men bear the so-called Gift of Men, mortality. The descendants of the Dúnedain include the Rangers of the North and the Rangers of Ithilien.[4]", "Men" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Drúedain somewhat resemble Dwarves in stature and endurance; they are stumpy, clumsy-limbed with short, thick legs, and fat, gnarled arms, broad chests, fat bellies, and heavy buttocks. According to the Elves and other Men, they had unlovely faces: wide, flat, and expressionless with deep-set black eyes that glowed red when angered. They had horny brows, flat noses, wide mouths, and sparse, lank hair. They had no hair lower than the eyebrows, except for a few men who had a tail of black hair on the chin. They were short-lived and had a deep hatred of Orcs.[T 1] They had certain magical powers and sat still in meditation for long periods.", "Drúedain" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hobbits, also known as Halflings, were an ancient mortal race that lived in Middle-earth. Although their exact origins are unknown, they were initially found in the northern regions of Middle-earth and below the Vales of Anduin. At the beginning of the Third Age, hobbits moved north and west. Most of their race eventually founded the land of the Shire in the year TA 1601, though one type of hobbit known as Stoors remained in the Anduin Vale (the type of hobbit Sméagol was).", "Hobbits" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ents, also known as Onodrim (Tree-host) by the Elves, were a very old race of Middle-earth. They were apparently created at the behest of Yavanna after she learned of Aulë's children, the Dwarves, knowing that they would want to fell trees. Becoming shepherds of the trees, they protected certain forests from Orcs and other perils. The Elves had tales of teaching the trees and the Ents to talk: although the Ents were sentient beings at the time, they did not know how to speak until the Elves taught them. Treebeard spoke of the Elves curing the Ents of their dumbness, an unforgettable gift.", "Ents" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Maiar (singular Maia) were primordial spirits created to help the Valar first shape the World. They were numerous, though not many were named. Their chiefs were Eönwë, banner-bearer and herald of Manwë, and Ilmarë, the handmaid of Varda. Five of these spirits, in the Third Age, became the incarnated Wizards.", "Maiar" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Valar (Quenya; singular Vala) were the Powers of Arda who shaped and ruled the world. They lived on the Western continent of Aman.", "Valar" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balrogs, also known as the Valaraukar, were Maiar that were seduced and corrupted by Melkor into his service.", "Balrogs" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orcs were the primary soldiers of the Dark Lord's armies and sometimes the weakest (but most numerous) of their servants. They were created by the first Dark Lord, Morgoth, before the First Age and served him and later his successor in their quest to dominate Middle-earth. Before Oromë first found the Elves at Cuiviénen, Melkor kidnapped some of them and cruelly deformed them, twisting them into the first Orcs.", "Orcs" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wights appeared as dark phantoms whose eyes were luminous and cold, and whose voice was horrible yet hypnotic; their skeletal hands had a touch like ice and a deadly grip. Victims under a Wight's spell would lose their will; in this way the Barrow-wights drew the living into the tombs of the downs. Some, if not all, victims were laid on a stone altar and bound in chains of gold, to then be draped in pale cloth and jewelry of ancient dead, and killed by a wight with a sacrificial sword.", "Barrow-wights" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Easterlings, known in early times as Swarthy Men, were a race of Men who eventually populated the vast, uncharted lands of Rhûn, east of Mordor and the Sea of Rhûn. Easterlings were enemies of the Free Peoples since the First Age, and a populous vassal of Sauron throughout the Second and Third Ages.", "Easterlings" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dragons were ancient, intelligent, powerful creatures, as feared as they were admired in Middle-earth. Their exact origin is debated, though it was clearly stated that they were created by Morgoth in some sense, millennia before the events of The Hobbit and The Lord of the Rings.", "Dragons" },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trolls were a very large and monstrous, and for the most part unintelligent,[1] humanoid race inhabiting Middle-earth.", "Trolls" }
                });

            migrationBuilder.InsertData(
                table: "Realms",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khazad-dûm, commonly known as Moria or the Dwarrowdelf, was an underground kingdom beneath the Misty Mountains. It was known for being the ancient realm of the Dwarves of Durin's Folk, and the most famed of all Dwarven realms.", "Khazad-dûm" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount Gundabad was an Orc mountain-stronghold situated at the northern end of the Misty Mountains, located to the east of the ancient realm of Angmar.", "Mount Gundabad" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "he Lonely Mountain, known in Sindarin as Erebor, referred to both a mountain in northern Rhovanion and the subterranean Dwarven city contained within it. In the latter half of the Third Age, it became the greatest Dwarf city in Middle-earth. It was located northeast of Mirkwood, near the Grey Mountains, and was the source of the River Running.", "Erebor" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Iron Hills, or Emyn Engrin in Sindarin, were a range of hills located in the north-east of Middle-earth, and was a settlement of the Dwarves of Durin's Folk.", "Iron Hills" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nogrod was one of two Dwarven cities in the Blue Mountains. It lay in the middle of the range, near Mount Dolmed where the Dwarf-road of Beleriand crossed into Eriador. ogrod was home to the great Dwarven smiths Gamil Zirak and Telchar.", "Nogrod" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lothlórien, also known as Lórien, was a forest and Elven realm near the lower Misty Mountains. It was first settled by Nandorin Elves, but they were later joined by a small number of Ñoldor and Sindar under Celeborn of Doriath and Galadriel, daughter of Finarfin. It was located on the River Celebrant, southeast of Khazad-dûm, and was the only place in Middle-earth where the golden Mallorn trees grew.", "Lothlórien" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gondolin was a hidden city of the Elves located approximately in the middle of the land of Beleriand in Middle-earth. It was founded by Turgon the Wise, a Ñoldorin king in the early First Age. It endured the longest of all the Ñoldorin kingdoms in exile, lasting nearly four centuries during the Years of the Sun.", "Gondolin" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rivendell, also known as Imladris in Sindarin, was an Elven town and the house of Elrond located in Middle-earth. It is described as The Last Homely House East of the Sea in reference to Valinor, which was west of the Great Sea in Aman.", "Rivendell" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gondor was the most prominent kingdom of Men in Middle-earth, bordered by Rohan to the north, Harad to the south, the cape of Andrast and the Sea to the west, and Mordor to the east. Its first capital was Osgiliath, moved to Minas Anor in TA 1640. This city, later renamed Minas Tirith, remained the capital of Gondor for the rest of the Third Age and into the Fourth Age; other major fortresses included Pelargir, Dol Amroth in Belfalas and Minas Ithil.", "Gondor" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rohan, or the Riddermark (Rohirric), was a great kingdom of Men located in the land once known as Calenardhon, situated in the plains between the Misty Mountains and the White Mountains. The land of Rohan extended from the banks of the river Isen in the west, up to the East wall of Rohan and shores of the river Anduin in the east. The forest of Fangorn lay on its border, and the Elven forest of Lothlórien lay north of the river Limlight.", "Rohan" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mordor was a black, volcanic plain in the southeast of Middle-earth to the east of Gondor, Ithilien, and the great river Anduin. Mordor was chosen by Sauron as his realm because of the mountain ranges surrounding it on three sides, creating a natural fortress against his enemies.", "Mordor" }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sword" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bow" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Spear" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Staff" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Axe" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hammer" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "Name", "RaceId", "RealmId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.wikia.nocookie.net/lotr/images/e/e7/Gandalf_the_Grey.jpg/revision/latest/scale-to-width-down/350?cb=20121110131754", "Gandalf", 7, null });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "Name", "RaceId", "RealmId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.wikia.nocookie.net/lotr/images/8/82/Melkor_by_formenost.jpg/revision/latest/scale-to-width-down/350?cb=20121205131822", "Melkor", 8, null });

            migrationBuilder.InsertData(
                table: "characterFeatures",
                columns: new[] { "Id", "CharacterId", "Eyes", "Hair", "Height", "Sex" },
                values: new object[] { 1, 1, "Blue", "Grey", 168, "Male" });

            migrationBuilder.InsertData(
                table: "characterFeatures",
                columns: new[] { "Id", "CharacterId", "Eyes", "Hair", "Height", "Sex" },
                values: new object[] { 2, 2, "Black", "Black", 300, "Valar" });

            migrationBuilder.CreateIndex(
                name: "IX_characterFeatures_CharacterId",
                table: "characterFeatures",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RealmId",
                table: "Characters",
                column: "RealmId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeapon_WeaponsId",
                table: "CharacterWeapon",
                column: "WeaponsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "characterFeatures");

            migrationBuilder.DropTable(
                name: "CharacterWeapon");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Realms");
        }
    }
}
