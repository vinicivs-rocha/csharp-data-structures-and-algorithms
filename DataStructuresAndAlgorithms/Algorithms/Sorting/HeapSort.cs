using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Algorithms.Sorting;

public static class HeapSort<TItem> where TItem : IComparable<TItem>
{
  public static TItem[] Sort(TItem[] arr)
  {
    Heap<TItem> heap = new(arr);

    for (int i = heap.nodes.Length - 1; i > 0; i--)
    {
      (heap.nodes[0], heap.nodes[i]) = (heap.nodes[i], heap.nodes[0]);
      Heap<TItem>.Heapify(heap.nodes, i, 0);
    }

    return heap.nodes;
  }
}
