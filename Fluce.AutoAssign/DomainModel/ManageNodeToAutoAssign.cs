using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel
{
   public class ManageNodeToAutoAssign
    {
        /// <summary>
        /// Node信息
        /// </summary>
        public string NodeName { get; set; }
        public int NodeId { get; set; }
        /// <summary>
        /// 可供分配的时间
        /// </summary>
        public TimeScale TimeScale { get; set; }
    }
}
