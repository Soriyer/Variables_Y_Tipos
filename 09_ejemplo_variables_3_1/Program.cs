/*
 * Ya que al utilizar una variable estamos utilizando el valor que hay
 * dentro de la variable, podemos utilizar variables cuando definimos
 * una variable nueva.
 */

using System;

namespace _09_ejemplo_variables_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int manzanas;
            manzanas = 2;
            string frase;
            frase = "tengo " + manzanas + " manzanas";
            Console.WriteLine(frase);

            manzanas = manzanas + 1;
            frase = "tengo " + manzanas + " manzanas";
            Console.WriteLine(frase);
        }
    }
}
