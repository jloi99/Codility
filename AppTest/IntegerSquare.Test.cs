using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Codility;
namespace AppTest
{
    [TestFixture]
    class IntegerSquareTest
    {
        [TestCase]
        public void Square_NegativeAnd16_5()
        {
            int intResult = (new IntegerSquare()).solution(-100, 16);
            Assert.AreEqual(5, intResult);
        }

        [TestCase]
        public void Square_4And100_11()
        {
            int intResult = (new IntegerSquare()).solution(4, 100);
            Assert.AreEqual(9, intResult);
        }

        [TestCase]
        public void Square_3And100_11()
        {
            int intResult = (new IntegerSquare()).solution(3, 100);
            Assert.AreEqual(9, intResult);
        }

        [TestCase]
        public void Square_4And105_11()
        {
            int intResult = (new IntegerSquare()).solution(4, 105);
            Assert.AreEqual(9, intResult);
        }


        [TestCase]
        public void Square_3And105_11()
        {
            int intResult = (new IntegerSquare()).solution(3, 105);
            Assert.AreEqual(9, intResult);
        }


        [TestCase]
        public void Square_4And5_1()
        {
            int intResult = (new IntegerSquare()).solution(4, 5);
            Assert.AreEqual(1, intResult);
        }


        [TestCase]
        public void Square_8And9_1()
        {
            int intResult = (new IntegerSquare()).solution(8, 9);
            Assert.AreEqual(1, intResult);
        }


        [TestCase]
        public void Square_33And35_0()
        {
            int intResult = (new IntegerSquare()).solution(33, 35);
            Assert.AreEqual(0, intResult);
        }


        [TestCase]
        public void Square_negativeValues_0()
        {
            int intResult = (new IntegerSquare()).solution(-100, -1);
            Assert.AreEqual(0, intResult);
        }

    }
}
