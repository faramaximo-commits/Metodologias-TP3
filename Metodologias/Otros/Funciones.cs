using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologias.Colecciones;
using Metodologias.Estrategias;
using Metodologias.Iteradores;
using MiComparable = Metodologias.Objetos.IComparable;
using Num = Metodologias.Objetos.Numero;
using Alum = Metodologias.Objetos.Alumno;
using Metodologias.Práctica_3;
using Metodologias.Objetos;

namespace Metodologias.Otros
{
    class Funciones
    {
        public void llenar(IColeccionable i, int opcion) //Ejercicio 6 (Práctica 3) Implemente una unica funcion Llenar() y una unica funcion Informar()
        {
            
            for(int k = 0; k < 20; k++)
            {
                MiComparable c = FabricaDeComparables.crearAleatorio(opcion);
                i.agregar(c);
            }
        }

        public void informar(IColeccionable i, int opcion)
        {
            
            Console.WriteLine($"Cantidad de elementos en el coleccionable: {i.cuantos()}");
            Console.WriteLine($"El elemento minimo del coleccionable es: {i.minimo()}");
            Console.WriteLine($"El elemento máximo del coleccionable es: {i.maximo()}");
            MiComparable c = FabricaDeComparables.crearPorTeclado(opcion);
            if (i.contiene(c))
            {
                Console.WriteLine("El elemento leído está en la colección :) ");
            }
            else { Console.WriteLine("El elemento leído no está en la colección :( "); }
        }

        //---------------------------------------------------------------------------------------------------------------

        public void cambiarEstrategia(IColeccionable c, IEstrategiaComparacion e)
        {
            IIterador i = ((IIterable)c).crearIterador();

            for (i.primero(); !i.fin(); i.siguiente())
            {
                Alum a = (Alum)i.actual();
                a.setEstrategia(e);
            }
        }

        public void dictadoDeClases(Profesor p) //Ejercicio 13 (Práctica 3) Implemente la funcion dictadoDeClases(profesor)
        {
            for(int i = 0; i < 5; i++)
            {
                p.hablarALaClase();
                p.escribirEnElPizarron();
            }
        }

        
    }
}
