using System;

namespace _12_ejemplo_Input_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad");
            string edadtexto;
            edadtexto = Console.ReadLine();
            int edad;
            edad = Convert.ToInt32(edadtexto);
            Console.WriteLine("Hola " + edad + " años");
        }
    }
}