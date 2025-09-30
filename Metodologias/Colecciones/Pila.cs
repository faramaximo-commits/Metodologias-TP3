using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologias.Iteradores;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Colecciones
{
    public class Pila : IColeccionable, IIterable
    {
        List<MiComparable> pila;
        public Pila()
        {
            pila = new List<MiComparable>();
        }

        public int cuantos()
        {
            return pila.Count;
        }

        public MiComparable minimo()
        {
            MiComparable devolver = pila[0];
            for (int i = 0; i < cuantos(); i++)
            {
                if (pila[i].SosMenor(devolver))
                {
                    devolver = pila[i];
                }
            }
            return devolver;
        }

        public MiComparable maximo()
        {
            MiComparable devolver = pila[0];
            for (int c = 0; c < cuantos(); c++)
            {
                if (pila[c].SosMayor(devolver))
                {
                    devolver = pila[c];
                }
            }
            return devolver;
        }

        public void agregar(MiComparable i)
        {
            pila.Add(i);
        }

        public bool contiene(MiComparable i)
        {
            bool cont = false;
            for (int c = 1; c < cuantos(); c++)
            {
                if (pila[c].SosIgual(i))
                {
                    cont = true;
                }
            }
            return cont;
        }
        //Metodos de pila
        public void Apilar(MiComparable i)
        {
            pila.Add(i);
        }

        public MiComparable Desapilar()
        {
            if (cuantos() == 0) return null;
            MiComparable elem = pila[pila.Count - 1];
            pila.RemoveAt(pila.Count - 1);
            return elem;
        }

        public MiComparable Tope()
        {
            if (cuantos() == 0) return null;
            return pila[pila.Count - 1];
        }

        public IIterador crearIterador()
        {
            IIterador i = new IteradorPila(pila);
            return i;
        }
    }
}

