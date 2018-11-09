using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel.Service
{
    public interface  ILeisureDegreeService
    {
        LeisureDegree Calculate(StaffId staffId, FlucePeriod period);
    }
    public class LeisureDegree
    {
        public LeisureDegree(StaffId staffid, decimal degree)
        {
            this.StaffId = staffid;
            this.Degree = degree;
        }
        public StaffId StaffId { get; protected set; }
        public decimal Degree { get; protected set; }
    }
}
