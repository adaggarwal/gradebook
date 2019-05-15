using System;
using System.Collections.Generic;


/* 
Your your name with the command line arguments as the application assumes the first string as the name of the user

The class Program is the main class encapsulating the main method. 

 */
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var book = new book("first", args);
            book.AddGrade(32);
            book.showStatistics();
        }
    }
}
