namespace DataStructuresAndAlgorithms.Algorithms.Sorting;

public static class QuickSort<TItem> where TItem : IComparable<TItem>
{
  public static List<TItem> Sort(List<TItem> list)
  {
    if (list.Count <= 1) return list;

    var pivot = list.First();

    var pivotedList = list[1..];

    var less = pivotedList.Where(item => item.CompareTo(pivot) == -1).ToList();
    var greaterOrEqual = pivotedList.Where(item => item.CompareTo(pivot) >= 0).ToList();

    return [.. Sort(less), pivot, .. Sort(greaterOrEqual)];
  }
}
