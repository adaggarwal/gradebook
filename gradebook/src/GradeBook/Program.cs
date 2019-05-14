using System;
using System.Collections.Generic;


/* 
Your your name with the command line arguments as the application assumes the first string as the name of the user

The class Program is the main class encapsulating the main method. 
It tries to statically store grades in the gradebook and compute high and low grades for a given gradebook. 
 */
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var book = new book("first");
            book.AddGrade(80.0);
            book.AddGrade(21.1);

            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var Avg = 0.0;
            List<double> list = book.getGrade();
            for (int i = 0; i < list.Count; i++)
            {
                double gd = list[i];
                Avg += gd;
                highGrade = Math.Max(gd, highGrade);
                lowGrade = Math.Min(gd, lowGrade);
            }
            Avg /= list.Count;
            
            
            var x = "";
            if (args.Length > 0)
            {   
                x = $"Hello, {args[0]}!";
            }
            else
            {
                x = "Hello, User!";
            }
            Console.WriteLine(x);
            Console.WriteLine($"Min grade - {lowGrade}\nMax Grade- {highGrade}\nAvg Grade - {Avg}");
        }
    }
}
