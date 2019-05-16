using System;
using System.Collections.Generic;


// The class Book packages the blueprint book provides ways to:
// 1 store the grades. 
// 2 add to the given gradebook obj
// 3 welcomes the user from args
// 4 Assign name to the gradebook


namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;
        private double highGrade = double.MinValue;
        private double lowGrade = double.MaxValue;
        private double avg = 0.0;

        //Constructor
        public Book(string name, string[] args)
        {
            grades = new List<double>() { 1, 22, 56, 33.2, 45, 30, 32 };
            this.name = name;
        }

        public void CalculateStats()
        {
            foreach (double gd in this.grades)
            {
                avg += gd;
                highGrade = Math.Max(highGrade,gd);
                lowGrade = Math.Min(lowGrade,gd);
            }
            avg /= this.grades.Count;
        }

        // show the current statistics
        public void ShowStatistics()
        {
            CalculateStats();
            Console.WriteLine($"Min grade - {lowGrade}\nMax Grade- {highGrade}\nAvg Grade - {avg}");
        }

        // Welcomes the user
        public void WelcomeUser(string[] args)
        {
            string user = "";
            if (args.Length > 0)
            {
                user = args[0];
            }
            if (string.IsNullOrWhiteSpace(user))
            {
                throw new ArgumentException("the argument was null or white space");
            } 
            else
            {
                Console.WriteLine($"Welcome, {user}");
            }
        }

        // Adds grade to the class member
        public void AddGrade(double grade)
        {
            if((grade> 0) && (grade < 101))
            {
                this.grades.Add(grade);
            }
        }

        // getter for grades member
        public List<double> GetGrade()
        {
            return grades;
        }
    }
}