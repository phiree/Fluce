using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel
{
    public class Requirement:DomainEntity<Guid>
    {
        
        public string Name { get; set; }
       
        public DateTime? BeginDate { get; set; }
        public DateTime? DeadLine { get; set; }
    }
}
