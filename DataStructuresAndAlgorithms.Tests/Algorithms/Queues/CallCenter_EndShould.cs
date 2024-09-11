using DataStructuresAndAlgorithms.Algorithms.Queues;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Queues;

public class CallCenter_EndShould
{
  [Fact]
  public void End_ShouldRemoveTheFirstCallInQueue()
  {
    // Arrange
    var callCenter = new CallCenter();
    callCenter.Call(1234);
    callCenter.Call(5678);

    // Act
    var call = callCenter.Answer("Marcin")!;
    callCenter.End(call);

    // Assert
    Assert.DoesNotContain<IncommingCall>(call, callCenter.Calls);
  }
}
