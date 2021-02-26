using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public interface IStringSorter
    {
        CustomList<string> SortByShortestToLongestLength();
    }
}
