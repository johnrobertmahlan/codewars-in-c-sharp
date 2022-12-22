public class Recursion
{
  public static ulong Factorial(ulong n)
  {
    checked
    {
      if (n < 1)
      {
        return 1;
      }
      else
      {
        return n * Factorial(n - 1);
      }
    }
  }
}