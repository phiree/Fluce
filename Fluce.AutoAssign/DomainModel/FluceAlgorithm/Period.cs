using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluce.AutoAssign.DomainModel
{
    public abstract class  Period<T> where T:IComparable
    {
       
        public  Point<T> Start { get; set; }
        public  Point<T> End { get; set; }
    }
}
