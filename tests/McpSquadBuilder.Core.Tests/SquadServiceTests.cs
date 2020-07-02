using McpSquadBuilder.Core.Models;
using McpSquadBuilder.Core.Services;
using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace McpSquadBuilder.Core.Tests
{
    public class SquadServiceTests
    {
        [Fact]
        public void GetPossibleSquads_Not10Members_ThrowsException()
        {
            var squadService = new SquadService(TestData.Affiliations);
            var roster = new SquadMember[]
            {
                new McpCharacter
                {
                    Name = "Captain America",
                    PointCost = 4,
                    AlterEgo = "Steve Rodgers"
                },
                new InfinityGem
                {
                    Name = "Time Gem",
                    PointCost = 1
                }
            };

            Assert.Throws<ArgumentException>(() => squadService.GetPossibleSquads(roster, 15));
        }

        [Fact]
        public void GetPossibleSquads_AffiliationNull_ThrowsException()
        {
            var squadService = new SquadService(null);
            var roster = BuildRoster();

            Assert.Throws<Exception>(() => squadService.GetPossibleSquads(roster, 15));
        }

        [Theory]
        [ClassData(typeof(SquadServiceCountTestData))]
        public void GetPossibleSquads_SquadCount(IEnumerable<SquadMember> roster, int targetPoints, SquadOption squadOption, int expectedCount)
        {
            var squadService = new SquadService(TestData.Affiliations);
            var squads = squadService.GetPossibleSquads(roster, targetPoints, squadOption);

            Assert.Equal(expectedCount, squads.Count());
        }

        [Theory]
        [ClassData(typeof(InfinityGemTestData))]
        public void IsSquadValid_InfinityGems(Squad squad, SquadOption squadOption, bool expected)
        {
            var squadService = new SquadService(TestData.Affiliations);
            var isSquadValid = squadService.IsSquadValid(squad, squadOption);

            Assert.Equal(expected, isSquadValid);
        }

        private SquadMember[] BuildRoster()
        {
            return new SquadMember[]
            {
                new McpCharacter
                {
                    Name = "Captain America",
                    PointCost = 4,
                    AlterEgo = "Steve Rodgers"
                },
                new McpCharacter
                {
                    Name = "Black Widow",
                    PointCost = 2,
                    AlterEgo = "Natasha Romanoff"
                },
                new McpCharacter
                {
                    Name = "Hulk",
                    PointCost = 6,
                    AlterEgo = "Bruce Banner"
                },
                new McpCharacter
                {
                    Name = "Baron Zemo",
                    PointCost = 3,
                    AlterEgo = "Helmut Zemo"
                },
                new McpCharacter
                {
                    Name = "Ultron",
                    PointCost = 4,
                    AlterEgo = "Ultron"
                },
                new McpCharacter
                {
                    Name = "Black Panther",
                    PointCost = 4,
                    AlterEgo = "T'Challa"
                },
                new McpCharacter
                {
                    Name = "Doctor Octopus",
                    PointCost = 3,
                    AlterEgo = "Otto Octavius"
                },
                new McpCharacter
                {
                    Name = "Killmonger",
                    PointCost = 4,
                    AlterEgo = "N'Jadaka"
                },
                new McpCharacter
                {
                    Name = "Corvus Glaive",
                    PointCost = 4,
                    AlterEgo = "Corvus Glaive"
                },
                new McpCharacter
                {
                    Name = "Okoye",
                    PointCost = 2,
                    AlterEgo = "Okoye"
                }
            };
        }
    }
}
