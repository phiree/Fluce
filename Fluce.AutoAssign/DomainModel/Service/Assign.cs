using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel.Service
{
    /// <summary>
    /// 手动分配
    /// </summary>
    public class ManuallyAssign:IAssign
    {
        public IList<Assignment> Assign(DateTime? begin, DateTime? endTime, StaffId staffId,int daysSpend)
        {
            var assignments = new List<Assignment>();
            foreach (var cost in hrCosts)
            {

            }
        }
    }
}
