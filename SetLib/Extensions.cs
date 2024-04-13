using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetLib
{
    public static class Extensions
    {
        public static string AddOccupied(this string input)
        {
            return string.Join(" ", input.Split(' ').Select(word => word + " занятой"));
        }

        public static Set RemoveDuplicates(this Set set)
        {
            return new Set(set.elements.Distinct());
        }
    }

}
