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
    internal class RaceSeed : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.HasData(
                new Race
                {
                    Id = 1,
                    Name = "Elves",
                    Description = "The Elves, who called themselves the Quendi (Q.: Speakers) and who in lore are commonly referred to as Eldar (Q.: People of the Stars), were the first and eldest of the Children of Ilúvatar, considered the fairest and wisest of the earthly race of Arda."
                },
                new Race
                {
                    Id = 2,
                    Name = "Dwarves",
                    Description = "Dwarves were a race of Middle-earth also known as the Khazâd (in their own tongue) or Casari, Naugrim, meaning 'Stunted People', and Gonnhirrim, the 'Masters of Stone'."
                },
                new Race
                {
                    Id = 3,
                    Name = "Men",
                    Description = "During the time of The Lord of the Rings, Men in Middle-earth were located in many places, with the largest group of free men in the countries of Gondor and Rohan. When the island of Númenor fell, only the Faithful escaped and founded the twin kingdoms of Gondor and Arnor. The Faithful were known in Middle-earth as the Dúnedain, and as leaders of these kingdoms, they were able to lead the resistance to Sauron, and preserve the Men of the West as Free People. There were also free men at the village of Bree, at Esgaroth, in Drúadan Forest (home to wild men known as Drúedain or Woses), and in the icy regions of Forochel. Those who served evil powers, such as the men of Dunland, Rhûn, Harad, and Umbar, were not considered free men. Men bear the so-called Gift of Men, mortality. The descendants of the Dúnedain include the Rangers of the North and the Rangers of Ithilien.[4]"
                },
                new Race
                {
                    Id = 4,
                    Name = "Drúedain",
                    Description = "The Drúedain somewhat resemble Dwarves in stature and endurance; they are stumpy, clumsy-limbed with short, thick legs, and fat, gnarled arms, broad chests, fat bellies, and heavy buttocks. According to the Elves and other Men, they had unlovely faces: wide, flat, and expressionless with deep-set black eyes that glowed red when angered. They had horny brows, flat noses, wide mouths, and sparse, lank hair. They had no hair lower than the eyebrows, except for a few men who had a tail of black hair on the chin. They were short-lived and had a deep hatred of Orcs.[T 1] They had certain magical powers and sat still in meditation for long periods."
                },
                new Race
                {
                    Id = 5,
                    Name = "Hobbits",
                    Description = "Hobbits, also known as Halflings, were an ancient mortal race that lived in Middle-earth. Although their exact origins are unknown, they were initially found in the northern regions of Middle-earth and below the Vales of Anduin. At the beginning of the Third Age, hobbits moved north and west. Most of their race eventually founded the land of the Shire in the year TA 1601, though one type of hobbit known as Stoors remained in the Anduin Vale (the type of hobbit Sméagol was)."
                },
                new Race
                {
                    Id = 6,
                    Name = "Ents",
                    Description = "Ents, also known as Onodrim (Tree-host) by the Elves, were a very old race of Middle-earth. They were apparently created at the behest of Yavanna after she learned of Aulë's children, the Dwarves, knowing that they would want to fell trees. Becoming shepherds of the trees, they protected certain forests from Orcs and other perils. The Elves had tales of teaching the trees and the Ents to talk: although the Ents were sentient beings at the time, they did not know how to speak until the Elves taught them. Treebeard spoke of the Elves curing the Ents of their dumbness, an unforgettable gift."
                },
                new Race
                {
                    Id = 7,
                    Name = "Maiar",
                    Description = "The Maiar (singular Maia) were primordial spirits created to help the Valar first shape the World. They were numerous, though not many were named. Their chiefs were Eönwë, banner-bearer and herald of Manwë, and Ilmarë, the handmaid of Varda. Five of these spirits, in the Third Age, became the incarnated Wizards."
                },
                new Race
                {
                    Id = 8,
                    Name = "Valar",
                    Description = "The Valar (Quenya; singular Vala) were the Powers of Arda who shaped and ruled the world. They lived on the Western continent of Aman."
                },
                new Race
                {
                    Id = 9,
                    Name = "Balrogs",
                    Description = "Balrogs, also known as the Valaraukar, were Maiar that were seduced and corrupted by Melkor into his service."
                },
                new Race
                {
                    Id = 10,
                    Name = "Orcs",
                    Description = "Orcs were the primary soldiers of the Dark Lord's armies and sometimes the weakest (but most numerous) of their servants. They were created by the first Dark Lord, Morgoth, before the First Age and served him and later his successor in their quest to dominate Middle-earth. Before Oromë first found the Elves at Cuiviénen, Melkor kidnapped some of them and cruelly deformed them, twisting them into the first Orcs."
                },
                new Race
                {
                    Id = 11,
                    Name = "Barrow-wights",
                    Description = "Wights appeared as dark phantoms whose eyes were luminous and cold, and whose voice was horrible yet hypnotic; their skeletal hands had a touch like ice and a deadly grip. Victims under a Wight's spell would lose their will; in this way the Barrow-wights drew the living into the tombs of the downs. Some, if not all, victims were laid on a stone altar and bound in chains of gold, to then be draped in pale cloth and jewelry of ancient dead, and killed by a wight with a sacrificial sword."
                },
                new Race
                {
                    Id = 12,
                    Name = "Easterlings",
                    Description = "Easterlings, known in early times as Swarthy Men, were a race of Men who eventually populated the vast, uncharted lands of Rhûn, east of Mordor and the Sea of Rhûn. Easterlings were enemies of the Free Peoples since the First Age, and a populous vassal of Sauron throughout the Second and Third Ages."
                },
                new Race
                {
                    Id = 13,
                    Name = "Dragons",
                    Description = "Dragons were ancient, intelligent, powerful creatures, as feared as they were admired in Middle-earth. Their exact origin is debated, though it was clearly stated that they were created by Morgoth in some sense, millennia before the events of The Hobbit and The Lord of the Rings."
                },
                new Race
                {
                    Id = 14,
                    Name = "Trolls",
                    Description = "Trolls were a very large and monstrous, and for the most part unintelligent,[1] humanoid race inhabiting Middle-earth."
                }
                );
        }
    }
}
