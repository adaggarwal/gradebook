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

        ///Constructor
        /// User for initializing the members
        public Book(string name, string username)
        {
            WelcomeUser(username);
            grades = new List<double> {};
            this.name = name;
        }

        /// calculate statistics such as high, low and avg grade
        public Statistics CalculateStats()
        {
            var results = new Statistics();
            results.High = double.MinValue;
            results.Low = double.MaxValue;

            foreach (double gd in this.grades)
            {
                results.Avg += gd;
                results.High = Math.Max(results.High,gd);
                results.Low = Math.Min(results.Low,gd);
            }
            results.Avg /= this.grades.Count;
            return results;
        }

        /// show the current statistics
        public void ShowStatistics()
        {
            var tempR = CalculateStats();
            Console.WriteLine($"Min grade - {tempR.Low}\nMax Grade- {tempR.High}\nAvg Grade - {tempR.Avg}");
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