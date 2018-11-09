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
        public IList<RequirementResource> CostResources { get; set; }
    }
    /// <summary>
    ///  所需资源,  技能/时间/人力
    /// </summary>

    public class RequirementResource
    {
        public Skill Skill { get; set; }
        public HRCost HRCost { get; set; }
    }
}
