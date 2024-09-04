namespace DataStructuresAndAlgorithms.Algorithms.Sorting;

public static class MergeSort<TItem> where TItem : IComparable<TItem>
{
  public static List<TItem> Sort(List<TItem> list)
  {
    if (list.Count <= 1) return list;

    var middle = list.Count / 2;

    return Merge(Sort(list[..middle]), Sort(list[middle..]));
  }

  private static List<TItem> Merge(List<TItem> left, List<TItem> right) => (left, right) switch
  {
    (var l, var r) when l.Count == 0 => r,
    (var l, var r) when r.Count == 0 => l,
    (var l, var r) when l.First().CompareTo(r.First()) <= 0 => [l.First(), .. Merge(l[1..], r)],
    (var l, var r) => [r.First(), .. Merge(l, r[1..])]
  };
}
