using System.Collections.Generic;

/*
The class Book packages the blueprint book in a way to store and add to the grades. Each gradebook can have a name of itself.
 */

namespace GradeBook
{
    public class book
    {
        List<double> grades;
        string name;
        public book(string name) 
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade) 
        {
            this.grades.Add(grade);
        }

        public List<double> getGrade()
        {
            return grades;
        }
    }
}