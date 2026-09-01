using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _11.CIcloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ciclo Do While
            /*   int contador = 1;
               int acumulador = 0;

               do
               {
                   acumulador += contador;
                   contador++;
               } while (contador <= 5);*/


            //Algoritmo que solicite un numero y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. y asi sucesivamente hasta que el usuario ya no desee continuar generando tablas de ultiplicar.

            /*int numero;
            int contador = 0;
            int acumulador;
            char selector;
            

           
            
                Console.WriteLine("ingrese el numero que quieres generar su tabla de multiplicar del 1 al 10: ");
                numero = int.Parse(Console.ReadLine());

             do
             {
                acumulador = numero * contador;

                Console.WriteLine($"{numero} x {contador} = {acumulador}");
                    contador++;
             } while (contador <= 10);
             {
                Console.WriteLine("Desea generar otra tabla de multiplicar: (s) para si, de lo contrario ingrese cualquier otro caracter");
                selector = char.Parse(Console.ReadLine());
                if (selector == 's' || selector == 's')
                {
                    Main(args);
                }
                else
                {
                    Console.WriteLine("Adios");
                }


             }*/

            //2. crear un algoritmo que permita calcular y mostar por pantalla los numeros primos hasta le numero 100

            int numero = 2;
            int contador;
            bool esPrimo = true;

            Console.WriteLine("se calcularan los numeros primos:");
            do
            {
                contador = 2;
                esPrimo = true;
                while (contador <= Math.Sqrt(numero))
                {
                    if (numero % contador == 0) {
                        esPrimo )= false;
                        break;
                    }
                    contador++;

                    if (esPrimo) {
                        Console.WriteLine(numero);
                    }
                    numero++;
                } while (numero<= 100)


            

            
        


        }


    }
}
