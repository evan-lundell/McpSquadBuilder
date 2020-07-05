using McpSquadBuilder.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McpSquadBuilder.Core.Tests
{
    public class AffiliationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var avengersAffiliation = TestData.Affiliations.FirstOrDefault(a => a.Name.Equals("Avengers", StringComparison.OrdinalIgnoreCase));
            var wakandanAffiliation = TestData.Affiliations.FirstOrDefault(a => a.Name.Equals("Wakandans", StringComparison.OrdinalIgnoreCase));

            yield return new object[]
            {
                new SquadMember[]
                {
                    new McpCharacter
                    {
                        Name = "Captain America",
                        AlterEgo = "Steve Rodgers",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Hulk",
                        AlterEgo = "Bruce Banner",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Thor, Prince of Asgard",
                        AlterEgo = "Thor Odinson",
                        PointCost = 5,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    }
                },
                new Affiliation[]
                {
                    avengersAffiliation
                }
            };

            yield return new object[]
            {
                new SquadMember[]
                {
                    new McpCharacter
                    {
                        Name = "Captain America",
                        AlterEgo = "Steve Rodgers",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Hulk",
                        AlterEgo = "Bruce Banner",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Thor, Prince of Asgard",
                        AlterEgo = "Thor Odinson",
                        PointCost = 5,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Baron Zemo",
                        AlterEgo = "Helmut Zemo",
                        PointCost = 3,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    }
                },
                new Affiliation[]
                {
                    avengersAffiliation
                }
            };

            yield return new object[]
            {
                new SquadMember[]
                {
                    new McpCharacter
                    {
                        Name = "Captain America",
                        AlterEgo = "Steve Rodgers",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Black Panther",
                        AlterEgo = "T'Challa",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Shuri",
                        AlterEgo = "Shuri",
                        PointCost = 3,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Okoye",
                        AlterEgo = "Okoye",
                        PointCost = 2,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Black Widow",
                        AlterEgo = "Natasha Romanoff",
                        PointCost = 2,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    }
                },
                new Affiliation[]
                {
                    avengersAffiliation,
                    wakandanAffiliation
                }
            };

            yield return new object[]
            {
                new SquadMember[]
                {
                    new McpCharacter
                    {
                        Name = "Captain America",
                        AlterEgo = "Steve Rodgers",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Iron Man",
                        AlterEgo = "Tony Stark",
                        PointCost = 3,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Winter Soldier",
                        AlterEgo = "James \"Bucky\" Barnes",
                        PointCost = 3,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = true
                    },
                    new McpCharacter
                    {
                        Name = "Spider-Man",
                        AlterEgo = "Peter Parker",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Drax the Destroyer",
                        AlterEgo = "Drax",
                        PointCost = 3,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    }
                },
                new Affiliation[]
                {
                    avengersAffiliation
                }
            };

            yield return new object[]
            {
                new SquadMember[]
                {
                    new McpCharacter
                    {
                        Name = "Captain America",
                        AlterEgo = "Steve Rodgers",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Iron Man",
                        AlterEgo = "Tony Stark",
                        PointCost = 3,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Winter Soldier",
                        AlterEgo = "James \"Bucky\" Barnes",
                        PointCost = 3,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = true
                    },
                    new McpCharacter
                    {
                        Name = "Black Panther",
                        AlterEgo = "T'Challa",
                        PointCost = 4,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "Shuri",
                        AlterEgo = "Shuri",
                        PointCost = 3,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                },
                new Affiliation[]
                {
                    avengersAffiliation,
                    wakandanAffiliation
                }
            };

            yield return new object[]
            {
                new SquadMember[]
                {
                    new McpCharacter
                    {
                        Name = "Hulk",
                        AlterEgo = "Bruce Banner",
                        PointCost = 6,
                        InfinityGems = new InfinityGem[0],
                        IsRogue = false
                    },
                    new McpCharacter
                    {
                        Name = "M.O.D.O.K.",
                        PointCost = 5,
                        AlterEgo = "George Tarleton",
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
                    new InfinityGem
                    {
                        Name = "Time Gem",
                        PointCost = 2
                    }
                },
                new Affiliation[0]
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
