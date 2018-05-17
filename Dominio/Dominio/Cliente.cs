using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente: Persona
    {
        public String CI { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public ICollection<Plano> Planos { get; set; }

        public Cliente() : base()
        {
            CI = "";
            Telefono = "";
            Direccion = "";
            this.Planos = new List<Plano>();
        }

        public Cliente(string unUsuario, string unaContrasena, string unNombre, string unApellido, string unRegistro, string elUltimoIngreso, string unaCI, string unTelefono, string unaDireccion) : base( unUsuario,  unaContrasena,  unNombre,  unApellido,  unRegistro,  elUltimoIngreso)
        {
            CI = unaCI; ;
            Telefono = unTelefono;
            Direccion = unaDireccion;
            this.Planos = new List<Plano>();
        }

        public bool AgregoPlano(Plano p)
        {

            if (!this.Planos.Contains(p))
            {
                Planos.Add(p);
                return (true);
            }
            else
            {
                return false;
            }
        }

        public bool EliminoPlano(Plano p)
        {
            if (this.Planos.Contains(p))
            {
                Planos.Remove(p);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
