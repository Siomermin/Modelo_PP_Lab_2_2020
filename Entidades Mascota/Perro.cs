using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Mascota
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza) : this(nombre, raza, 0, false)
        {
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) :base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.GetType().Name} - {base.DatosCompletos()} ");
            if (this.esAlfa)
            {
                sb.Append($"- Alfa de la manada ");
            }
            sb.AppendLine($"- edad: {this.edad}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is not null && obj.GetType() == typeof(Perro))
            {
                return this == (Perro)obj;
            }

            return false;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public static explicit operator int(Perro p)
        {
            return p.edad;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return ((Mascota)p1) == p2 && p1.edad == p2.edad;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }



    }
}
