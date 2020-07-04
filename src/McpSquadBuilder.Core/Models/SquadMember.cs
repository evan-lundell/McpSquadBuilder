using System;
using System.Collections.Generic;
using System.Text;

namespace McpSquadBuilder.Core.Models
{
    public abstract class SquadMember
    {
        public string Name { get; set; }
        public int PointCost { get; set; }
        public abstract string UniqueIdentifier { get; }

        public override bool Equals(object obj)
        {
            if (obj is SquadMember squadMember)
            {
                return squadMember.UniqueIdentifier.Equals(UniqueIdentifier, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return UniqueIdentifier.GetHashCode();
        }
    }
}
