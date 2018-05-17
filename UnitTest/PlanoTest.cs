using System;
using Dominio;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    /// <summary>
    /// Descripción resumida de PlanoTest
    /// </summary>
    [TestClass]
    public class PlanoTest
    {
        public PlanoTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private Plano casaEnAguada { get; set; }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            casaEnAguada = new Plano("Casa en Aguada");
        }

        [TestMethod]
        public void NombreVacioTest()
        {
            Plano unPlano = new Plano();
            Assert.AreEqual(unPlano.Nombre, "");
        }

        [TestMethod]
        public void AsignarNombreTest()
        {
            Plano unPlano = new Plano();
            unPlano.Nombre = "Casa";
            Assert.AreEqual(unPlano.Nombre, "Casa");
        }

        [TestMethod]
        public void IgualdadPersonaTest()
        {
            Plano otracasaEnAguada = new Plano("Casa en Aguada");
            Assert.AreEqual(casaEnAguada, otracasaEnAguada);
        }

        [TestMethod]
        public void IgualdadPersonaFailTest()
        {
            Plano casaEnPalermo = new Plano("Casa en Palermo");
            Assert.IsFalse(casaEnAguada.Equals(casaEnPalermo));
        }
    }
}
