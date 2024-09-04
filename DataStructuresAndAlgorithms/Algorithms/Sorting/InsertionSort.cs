namespace DataStructuresAndAlgorithms.Algorithms.Sorting;

public static class InsertionSort<TItem> where TItem : IComparable<TItem>
{
    public static TItem[] Sort(TItem[] arr)
    {
        var sortedArr = new TItem[arr.Length];
        arr.CopyTo(sortedArr, 0);

        for (int i = 1; i < sortedArr.Length; i++)
        {
            var j = i;

            while ((j > 0) && (sortedArr[j].CompareTo(sortedArr[j - 1]) == -1))
            {
                (sortedArr[j], sortedArr[j - 1]) = (sortedArr[j - 1], sortedArr[j]);
                j--;
            }

        }

        return sortedArr;
    }
}
