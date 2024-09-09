namespace DataStructuresAndAlgorithms.Algorithms.Stacks;

public class TowerOfHanoi<TItem>(Stack<TItem> from, int disksCount)
{
  public Stack<TItem> From { get; private set; } = from;

  public Stack<TItem> To { get; private set; } = new();

  public Stack<TItem> Aux { get; private set; } = new();

  public int DisksCount { get; private set; } = disksCount;

  public int MovesCount { get; private set; }

  public event EventHandler<EventArgs>? MoveCompleted;

  public async Task Solve() => await Move(DisksCount, From, To, Aux);

  private async Task Move(int disksCount, Stack<TItem> from, Stack<TItem> to, Stack<TItem> aux)
  {
    if (disksCount == 0) { return; }

    await Move(disksCount - 1, from, aux, to);

    to.Push(from.Pop());

    MovesCount++;

    MoveCompleted?.Invoke(this, EventArgs.Empty);

    await Move(disksCount - 1, aux, to, from);
  }
}
