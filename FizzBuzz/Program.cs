// See https://aka.ms/new-console-template for more information
/*Alternatively, try a challenge like “FizzBuzz” (print numbers 1–100, but for multiples of 3 print “Fizz”, for 5 “Buzz”, for both print “FizzBuzz”). 
 * This will test your use of loops and conditionals (you might need a loop, which you can either preview now or do in Week 2).
 * Don’t worry if you haven’t formally learned loops yet – you can read ahead or skip and return after Week 2. The key is to start thinking in code.
 * Push your solution to GitHub.
*/


using System;

for (int i = 1; i <= 100; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz {0}", i);
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine("Fizz {0}", i);
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine("Buzz {0}", i);
    }
}