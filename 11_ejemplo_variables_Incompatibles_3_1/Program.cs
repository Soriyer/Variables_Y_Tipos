/*
 * Algo que todavía no hemos mencionado es el hecho que
 * el tipo de variable que creamos limita el tipo de
 * valores que podemos introducir en él.
 * 
 * En el caso de cadenas de texto y números enteros
 * las variables son incompatibles. Puede ser obvio que
 * no podemos introducir una cadena de texto en
 * una variable que hemos creado para números
 * enteros. Del mismo modo, tampoco es posible introducir 
 * un valor numérico dentro de una variable de cadena de 
 * texto. Si intentamos cualquiera de las dos, Visual 
 * Studio nos indicará que existe un error. 
 * 
 * Aunque hayamos usado números dentro de variables de
 * tipo string anteriormente, hay que fijarse en que
 * estabamos utilizando números que se habían convertido
 * a texto (por ejemplo cuando concatenábamos textos
 * con valore numéricos utilizando el símbolo +). Por
 * otro lado, cuando mostramos a pantalla utilizando
 * Console.WriteLine(), podemos pasarle cualquier valor
 * ya sea entero o de texto, ya que no lo especifica.
 * Pero al especificar que una variable es de un tipo
 * u otro, limitamos los tipos de valores que le podemos
 * dar.
 * 
 * Para comprobar que no se pueden mezclar los tipos de
 * variables, las líneas de código que están comentadas
 * en este ejemplo dan error.
 * 
 * Si queremos utilizar valores numéricos en cadenas
 * de texto (o utilizar un número de una cadena de
 * texto como un valor numérico) tenemos que parsearlos
 * es decir, hacer que el ordenador los lea y los convierta
 * al tipo correcto. 
 */


using System;

namespace _11_Ejemplo_Variables_Incompatibles
{
    class Program
    {
        static void Main(string[] args)
        {
            int coches;
            // coches = "2"; // Si quitas el comentario al principio de la línea, verás que esto da un error.
            coches = Convert.ToInt32("2");
            string diadelmes;
            diadelmes = Convert.ToString(17);
            Console.WriteLine(diadelmes);

           
        }
    }
}
