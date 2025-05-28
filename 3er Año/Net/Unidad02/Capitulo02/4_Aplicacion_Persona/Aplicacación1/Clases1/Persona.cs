using System;

namespace Clases1
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int dni;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
            Console.WriteLine("El objeto fue creado.");
        }
        ~Persona()
        {
            Console.WriteLine("El objeto fue destruido.");
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public void GetFullName()
        {
            Console.WriteLine(apellido + ", " + nombre);
        }

        public void GetAge()
        {
            Console.WriteLine(edad);
        }
    }
}

