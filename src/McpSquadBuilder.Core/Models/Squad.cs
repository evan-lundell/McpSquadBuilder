using System;
using System.Collections.Generic;
using System.Text;

namespace McpSquadBuilder.Core.Models
{
    public class Squad
    {
        public IEnumerable<SquadMember> Members { get; set; }
        public IEnumerable<Affiliation> Affiliations { get; set; }

        public Squad()
        {
            Members = new List<SquadMember>();
            Affiliations = new List<Affiliation>();
        }
    }
}
