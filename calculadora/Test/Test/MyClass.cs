using System;
using calculadora;
using System.Globalization;
namespace Test
{
    using NUnit.Framework;

    [TestFixture]
public class TestSuma
{

        [Test]
        public void TestDosEnteros(){

        
            var calc = new Calculadora(" 4 * 2");
            Assert.AreEqual(8, calc.Resultado);

        }

        [Test]
        public void TestDosReales()
        {

            var pruebas = new string[]{

                "4.2 + 4.4",
                "4 + 2.5",
                "5 + 6.1"
            };

            var resultados = new double[]{

                8.6,6.5,11.1
            };


            Calculadora calc = null;

            for (int i = 0; i < pruebas.Length ; i++){

                calc = new Calculadora(pruebas[i]);

                Assert.AreEqual(Math.Ceiling(resultados[i]),
                                Math.Ceiling(pruebas[i]));

            }

        }
        
    }
}
