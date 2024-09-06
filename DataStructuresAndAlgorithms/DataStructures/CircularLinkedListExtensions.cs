namespace DataStructuresAndAlgorithms.DataStructures;

public static class CircularLinkedListExtensions
{
  public static LinkedListNode<TItem>? Next<TItem>(this LinkedListNode<TItem> node) => node?.List != null ? node.Next ?? node.List.First : null;
  public static LinkedListNode<TItem>? Prev<TItem>(this LinkedListNode<TItem> node) => node?.List != null ? node.Previous ?? node.List.Last : null;
}
