/*
 * Escribe un programa que convierta los segundos a horas, minutos y segundos. Por ejemplo si introduce 4000 segundos que muestre 
 * el mensaje: 1 horas, 6 minutos, 40 segundos.
 * Pistas:
 * 1. Necesitarás como mínimo 3 variables: Horas, minutos y segundos
 * 2. El usuario nos introduce segundos, para pasar de segundos a horas hay que dividir entre 3600. 
 * La parte entera por ejemplo 3 de 3,1567 son las horas exactas que se cumplen con esos segundos. 
 * La parte decimal 1567 del ejemplo anterior por ejemplo, serán los segundos que no llegan a cumplir una hora. 
 * ¿Pero si que pueden llegar a cumplir un minuto no?
 */
using System;

namespace _16_Ejercicio_Repaso02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe en segundos lo que vamos a pasar a horas minutos y segundos");
            String segundo;
            segundo = Console.ReadLine();
            int segundos;
            segundos = Convert.ToInt32(segundo);
            int minutos;
            minutos = segundos / 60;
            int peras;
            peras = minutos / 60;

            {
                Console.WriteLine(segundos + " son " + (segundos / 3600) + " hora " + (segundos /3600 / minutos) + " minutos " + peras/3600/minutos + " segundos");

            }

        }
    }
}
