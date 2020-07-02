using McpSquadBuilder.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace McpSquadBuilder.Core.Tests
{
    internal static class TestData
    {
        private static Affiliation[] _affiliations;

        internal static Affiliation[] Affiliations
        {
            get
            {
                if (_affiliations == null)
                {
                    _affiliations = new Affiliation[]
                    {
                        new Affiliation
                        {
                            Name = "Avengers",
                            Members = new AffiliationMember[]
                            {
                                new AffiliationMember
                                {
                                    IsLeader = true,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Captain America",
                                        PointCost = 4,
                                        AlterEgo = "Steve Rodgers",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Black Panther",
                                        PointCost = 4,
                                        AlterEgo = "T'Challa",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Black Widow",
                                        PointCost = 2,
                                        AlterEgo = "Natasha Romanoff",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Black Widow, Agent of S.H.I.E.L.D.",
                                        PointCost = 3,
                                        AlterEgo = "Natasha Romanoff",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Captain Marvel",
                                        PointCost = 4,
                                        AlterEgo = "Carol Danvers",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Hawkeye",
                                        PointCost = 3,
                                        AlterEgo = "Clinton Barton",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Hulk",
                                        PointCost = 6,
                                        AlterEgo = "Bruce Banner",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Iron Man",
                                        PointCost = 3,
                                        AlterEgo = "Tony Stark",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Thor, Prince of Asgard",
                                        PointCost = 5,
                                        AlterEgo = "Thor Odinson",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Vision",
                                        PointCost = 4,
                                        AlterEgo = "Victor Shade",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                }
                            }
                        },
                        new Affiliation
                        {
                            Name = "Cabal",
                            Members = new AffiliationMember[]
                            {
                                new AffiliationMember
                                {
                                    IsLeader = true,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Red Skull",
                                        PointCost = 4,
                                        AlterEgo = "Johann Schmidt",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Baron Zemo",
                                        PointCost = 3,
                                        AlterEgo = "Helmut Zemo",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Crossbones",
                                        PointCost = 3,
                                        AlterEgo = "Brock Rumlow",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Killmonger",
                                        PointCost = 4,
                                        AlterEgo = "N'Jadaka",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Loki, God of Mischief",
                                        PointCost = 4,
                                        AlterEgo = "Loki Laufeyson",
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
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Modok",
                                        PointCost = 5,
                                        AlterEgo = "George Tarleton",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Ultron",
                                        PointCost = 4,
                                        AlterEgo = "Ultron",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                }
                            }
                        },
                        new Affiliation
                        {
                            Name = "Wakandans",
                            Members = new AffiliationMember[]
                            {
                                new AffiliationMember
                                {
                                    IsLeader = true,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Black Panther",
                                        PointCost = 4,
                                        AlterEgo = "T'Challa",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Killmonger",
                                        PointCost = 4,
                                        AlterEgo = "N'Jadaka",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Okoye",
                                        PointCost = 2,
                                        AlterEgo = "Okoye",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Shuri",
                                        PointCost = 3,
                                        AlterEgo = "Shuri",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                }
                            }
                        },
                        new Affiliation
                        {
                            Name = "Asgardians",
                            Members = new AffiliationMember[]
                            {
                                new AffiliationMember
                                {
                                    IsLeader = true,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Thor, Prince of Asgard",
                                        PointCost = 5,
                                        AlterEgo = "Thor Odinson",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Loki, God of Mischief",
                                        PointCost = 4,
                                        AlterEgo = "Loki Laufeyson",
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
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Hela, Queen of Hel",
                                        PointCost = 4,
                                        AlterEgo = "Hela",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Valkyrie",
                                        PointCost = 3,
                                        AlterEgo = "Brunhilde",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                }
                            }
                        },
                        new Affiliation
                        {
                            Name = "Guardians of the Galaxy",
                            Members = new AffiliationMember[]
                            {
                                new AffiliationMember
                                {
                                    IsLeader = true,
                                    McpCharacter = new McpCharacter
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
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Drax the Destroyer",
                                        PointCost = 3,
                                        AlterEgo = "Drax",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Gamora",
                                        PointCost = 4,
                                        AlterEgo = "Gamora",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Groot",
                                        PointCost = 3,
                                        AlterEgo = "I Am Groot",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Ronan the Accuser",
                                        PointCost = 4,
                                        AlterEgo = "Ronan the Accuser",
                                        InfinityGems = new InfinityGem[]
                                        {
                                            new InfinityGem
                                            {
                                                Name = "Power Gem",
                                                PointCost = 1
                                            }
                                        },
                                        IsRogue = false
                                    }
                                }
                            }
                        },
                        new Affiliation
                        {
                            Name = "Black Order",
                            Members = new AffiliationMember[]
                            {
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Black Dwarf",
                                        PointCost = 4,
                                        AlterEgo = "Black Dwarf",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
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
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
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
                                    }
                                },
                                new AffiliationMember
                                {
                                    IsLeader = false,
                                    McpCharacter = new McpCharacter
                                    {
                                        Name = "Proxima Midnight",
                                        PointCost = 3,
                                        AlterEgo = "Proxima Midnight",
                                        InfinityGems = new InfinityGem[0],
                                        IsRogue = false
                                    }
                                }
                            }
                        }
                    };
             
                }

                return _affiliations;
            }
        }
    }
}
