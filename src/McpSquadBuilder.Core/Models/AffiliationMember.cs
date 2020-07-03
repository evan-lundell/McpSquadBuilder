using System;
using System.Collections.Generic;
using System.Text;

namespace McpSquadBuilder.Core.Models
{
    public class AffiliationMember
    {
        public McpCharacter McpCharacter { get; set; }
        public bool IsLeader { get; set; }
    }
}
