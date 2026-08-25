using System;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//1.Escribir un algoritmo que permita generar los primeros 5 numeros enteros positivos y realizar y mostar su suma
            int contador = 1;
            int acumulador = 1;

            while (contador < 5)
            {
                contador++;
                acumulador = acumulador + contador;
            }
            Console.WriteLine($"La suma de los primeros 5 números enteros positivos es: {acumulador}");*/

            //crear que permita calcular la factorial de un numero dado por el usuario. (5! = 5*4*3*2*1)
            Console.Write("Ingrese un número para calcular su factorial: ");
            int numero = int.Parse(Console.ReadLine());
            int factorial = 1;
            int i = 1;

            while (i <= numero)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"El factorial de {numero} es: {factorial}");

        }
    }
}
