using Fluce.AutoAssign.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using Fluce.AutoAssign.DomainModel.Repository;
using Fluce.AutoAssign.DomainModel.Service;


namespace Fluce.AutoAssign.Application
{
    public class AutoAssignApplication
    {
        IRepositoryRequirement repoRequirement;

        ICandidateDetermine candidateDetermine;
        public AutoAssignApplication()
        {

        }
        public IList<Assignment> Assign(string requirementId, IList<HRCost> hRCosts)
        {
            var requirementModelId = new RequirementId(requirementId);
            Requirement requirement = repoRequirement.GetById(requirementModelId);
            DateTime? begin = requirement.BeginDate;
            DateTime? deadline = requirement.DeadLine;
            
            
           
             

        }


    }
}
