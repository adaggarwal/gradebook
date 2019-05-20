using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

/// The class Book packages the blueprint book provides ways to:
/// 1 store the grades. 
/// 2 add to the given gradebook obj
/// 3 welcomes the user from args
/// 4 Assign name to the gradebook


namespace GradeBook
{
    public class Book
    {
        private List <double> grades;
        private string name;
        private double highGrade = double.MinValue;
        private double lowGrade = double.MaxValue;
        private double avg = 0.0;

        ///Constructor
        /// User for initializing the members
        public Book(string name, string username)
        {
            WelcomeUser(username);
            grades = new List<double>() { 1, 22, 56, 33.2, 45, 30, 32 };
            this.name = name;
        }

        /// calculate statistics such as high, low and avg grade
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

        /// show the current statistics
        public void ShowStatistics()
        {
            CalculateStats();
            Console.WriteLine($"Min grade - {lowGrade}\nMax Grade- {highGrade}\nAvg Grade - {avg}");
        }

        /// Welcomes the user
        public void WelcomeUser(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The username is either whitespice or blank. Expecting an alphanumeric string w/o whitespace.");
            } 
            else
            {
                Console.WriteLine($"Welcome, {name}");
            }
        }

        /// Adds grade to the class member
        public void AddGrade(double grade)
        {
            if((grade> 0) && (grade < 101))
            {
                this.grades.Add(grade);
            }
        }

        /// getter for grades member
        public ReadOnlyCollection<double> readOnlyGrades
        {
            get
            {
                ReadOnlyCollection<double> readOnlyGrades = new ReadOnlyCollection<double>(grades);
                return readOnlyGrades;
            }
        }
    }
}