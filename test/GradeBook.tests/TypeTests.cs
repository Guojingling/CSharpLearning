using System;
using Xunit;

namespace GradeBook.tests
{
    public class TypeTests
    {
        [Fact]
        public void TestIntPassByValue()
        {
            int x = 3;
            //x won't be change in this way.
            SetInt(x);
            Assert.Equal(3,x);                 
           
        }

        private void SetInt(int x)
        {
            x = 42;
            
        }

        [Fact]
        public void TestObjectPassByValue()
        {
            Book book  = new Book("Jing");
            //x won't be change in this way.
            BookSetName(book);
            BookSetNameAndReturnValue(book);
            Assert.Equal("Book 2",book.getName());                 
           
        }

        private void BookSetName(Book book)
        {
            book = new Book("Book 1");
            
        }

        private void BookSetNameAndReturnValue(Book book)
        {
            book.setName("Book 2");   
            
        }
    }
}
