namespace SortingAlgorithms.Algorithms;

public static class BubbleSort
{
    public static int[] SortAscending(int[] arrayToSort)
    {
        var resultArray = new int[arrayToSort.Length];
        Array.Copy(arrayToSort, resultArray, arrayToSort.Length);
        
        // Algorithm.
        for (var i = resultArray.Length - 1; i > 0; i--)
        {
            var isSwapped = false;

            for (var j = 0; j < i; j++)
            {
                if (resultArray[j] > resultArray[j + 1])
                {
                    (resultArray[j], resultArray[j + 1]) = (resultArray[j + 1], resultArray[j]);
                    
                    isSwapped = true;
                }
            }

            if (!isSwapped)
            {
                return resultArray;
            }
        }

        return resultArray;
    }
    
    public static int[] SortDescending(int[] arrayToSort)
    {
        var resultArray = new int[arrayToSort.Length];
        Array.Copy(arrayToSort, resultArray, arrayToSort.Length);
        
        // Algorithm.
        for (var i = resultArray.Length - 1; i > 0; i--)
        {
            var isSwapped = false;

            for (var j = 0; j < i; j++)
            {
                if (resultArray[j] < resultArray[j + 1])
                {
                    (resultArray[j], resultArray[j + 1]) = (resultArray[j + 1], resultArray[j]);
                    
                    isSwapped = true;
                }
            }

            if (!isSwapped)
            {
                return resultArray;
            }
        }

        return resultArray;
    }
}