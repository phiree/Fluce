using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel.FluceAlgorithm
{
    /// <summary>
    /// 无重叠区间列表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ContinuousPeriod<T> where T:IComparable
    {
        IList<Period<T>> periods;
        public ContinuousPeriod()
        {
            this.periods = new List<Period<T>>();
        }
        public IList<Period<T>> Periods {
            get {
                return periods;
            }
        }
        public void Add(Period<T> period)
        {
            //if period   overlap with any other p, return  or throw
        }
        public void Remove(Period<T> period)
        {
            //remove an existed period
        }
    }
}
