using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpncalc
{
    public static class StackExtensions
    {
        public static string AsString<T>(this Stack<T> stack)
        {
            return "[" + stack.Aggregate("]", (seed, next) => ", " + next + seed).TrimStart(',', ' ');
        }
    }
}
