using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo Operaciones Aritmeticas para Git");

            Console.WriteLine("Numero Uno:");
            short numUno = short.Parse(Console.ReadLine());

            Console.WriteLine("Numero Dos:");
            short numDos = short.Parse(Console.ReadLine());


            /*ya tenemos creada la aplicacion de escritorio que por ahora solicita dos numeros enteros.
             * se guardan los cambios, los cuales van a ser empaquetados(versionados)
             * en un primer commit mediante GIT, para ello debemos abrir el CMD o terminal
             
            ya se creo el primer commit con la configuracion inical del proyecto

            vamos a modificar o actualizar el proyecto, se agregara una nueva class y en esta dos atributos y un metodo
            que sume los dos numeros solicitados por consola
             */

            //instanciar la class de OperacionesAritmeticas
            var realizarOperacion = new OperacionesAritmeticas();

            //asignar valores de las variables a los atributos de la class
            realizarOperacion.nUno = numUno;
            realizarOperacion.nDos = numDos;
            //no es la forma mas adecuada de asignar valores, pero se realizara solo para este ejercicio


            //acceder al metodo (utilizarlo)
            realizarOperacion.Sumar(realizarOperacion.nUno, realizarOperacion.nDos);

            Console.ReadLine();
        }
    }
}
