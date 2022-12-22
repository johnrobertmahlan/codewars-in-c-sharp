using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    if (numbers.Count == 0)
    {
      return numbers;
    }
    else
    {
      int[] copiedArr = numbers.ToArray();

      Array.Sort(copiedArr);

      int number = copiedArr.First();

      numbers.Remove(number);

      return numbers;
    }
  }
}