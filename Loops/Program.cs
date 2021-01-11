using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            // int end = 255;
            int endHundo = 100;
            string f = "Fizz";
            string b = "Buzz";

            // while (start <= end)
            // {
            //     Console.WriteLine(start);
            //     start++;
            // }

            // while (start <= endHundo)
            // {
            //     if (start % 3 == 0)
            //     {
            //         if (start % 5 != 0)
            //         {                        
            //             Console.WriteLine(f);
            //             start++;
            //         } else if (start % 5 ==0){
            //             Console.WriteLine(f+b);
            //             start++;
            //         }
            //         start++;
            //     }
            //     else if (start % 5 == 0)
            //     {
            //         Console.WriteLine(b);
            //         start++;
            //     }
            //     else
            //     {
            //         start++;
            //     }
            // }

            for (int i = start; i <= endHundo; i++)
            {
                if (start % 3 == 0)
                {
                    if (start % 5 != 0)
                    {
                        Console.WriteLine(f);
                        start++;
                    }
                    else if (start % 5 == 0)
                    {
                        Console.WriteLine(f + b);
                        start++;
                    }
                    start++;
                }
                else if (start % 5 == 0)
                {
                    Console.WriteLine(b);
                    start++;
                }
                else
                {
                    start++;
                }
            }
        }
    }
}
