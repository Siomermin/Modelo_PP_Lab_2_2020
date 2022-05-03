using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Mascota
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }

        protected override string Ficha()
        {
            return $"{this.GetType().Name} - {base.DatosCompletos()}\n";
        }

        public override bool Equals(object obj)
        {
            if (obj is not null && obj.GetType() == typeof(Gato))
            {
                return this == (Gato)obj;
            }

            return false;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            return ((Mascota)g1) == g2;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
    }
}
