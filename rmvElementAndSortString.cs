using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_linked_lists
{
    internal class rmvElementAndSortString {
        public static List<string> removeChar(List<string> list, char c)
        {
            List<string> newList = new List<string>(list);
            newList.RemoveAll(s => s.Contains(c));

            return newList;
        }
    }
}
