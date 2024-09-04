namespace DataStructuresAndAlgorithms.Algorithms.Sorting;

public static class ShellSort<TItem> where TItem : IComparable<TItem>
{
  public static TItem[] Sort(TItem[] arr) {
    var sortedArr = new TItem[arr.Length];
    arr.CopyTo(sortedArr, 0);

    for (int h = sortedArr.Length / 2; h > 0; h /= 2) {
      for (int i = h; i < sortedArr.Length; i++) {
        var j = i;
        var current = sortedArr[i];

        while ((j >= h) && (sortedArr[j - h].CompareTo(current) == 1))
        {
          sortedArr[j] = sortedArr[j - h];
          j -= h;
        }

        sortedArr[j] = current;
      }
    }

    return sortedArr;
  }
}
