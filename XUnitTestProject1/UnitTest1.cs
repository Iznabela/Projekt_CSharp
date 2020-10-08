using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Projekt_CSharp;

namespace XUnitTestProject1
{
    public class ParseTest
    {
        Conversion conversion = new Conversion();

        [Fact]
        public void Additions()
        {
            Assert.Equal(2, conversion.Parse("one plus one"));
            Assert.Equal(5, conversion.Parse("two plus three"));
            Assert.Equal(10, conversion.Parse("five plus five"));
            Assert.Equal(4, conversion.Parse("three plus one"));
            Assert.Throws<Exception>(() => conversion.Parse("1 + 1"));
            Assert.Throws<Exception>(() => conversion.Parse("2 + 3"));
        }

        [Fact]
        public void Subtractions()
        {
            Assert.Equal(3, conversion.Parse("five minus two"));
            Assert.Equal(-1, conversion.Parse("one minus two"));
            Assert.Equal(5, conversion.Parse("six minus one"));
            Assert.Equal(2, conversion.Parse("eight minus six"));
            //Assert.Throws<FormatException>(() => conversion.Parse("minus five"));
            //Assert.Throws<FormatException>(() => conversion.Parse("nine minus"));
        }

        [Fact]
        public void Multiplication()
        {
            Assert.Equal(4, conversion.Parse("two times two"));
            Assert.Equal(6, conversion.Parse("two times three"));
            Assert.Equal(10, conversion.Parse("five times two"));
            Assert.Equal(12, conversion.Parse("three times four"));
            //Assert.Throws<FormatException>(() => conversion.Parse("1 + 1"));
            //Assert.Throws<FormatException>(() => conversion.Parse("5 - 2"));
        }
        [Fact]
        public void Division()
        {
            Assert.Equal(1, conversion.Parse("one divided by one"));
            Assert.Equal(1.5, conversion.Parse("three divided by two"));
            Assert.Equal(2, conversion.Parse("ten divided by five"));
            Assert.Equal(3, conversion.Parse("nine divided by three"));
            //Assert.Throws<FormatException>(() => conversion.Parse("one divided by"));
            //Assert.Throws<FormatException>(() => conversion.Parse("divided by two"));
        }
    }
}
