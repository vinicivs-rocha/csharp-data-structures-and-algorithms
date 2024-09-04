using DataStructuresAndAlgorithms.Algorithms.Sorting;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Sorting;

public class QuickSort_SortShould
{
    [Fact]
    public void Sort_ShouldReturnSortedArray()
    {
        // Arrange
        List<int> arr = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
        List<int> expectedArr = [-42, -11, -9, 0, 1, 6, 12, 68, 90];

        // Act
        var sortedArr = QuickSort<int>.Sort(arr);

        // Assert
        Assert.Equal(expectedArr, sortedArr);
    }
}