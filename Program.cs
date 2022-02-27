//programa lai atrastu kopīgo lielāko iespējamo dalītāju
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // lietotājs ievada 1.skaitli
      Console.WriteLine("Ievadi skaitli:");

      // saglabā skaitli mainīgajā lielumā - int
      int x = Convert.ToInt32(Console.ReadLine());

      // lietotājs ievada 2. skaitli
      Console.WriteLine("Ievadi skaitli:");

      // saglabā skaitli mainīgajā lielumā - int
      int y = Convert.ToInt32(Console.ReadLine());

      Console.Write("Lielākais kopīgais dalītājs " + x + " un " + y + " ir: ");
      Console.WriteLine(GCD(x, y));
    }
    private static int GCD(int x, int y)
    {
        if(y == 0)
            return x;
        else
            return GCD(y, x % y);
    }
  }
}
