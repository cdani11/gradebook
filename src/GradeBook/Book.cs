using System;
using System.Collections.Generic;
using static System.Console;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;
        
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.00;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            result /= grades.Count;

            WriteLine($"La calificación más alta es {highGrade}");
            WriteLine($"La calificación más baja es {lowGrade}");
            WriteLine($"El promedio de las calificaciones es {result:N3}");
        }
    }
}