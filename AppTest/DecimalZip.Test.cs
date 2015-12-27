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
    class DecimalZipTest
    {
        [Test]
        public void decimalZip_3digitAnd3digit_6digit()
        {
            int d = (new DecimalZip()).solution(123, 789);
            Assert.AreEqual(172839, d);
        }

        [Test]
        public void decimalZip_3digitAnd5digit_8digit()
        {
            int d = (new DecimalZip()).solution(123, 78956);
            Assert.AreEqual(17283956, d);
        }

        [Test]
        public void decimalZip_5digitAnd3digit_8digit()
        {
            int d = (new DecimalZip()).solution(12345, 789);
            Assert.AreEqual(17283945, d);
        }

        [Test]
        public void decimalZip_0And8digit_8digit()
        {
            int d = (new DecimalZip()).solution(0, 12345678);
            Assert.AreEqual(12345678, d);
        }


        [Test]
        public void decimalZip_8digitAnd0_negative1()
        {
            int d = (new DecimalZip()).solution(12345678,0);
            Assert.AreEqual(-1, d);

        }


        [Test]
        public void decimalZip_0And9digit_negative1()
        {
            int d = (new DecimalZip()).solution(0, 100000000);
            Assert.AreEqual(-1, d);
        }

        [Test]
        public void decimalZip_0And0_0()
        {
            int d = (new DecimalZip()).solution(0, 0);
            Assert.AreEqual(0, d);
        }
    }
}
