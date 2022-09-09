
namespace GrokkingAlgorithmsBookExampleWithCSharp
{
    public static class SelectionSort
    {
        public static List<int> Sort(List<int> list)
        {
            int[] newList = new int[list.Count];
            for (int i = 0; i < newList.Length; i++)
            {
                int smallSet = fintSmallSet(list);
                newList[i] = list[smallSet];
                list.RemoveAt(smallSet);
            }
            return newList.ToList();
        }
        private static int fintSmallSet(List<int> list)
        {
            int smallSet = list[0];
            int smallSet_index = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < smallSet)
                {
                    smallSet = list[i];
                    smallSet_index = i;
                }
            }
            return smallSet_index;
        }
    }
}
