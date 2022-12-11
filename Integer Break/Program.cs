// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Solution s = new Solution();
var answer = s.IntegerBreak(11);
Console.WriteLine(answer);


public class Solution
{
  public int IntegerBreak(int n)
  {
    /*
    The reason why we should use 3 as many as possible is
    For 6, (3 * 3) > (2 * 2 * 2).
    8, (3 * 3 * 2) > (2 * 2 * 2 * 2).
    Thus, the optimal product should contain more 3.
    */
    if (n == 2) return 1;
    if (n == 3) return 2;
    if (n == 4) return 4;

    int p = 1;
    while (n > 4)
    {
      p = p * 3;
      n = n - 3;
    }

    p = p * n;
    return p;
  }
}