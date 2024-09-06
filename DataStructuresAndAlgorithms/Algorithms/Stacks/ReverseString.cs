using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms.Stacks;

public class ReverseString
{
  public static string Execute(string input)
  {
    var stack = new Stack<char>();
    foreach (var c in input)
    {
      stack.Push(c);
    }

    var reversed = new StringBuilder();
    while (stack.Count > 0)
    {
      reversed.Append(stack.Pop());
    }

    return reversed.ToString();
  }
}
