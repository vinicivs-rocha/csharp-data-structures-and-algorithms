using DataStructuresAndAlgorithms.Algorithms.Queues;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Queues;

public class CallCenter_AnswerShould
{
  [Fact]
  public void Answer_ShouldReturnTheFirstCallInQueue()
  {
    // Arrange
    var callCenter = new CallCenter();
    callCenter.Call(1234);
    callCenter.Call(5678);

    // Act
    var result = callCenter.Answer("Marcin");

    // Assert
    Assert.Equal("1234", result?.ClientId);
    Assert.Equal("Marcin", result?.Consultant);
  }
}
