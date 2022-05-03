using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Mascota
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static ETipoManada tipo;

        static Grupo()
        {
            Grupo.tipo = ETipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, ETipoManada tipo) :this(nombre)
        {
            Grupo.tipo = tipo;
        }

        public ETipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Grupo: {g.nombre} - tipo: {Grupo.tipo}");
            sb.AppendLine($"Integrantes ({g.manada.Count})");
            foreach (Mascota item in g.manada)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            foreach (Mascota item in g.manada)
            {
                if (item.Equals(m))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g.manada.Add(m);
                return g;
            }

            Console.WriteLine("No fue posible agregar la mascota a la lista");
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g.manada.Remove(m);
                return g;
            }

            Console.WriteLine("No fue posible quitar la mascota de la lista");
            return g;
        }





    }
}
