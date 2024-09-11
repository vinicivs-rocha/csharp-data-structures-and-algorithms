namespace DataStructuresAndAlgorithms.DataStructures;

public record class IncommingCall
(
  string Id,
  string ClientId,
  DateTime CallTime
)
{
  public DateTime? AnswerTime { get; set; }
  public DateTime? EndTime { get; set; }
  public string? Consultant { get; set; }
}
