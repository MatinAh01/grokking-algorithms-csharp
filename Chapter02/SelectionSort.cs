namespace grokking_algorithms_csharp.Chapter02;

internal static class SelectionSort
{
    // Exercise: write a method that returns the index of the smallest
    // element in a nonempty int array. Implement it yourself here.


    public static int FindSmallestIndex(int[] array)
    {
        int minIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }

        return minIndex;
    }

    public static int[] Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }

        return array;
    }
}
