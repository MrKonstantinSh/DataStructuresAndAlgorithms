namespace SortingAlgorithms.Algorithms;

public static class InsertionSort
{
    public static int[] SortAscending(int[] arrayToSort)
    {
        for (var index = 0; index < arrayToSort.Length; index++)
        {
            var currentElement = index;
            while (currentElement > 0 && arrayToSort[currentElement] < arrayToSort[currentElement - 1])
            {
                (arrayToSort[currentElement], arrayToSort[currentElement - 1]) = (arrayToSort[currentElement - 1], arrayToSort[currentElement]);

                currentElement--;
            }
        }

        return arrayToSort;
    }
    
    public static int[] SortDescending(int[] arrayToSort)
    {
        for (var index = 0; index < arrayToSort.Length; index++)
        {
            var currentElement = index;
            while (currentElement > 0 && arrayToSort[currentElement] > arrayToSort[currentElement - 1])
            {
                (arrayToSort[currentElement], arrayToSort[currentElement - 1]) = (arrayToSort[currentElement - 1], arrayToSort[currentElement]);

                currentElement--;
            }
        }

        return arrayToSort;
    }
}