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

        public IList<Period<T>> SplittedBy(IList<Period<T>> splitters)
        {
            //该区间被其他区间分隔后剩下的(可以用来分配的

            throw new NotImplementedException();
        }
       
    }
}
