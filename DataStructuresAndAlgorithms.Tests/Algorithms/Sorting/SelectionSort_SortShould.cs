using DataStructuresAndAlgorithms.Algorithms.Sorting;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Sorting;

public class SelectionSort_SortShould
{
    [Fact]
    public void Sort_ShouldReturnSortedArray()
    {
        // Arrange
        var arr = new int[] { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        var expectedArr = new int[] { -42, -11, -9, 0, 1, 6, 12, 68, 90 };

        // Act
        var sortedArr = SelectionSort<int>.Sort(arr);

        // Assert
        Assert.Equal(expectedArr, sortedArr);
    }
}