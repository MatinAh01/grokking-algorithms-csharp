using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grokking_algorithms_csharp.Chapter02;

public static class HeightChecker
{
    public static int PositionsDifferCount(int[] heights)
    {
        int[] sortedHeight = heights.ToArray();
        int positionsDifferCount = 0;

        for (int i = 0; i < sortedHeight.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < sortedHeight.Length; j++)
            {
                if (sortedHeight[j] < sortedHeight[minIndex])
                {
                    minIndex = j;
                }
            }

            (sortedHeight[i], sortedHeight[minIndex]) = (sortedHeight[minIndex], sortedHeight[i]);
        }

        for (int i = 0; i < heights.Length; i++)
        {
            if (sortedHeight[i] != heights[i])
            {
                positionsDifferCount++;
            }
        }

        return positionsDifferCount;
    }
}