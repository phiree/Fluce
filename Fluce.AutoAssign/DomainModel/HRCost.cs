using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel
{
    public class HRCost
    {
        public HRCost(int personCost, int timeCost)
        {
            this.PersonCost = personCost;
            this.TimeCost = timeCost;
        }
        public int Cost()
        {
            return PersonCost * TimeCost;
        }
        
        public int PersonCost { get; set; }
        public int TimeCost { get; set; }
    }
}
