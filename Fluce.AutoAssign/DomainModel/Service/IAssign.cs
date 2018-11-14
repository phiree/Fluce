using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel.Service
{
    public interface IAssign
    {
        IList<Assignment> Assign(DateTime? begin, DateTime? endTime, IList<HRCost> hrCosts);
    }
}
