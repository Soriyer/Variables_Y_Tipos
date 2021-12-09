/*
 * Escribe un programa que pida un número de 3 dígitos y que muestre en pantalla el resultado de sumarlos.
 * Pistas:
 * 1. El resto de una división cuyo divisor es 10, 100, 1000... se corresponde con los decimales del resultado
 * 52/10 = 5,2
 * 52%10 = 2
 */
using System;

namespace _19_Ejercicio_Repaso05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe un numero");
            string numero1;
            numero1 = Console.ReadLine();
            int primero;
            primero = Convert.ToInt32(numero1);
            Console.WriteLine("escribe otro numero");
            string numero2;
            numero2 = Console.ReadLine();
            int segundo;
            segundo = Convert.ToInt32(numero2);
            Console.WriteLine("escribe un tercer numero");
            string numero3;
            numero3 = Console.ReadLine();
            int tercero;
            tercero = Convert.ToInt32(numero3);
            {
                Console.WriteLine(numero1 + numero2 + numero3);
            }

        }
    }
}