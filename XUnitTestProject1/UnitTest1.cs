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
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("plus one"));
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("three plus"));
        }

        [Fact]
        public void Subtractions()
        {
            Assert.Equal(3, conversion.Parse("five minus two"));
            Assert.Equal(-1, conversion.Parse("one minus two"));
            Assert.Equal(5, conversion.Parse("six minus one"));
            Assert.Equal(2, conversion.Parse("eight minus six"));
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("minus five"));
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("nine minus")); 
        }

        [Fact]
        public void Multiplication()
        {
            Assert.Equal(4, conversion.Parse("two times two"));
            Assert.Equal(6, conversion.Parse("two times three"));
            Assert.Equal(10, conversion.Parse("five times two"));
            Assert.Equal(12, conversion.Parse("three times four"));
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("one times"));
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("times nine")); 
        }
        [Fact]
        public void Division()
        {
            Assert.Equal(1, conversion.Parse("one divided by one"));
            Assert.Equal(1.5, conversion.Parse("three divided by two"));
            Assert.Equal(2, conversion.Parse("ten divided by five"));
            Assert.Equal(3, conversion.Parse("nine divided by three"));
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("one divided by"));
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("divided by two")); 
        }

        [Fact] 
        public void MultiOperation() 
        { 
            Assert.Equal(6, conversion.Parse("two plus one plus three")); 
            Assert.Equal(6, conversion.Parse("two times one plus four ")); 
            Assert.Equal(5, conversion.Parse("five times two minus five")); 
            Assert.Equal(11, conversion.Parse("nine divided by three plus eight"));
            Assert.Equal(-3, conversion.Parse("one plus two minus three times two"));
            Assert.Equal(5, conversion.Parse("ten plus ten divided by two times two"));
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("one plus one times nine minus"));
            Assert.Throws<ArgumentOutOfRangeException>(() => conversion.Parse("three divided by eight minus seven plus one minus"));
        } 
    }
}