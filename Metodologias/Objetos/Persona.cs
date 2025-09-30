using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias.Objetos
{
    public abstract class Persona : IComparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string n, int d)
        {
            nombre = n;
            dni = d;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getDni()
        {
            return dni;
        }

        public virtual bool SosIgual(IComparable i)
        {
            Persona p = (Persona)i;
            return dni == p.getDni();
        }

        public virtual bool SosMayor(IComparable i)
        {
            Persona p = (Persona)i;
            return dni < p.getDni();
        }

        public virtual bool SosMenor(IComparable i)
        {
            Persona p = (Persona)i;
            return dni > p.getDni();
        }


    }
}
