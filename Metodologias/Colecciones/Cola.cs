using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologias.Iteradores;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Colecciones
{
    public class Cola : IColeccionable, IIterable
    {
        List<MiComparable> cola;
        public Cola()
        {
            cola = new List<MiComparable>();
        }

        public int cuantos()
        {
            return cola.Count;
        }

        public MiComparable minimo()
        {
            MiComparable devolver = cola[0];
            for (int i = 0; i < cuantos(); i++)
            {
                if (cola[i].SosMenor(devolver))
                {
                    devolver = cola[i];
                }
            }
            return devolver;
        }

        public MiComparable maximo()
        {
            MiComparable devolver = cola[0];
            for (int c = 0; c < cuantos(); c++)
            {
                if (cola[c].SosMayor(devolver))
                {
                    devolver = cola[c];
                }
            }
            return devolver;
        }

        public void agregar(MiComparable i)
        {
            cola.Add(i);
        }

        public bool contiene(MiComparable i)
        {
            bool cont = false;
            for (int c = 1; c < cuantos(); c++)
            {
                if (cola[c].SosIgual(i))
                {
                    cont = true;
                }
            }
            return cont;
        }
        //Metodos de Cola
        public void encolar(MiComparable i)
        {
            cola.Add(i);
        }

        public MiComparable desencolar()
        {
            if (cuantos() == 0) return null;
            MiComparable elem = cola[0];
            cola.RemoveAt(0);
            return elem;
        }

        public MiComparable primero()
        {
            if (cuantos() == 0) return null;
            return cola[0];
        }

        public IIterador crearIterador()
        {
            IIterador i = new IteradorCola(cola);
            return i;
        }
    }
}
