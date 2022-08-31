using System;

namespace SortAlgorithms
{
    internal class Program
    {
        static int[] Array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
        static void Main(string[] args)
        {
            //var result = SelectionSort.SelectionSortAlgorithms(Array);
            //var result = LinerSort.Algorithm(Array);
            var result = QuickSort.SortArray(Array, 0, Array.Length -1 );

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
