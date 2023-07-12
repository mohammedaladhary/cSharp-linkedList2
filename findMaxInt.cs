using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_linked_lists
{
    internal class findMaxInt
    {
        public int findMaxInteger(List<int> list)
        {
            int max = 0;
            foreach (int i in list)
            {
                //update the maximum value if the statement is true
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
