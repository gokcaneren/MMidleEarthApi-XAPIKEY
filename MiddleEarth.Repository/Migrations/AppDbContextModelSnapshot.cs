﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiddleEarth.Repository;

#nullable disable

namespace MiddleEarth.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CharacterWeapon", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("int");

                    b.Property<int>("WeaponsId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "WeaponsId");

                    b.HasIndex("WeaponsId");

                    b.ToTable("CharacterWeapon");
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<int?>("RealmId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.HasIndex("RealmId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://static.wikia.nocookie.net/lotr/images/e/e7/Gandalf_the_Grey.jpg/revision/latest/scale-to-width-down/350?cb=20121110131754",
                            Name = "Gandalf",
                            RaceId = 7
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://static.wikia.nocookie.net/lotr/images/8/82/Melkor_by_formenost.jpg/revision/latest/scale-to-width-down/350?cb=20121205131822",
                            Name = "Melkor",
                            RaceId = 8
                        });
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.CharacterFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Eyes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hair")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("characterFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Eyes = "Blue",
                            Hair = "Grey",
                            Height = 168,
                            Sex = "Male"
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Eyes = "Black",
                            Hair = "Black",
                            Height = 300,
                            Sex = "Valar"
                        });
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Races");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Elves, who called themselves the Quendi (Q.: Speakers) and who in lore are commonly referred to as Eldar (Q.: People of the Stars), were the first and eldest of the Children of Ilúvatar, considered the fairest and wisest of the earthly race of Arda.",
                            Name = "Elves"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Dwarves were a race of Middle-earth also known as the Khazâd (in their own tongue) or Casari, Naugrim, meaning 'Stunted People', and Gonnhirrim, the 'Masters of Stone'.",
                            Name = "Dwarves"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "During the time of The Lord of the Rings, Men in Middle-earth were located in many places, with the largest group of free men in the countries of Gondor and Rohan. When the island of Númenor fell, only the Faithful escaped and founded the twin kingdoms of Gondor and Arnor. The Faithful were known in Middle-earth as the Dúnedain, and as leaders of these kingdoms, they were able to lead the resistance to Sauron, and preserve the Men of the West as Free People. There were also free men at the village of Bree, at Esgaroth, in Drúadan Forest (home to wild men known as Drúedain or Woses), and in the icy regions of Forochel. Those who served evil powers, such as the men of Dunland, Rhûn, Harad, and Umbar, were not considered free men. Men bear the so-called Gift of Men, mortality. The descendants of the Dúnedain include the Rangers of the North and the Rangers of Ithilien.[4]",
                            Name = "Men"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Drúedain somewhat resemble Dwarves in stature and endurance; they are stumpy, clumsy-limbed with short, thick legs, and fat, gnarled arms, broad chests, fat bellies, and heavy buttocks. According to the Elves and other Men, they had unlovely faces: wide, flat, and expressionless with deep-set black eyes that glowed red when angered. They had horny brows, flat noses, wide mouths, and sparse, lank hair. They had no hair lower than the eyebrows, except for a few men who had a tail of black hair on the chin. They were short-lived and had a deep hatred of Orcs.[T 1] They had certain magical powers and sat still in meditation for long periods.",
                            Name = "Drúedain"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hobbits, also known as Halflings, were an ancient mortal race that lived in Middle-earth. Although their exact origins are unknown, they were initially found in the northern regions of Middle-earth and below the Vales of Anduin. At the beginning of the Third Age, hobbits moved north and west. Most of their race eventually founded the land of the Shire in the year TA 1601, though one type of hobbit known as Stoors remained in the Anduin Vale (the type of hobbit Sméagol was).",
                            Name = "Hobbits"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ents, also known as Onodrim (Tree-host) by the Elves, were a very old race of Middle-earth. They were apparently created at the behest of Yavanna after she learned of Aulë's children, the Dwarves, knowing that they would want to fell trees. Becoming shepherds of the trees, they protected certain forests from Orcs and other perils. The Elves had tales of teaching the trees and the Ents to talk: although the Ents were sentient beings at the time, they did not know how to speak until the Elves taught them. Treebeard spoke of the Elves curing the Ents of their dumbness, an unforgettable gift.",
                            Name = "Ents"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Maiar (singular Maia) were primordial spirits created to help the Valar first shape the World. They were numerous, though not many were named. Their chiefs were Eönwë, banner-bearer and herald of Manwë, and Ilmarë, the handmaid of Varda. Five of these spirits, in the Third Age, became the incarnated Wizards.",
                            Name = "Maiar"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Valar (Quenya; singular Vala) were the Powers of Arda who shaped and ruled the world. They lived on the Western continent of Aman.",
                            Name = "Valar"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Balrogs, also known as the Valaraukar, were Maiar that were seduced and corrupted by Melkor into his service.",
                            Name = "Balrogs"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Orcs were the primary soldiers of the Dark Lord's armies and sometimes the weakest (but most numerous) of their servants. They were created by the first Dark Lord, Morgoth, before the First Age and served him and later his successor in their quest to dominate Middle-earth. Before Oromë first found the Elves at Cuiviénen, Melkor kidnapped some of them and cruelly deformed them, twisting them into the first Orcs.",
                            Name = "Orcs"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Wights appeared as dark phantoms whose eyes were luminous and cold, and whose voice was horrible yet hypnotic; their skeletal hands had a touch like ice and a deadly grip. Victims under a Wight's spell would lose their will; in this way the Barrow-wights drew the living into the tombs of the downs. Some, if not all, victims were laid on a stone altar and bound in chains of gold, to then be draped in pale cloth and jewelry of ancient dead, and killed by a wight with a sacrificial sword.",
                            Name = "Barrow-wights"
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Easterlings, known in early times as Swarthy Men, were a race of Men who eventually populated the vast, uncharted lands of Rhûn, east of Mordor and the Sea of Rhûn. Easterlings were enemies of the Free Peoples since the First Age, and a populous vassal of Sauron throughout the Second and Third Ages.",
                            Name = "Easterlings"
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Dragons were ancient, intelligent, powerful creatures, as feared as they were admired in Middle-earth. Their exact origin is debated, though it was clearly stated that they were created by Morgoth in some sense, millennia before the events of The Hobbit and The Lord of the Rings.",
                            Name = "Dragons"
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Trolls were a very large and monstrous, and for the most part unintelligent,[1] humanoid race inhabiting Middle-earth.",
                            Name = "Trolls"
                        });
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.Realm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Realms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Khazad-dûm, commonly known as Moria or the Dwarrowdelf, was an underground kingdom beneath the Misty Mountains. It was known for being the ancient realm of the Dwarves of Durin's Folk, and the most famed of all Dwarven realms.",
                            Name = "Khazad-dûm"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Mount Gundabad was an Orc mountain-stronghold situated at the northern end of the Misty Mountains, located to the east of the ancient realm of Angmar.",
                            Name = "Mount Gundabad"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "he Lonely Mountain, known in Sindarin as Erebor, referred to both a mountain in northern Rhovanion and the subterranean Dwarven city contained within it. In the latter half of the Third Age, it became the greatest Dwarf city in Middle-earth. It was located northeast of Mirkwood, near the Grey Mountains, and was the source of the River Running.",
                            Name = "Erebor"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Iron Hills, or Emyn Engrin in Sindarin, were a range of hills located in the north-east of Middle-earth, and was a settlement of the Dwarves of Durin's Folk.",
                            Name = "Iron Hills"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nogrod was one of two Dwarven cities in the Blue Mountains. It lay in the middle of the range, near Mount Dolmed where the Dwarf-road of Beleriand crossed into Eriador. ogrod was home to the great Dwarven smiths Gamil Zirak and Telchar.",
                            Name = "Nogrod"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lothlórien, also known as Lórien, was a forest and Elven realm near the lower Misty Mountains. It was first settled by Nandorin Elves, but they were later joined by a small number of Ñoldor and Sindar under Celeborn of Doriath and Galadriel, daughter of Finarfin. It was located on the River Celebrant, southeast of Khazad-dûm, and was the only place in Middle-earth where the golden Mallorn trees grew.",
                            Name = "Lothlórien"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gondolin was a hidden city of the Elves located approximately in the middle of the land of Beleriand in Middle-earth. It was founded by Turgon the Wise, a Ñoldorin king in the early First Age. It endured the longest of all the Ñoldorin kingdoms in exile, lasting nearly four centuries during the Years of the Sun.",
                            Name = "Gondolin"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rivendell, also known as Imladris in Sindarin, was an Elven town and the house of Elrond located in Middle-earth. It is described as The Last Homely House East of the Sea in reference to Valinor, which was west of the Great Sea in Aman.",
                            Name = "Rivendell"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gondor was the most prominent kingdom of Men in Middle-earth, bordered by Rohan to the north, Harad to the south, the cape of Andrast and the Sea to the west, and Mordor to the east. Its first capital was Osgiliath, moved to Minas Anor in TA 1640. This city, later renamed Minas Tirith, remained the capital of Gondor for the rest of the Third Age and into the Fourth Age; other major fortresses included Pelargir, Dol Amroth in Belfalas and Minas Ithil.",
                            Name = "Gondor"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rohan, or the Riddermark (Rohirric), was a great kingdom of Men located in the land once known as Calenardhon, situated in the plains between the Misty Mountains and the White Mountains. The land of Rohan extended from the banks of the river Isen in the west, up to the East wall of Rohan and shores of the river Anduin in the east. The forest of Fangorn lay on its border, and the Elven forest of Lothlórien lay north of the river Limlight.",
                            Name = "Rohan"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Mordor was a black, volcanic plain in the southeast of Middle-earth to the east of Gondor, Ithilien, and the great river Anduin. Mordor was chosen by Sauron as his realm because of the mountain ranges surrounding it on three sides, creating a natural fortress against his enemies.",
                            Name = "Mordor"
                        });
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sword"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bow"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Spear"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Staff"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Axe"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Hammer"
                        });
                });

            modelBuilder.Entity("CharacterWeapon", b =>
                {
                    b.HasOne("MiddleEarth.Core.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiddleEarth.Core.Models.Weapon", null)
                        .WithMany()
                        .HasForeignKey("WeaponsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.Character", b =>
                {
                    b.HasOne("MiddleEarth.Core.Models.Race", "Race")
                        .WithMany("Characters")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiddleEarth.Core.Models.Realm", "Realm")
                        .WithMany("Characters")
                        .HasForeignKey("RealmId");

                    b.Navigation("Race");

                    b.Navigation("Realm");
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.CharacterFeature", b =>
                {
                    b.HasOne("MiddleEarth.Core.Models.Character", "Character")
                        .WithOne("CharacterFeature")
                        .HasForeignKey("MiddleEarth.Core.Models.CharacterFeature", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.Character", b =>
                {
                    b.Navigation("CharacterFeature")
                        .IsRequired();
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.Race", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("MiddleEarth.Core.Models.Realm", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
