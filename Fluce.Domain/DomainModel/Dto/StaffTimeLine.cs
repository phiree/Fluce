using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluce.Domain.DomainModel
{
    /// <summary>
    /// 人员的时间线,一种dto,来自任务分配
    /// </summary>
    public class StaffTimeLine
    {
        public StaffToAutoAssign StaffId { get; set; }
        IList<Period> AssignedPeriod { get; set; }
    }
    public class Period
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
