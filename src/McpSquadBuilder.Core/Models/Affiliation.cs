using System;
using System.Collections.Generic;
using System.Text;

namespace McpSquadBuilder.Core.Models
{
    public class Affiliation
    {
        public ICollection<AffiliationMember> Members { get; set; }
        public string Name { get; set; }
    }
}
