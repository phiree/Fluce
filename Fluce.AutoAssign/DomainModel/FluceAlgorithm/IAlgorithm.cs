using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel
{
   public interface ISplitter<T> where T:IComparable
    {
        /// <summary>
        /// 线段分割算法. 用N条线段分割一条线段.
        /// </summary>
        /// <param name="toBeSplitted">需要被分割的线段</param>
        /// <param name="existed">分割者</param>
        /// <returns></returns>
        Period<T> Split(Period<T> toBeSplitted, IList<Period<T>> existed);
    }
}
