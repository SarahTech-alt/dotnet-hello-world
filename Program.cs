using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
    
}


public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        if (flower1%2 == flower2%2) 
          {
          return false;
        } else
          {
          return true;
        }
    }

    
}

public class Kata
{
  public static bool Check(object[] a, object x)
 // for (int i = 0; i < ((a)obj).Length; i++)
	if (a.Contains(x))
            {
              return true
            }
    }




  


