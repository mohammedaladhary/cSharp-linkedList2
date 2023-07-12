using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_linked_lists
{
    internal class removeDuplicate
    {
        public static List<int> RemoveDuplicates(List<int> input)
        {
            List<int> output = new List<int>();
            List<int> track  = new List<int>();

            foreach (int num in input)
            {
                if (!track.Contains(num))
                {
                    output.Add(num);
                    track.Add(num);
                }
            }
            return output;
        }
    }
}