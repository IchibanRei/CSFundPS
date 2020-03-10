using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Rey's GradeBook");
            book.AddGrade(12.7);
            book.AddGrade(10.3);
            book.AddGrade(6.11);
            book.AddGrade(4.11);
            book.AddGrade(25.1);            
            book.AddGrade(56.1);

            var stats = book.GetStatistics();
            
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"the highest grade is {stats.High:N1}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
