using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithmsBookExampleWithXSharp
{
    public static class ArraySumByRecursion
    {
        public static int Sum(int[] arr, int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            return Sum(arr, n - 1) + arr[n - 1];
        }
    }
}
