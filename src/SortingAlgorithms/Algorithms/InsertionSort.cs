namespace SortingAlgorithms.Algorithms;

public static class InsertionSort
{
    public static int[] SortAscending(int[] arrayToSort)
    {
        var resultArray = new int[arrayToSort.Length];
        Array.Copy(arrayToSort, resultArray, arrayToSort.Length);
        
        for (var index = 0; index < resultArray.Length; index++)
        {
            var currentElement = index;
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
        
        for (var index = 0; index < resultArray.Length; index++)
        {
            var currentElement = index;
            while (currentElement > 0 && resultArray[currentElement] > resultArray[currentElement - 1])
            {
                (resultArray[currentElement], resultArray[currentElement - 1]) = (resultArray[currentElement - 1], resultArray[currentElement]);

                currentElement--;
            }
        }

        return resultArray;
    }
}