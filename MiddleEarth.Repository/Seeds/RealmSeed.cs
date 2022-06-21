using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiddleEarth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Repository.Seeds
{
    internal class RealmSeed : IEntityTypeConfiguration<Realm>
    {
        public void Configure(EntityTypeBuilder<Realm> builder)
        {
            builder.HasData(
                new Realm
                {
                    Id = 1,
                    Name = "Khazad-dûm",
                    Description = "Khazad-dûm, commonly known as Moria or the Dwarrowdelf, was an underground kingdom beneath the Misty Mountains. It was known for being the ancient realm of the Dwarves of Durin's Folk, and the most famed of all Dwarven realms."
                },
                new Realm
                {
                    Id = 2,
                    Name = "Mount Gundabad",
                    Description = "Mount Gundabad was an Orc mountain-stronghold situated at the northern end of the Misty Mountains, located to the east of the ancient realm of Angmar."
                },
                new Realm
                {
                    Id = 3,
                    Name = "Erebor",
                    Description = "he Lonely Mountain, known in Sindarin as Erebor, referred to both a mountain in northern Rhovanion and the subterranean Dwarven city contained within it. In the latter half of the Third Age, it became the greatest Dwarf city in Middle-earth. It was located northeast of Mirkwood, near the Grey Mountains, and was the source of the River Running."
                },
                new Realm
                {
                    Id = 4,
                    Name = "Iron Hills",
                    Description = "The Iron Hills, or Emyn Engrin in Sindarin, were a range of hills located in the north-east of Middle-earth, and was a settlement of the Dwarves of Durin's Folk."
                },
                new Realm
                {
                    Id = 5,
                    Name = "Nogrod",
                    Description = "Nogrod was one of two Dwarven cities in the Blue Mountains. It lay in the middle of the range, near Mount Dolmed where the Dwarf-road of Beleriand crossed into Eriador. ogrod was home to the great Dwarven smiths Gamil Zirak and Telchar."
                },
                new Realm
                {
                    Id = 6,
                    Name = "Lothlórien",
                    Description = "Lothlórien, also known as Lórien, was a forest and Elven realm near the lower Misty Mountains. It was first settled by Nandorin Elves, but they were later joined by a small number of Ñoldor and Sindar under Celeborn of Doriath and Galadriel, daughter of Finarfin. It was located on the River Celebrant, southeast of Khazad-dûm, and was the only place in Middle-earth where the golden Mallorn trees grew."
                },
                new Realm
                {
                    Id = 7,
                    Name = "Gondolin",
                    Description = "Gondolin was a hidden city of the Elves located approximately in the middle of the land of Beleriand in Middle-earth. It was founded by Turgon the Wise, a Ñoldorin king in the early First Age. It endured the longest of all the Ñoldorin kingdoms in exile, lasting nearly four centuries during the Years of the Sun."
                },
                new Realm
                {
                    Id = 8,
                    Name = "Rivendell",
                    Description = "Rivendell, also known as Imladris in Sindarin, was an Elven town and the house of Elrond located in Middle-earth. It is described as The Last Homely House East of the Sea in reference to Valinor, which was west of the Great Sea in Aman."
                },
                new Realm
                {
                    Id = 9,
                    Name = "Gondor",
                    Description = "Gondor was the most prominent kingdom of Men in Middle-earth, bordered by Rohan to the north, Harad to the south, the cape of Andrast and the Sea to the west, and Mordor to the east. Its first capital was Osgiliath, moved to Minas Anor in TA 1640. This city, later renamed Minas Tirith, remained the capital of Gondor for the rest of the Third Age and into the Fourth Age; other major fortresses included Pelargir, Dol Amroth in Belfalas and Minas Ithil."
                },
                new Realm
                {
                    Id = 10,
                    Name = "Rohan",
                    Description = "Rohan, or the Riddermark (Rohirric), was a great kingdom of Men located in the land once known as Calenardhon, situated in the plains between the Misty Mountains and the White Mountains. The land of Rohan extended from the banks of the river Isen in the west, up to the East wall of Rohan and shores of the river Anduin in the east. The forest of Fangorn lay on its border, and the Elven forest of Lothlórien lay north of the river Limlight."
                },
                new Realm
                {
                    Id = 11,
                    Name = "Mordor",
                    Description = "Mordor was a black, volcanic plain in the southeast of Middle-earth to the east of Gondor, Ithilien, and the great river Anduin. Mordor was chosen by Sauron as his realm because of the mountain ranges surrounding it on three sides, creating a natural fortress against his enemies."
                }
                );
        }
    }
}
