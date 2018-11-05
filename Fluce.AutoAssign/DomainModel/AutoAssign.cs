using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluce.AutoAssign.DomainModel
{
    /// <summary>
    /// 自动分配任务
    /// <delete>两层自动分配,需求人员 自动分配给某个管理节点, 节点管理人 自动分配到具体人员
    ///     <reason>自动计算部门时间无意义</reason>
    /// </delete>
    /// 
    /// </summary>
    public class AutoAssign
    {

        /// <param name="staffIdsToBeAssign">待分配人员及他们的时间安排</param>
        /// <param name="deadLine">截至日期</param>
        public IList<AutoAssignedResult> Assign(IList<StaffToAutoAssign> staffToAutoAssigns,DateTime deadLine)
        {
            //自动分配的人员范围

            //需求的截止日期
            foreach (var stafftoassign in staffToAutoAssigns)
            {

            }
        }
        /// <summary>
        /// 时间分配算法
        /// 
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="assignedPeriods">已经分配的时间</param>
        public void TimeAssign(DateTime start, DateTime end, IList<Period> assignedPeriods)
        {

        }


    }
}
