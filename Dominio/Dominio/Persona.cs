using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public String Usuario { get; set; }
        public String Contrasena { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Registro { get; set; }
        public String UltimoIngreso { get; set; }

        public Persona()
        {
            Usuario = "";
            Nombre = "";
            Apellido = "";
            Contrasena = "";
            Registro = "";
            UltimoIngreso = "";
        }

        public Persona(string unUsuario, string unaContrasena, string unNombre, string unApellido, string unRegistro, string elUltimoIngreso)
        {
            Usuario = unUsuario;
            Contrasena = unaContrasena;
            Nombre = unNombre;
            Apellido = unApellido;
            Registro = unRegistro;
            UltimoIngreso = elUltimoIngreso;
        }

        public override string ToString()
        {
            return Usuario + ": " + Nombre + " " + Apellido ;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                Persona unaPersona = (Persona)obj;
                equals = this.Usuario.Equals(unaPersona.Usuario);
            }
            return equals;

        }
    }
}
