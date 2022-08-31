namespace SortAlgorithms
{
    public static class LinerSort
    {
        public static int[] Algorithm(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        var tempData = array[i];
                        array[i] = array[j];
                        array[j] = tempData;
                    }
                }
            }
            return array;
        }
    }
    
}
