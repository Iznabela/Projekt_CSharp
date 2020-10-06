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

        }
    }
}
