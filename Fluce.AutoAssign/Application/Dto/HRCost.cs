using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.Application.Dto
{
   public  class HRCost
    {
        public string StaffId { get; set; }
        /// <summary>
        /// 需要的时间
        /// </summary>
        public int DaysSpent { get; set; }
    }
}
