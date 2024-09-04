using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Tests.DataStructures;

public class Heap_ConstructorShould
{
  [Fact]
  public void Constructor_ShouldReturnHeapifiedArray()
  {
    // Arrange
    var arr = new int[] { -11, 12, -42, 0, 90, -9 };
    var expectedArr = new int[] { 90, 12, -9, -11, 0, -42 };

    // Act
    Heap<int> result = new(arr);

    // Assert
    Assert.Equal(result.nodes, expectedArr);
  }
}
