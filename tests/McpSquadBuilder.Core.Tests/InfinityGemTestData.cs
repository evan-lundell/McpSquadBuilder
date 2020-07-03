using McpSquadBuilder.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace McpSquadBuilder.Core.Tests
{
    public class InfinityGemTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var avengersAffiliation = TestData.Affiliations.FirstOrDefault(a => a.Name == "Avengers");
            var gotgAffiliation = TestData.Affiliations.FirstOrDefault(a => a.Name == "Guardians of the Galaxy");
            var blackOrderAffiliation = TestData.Affiliations.FirstOrDefault(a => a.Name == "Black Order");

            yield return new object[]
            {
                new Squad
                {
                    Affiliations = new Affiliation[]
                    {
                        avengersAffiliation
                    },
                    Members = new SquadMember[]
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
                            Name = "Hulk",
                            PointCost = 6,
                            AlterEgo = "Bruce Banner",
                            InfinityGems = new InfinityGem[0],
                            IsRogue = false
                        },
                        new McpCharacter
                        {
                            Name = "Thor",
                            PointCost = 5,
                            AlterEgo = "Thor Odinson",
                            InfinityGems = new InfinityGem[0],
                            IsRogue = false
                        },
                        new InfinityGem
                        {
                            Name = "Time Gem",
                            PointCost = 2
                        }
                    }
                },
                SquadOption.LeaderOnly,
                false
            };

            yield return new object[]
            {
                new Squad
                {
                    Affiliations = new Affiliation[]
                    {
                        gotgAffiliation
                    },
                    Members = new SquadMember[]
                    {
                        new McpCharacter
                        {
                            Name = "Star-Lord",
                            PointCost = 3,
                            AlterEgo = "Peter Quill",
                            InfinityGems = new InfinityGem[]
                            {
                                new InfinityGem
                                {
                                    Name = "Power Gem",
                                    PointCost = 1
                                }
                            },
                            IsRogue = false
                        },
                        new McpCharacter
                        {
                            Name = "Gamora",
                            PointCost = 4,
                            AlterEgo = "Gamora",
                            InfinityGems = new InfinityGem[0],
                            IsRogue = false
                        },
                        new McpCharacter
                        {
                            Name = "Groot",
                            PointCost = 3,
                            AlterEgo = "I Am Groot",
                            InfinityGems = new InfinityGem[0],
                            IsRogue = false
                        },
                        new McpCharacter
                        {
                            Name = "Thor",
                            PointCost = 5,
                            AlterEgo = "Thor Odinson",
                            InfinityGems = new InfinityGem[0],
                            IsRogue = false
                        },
                        new InfinityGem
                        {
                            Name = "Space Gem",
                            PointCost = 2
                        }
                    }
                },
                SquadOption.LeaderOnly,
                false
            };

            yield return new object[]
            {
                new Squad
                {
                    Affiliations = new Affiliation[]
                    {
                        blackOrderAffiliation
                    },
                    Members = new SquadMember[]
                    {
                        new McpCharacter
                        {
                            Name = "Ebony Maw",
                            PointCost = 5,
                            AlterEgo = "Ebony Maw",
                            InfinityGems = new InfinityGem[]
                            {
                                new InfinityGem
                                {
                                    Name = "Mind Gem",
                                    PointCost = 1
                                },
                                new InfinityGem
                                {
                                    Name = "Space Gem",
                                    PointCost = 2
                                }
                            },
                            IsRogue = false
                        },
                        new McpCharacter
                        {
                            Name = "Black Dwarf",
                            PointCost = 4,
                            AlterEgo = "Black Dwarf",
                            InfinityGems = new InfinityGem[0],
                            IsRogue = false
                        },
                        new McpCharacter
                        {
                            Name = "Proxima Midnight",
                            PointCost = 3,
                            AlterEgo = "Proxima Midnight",
                            InfinityGems = new InfinityGem[0],
                            IsRogue = false
                        },
                        new McpCharacter
                        {
                            Name = "Gamora",
                            PointCost = 4,
                            AlterEgo = "Gamora",
                            InfinityGems = new InfinityGem[0],
                            IsRogue = false
                        },
                        new InfinityGem
                        {
                            Name = "Mind Gem",
                            PointCost = 1

                        }
                    }
                },
                SquadOption.AffiliationOnly,
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
