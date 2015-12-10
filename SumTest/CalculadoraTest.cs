using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace SumTest
{
    [TestFixture]
    public class CalculadoraTest
    {
        [Test]
        public void sumaTest() {
            Calculadora cal = new Calculadora();
            Assert.AreEqual(cal.suma(2,3),5);

        }

        [Test]
        public void restaTest()
        {
            Calculadora cal = new Calculadora();
            Assert.AreEqual(cal.resta(5, 3),2);

        }

        [Test]
        public void diviTest()
        {
            Calculadora cal = new Calculadora();
            Assert.AreEqual(cal.divisio(15, 3),5);

        }

        [Test]
        public void multiTest()
        {
            Calculadora cal = new Calculadora();
            Assert.AreEqual(cal.multiplicacio(5, 3), 15);

        }

    }
}
