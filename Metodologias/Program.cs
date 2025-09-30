using Metodologias.Colecciones;
using Metodologias.Estrategias;
using Metodologias.Objetos;
using Metodologias.Otros;
using Metodologias.Práctica_3;
using System;

namespace Metodologias
{
    class Program
    {
        static void Main(string[] args)
        {
            Funciones funciones = new Funciones();

            //Ejercicio 14 (Práctica 3) Probar la funcion dictadoDeClases(profesor) en el Main
            
            Profesor profe = (Profesor)FabricaDeComparables.crearAleatorio(3);

            for (int i = 0; i < 20; i++)
            {
                Alumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(2);
                profe.agregarObservador(alumno);
            }

            funciones.dictadoDeClases(profe);
            

        }
    }
}
