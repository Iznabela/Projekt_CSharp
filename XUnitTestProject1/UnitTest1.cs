using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

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
