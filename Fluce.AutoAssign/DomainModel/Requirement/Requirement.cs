using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel.Requirement
{
    public class Requirement:DomainEntity<Guid>
    {
        
        public string Name { get; set; }
       
        public DateTime? BeginDate { get; set; }
        public DateTime? DeadLine { get; set; }
    }
}
