using System;
using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ClienteTest
    {
        public ClienteTest()
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

        private Cliente ana { get; set; }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            ana = new Cliente("AGarcia", "", "", "", "", "", "", "", "");
        }

        [TestMethod]
        public void UsuarioVacioTest()
        {
            Cliente unCliente = new Cliente();
            Assert.AreEqual(unCliente.Usuario, "");
        }

        [TestMethod]
        public void AsignarUsuarioTest()
        {
            Cliente unCliente = new Cliente();
            unCliente.Usuario = "Usuario";
            Assert.AreEqual(unCliente.Usuario, "Usuario");
        }

        [TestMethod]
        public void NombreVacioTest()
        {
            Cliente unCliente = new Cliente();
            Assert.AreEqual(unCliente.Nombre, "");
        }

        [TestMethod]
        public void TestAsignarNombre()
        {
            Cliente unCliente = new Cliente();
            unCliente.Nombre = "Juan";
            Assert.AreEqual(unCliente.Nombre, "Juan");
        }

        [TestMethod]
        public void ApellidoVacioTest()
        {
            Cliente unCliente = new Cliente();
            Assert.AreEqual(unCliente.Apellido, "");
        }

        [TestMethod]
        public void AsignarApellidoTest()
        {
            Cliente unCliente = new Cliente();
            unCliente.Apellido = "Perez";
            Assert.AreEqual(unCliente.Apellido, "Perez");
        }

        [TestMethod]
        public void CIVaciaTest()
        {
            Cliente unCliente = new Cliente();
            Assert.AreEqual(unCliente.CI, "");
        }

        [TestMethod]
        public void AsignarCITest()
        {
            Cliente unCliente = new Cliente();
            unCliente.Apellido = "12345678";
            Assert.AreEqual(unCliente.Apellido, "12345678");
        }

        [TestMethod]
        public void TelefonoVacioTest()
        {
            Cliente unCliente = new Cliente();
            Assert.AreEqual(unCliente.Telefono, "");
        }

        [TestMethod]
        public void TestAsignarTelefono()
        {
            Cliente unCliente = new Cliente();
            unCliente.Telefono = "555-1234";
            Assert.AreEqual(unCliente.Telefono, "555-1234");
        }

        [TestMethod]
        public void DireccionVaciaTest()
        {
            Cliente unCliente = new Cliente();
            Assert.AreEqual(unCliente.Direccion, "");
        }

        [TestMethod]
        public void AsignarDireccionTest()
        {
            Cliente unCliente = new Cliente();
            unCliente.Direccion = "Una direccion";
            Assert.AreEqual(unCliente.Direccion, "Una direccion");
        }

        [TestMethod]
        public void IgualdadClienteTest()
        {
            Cliente otraAna = new Cliente("AGarcia", "", "", "", "", "", "", "", "");
            Assert.AreEqual(ana, otraAna);
        }

        [TestMethod]
        public void IgualdadClienteFailTest()
        {
            Cliente juan = new Cliente("Jperez", "", "", "", "", "", "", "", "");
            Assert.IsFalse(ana.Equals(juan));
        }

        [TestMethod]
        public void GetListaPlanosTest()
        {
            Cliente unCliente = new Cliente();
            Assert.AreEqual(unCliente.Planos.Count, 0);
        }

        [TestMethod]
        public void AgregoPlanoTest()
        {
            Cliente unCliente = new Cliente();
            Plano p = new Plano();
            unCliente.AgregoPlano(p);
            Assert.AreEqual(unCliente.Planos.Count, 1);
        }

        [TestMethod]
        public void EliminoPlanoTest()
        {
            Cliente unCliente = new Cliente();
            Plano p = new Plano();
            unCliente.AgregoPlano(p);
            unCliente.EliminoPlano(p);
            Assert.AreEqual(unCliente.Planos.Count, 0);
        }
    }
}
