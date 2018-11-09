using System;
using System.Collections.Generic;
using System.Text;
using Fluce.AutoAssign.DomainModel;

namespace Fluce.AutoAssign.DomainModel
{
 
    public class AssignmentId : Fluce.Core.DomainModel.Identity
    {

    }

    /// <summary>
    /// 任务分配结果
    /// </summary>
    public class Assignment:DomainEntity<AssignmentId>
    {
        public StaffId StaffId { get; protected set; }
        public RequirementId RequirementId { get; protected set; }

        public FlucePeriod Period { get; }
        
    }
}
