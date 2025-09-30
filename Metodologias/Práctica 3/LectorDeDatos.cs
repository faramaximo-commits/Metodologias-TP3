using Metodologias.Estrategias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias.Práctica_3
{
    public class LectorDeDatos //Ejercicio 3 (Práctica 3) Implemente la clase LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            int valor;
            Console.Write("Introducir número: ");
            while (!int.TryParse(Console.ReadLine(), out valor))
            { 
                Console.Write("Inválido, introduzca un número por favor: "); 
            }
            return valor;
        }

        public string stringPorTeclado()
        {
            Console.Write("Introducir palabra: ");
            string palabra = Console.ReadLine();
            return palabra;
        }

        //--Agrego este método no solicitado en la práctica pero me pareció útil que el usuario tenga el control para elegir la estrategia que desee
        public IEstrategiaComparacion estrategiaPorTeclado() 
        {
            Console.WriteLine("Estrategias de comparación (Si no elige alguna por defecto se comparan por nombre)! ");
            Console.WriteLine("1 - Comparar por Nombre");
            Console.WriteLine("2 - Comparar por DNI");
            Console.WriteLine("3 - Comparar por Legajo");
            Console.WriteLine("4 - Comparar por Promedio");
            Console.Write("Elija una estrategia: ");
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = 1;
            }
            switch (opcion)
            {
                case 1: return new CompararAlumnoNombre();
                case 2: return new CompararAlumnoDni();
                case 3: return new CompararAlumnoLegajo();
                case 4: return new CompararAlumnoPromedio();
                default: return new CompararAlumnoNombre();
            }


        }
    }
}
