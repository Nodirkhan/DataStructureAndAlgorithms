namespace SortAlgorithms
{
    public static class BubbleSort
    {
        public static int[] Algorithm(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - i -1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        var temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;  
                    }
                }
            }
            return array;
        }
    }
}
