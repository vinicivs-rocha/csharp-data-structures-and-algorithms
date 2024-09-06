using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Tests.DataStructures;

public class CircularLinkedList_PrevShould
{
  [Fact]
  public void Prev_ShouldBeAbleToExecuteMoreThanListLengthTimes()
  {
    // Arrange
    CircularLinkedList<int> circularLinkedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var iterations = circularLinkedList.Count + 1;
    var node = circularLinkedList.First;

    // Act
    for (int i = 0; i < iterations; i++)
    {
      node = node?.Prev();
    }

    // Assert
    Assert.NotNull(node);
    Assert.Equal(10, node.Value);
  }
}