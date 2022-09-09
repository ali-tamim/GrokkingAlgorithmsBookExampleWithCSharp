

namespace GrokkingAlgorithmsBookExampleWithCSharp
{
    public static class CountDown
    {
        public static void Start(int i)
        {
            Console.WriteLine(i);
            if (i < 1)
            {
                return;
            }
            Thread.Sleep(500);
            Start(i - 1);
        }
    }
}
