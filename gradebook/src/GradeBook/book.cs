using System;
using System.Collections.Generic;

/*
The class Book packages the blueprint book provides ways to:
1 store the grades. 
2 add to the given gradebook obj
3 welcomes the user from args
4 Assign name to the gradebook
 */

namespace GradeBook
{
    public class book
    {
        List<double> grades;
        string name;
        double highGrade = double.MinValue;
        double lowGrade = double.MaxValue;
        double avg = 0.0;

        //Constructor
        public book(string name, string[] args) 
        {
            grades = new List<double>() {1,22,56,33.2,45,30,32};
            this.name = name;
            welcomeUser(args);
        }

        public void calculateStats()
        {
            foreach(double gd in this.grades)
            {
                avg += gd;
                highGrade = Math.Max(highGrade,gd);
                lowGrade = Math.Min(lowGrade, gd);
            }
            avg /= this.grades.Count;
        }

        // show the current statistics
        public void showStatistics() 
        {
            calculateStats();
            Console.WriteLine($"Min grade - {lowGrade}\nMax Grade- {highGrade}\nAvg Grade - {avg}");
        }

        // Welcomes the user
        private void welcomeUser(string[] args)
        {
            string user = "User";
            if(args.Length>0)
            {
                user = args[0];
            }
            Console.WriteLine($"Welcome, {user}");
        }

        // Adds grade to the class member
        public void AddGrade(double grade) 
        {
            this.grades.Add(grade);
        }

        // getter for grades member
        public List<double> getGrade()
        {
            return grades;
        }
    }
}