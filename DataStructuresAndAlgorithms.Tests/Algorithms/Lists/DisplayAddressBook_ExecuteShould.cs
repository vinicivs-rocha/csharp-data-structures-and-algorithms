using DataStructuresAndAlgorithms.Algorithms.Lists;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Lists;

public class DisplayAddressBook_ExecuteShould
{
  [Fact]
  public void Execute_ShouldReturnOrderedFilteredList()
  {
    // Arrange
    var addressBook = new SortedList<string, Friend> {
      { "John", new("John", "Main Street", "12345", "New York", "USA") },
      { "Jane", new("Jane", "Main Street", "12345", "New York", "USA") },
      { "Doe", new("Doe", "Main Street", "12345", "New York", "USA") },
    };
    var expected = new List<string> {
      "Doe: Main Street, 12345 New York, USA",
      "Jane: Main Street, 12345 New York, USA",
      "John: Main Street, 12345 New York, USA",
    };
    var query = new DisplayAddressBook(addressBook);

    // Act
    var result = query.Execute();

    // Assert
    Assert.Equal(expected, result);
  }
}
