using Fluce.AutoAssign.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using Fluce.AutoAssign.DomainModel.Repository;
namespace Fluce.AutoAssign.Application
{
    public class AutoAssignApplication
    {
        IRepositoryRequirement repoRequirement;

        public AutoAssignApplication()
        {

        }
        public IList<AutoAssignedResult> Assign(Guid requirementId, IList<string> departmentId)
        {
            Requirement requirement = repoRequirement.GetById(requirementId);
            DateTime? begin = requirement.BeginDate;
            DateTime? deadline = requirement.DeadLine;
            //staff tasks between the period
        }


    }
}
