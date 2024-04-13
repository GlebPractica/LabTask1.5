using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetLib
{
    public static class StatisticOperation
    {
        public static int Sum(Set set) => set.elements.Sum();

        public static int MaxMinDifference(Set set) => set.elements.Max() - set.elements.Min();

        public static int Count(Set set) => set.elements.Count;
    }

}
