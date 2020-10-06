using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Projekt_CSharp;

namespace XUnitTestProject1
{
    public class ParseTest
    {
        [Fact]
        public void Additions()
        {
            Assert.Equal(2, Conversion.Parse("one plus one"));
            Assert.Equal(5, Conversion.Parse("two plus three"));
            Assert.Equal(10, Conversion.Parse("five plus five"));
            Assert.Equal(4, Conversion.Parse("three plus one"));
            Assert.Throws<FormatException>(() => Conversion.Parse("one plus"));
            Assert.Throws<FormatException>(() => Conversion.Parse("plus two"));
        }

        [Fact]
        public void Subtractions()
        {
            Assert.Equal(3, Conversion.Parse("five minus two"));
            Assert.Equal(-1, Conversion.Parse("one minus two"));
            Assert.Equal(5, Conversion.Parse("six minus one"));
            Assert.Equal(2, Conversion.Parse("eight minus six"));
            Assert.Throws<FormatException>(() => Conversion.Parse("minus five"));
            Assert.Throws<FormatException>(() => Conversion.Parse("nine minus"));
        }
    }
}
