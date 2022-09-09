using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithmsBookExampleWithXSharp
{
    public static class QuickSort
    {
        public static List<int> Sort(List<int> items)
        {
            if (items.Count < 2)
            {
                return items;
            }
            else
            {
                int piovt = items[0];
                List<int> smaller = new List<int>();
                List<int> larger = new List<int>();
                for (int i = 1; i < items.Count; i++)
                {
                    if (items[i] <= piovt)
                    {
                        smaller.Add(items[i]);
                    }
                    else
                    {
                        larger.Add(items[i]);
                    }
                }
                smaller.Add(piovt);
                smaller = Sort(smaller);
                larger = Sort(larger);
                return smaller.Concat(larger).ToList();
            }
        }
    }
}
