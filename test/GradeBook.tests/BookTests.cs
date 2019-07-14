using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            Book book = new Book("Jing");
            book.AddGrade(34.5);
            book.AddGrade(45.7);
            book.AddGrade(40.1);

            Statistics result = book.getStatistics(); 
            Assert.Equal(45.7, result.High);
            Assert.Equal(34.5, result.Low);
            Assert.Equal(40.1, result.Average);
                      


            
        }
    }
}
