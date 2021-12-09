/*
 * Escribe un programa que pida un número de minutos y muestre cuantos años y días son.
 */
using System;

namespace _20_Ejercicio_Repaso06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe un numero en minutos para convertirlos en años y dias");
            String minutos;
            minutos = Console.ReadLine();
            int minuto;
            minuto = Convert.ToInt32(minutos);
            int años;
            años = (minuto / 525600);
            int dias;
            dias =(minuto / 1440);
            {
                Console.WriteLine("Esos minutos " + " son " + años + " años " + " y " + dias + " dias");
            }
        }
    }
}
