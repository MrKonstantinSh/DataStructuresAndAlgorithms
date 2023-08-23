using BenchmarkDotNet.Attributes;
using SortingAlgorithms.Algorithms;

namespace SortingAlgorithms;

[MemoryDiagnoser]
public class Benchmarks
{
    private int[] _arrayToSort = null!;

    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    [Params(10, 1_000)]
    public int ItemCount { get; set; }

    [GlobalSetup]
    public void GlobalSetup()
    {
        _arrayToSort = new int[ItemCount];
        var random = new Random(42);

        for (var i = 0; i < ItemCount; i++)
        {
            _arrayToSort[i] = random.Next(-1_000_000, 1_000_000);
        }
    }
    
    [Benchmark]
    public int[] InsertionSortAscending()
    {
        return InsertionSort.SortAscending(_arrayToSort);
    }
    
    [Benchmark]
    public int[] SelectionSortAscending()
    {
        return SelectionSort.SortAscending(_arrayToSort);
    }
    
    [Benchmark]
    public int[] BubbleSortAscending()
    {
        return BubbleSort.SortAscending(_arrayToSort);
    }
    
    [Benchmark]
    public int[] NativeSortAscending()
    {
        return NativeSort.SortAscending(_arrayToSort);
    }
}