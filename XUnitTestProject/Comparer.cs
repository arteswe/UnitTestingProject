using System;
using System.Collections.Generic;

namespace XUnitTestProject
{
    public class Comparer
    {
        public static Comparer<U> Get<U>(Func<U, U, bool> func)
        {
            return new Comparer<U>(func);
        }
    }

    public class Comparer<T> : Comparer, IEqualityComparer<T>
    {
        private Func<T, T, bool> comparisonFunc;

        public Comparer(Func<T, T, bool> func)
        {
            comparisonFunc = func;
        }

        public bool Equals(T x, T y)
        {
            return comparisonFunc(x, y);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }
    }

}

