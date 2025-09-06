using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class LengthComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            int result = x.Length.CompareTo(y.Length);

            if (result == 0)
                result = string.Compare(x, y, StringComparison.OrdinalIgnoreCase);

            return result;
        }
    }
}
