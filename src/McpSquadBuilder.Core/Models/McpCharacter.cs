using System;
using System.Collections.Generic;
using System.Text;

namespace McpSquadBuilder.Core.Models
{
    public class McpCharacter : SquadMember
    {
        public string AlterEgo { get; set; }
        public override string UniqueIdentifier => AlterEgo;
        public bool IsRogue { get; set; }
        public IEnumerable<InfinityGem> InfinityGems { get; set; }

        public McpCharacter()
        {
            InfinityGems = new List<InfinityGem>();
        }
    }
}
