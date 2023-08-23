namespace SortingAlgorithms.Algorithms;

public static class SelectionSort
{
    public static int[] SortAscending(int[] arrayToSort)
    {
        var resultArray = new int[arrayToSort.Length];
        Array.Copy(arrayToSort, resultArray, arrayToSort.Length);

        // Algorithm.
        for (var i = 0; i < resultArray.Length - 1; i++)
        {
            var minElementIndex = i;

            for (var j = i + 1; j < resultArray.Length; j++)
            {
                if (resultArray[j] < resultArray[minElementIndex])
                {
                    minElementIndex = j;
                }
            }

            (resultArray[i], resultArray[minElementIndex]) = (resultArray[minElementIndex], resultArray[i]);
        }

        return resultArray;
    }
    
    public static int[] SortDescending(int[] arrayToSort)
    {
        var resultArray = new int[arrayToSort.Length];
        Array.Copy(arrayToSort, resultArray, arrayToSort.Length);
        
        // Algorithm.
        for (var i = 0; i < resultArray.Length - 1; i++)
        {
            var minElementIndex = i;

            for (var j = i + 1; j < resultArray.Length; j++)
            {
                if (resultArray[j] > resultArray[minElementIndex])
                {
                    minElementIndex = j;
                }
            }

            (resultArray[i], resultArray[minElementIndex]) = (resultArray[minElementIndex], resultArray[i]);
        }

        return resultArray;
    }
}