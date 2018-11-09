using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel.Service
{
    /// <summary>
    /// 决定 将任务分配给哪些员工
    /// </summary>
   public  class CandidateDetermine : ICandidateDetermine
    {
        Repository.IRepositoryAssignment repositoryAssignment;
        IDetermineStratage stragate;
        IOrganizationService organizationService;
        ILeisureDegreeService leisureDegreeService;
        public CandidateDetermine(IList<string> groupIds)
        {

        }
        /// <summary>
        ///    
        /// </summary>
        /// <returns></returns>
        public IList<StaffId> Determine(IList<string> groupIds, FlucePeriod period)
        {
            IList<StaffId> staffids = organizationService.FindStaffs(groupIds);
            IList<LeisureDegree> leisureDegrees = new List<LeisureDegree>();
            foreach (var staffId in staffids)
            {
                LeisureDegree leisureDegree = leisureDegreeService.Calculate(staffId, period);
                leisureDegrees.Add(leisureDegree);
            }



        }
    }
}
