using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Plano
    {
        public String Nombre { get; set; }

        public Plano()
        {
            Nombre = "";
        }

        public Plano(string unNombre)
        {
            Nombre = unNombre;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                Plano unPlano = (Plano)obj;
                equals = this.Nombre.Equals(unPlano.Nombre);
            }

            return equals;
        }
    }
}
