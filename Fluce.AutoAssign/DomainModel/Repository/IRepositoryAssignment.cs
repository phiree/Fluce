using System;
using System.Collections.Generic;

namespace Fluce.AutoAssign.DomainModel.Repository
{
    public interface IRepositoryAssignment : IRepository<Assignment,AssignmentId>
    {
        IList<Assignment> FindStaffAssignment(StaffId staffId, FlucePeriod period);
        IList<Assignment> FindRequirementAssignment(RequirementId requirementId);

    }
}