using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("GBook Name", "User 1");
            book.AddGrade(20);
            book.AddGrade(30);
            book.AddGrade(40);

            //act
            var result = book.CalculateStats();

            //assert
            Assert.Equal(30, result.Avg, 1);
            Assert.Equal(40, result.High, 1);
            Assert.Equal(20,result.Low,1);
        }
    }
}
