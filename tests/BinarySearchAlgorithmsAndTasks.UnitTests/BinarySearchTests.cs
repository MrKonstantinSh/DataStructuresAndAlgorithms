namespace BinarySearchAlgorithmsAndTasks.UnitTests;

public class BinarySearchTests
{
    [Theory]
    [InlineData(new[] { 1 }, 1, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 4, 3)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 9)]
    public void Get_correct_index_of_the_searched_item(int[] array, int elementToSearch, int expectedIndex)
    {
        var index = BinarySearch.Search(array, elementToSearch);

        index.Should().Be(expectedIndex);
    }
    
    [Theory]
    [InlineData(new int[] {  }, 1, -1)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 15, -1)]
    public void Get_minus_one_if_element_not_found(int[] array, int elementToSearch, int expectedIndex)
    {
        var index = BinarySearch.Search(array, elementToSearch);

        index.Should().Be(expectedIndex);
    }
}