using System;


namespace _13.CicloFor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que permita imprimir por pantalla los números múltiplos de 5, el usuario debe ingresar por el teclado el rango de números a evaluar.
            
            int acumulador = 0;
            int rango;

            Console.WriteLine("ingresa la cantidad de multiplos de 5 que quieres ver: " );
           rango = int.Parse(Console.ReadLine());

            for (int i = 0; i <= rango; i++)
            {
                acumulador = i * 5;
                Console.WriteLine(acumulador);
            }

        }
    }
}
