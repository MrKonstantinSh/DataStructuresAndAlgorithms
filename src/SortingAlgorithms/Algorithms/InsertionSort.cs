namespace SortingAlgorithms.Algorithms;

public static class InsertionSort
{
    public static int[] SortAscending(int[] arrayToSort)
    {
        var resultArray = new int[arrayToSort.Length];
        Array.Copy(arrayToSort, resultArray, arrayToSort.Length);
        
        // Algorithm.
        for (var i = 0; i < resultArray.Length; i++)
        {
            var currentElement = i;
            while (currentElement > 0 && resultArray[currentElement] < resultArray[currentElement - 1])
            {
                (resultArray[currentElement], resultArray[currentElement - 1]) = (resultArray[currentElement - 1], resultArray[currentElement]);

                currentElement--;
            }
        }

        return resultArray;
    }
    
    public static int[] SortDescending(int[] arrayToSort)
    {
        var resultArray = new int[arrayToSort.Length];
        Array.Copy(arrayToSort, resultArray, arrayToSort.Length);
        
        // Algorithm.
        for (var i = 0; i < resultArray.Length; i++)
        {
            var currentElement = i;
            while (currentElement > 0 && resultArray[currentElement] > resultArray[currentElement - 1])
            {
                (resultArray[currentElement], resultArray[currentElement - 1]) = (resultArray[currentElement - 1], resultArray[currentElement]);

                currentElement--;
            }
        }

        return resultArray;
    }
}