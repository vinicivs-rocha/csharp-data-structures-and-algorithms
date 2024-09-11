using DataStructuresAndAlgorithms.Algorithms.Queues;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Queues;

public class CallCenter_CallShould
{
  [Fact]
  public void Call_ShouldAddCallToQueue()
  {
    // Arrange
    var callCenter = new CallCenter();

    // Act
    var call = callCenter.Call(1234);

    // Assert
    Assert.Contains(call, callCenter.Calls);
  }
}
