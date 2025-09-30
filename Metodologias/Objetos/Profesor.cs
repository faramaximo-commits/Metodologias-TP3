using Metodologias.Observer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias.Objetos
{
    public class Profesor : Persona //Ejercicio 8 (Práctica 3) Implemente la clase Profesor que sea subclase de Persona
    {
        private int antiguedad;
        private List<IObservador> observadores = new List<IObservador>(); //Ejercicio 12 (Práctica 3) Implemente el patron Observer haciendo que el profesor sea el observable y los alumnos los observadores del profesor

        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.antiguedad = a;
        }

        public int getAntiguedad()
        {
            return this.antiguedad;
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algun tema...");
            Notificar("hablar");
        }

        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarrón...");
            Notificar("escribir");
        }

        public void agregarObservador(IObservador o)
        {
            this.observadores.Add(o);
        }

        public void quitarObservador(IObservador o)
        {
            this.observadores.Remove(o);
        }

        private void Notificar(string accion)
        {
            foreach (var o in observadores)
            {
                o.Actualizar(accion);
            }
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, DNI: {dni}, antiguedad: {antiguedad}";
        }

        public override bool SosIgual(IComparable i)
        {
            Profesor comparado = (Profesor)i;
            return this.antiguedad == comparado.getAntiguedad();
        }

        public override bool SosMayor(IComparable i)
        {
            Profesor comparado = (Profesor)i;
            return this.antiguedad > comparado.getAntiguedad();
        }

        public override bool SosMenor(IComparable i)
        {
            Profesor comparado = (Profesor)i;
            return this.antiguedad < comparado.getAntiguedad();
        }
    }
}
