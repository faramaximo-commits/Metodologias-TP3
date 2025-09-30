using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologias.Otros;
using Metodologias.Objetos;
using Metodologias.Estrategias;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Práctica_3
{
    public abstract class FabricaDeComparables 
    {
        //--Ejercicio 4 (Práctica 3)(Clase abstracta FabricaDeComparables, métodos estáticos crearAleatorio(opcion) y crearPorTeclado(opcion))
        public static MiComparable crearAleatorio(int opcion)
        {
            MiComparable c = null;
            switch (opcion)
            {
                case 1:
                    int valor = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10000000);
                    c = new Numero(valor);
                    break;
                case 2:
                    string nombre = GeneradorDeDatos.ObtenerNombreAleatorio();
                    int dni = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000);
                    int legajo = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 1000);
                    int promedio = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10);
                    IEstrategiaComparacion estrategia = GeneradorDeDatos.obtenerEstrategiaAleatoria();
                    c = new Alumno(nombre, dni, legajo, promedio, estrategia);
                    break;
                case 3:
                    string nombreProfesor = GeneradorDeDatos.ObtenerNombreAleatorio();
                    int dniProfesor = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000);
                    int antiguedad = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 100);
                    c = new Profesor(nombreProfesor, dniProfesor, antiguedad);
                    break;

                default:
                    break;
            }
            return c;
        }

        public static MiComparable crearPorTeclado(int opcion)
        {
            MiComparable c = null;
            switch (opcion)
            {
                case 1:
                    FabricaDeNumeros fNumero = new FabricaDeNumeros();
                    c = fNumero.crearPorTeclado();
                    break;
                case 2:
                    FabricaDeAlumnos fAlumnos = new FabricaDeAlumnos();
                    c = fAlumnos.crearPorTeclado();
                    break;
                case 3:
                    FabricaDeProfesores fProfesores = new FabricaDeProfesores();
                    c = fProfesores.crearPorTeclado();
                    break;
                default:
                    break;
            }
            return c;
        }

        public abstract MiComparable crearAleatorio();
        public abstract MiComparable crearPorTeclado();

        
    }
}
