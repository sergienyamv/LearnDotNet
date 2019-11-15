namespace Sorting
{
    public static class QuickSortHelper
    {
        private static int Partition(int[] array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end])
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;

            return marker;
        }

        public static int[] Sort(int[] array, int start, int end)
        {
            var progress = array;
            if (start >= end)
            {
                return progress;
            }
            int pivot = Partition(progress, start, end);
            Sort(progress, start, pivot - 1);
            Sort(progress, pivot + 1, end);

            return progress;
        }
    }
}
