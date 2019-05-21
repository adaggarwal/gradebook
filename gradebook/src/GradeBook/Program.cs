using System;
using System.Collections.Generic;

///Your name with the command line arguments as the application assumes the first string as the name of the user.
///
///The class Program is the main class encapsulating the main method.

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            var gradeBookName = "first";
            username = args.Length<1 ? "" : args[0];
            var book = new Book(gradeBookName, username);
            AddShowStats(book);
        }

        public static void AddShowStats(Book book)
        {
            System.Console.WriteLine("\nBefore adding the grade:");
            book.ShowStatistics();
            Random random = new Random();
            book.AddGrade(random.Next(0,100));
            book.AddGrade(random.Next(0,100));
            book.AddGrade(random.Next(0,100));
            book.AddGrade(random.Next(0,100));
            System.Console.WriteLine("\nAfter adding the grades:");
            book.ShowStatistics();
        } 
    }
}