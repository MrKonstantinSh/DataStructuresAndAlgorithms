namespace SortingAlgorithms.UnitTests;

public class InsertionSortTests
{
    [Theory]
    [InlineData(new[] { 5, 4, 3, 2, 1, 0 },new[] { 0, 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 0, -1, -2, -3, -4, -5 },new[] { -5, -4, -3, -2, -1, 0 })]
    [InlineData(new[] { -10, 4, 2, -5, 1, 0 },new[] { -10, -5, 0, 1, 2, 4 })]
    public void Sorting_in_ascending_order_must_be_correct(int[] arrayToSort, int[] expectedSortedArray)
    {
        var sortedArray = InsertionSort.SortAscending(arrayToSort);
        
        sortedArray.Should().BeEquivalentTo(expectedSortedArray);
    }
    
    [Theory]
    [InlineData(new[] { 0, 1, 2, 3, 4, 5 },new[] { 5, 4, 3, 2, 1, 0 })]
    [InlineData(new[] { -5, -4, -3, -2, -1, 0 },new[] { 0, -1, -2, -3, -4, -5 })]
    [InlineData(new[] { -10, 4, 2, -5, 1, 0 },new[] { 4, 2, 1, 0, -5, -10})]
    public void Sorting_in_descending_order_must_be_correct(int[] arrayToSort, int[] expectedSortedArray)
    {
        var sortedArray = InsertionSort.SortAscending(arrayToSort);
        
        sortedArray.Should().BeEquivalentTo(expectedSortedArray);
    }
}