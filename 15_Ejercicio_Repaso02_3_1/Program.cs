/*
 * Escribe un programa que pida dos números al usuario y muestre el resultado de sumarlos, multiplicarlos, restarlos, dividirlos y el resto de la división
 */
using System;

namespace _15_Ejercicio_Repaso01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero");
            string numero1;
            numero1 = Console.ReadLine();
            float primero;
            primero = Convert.ToInt32(numero1);
            Console.WriteLine("introduzca otro numero");
            string numero2;
            numero2 = Console.ReadLine();
            float segundo;
            segundo = Convert.ToInt32(numero2);
            Console.WriteLine("El resultado de " + primero + "+" + segundo + " = " + (primero + segundo));
            {
                Console.WriteLine("El resultado de " + primero + "-" + segundo + " = " + (primero - segundo));
                {
                    Console.WriteLine("El resultado de " + primero + "*" + segundo + " = " + (primero * segundo));
                    {
                        Console.WriteLine("El resultado de " + primero + "/" + segundo + " = " + (primero / segundo));
                    }

                }
            }
        }

    }
    }