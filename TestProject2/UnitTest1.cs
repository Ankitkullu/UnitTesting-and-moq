using System;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            public int i = 10, j = 25;
            public void testsum()
            {
                Arithmetic ar = new Arithmetic();
                Assert.AreEqual(35, ar.sum(i, j));

            }
        }
    }
}
