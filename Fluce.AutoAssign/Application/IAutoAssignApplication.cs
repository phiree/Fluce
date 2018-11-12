using Fluce.AutoAssign.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.Application
{
    public interface IAutoAssignApplication
    {
        /// <summary>
        /// 需求分配
        /// </summary>
        /// <param name="requirementId">需求id</param>
        /// <param name="staffIds">参与任务分配的人 v2: groupids</param>
        /// <returns></returns>
        IList<Assignment> Assign(string requirementId, IList<string> staffIds);


    }
}
