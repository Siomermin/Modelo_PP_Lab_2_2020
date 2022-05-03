using System;
using System.Text;

namespace Entidades_Mascota
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        protected Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        protected virtual string DatosCompletos()
        {
            return $"{this.nombre} - {this.raza}";
        }

        protected abstract string Ficha();

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            return m1.nombre == m2.nombre && m1.raza == m2.raza;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }

    }
}
