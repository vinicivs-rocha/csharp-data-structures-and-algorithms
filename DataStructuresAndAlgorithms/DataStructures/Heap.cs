namespace DataStructuresAndAlgorithms.DataStructures;

public class Heap<TItem> where TItem : IComparable<TItem>
{
  public readonly TItem[] nodes;


  public Heap(TItem[] items)
  {
    TItem[] heapifiedArray = new TItem[items.Length];
    items.CopyTo(heapifiedArray, 0);

    for (int i = items.Length / 2 - 1; i >= 0; i--)
    {
      Heapify(heapifiedArray, heapifiedArray.Length, i);
    }

    nodes = heapifiedArray;
  }

  public static void Heapify(TItem[] items, int count, int root)
  {
    int leftChildIndex = 2 * root + 1;
    int rightChildIndex = 2 * root + 2;

    if (leftChildIndex < count && items[leftChildIndex].CompareTo(items[root]) == 1)
    {
      (items[leftChildIndex], items[root]) = (items[root], items[leftChildIndex]);
      Heapify(items, count, leftChildIndex);
    }

    if (rightChildIndex < count && items[rightChildIndex].CompareTo(items[root]) == 1)
    {
      (items[rightChildIndex], items[root]) = (items[root], items[rightChildIndex]);
      Heapify(items, count, rightChildIndex);
    }
  }
}
