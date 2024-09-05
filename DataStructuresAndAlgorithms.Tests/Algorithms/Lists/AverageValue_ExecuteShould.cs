using DataStructuresAndAlgorithms.Algorithms.Lists;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Lists;

public class AverageValue_ExecuteShould
{
    [Fact]
    public void Execute_ShouldReturnAverageValue()
    {
        // Arrange
        var numbers = new List<double> { 1, 2, 3, 4, 5 };
        var expectedAverage = 3.0;

        // Act
        var average = new AverageValue(numbers).Execute();

        // Assert
        Assert.Equal(expectedAverage, average);
    }
}