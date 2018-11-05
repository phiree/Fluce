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
       
        private static int Compare(Point<T> e1, Point<T> e2)
        {
            return e1.t.CompareTo(e2.t);
        }

        public int CompareTo(T other)
        {
            return t.CompareTo(other) ;
        }

        public   static  bool operator < (Point<T> e1, Point<T> e2)
        {
            return Compare( e1, e2) < 0;
        }
        public static   bool operator >(Point<T> e1, Point<T> e2)
        {
            return Compare(e1, e2) > 0;
        }
        public static  bool operator <=(Point<T> e1, Point<T> e2)
        {
            return Compare(e1, e2) <= 0;
        }
        public static  bool operator >=(Point<T> e1, Point<T> e2)
        {
            return Compare(e1, e2) >= 0;
        }

    }
}
