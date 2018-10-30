using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluce.AutoAssign.DomainModel
{
    public class RequirementToAutoAssign:DomainEntity<Guid>
    {
        public DateTime StartTime { get; set;}
        public DateTime DealLine { get; set; }

    }
}
