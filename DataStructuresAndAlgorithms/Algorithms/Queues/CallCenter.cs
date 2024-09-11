using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Algorithms.Queues;

public class CallCenter
{
  private int _counter = 0;
  private readonly Queue<IncommingCall> _calls = new();

  public List<IncommingCall> Calls => [.. _calls];

  public IncommingCall Call(int ClientId)
  {
    IncommingCall call = new(Id: (++_counter).ToString(), ClientId: ClientId.ToString(), CallTime: DateTime.Now);
    _calls.Enqueue(call);
    return call;
  }

  public IncommingCall? Answer(string consultant)
  {
    if (!AreWaitingCalls()) { return null; }

    var call = _calls.Dequeue();

    call.Consultant = consultant;
    call.AnswerTime = DateTime.Now;
    return call;
  }

  public bool AreWaitingCalls() => _calls.Count > 0;

  public void End(IncommingCall call) => call.EndTime = DateTime.Now;
}
