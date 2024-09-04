namespace DataStructuresAndAlgorithms.Algorithms.Sorting;

public static class SelectionSort<TItem> where TItem : IComparable<TItem>
{
    public static TItem[] Sort(TItem[] arr)
    {
        var sortedArr = new TItem[arr.Length];
        arr.CopyTo(sortedArr, 0);

        for (int i = 0; i < sortedArr.Length - 1; i++)
        {
            var minIndex = i;
            var minValue = sortedArr[i];

            for (int j = i + 1; j < sortedArr.Length; j++)
            {
                if (sortedArr[j].CompareTo(minValue) == -1)
                {
                    minIndex = j;
                    minValue = sortedArr[j];
                }
            }

            (sortedArr[i], sortedArr[minIndex]) = (sortedArr[minIndex], sortedArr[i]);
        }

        return sortedArr;
    }
}
