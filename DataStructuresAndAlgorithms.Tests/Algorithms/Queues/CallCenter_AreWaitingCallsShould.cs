using DataStructuresAndAlgorithms.Algorithms.Queues;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Queues;

public class CallCenter_AreWaitingCallsShould
{
  [Fact]
  public void AreWaitingCalls_ShouldReturnTrue_WhenThereAreCallsWaiting()
  {
    // Arrange
    var callCenter = new CallCenter();
    callCenter.Call(1234);

    // Act
    var result = callCenter.AreWaitingCalls();

    // Assert
    Assert.True(result);
  }
}
