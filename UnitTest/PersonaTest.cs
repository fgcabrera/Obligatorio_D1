using System;
using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class PersonaTest
    {

        public PersonaTest()
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

        private Persona ana { get; set; }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            ana = new Persona("AGarcia", "", "", "", "", "");
        }

        [TestMethod]
        public void UsuarioVacioTest()
        {
            Persona unaPersona = new Persona();
            Assert.AreEqual(unaPersona.Usuario, "");
        }

        [TestMethod]
        public void AsignarUsuarioTest()
        {
            Persona unaPersona = new Persona();
            unaPersona.Usuario = "Usuario";
            Assert.AreEqual(unaPersona.Usuario, "Usuario");
        }

        [TestMethod]
        public void NombreVacioTest()
        {
            Persona unaPersona = new Persona();
            Assert.AreEqual(unaPersona.Nombre, "");
        }

        [TestMethod]
        public void AsignarNombreTest()
        {
            Persona unaPersona = new Persona();
            unaPersona.Nombre = "Juan";
            Assert.AreEqual(unaPersona.Nombre, "Juan");
        }

        [TestMethod]
        public void ApellidoVacioTest()
        {
            Persona unaPersona = new Persona();
            Assert.AreEqual(unaPersona.Apellido, "");
        }

        [TestMethod]
        public void AsignarApellidoTest()
        {
            Persona unaPersona = new Persona();
            unaPersona.Apellido = "Perez";
            Assert.AreEqual(unaPersona.Apellido, "Perez");
        }

        [TestMethod]
        public void IgualdadPersonaTest()
        {
            Persona otraAna = new Persona("AGarcia", "", "", "", "", "");
            Assert.AreEqual(ana, otraAna);
        }

        [TestMethod]
        public void IgualdadPersonaFailTest()
        {
            Persona juan = new Persona("Jperez", "", "", "", "", "");
            Assert.IsFalse(ana.Equals(juan));
        }
    }
}
