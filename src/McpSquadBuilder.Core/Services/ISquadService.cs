using McpSquadBuilder.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace McpSquadBuilder.Core.Services
{
    public interface ISquadService
    {
        IEnumerable<Squad> GetPossibleSquads(IEnumerable<SquadMember> roster, int targetPoints, SquadOption squadOption = SquadOption.LeaderOnly);
        bool IsSquadValid(Squad squad, SquadOption squadOption);
        IEnumerable<Affiliation> GetSquadAffiliations(List<SquadMember> members);
    }
}
