using Clases;
using System;

class Program
{
    static void Main()
    {
        A a = new A();
        A a2 = new A("Perro");
        B b = new B();
        B b2 = new B("Gato");

        a.M1();
        a.M2();
        a.M3();
        a.MostrarNombre();
        b.MostrarNombre();
        b.M1();
        b.M2();
        b.M3();
        b.M4();

    }
}
