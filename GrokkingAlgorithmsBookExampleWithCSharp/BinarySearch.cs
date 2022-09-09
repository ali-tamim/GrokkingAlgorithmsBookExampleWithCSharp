using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithmsBookExampleWithXSharp
{
    public static class BinarySearch
    {
        public static int Search(int[] arr, int item)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = arr[mid];
                if (guess == item)
                {
                    return guess;
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return default;
        }
    }
}
