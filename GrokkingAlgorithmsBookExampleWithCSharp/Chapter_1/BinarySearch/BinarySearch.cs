
namespace GrokkingAlgorithmsBookExampleWithCSharp
{
    public static class BinarySearch
    {
        public static int? Search(IList<int> list, int item)
        {
            int low = 0;
            int high = list.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];
                if (guess == item)
                {
                    return mid;
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
            return null;
        }
    }
}
