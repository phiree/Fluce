using System.Collections.Generic;

namespace Fluce.AutoAssign.DomainModel.Service
{
    public interface ICandidateDetermine
    {
        IList<StaffId> Determine(IList<string> groupIds, FlucePeriod period);
    }
}