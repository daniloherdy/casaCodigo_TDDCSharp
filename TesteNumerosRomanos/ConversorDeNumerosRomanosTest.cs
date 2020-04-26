using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNumerosRomanos
{
    [TestFixture]
    public class ConversorDeNumerosRomanosTest
    {
        [Test]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumerosRomanos romano = new ConversorDeNumerosRomanos();

            int numero = romano.Converte("I");

            Assert.AreEqual(1, numero);
        }
        
        [Test]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumerosRomanos romano = new ConversorDeNumerosRomanos();

            int numero = romano.Converte("V");

            Assert.AreEqual(5, numero);
        }
        
        [Test]
        public void DeveEntenderDoisSimbolos()
        {
            ConversorDeNumerosRomanos romano = new ConversorDeNumerosRomanos();

            int numero = romano.Converte("II");

            Assert.AreEqual(2, numero);
        }
        
        [Test]
        public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
        {
            ConversorDeNumerosRomanos romano = new ConversorDeNumerosRomanos();

            int numero = romano.Converte("XXII");

            Assert.AreEqual(22, numero);
        }
        
        [Test]
        public void DeveEntenderNumerosComoIX()
        {
            ConversorDeNumerosRomanos romano = new ConversorDeNumerosRomanos();

            int numero = romano.Converte("IX");

            Assert.AreEqual(9, numero);
        }
        
        [Test]
        public void DeveEntenderNumerosComplexoComoXXIV()
        {
            ConversorDeNumerosRomanos romano = new ConversorDeNumerosRomanos();

            int numero = romano.Converte("XXIV");

            Assert.AreEqual(24, numero);
        }


    }
}
