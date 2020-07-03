using McpSquadBuilder.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace McpSquadBuilder.Core.Tests
{
    public class SquadServiceCountTestData : IEnumerable<object[]>
    {
        private readonly SquadMember[] _roster;

        public SquadServiceCountTestData()
        {
            _roster = new SquadMember[]
            {
                new McpCharacter
                {
                    Name = "Captain America",
                    PointCost = 4,
                    AlterEgo = "Steve Rodgers",
                    InfinityGems = new InfinityGem[0],
                    IsRogue = false
                },
                new McpCharacter
                {
                    Name = "Black Widow",
                    PointCost = 2,
                    AlterEgo = "Natasha Romanoff",
                    InfinityGems = new InfinityGem[0],
                    IsRogue = false
                },
                new McpCharacter
                {
                    Name = "Hulk",
                    PointCost = 6,
                    AlterEgo = "Bruce Banner",
                    InfinityGems = new InfinityGem[0],
                    IsRogue = false
                },
                new McpCharacter
                {
                    Name = "Baron Zemo",
                    PointCost = 3,
                    AlterEgo = "Helmut Zemo",
                    InfinityGems = new InfinityGem[0],
                    IsRogue = false
                },
                new McpCharacter
                {
                    Name = "Ultron",
                    PointCost = 4,
                    AlterEgo = "Ultron",
                    InfinityGems = new InfinityGem[0],
                    IsRogue = false
                },
                new McpCharacter
                {
                    Name = "Black Panther",
                    PointCost = 4,
                    AlterEgo = "T'Challa",
                    InfinityGems = new InfinityGem[0],
                    IsRogue = false
                },
                new McpCharacter
                {
                    Name = "Doctor Octopus",
                    PointCost = 3,
                    AlterEgo = "Otto Octavius",
                    InfinityGems = new InfinityGem[0],
                    IsRogue = false
                },
                new McpCharacter
                {
                    Name = "Killmonger",
                    PointCost = 4,
                    AlterEgo = "N'Jadaka",
                    InfinityGems = new InfinityGem[0],
                    IsRogue = false
                },
                new McpCharacter
                {
                    Name = "Corvus Glaive",
                    PointCost = 4,
                    AlterEgo = "Corvus Glaive",
                    InfinityGems = new InfinityGem[]
                    {
                        new InfinityGem
                        {
                            Name = "Reality Gem",
                            PointCost = 1
                        },
                        new InfinityGem
                        {
                            Name = "Time Gem",
                            PointCost = 2
                        }
                    },
                    IsRogue = false
                },
                new McpCharacter
                {
                    Name = "Okoye",
                    PointCost = 2,
                    AlterEgo = "Okoye",
                    InfinityGems = new InfinityGem[0],
                    IsRogue = false
                }
            };
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { _roster, 15, SquadOption.NoRestrictions, 60 };
            yield return new object[] { _roster, 17, SquadOption.AffiliationOnly, 24 };
            yield return new object[] { _roster, 18, SquadOption.LeaderOnly, 15 };
        }



        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
