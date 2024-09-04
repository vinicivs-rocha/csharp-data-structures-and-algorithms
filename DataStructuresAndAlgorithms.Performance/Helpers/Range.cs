namespace DataStructuresAndAlgorithms.Performance.Helpers;

public static class Range
{
  public static IEnumerable<int> FromInt(int start, int end, int step) => (start, end, step) switch
  {
    (0, 0, _) => [],
    (_, _, 0) => [],
    (var s, var e, var st) when s > e && st > 0 => [],
    (var s, var e, var st) when s < e && st < 0 => [],
    (var s, var e, var st) => [s, .. FromInt(s + st, e, st)],
  };
}
