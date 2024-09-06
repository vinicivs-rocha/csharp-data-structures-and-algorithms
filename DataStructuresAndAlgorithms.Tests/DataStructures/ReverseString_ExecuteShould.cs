using DataStructuresAndAlgorithms.Algorithms.Stacks;

namespace DataStructuresAndAlgorithms.Tests.DataStructures;

public class ReverseString_ExecuteShould
{
  [Fact]
  public void Execute_ShouldReverseString()
  {
    // Arrange
    var input = "Hello, World!";
    var expected = "!dlroW ,olleH";

    // Act
    var actual = ReverseString.Execute(input);

    // Assert
    Assert.Equal(expected, actual);
  }
}
