using System;
using System.Collections.Generic;
using System.Text;
using McpSquadBuilder.Core.Models;
using System.Linq;

namespace McpSquadBuilder.Core.Services
{
    public class SquadService : ISquadService
    {
        private readonly IEnumerable<Affiliation> _affiliations;

        public SquadService(IEnumerable<Affiliation> affiliations)
        {
            _affiliations = affiliations;
        }

        public IEnumerable<Squad> GetPossibleSquads(IEnumerable<SquadMember> roster, int targetPoints, SquadOption squadOption = SquadOption.LeaderOnly)
        {
            if (roster.Count() != 10)
            {
                throw new ArgumentException("Roster must contain 10 characters/infinity gems", nameof(roster));
            }

            if (_affiliations == null)
            {
                throw new Exception("Affiliations not loaded");
            }

            var sortedRoster = roster.OrderByDescending(r => r.PointCost).ToList();
            return GetPossibleSquads(sortedRoster, new List<SquadMember>(), targetPoints, squadOption);
        }

        private IEnumerable<Squad> GetPossibleSquads(List<SquadMember> roster, List<SquadMember> partial, int targetPoints, SquadOption squadOption)
        {
            var squads = new List<Squad>();
            var sum = partial.Sum(r => r.PointCost);
            if (sum == targetPoints)
            {
                var affiliations = GetSquadAffiliations(partial);

                var squad  = new Squad
                {
                    Members = partial,
                    Affiliations = affiliations
                };

                if (IsSquadValid(squad, squadOption))
                {
                    squads.Add(squad);
                }
            }

            if (sum >= targetPoints)
            {
                return squads;
            }

            for (int i = 0; i < roster.Count; i++)
            {
                var remaining = new List<SquadMember>();
                var rosterMember = roster[i];
                for (int j = i + 1; j < roster.Count; j++)
                {
                    remaining.Add(roster[j]);
                }

                var newPartial = new List<SquadMember>(partial);
                newPartial.Add(rosterMember);
                squads.AddRange(GetPossibleSquads(remaining, newPartial, targetPoints, squadOption));
            }

            return squads;
        }

        public bool IsSquadValid(Squad squad, SquadOption squadOption)
        {
            foreach (var member in squad.Members.Where(m => m is InfinityGem))
            {
                var gem = member as InfinityGem;
                if (!squad.Members.Any(m => m is McpCharacter character && character.InfinityGems.Any(ig => ig.Equals(gem))))
                {
                    return false;
                }
            }

            switch (squadOption)
            {
                case SquadOption.AffiliationOnly:
                    if (squad.Affiliations.Any())
                    {
                        return true;
                    }
                    return false;
                case SquadOption.LeaderOnly:
                    foreach (var affiliation in squad.Affiliations)
                    {
                        foreach (var leader in affiliation.Members.Where(m => m.IsLeader))
                        {
                            if (squad.Members.Any(m => m.Equals(leader.McpCharacter)))
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                default:
                    return true;

            }
        }

        public IEnumerable<Affiliation> GetSquadAffiliations(List<SquadMember> members)
        {
            var affiliationCount = new Dictionary<string, int>();
            var characterCount = 0;
            foreach (var member in members.Where(m => m is McpCharacter))
            {
                characterCount++;
                foreach (var affiliation in _affiliations.Where(a => a.Members.Any(m => m.McpCharacter.Equals(member))))
                {
                    if (!affiliationCount.ContainsKey(affiliation.Name))
                    {
                        affiliationCount.Add(affiliation.Name, 0);
                    }
                    affiliationCount[affiliation.Name]++;
                }
            }

            var rogueCount = members
                .Where(m => m is McpCharacter mcpCharacter && mcpCharacter.IsRogue)
                .Count();

            var validAffiliations = affiliationCount
                .Where(a => Convert.ToDecimal(a.Value + rogueCount) / characterCount > .5m)
                .Select(a => a.Key);

            return _affiliations.Where(a => validAffiliations.Any(va => a.Name.Equals(va))).ToList();
        }
    }
}
