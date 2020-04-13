using System;
using System.Collections.Generic;
using static System.Console;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Libro de calificaciones de Carlos");

            book.AddGrade(88.6);
            book.AddGrade(44.05);
            book.AddGrade(12.81);
            book.AddGrade(56.1);
            book.ShowStatistics();
        }
    }
}
