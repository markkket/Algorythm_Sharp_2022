using System;
using System.IO;
using Xunit;
using CourseApp.Module1;

namespace CourseApp.Tests.Module1
{
    public class AplusBTest
    {
        [Theory]
        [InlineData("10 12", "22")]
        [InlineData("1 1", "2")]
        [InlineData("10000 10000", "20000")]
        public void Test1(string input, string expected)
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // act
            AplusB.Calculate();

            // assert
            var output = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.Equal($"{expected}", output[0]);
        }
    }
}
