using ArithmeticOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace UnitTestProject1
{
    [TestClass]
    public class testClass
    {
        public int i = 10, j = 25;
        [TestMethod]
        public void testsum()
        {
            Arithmetic ar= new Arithmetic();
            Assert.AreEqual(35,ar.sum(i,j));

        }
        [TestMethod]
        public void testsub()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(-15, ar.sub(i,j));

        }
        [TestMethod]
        public void testmul()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(250, ar.mul(i,j));

        }
        [TestMethod]
        public void testsame()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreNotSame(-150, ar.sub(i,j));

        }
        [TestMethod]
        public void testnegative()
        {
            Arithmetic ar = new Arithmetic();
            Assert.IsNotNull( ar.sum(i,j));

        }
        [TestMethod]
        public void testne()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreNotEqual(100,ar.mul(i, j));

        }
    }
}
