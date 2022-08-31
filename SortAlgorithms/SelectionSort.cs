namespace SortAlgorithms
{
    public static class SelectionSort
    {
        public  static int[] SelectionSortAlgorithms(int[] array)
        {
            for(int i = 0; i < array.Length -1;i++)
            {
                int smallest = i;
                for(int j = i+1; j < array.Length; j++)
                {
                    if(array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                var tempData = array[smallest];
                array[smallest] = array[i];
                array[i] = tempData;
            }
            return array;
        }
    }
}
