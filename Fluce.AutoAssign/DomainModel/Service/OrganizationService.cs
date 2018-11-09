using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel.Service
{
    public interface IOrganizationService
    {
        IList<StaffId> FindStaffs(IList<string> groupIds);
    }
}
