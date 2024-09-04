namespace DataStructuresAndAlgorithms.Algorithms.Sorting;

public static class BubbleSort<TItem> where TItem : IComparable<TItem>
{
    public static TItem[] Sort(TItem[] arr)
    {
        var sortedArr = new TItem[arr.Length];
        arr.CopyTo(sortedArr, 0);

        for (int i = 0; i < sortedArr.Length; i++)
        {
            var isAnyChange = false;

            for (int j = 0; j < sortedArr.Length - 1; j++)
            {
                if (sortedArr[j].CompareTo(sortedArr[j + 1]) == 1)
                {
                    isAnyChange = true;
                    (sortedArr[j], sortedArr[j + 1]) = (sortedArr[j + 1], sortedArr[j]);
                }
            }

            if (!isAnyChange) { break; }
        }

        return sortedArr;
    }
}
