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
        public IList< Assignment> Assign(string requirementId, IList<string> groupIds)
        {
            var requirementModelId = new RequirementId(requirementId);
            Requirement requirement = repoRequirement.GetById(requirementModelId);
            DateTime? begin = requirement.BeginDate;
            DateTime? deadline = requirement.DeadLine;
            //staff tasks between the period
            //根据小组/部门 计算 可待分配的人员.
            var resourceNeed = requirement.CostResources;
            var staffIds = candidateDetermine.Determine(groupIds, new FlucePeriod());

        }


    }
}
