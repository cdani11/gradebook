using System;
using System.Collections.Generic;
using static System.Console;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {12.7, 10.3, 6.11, 4.1};
            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            var result = 0.0;

            grades.Add(56.1);

            foreach (var number in grades)
            {
                result += number;
            }

            result /= grades.Count;

            WriteLine($"El promedio de las calificaciones es {result:N3}");

            if (args.Length > 0)
                WriteLine($"Hello {args[0]}!");
            else
                WriteLine("Hello!");
        }
    }
}
