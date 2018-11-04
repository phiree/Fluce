using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel
{
    public abstract class Point<T>:IComparable<T>  where T :IComparable
    {
        T t;
        public Point(T t)
        {
            this.t = t;
        }
        public int CompareTo(T obj)
        {
            return t.CompareTo(obj);
        }
         
        public  static  bool operator < ( T e2)
        {
            return this.CompareTo(  e2) < 0;
        }
        public   bool operator <(SeasonEpisode e1, SeasonEpisode e2)
        {
            return Compare(e1, e2) < 0;
        }
        public   bool operator <(SeasonEpisode e1, SeasonEpisode e2)
        {
            return Compare(e1, e2) < 0;
        }
        public   bool operator <(SeasonEpisode e1, SeasonEpisode e2)
        {
            return Compare(e1, e2) < 0;
        }

    }
}
