using System;
using System.Collections.Generic;
using System.Text;
using Fluce.AutoAssign.DomainModel.Staff;
using Fluce.AutoAssign.DomainModel.Requirement;

namespace Fluce.AutoAssign.DomainModel.Assign
{
    /// <summary>
    /// 任务分配结果
    /// </summary>
    public class StaffAssignment
    {
        public StaffId StaffId { get; protected set; }
        public RequirementId RequirementId { get; protected set; }

        public FlucePeriod Period { get; }
        
    }
}
