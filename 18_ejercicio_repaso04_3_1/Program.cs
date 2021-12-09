using System;

namespace _18_Ejercicio_Repaso04
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            int c;

            Console.WriteLine("escribe un numero");
            a = Convert.ToInt32(Console.ReadLine());
            c = a;
            Console.WriteLine("escribe otro numero");
            b = Convert.ToInt32(Console.ReadLine());
            a = b;
            Console.WriteLine("a: " + b + " Y" + " b: " + c);
           
        }

    }
}