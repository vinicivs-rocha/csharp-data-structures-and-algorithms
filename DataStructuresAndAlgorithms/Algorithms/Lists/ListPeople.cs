using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Algorithms.Lists;

public class ListPeople(List<Person> people)
{
  public List<string> Execute() => [.. people.OrderBy(p => p.Name).Select(p => $"{p.Name} ({p.Age}) from {p.Country}")];
}
