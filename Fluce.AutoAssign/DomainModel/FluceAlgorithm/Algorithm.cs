using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel.FluceAlgorithm
{
   public  class Splitter<T> : ISplitter<T> where T:IComparable
    {
        public Period<T> Split(Period<T> toBeSplitted, IList<Period<T>> existed)
        {
            var result=new List<Period<T>>();
            foreach (var p in existed)
            {
                if (p.)
                {
			
                }
            }
        }
    }
}
