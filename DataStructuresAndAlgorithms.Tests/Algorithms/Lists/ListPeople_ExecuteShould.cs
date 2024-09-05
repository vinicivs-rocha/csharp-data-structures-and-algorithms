using DataStructuresAndAlgorithms.Algorithms.Lists;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Lists;

public class ListPeople_ExecuteShould
{
  [Fact]
  public void Execute_ShouldReturnOrderedPeopleList()
  {
    // Arrange
    var people = new List<Person>
    {
      new("John", 25, "USA"),
      new("Jane", 22, "Canada"),
      new("Alice", 30, "UK"),
      new("Bob", 27, "USA"),
      new("Charlie", 35, "Canada")
    };
    var expectedList = new List<string>
    {
      "Alice (30) from UK",
      "Bob (27) from USA",
      "Charlie (35) from Canada",
      "Jane (22) from Canada",
      "John (25) from USA"
    };

    // Act
    var peopleList = new ListPeople(people).Execute();

    // Assert
    Assert.Equal(expectedList, peopleList);
  }
}
