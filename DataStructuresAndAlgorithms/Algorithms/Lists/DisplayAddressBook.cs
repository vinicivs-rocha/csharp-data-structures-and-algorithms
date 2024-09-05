using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Algorithms.Lists;

public class DisplayAddressBook(SortedList<string, Friend> addressBook)
{
  public List<string> Execute() => [..(
    from friend in addressBook
    select $"{friend.Key}: {friend.Value.Street}, {friend.Value.PostalCode} {friend.Value.City}, {friend.Value.Country}"
  )];
}
