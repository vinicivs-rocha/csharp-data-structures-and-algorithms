using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Tests.DataStructures;

public class CircularLinkedList_NextShould
{
  [Fact]
  public void Next_ShouldBeAbleToExecuteMoreThanListLengthTimes() {
    // Arrange
    CircularLinkedList<int> circularLinkedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var iterations = 0;

    // Act
    foreach (var item in circularLinkedList) {
      if (iterations == circularLinkedList.Count * 2) {
        break;
      }
      iterations++;
    }

    // Assert
    Assert.Equal(20, iterations);
  }
}
