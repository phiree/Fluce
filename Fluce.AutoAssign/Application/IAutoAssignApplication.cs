using Fluce.AutoAssign.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.Application
{
    public interface IAutoAssignApplication
    {
        IList<AutoAssignedResult> Assign(IList<StaffToAutoAssign> staffToAutoAssigns, DateTime deadLine);


    }
}
