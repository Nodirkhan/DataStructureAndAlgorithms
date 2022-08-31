using System;

namespace SortAlgorithms
{
    internal class Program
    {
        public static int[] Array = new int[] { 1, 2, 668, 5, 9 };
        static void Main(string[] args)
        {
            //var result = SelectionSort.SelectionSortAlgorithms(Array);
            var result = LinerSort.Algorithm(Array);

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
