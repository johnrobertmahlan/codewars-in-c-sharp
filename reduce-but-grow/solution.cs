using System.Linq;
public class Kata
{
  public static int Grow(int[] nums)
  {
    int product = nums.Aggregate(1, (product, num) => product *= num);

    return product;
  }
}