namespace SortAlgorithms
{
    public static class QuickSort                       //73
    {
        // static int[] Array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
        public static int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            int pivot = array[i];
            while(i <= j)
            {
                while(array[i] < pivot)
                {
                    i++;
                }
                while(array[j] > pivot)
                {
                    j--;
                }
                if(i <= j)
                {
                    var tempvar = array[i];
                    array[i] = array[j];
                    array[j] = tempvar;
                    i++;
                    j--;
                }
            }
            if (leftIndex < j)
                SortArray(array, leftIndex,j);
            if(rightIndex > i) 
                SortArray(array, i, rightIndex);
            return array;
        }
    }
}
