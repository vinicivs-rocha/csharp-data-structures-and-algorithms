using DataStructuresAndAlgorithms.Algorithms.Lists;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Lists;

public class QueryPeopleOverAge_ExecuteShould
{
  [Fact]
  public void Execute_ShouldReturnOrderedFilteredList()
  {
    // Arrange
    var people = new List<Person> {
      new(Name: "John", Age: 30, Country: "USA" ),
      new(Name: "Jane", Age: 25, Country: "USA" ),
      new(Name: "Doe", Age: 35 , Country: "USA" ),
    };
    var expected = new List<Person> {
      new(Name: "Doe", Age: 35, Country: "USA" ),
      new(Name: "John", Age: 30, Country: "USA" ),
    };
    var query = new QueryPeopleOverAge(people);

    // Act
    var result = query.Execute(29);

    // Assert
    Assert.Equal(expected, result);
  }
}
