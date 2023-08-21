using BenchmarkDotNet.Attributes;
using SortingAlgorithms.Algorithms;

namespace SortingAlgorithms;

[MemoryDiagnoser]
public class Benchmarks
{
    private int[] _arrayToSort = null!;

    [Params(10, 100, 1_000)]
    public int ItemCount { get; set; }

    [GlobalSetup]
    public void SetUp()
    {
        const int minValue = -10_000_000;
        const int maxValue = 10_000_000;
        var random = new Random(42);

        _arrayToSort = Enumerable
            .Range(minValue, maxValue)
            .Select(e => random.Next(minValue, maxValue))
            .Take(ItemCount)
            .ToArray();
    }

    [Benchmark]
    public int[] InsertionSortAscending()
    {
        return InsertionSort.SortAscending(_arrayToSort);
    }
    
    [Benchmark]
    public int[] InsertionSortDescending()
    {
        return InsertionSort.SortDescending(_arrayToSort);
    }
}