using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Jing");
            book.AddGrade(34.5);
            book.AddGrade(45.7);
            book.AddGrade(40.1);

            Statistics result = new Statistics();
            result = book.getStatistics();

            Console.WriteLine($"High value is {result.High}");
            Console.WriteLine($"Low value is {result.Low}");
            Console.WriteLine($"Everage value is {result.Average}");

        }
    }
}
