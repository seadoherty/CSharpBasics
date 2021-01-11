using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string color = "white";
            // string sketchyPlace = $"{color} unmarked van";
            // Console.WriteLine(sketchyPlace); // white unmarked van
            // Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim"); // My name is Tim, I am 28 years old
            // Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim"); // My name is 0, I am 28 years old

            // // for loop from 1 to 5 including 5
            // for (int i = 1; i <= 5; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // // loop from 1 to 5 excluding 5
            // for (int i = 1; i < 5; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // // while loop from 1 to 5 including 5
            // int i = 1;
            // while (i < 6)
            // {
            //     Console.WriteLine(i);
            //     i = i + 1;
            // }

            // create random numbers
            Random rand = new Random();
            for (int val = 0; val < 10; val++)
            {
                //Prints the next random value between 2 and 8
                Console.WriteLine(rand.Next(2, 8));
            }


        }
    }
}
