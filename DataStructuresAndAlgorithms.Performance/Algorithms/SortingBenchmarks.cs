using BenchmarkDotNet.Attributes;

namespace DataStructuresAndAlgorithms.Performance.Algorithms;

public class SortingBenchmarks
{
    private readonly Random random = new(42);
    private readonly IEnumerable<int> input;
    
    [Params([10000, 20000, 30000, 40000, 50000, 60000, 70000, 80000, 90000, 100000])]
    public int N;

    public SortingBenchmarks()
    {
        input = Enumerable.Range(0, N).Select(x => random.Next());
    }

    [Benchmark]
    public int[] BubbleSort() => DataStructuresAndAlgorithms.Algorithms.Sorting.BubbleSort<int>.Sort(input.ToArray());

    [Benchmark]
    public int[] SelectionSort() => DataStructuresAndAlgorithms.Algorithms.Sorting.SelectionSort<int>.Sort(input.ToArray());

    [Benchmark]
    public int[] InsertionSort() => DataStructuresAndAlgorithms.Algorithms.Sorting.InsertionSort<int>.Sort(input.ToArray());

    [Benchmark]
    public List<int> MergeSort() => DataStructuresAndAlgorithms.Algorithms.Sorting.MergeSort<int>.Sort(input.ToList());

    [Benchmark]
    public List<int> QuickSort() => DataStructuresAndAlgorithms.Algorithms.Sorting.QuickSort<int>.Sort(input.ToList());

    [Benchmark]
    public int[] ShellSort() => DataStructuresAndAlgorithms.Algorithms.Sorting.ShellSort<int>.Sort(input.ToArray());

    [Benchmark]
    public int[] HeapSort() => DataStructuresAndAlgorithms.Algorithms.Sorting.HeapSort<int>.Sort(input.ToArray());
}
