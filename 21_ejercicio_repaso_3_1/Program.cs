/*
 * Escribe un programa que genere un número aleatorio entre el 1 y el 100 
 * Pista: 
 * 1. hay que utilizar una función, hay que buscarlo en internet ya que no lo hemos visto en el precurso
 */
using System;

namespace _21_Ejercicio_Repaso07
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero = random.Next(1, 101);
            Console.WriteLine(numero);
                
        }
    }
}