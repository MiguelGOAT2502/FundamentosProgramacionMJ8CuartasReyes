using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _9.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Realizar un algoritmo que le pida al ususario ingresar por teclado numeros enteros al azar. Al usuario le corresponde ingresar la cantidad de numeros que va a introducir. El algoritmo debe escribir en pantalla: la cantidad de numneros introducidos que son mayores que 0, La cantidad de numeros introducidos menores que 0 y la canridad de numeros iguales a 0.
           
            int cantidadNumeros = 0;
            int numero = 0;
            int contador = 0;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;


            Console.WriteLine("Ingresa la cantidad de numeros a evaluar: ");
            cantidadNumeros = int.Parse(Console.ReadLine());

            while (cantidadNumeros>contador)
            {
                contador++;
                Console.WriteLine("ingrese el numero a evaluar");
                numero=int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    contadorNegativos++;
                }
                else
                {
                    if (numero > 0)
                    {
                        contadorPositivos++;
                    }
                    else
                    {
                        contadorCeros++;
                    }
                   

                }
            }
            Console.WriteLine($"cantidad positivos: {contadorPositivos}, cantidad negativos: {contadorNegativos}, cantidad ceros: {contadorCeros}");
        
        }
    }
}
