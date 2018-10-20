﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluce.AutoAssign.DomainModel
{
    /// <summary>
    /// 人员的时间线,一种dto,来自任务分配
    /// </summary>
    public class StaffToAutoAssign:DomainEntity<Guid>
    {
        public decimal SkillLevel { get; set; }
        
        IList<Period> AssignedPeriod { get; set; }
    }
}
