using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures;

public class CircularLinkedList<TItem> : LinkedList<TItem>
{
  public new IEnumerator GetEnumerator() => new CircularEnumerator<TItem>(this);

  public static implicit operator CircularLinkedList<TItem>(List<TItem> linkedList) {
    var circularLinkedList = new CircularLinkedList<TItem>();
    foreach (var item in linkedList) {
      circularLinkedList.AddLast(item);
    }
    return circularLinkedList;
  }
}
