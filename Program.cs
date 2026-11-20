using grokking_algorithms_csharp.Chapter02;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = [8, 3, 6, 1, 5];

        // var index = SelectionSort.FindSmallestIndex(array);

        // var sortedArray = SelectionSort.Sort(array);

        var positionsDifferCount = HeightChecker.PositionsDifferCount(array);

        // Console.WriteLine(index);
        // Console.WriteLine(string.Join(", ", sortedArray));
        Console.WriteLine(positionsDifferCount);
    }
}
