namespace DataStructuresAndAlgorithms.DataStructures;

public class CircularEnumerator<TItem>(LinkedList<TItem> list) : IEnumerator<TItem>
{
  private LinkedListNode<TItem>? _current = null;

  public TItem Current => _current is not null ? _current.Value : default!;

  object System.Collections.IEnumerator.Current => Current!;

  public bool MoveNext() {
    if(_current is null) {
      _current = list?.First;
      return _current is not null;
    }
    else
    {
      _current = _current.Next ?? _current.List?.First;
      return true;
    }
  } 

  public void Reset() => _current = null;

  public void Dispose() {}
}
