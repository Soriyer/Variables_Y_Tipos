/*
 * Escribe un programa que pida tres números al usuario y que calcule y muestre su media.
 */
using System;

namespace _17_Ejercicio_Repaso03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe un numero");
            {
                string numero1;
                numero1 = Console.ReadLine();
                float primero;
                primero = Convert.ToInt32(numero1);
                {
                    Console.WriteLine("escribe otro numero");
                    string numero2;
                    numero2 = Console.ReadLine ();
                    float segundo;
                    segundo =Convert.ToInt32(numero2);
                    {
                        Console.WriteLine("escribe un tercer numero");
                        string numero3;
                        numero3 = Console.ReadLine();
                        float tercero;
                        tercero = Convert.ToInt32(numero3);
                        {
                            Console.WriteLine("el promedio de los tres numeros es");
                            {
                                Console.WriteLine(((primero+segundo+tercero)/3));
      
                            }
                        }
                    }
                }
                
            }
        }
    }
}

