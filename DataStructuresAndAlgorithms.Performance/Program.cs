using BenchmarkDotNet.Running;
using DataStructuresAndAlgorithms.Performance.Algorithms;

namespace DataStructuresAndAlgorithms.Performance;

public class Program {
    public static void Main() {
      var sortingSummary = BenchmarkRunner.Run<SortingBenchmarks>();
    }
}