using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    var total = 0;

    foreach (var num in arr)
    {
      if (num > 0)
      {
        total += num;
      }
    }

    return total;
  }
}
