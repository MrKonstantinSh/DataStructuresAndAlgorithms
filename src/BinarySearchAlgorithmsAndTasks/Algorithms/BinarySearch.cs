namespace BinarySearchAlgorithmsAndTasks.Algorithms;

public static class BinarySearch
{
    public static int Search(int[] array, int elementToSearch)
    {
        var left = 0;
        var right = array.Length - 1;

        while (left <= right)
        {
            var middle = (left + right) / 2;

            if (array[middle] == elementToSearch)
            {
                return middle;
            }

            if (array[middle] < elementToSearch)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}