using System;

namespace _10.CiclosWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un algoritmo en el que el computador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. Utilizar la función Random para elegir el número aleatorio.
            int numeroAleatorio = new Random().Next(1, 101);
            int intento;
            bool adivinado = false;

            Console.WriteLine("Estoy pensando en un número entre 1 y 100.");

            while (adivinado == false)
            {
                Console.Write("Ingresa tu intento: ");
                intento = int.Parse(Console.ReadLine());

                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("¡Correcto! Has adivinado el número.");
                    adivinado = true;
                }
            }
        }
    }
}
