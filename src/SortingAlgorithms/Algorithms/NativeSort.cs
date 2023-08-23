namespace SortingAlgorithms.Algorithms;

public static class NativeSort
{
    public static int[] SortAscending(int[] arrayToSort)
    {
        var resultArray = new int[arrayToSort.Length];
        Array.Copy(arrayToSort, resultArray, arrayToSort.Length);
        
        // Algorithm.
        Array.Sort(resultArray);

        return resultArray;
    }
    
    public static int[] SortDescending(int[] arrayToSort)
    {
        var resultArray = new int[arrayToSort.Length];
        Array.Copy(arrayToSort, resultArray, arrayToSort.Length);
        
        // Algorithm.
        Array.Sort(resultArray, (first, second) => second.CompareTo(first));

        return resultArray;
    }
}