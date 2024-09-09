using DataStructuresAndAlgorithms.Algorithms.Stacks;

namespace DataStructuresAndAlgorithms.Tests.Algorithms.Stack;

public class TowerOfHanoi_SolveShould
{
  [Fact]
  public async void Solve() {
    // Arrange
    var disksCount = 3;
    var from = new Stack<int>(Enumerable.Range(1, disksCount).Reverse());
    TowerOfHanoi<int> towerOfHanoi = new(from, disksCount);

    // Act
    await towerOfHanoi.Solve();

    // Assert
    Assert.Empty(towerOfHanoi.From);
    Assert.Equal(disksCount, towerOfHanoi.To.Count);
    Assert.Empty(towerOfHanoi.Aux);
    Assert.True(towerOfHanoi.To.SequenceEqual(Enumerable.Range(1, disksCount)), "To stack should have all disks in order");
    Assert.True(towerOfHanoi.MovesCount == Math.Pow(2, disksCount) - 1, "Moves count should be 2^n - 1");
  }
}
