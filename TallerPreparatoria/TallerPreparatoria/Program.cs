using System;


namespace TallerPreparatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar enpantalla los números de menor a mayor.

            /*int numero1, numero2, numero3;

            Console.WriteLine("Ingrese el primer número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero2 != numero3)
            {
                if (numero1 > numero2 && numero2 > numero3 && numero1 > numero3)
                {
                    Console.WriteLine("El número mayor es: " + numero1);
                    Console.WriteLine("Ordenados de menor a mayor serían: " + numero3 + ", " + numero2 + ", " + numero1);
                }
                else if (numero1 > numero3 && numero3 > numero2 && numero1 > numero2)
                {
                    Console.WriteLine("El número mayor es: " + numero1);
                    Console.WriteLine("Ordenados de menor a mayor serían: " + numero2 + ", " + numero3 + ", " + numero1);
                }
                else if (numero2 > numero1 && numero1 > numero3 && numero2 > numero3)
                {
                    Console.WriteLine("El número mayor es: " + numero2);
                    Console.WriteLine("Ordenados de menor a mayor serían: " + numero3 + ", " + numero1 + ", " + numero2);
                }
                else if (numero2 > numero3 && numero3 > numero1 && numero2 > numero1)
                {
                    Console.WriteLine("El número mayor es: " + numero2);
                    Console.WriteLine("Ordenados de menor a mayor serían: " + numero1 + ", " + numero3 + ", " + numero2);
                }
                else if (numero3 > numero1 && numero1 > numero2 && numero3 > numero2)
                {
                    Console.WriteLine("El número mayor es: " + numero3);
                    Console.WriteLine("Ordenados de menor a mayor serían: " + numero2 + ", " + numero1 + ", " + numero3);
                }
                else if (numero3 > numero2 && numero2 > numero1 && numero3 > numero1)
                {
                    Console.WriteLine("El número mayor es: " + numero3);
                    Console.WriteLine("Ordenados de menor a mayor serían: " + numero1 + ", " + numero2 + ", " + numero3);
                }
            }

            else
         {
                    Console.WriteLine("Los números no son diferentes.");
         */
            //2. El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si cuenta con munición y si se encuentra en estado invencible

            byte estado;
            byte municion;

            Console.WriteLine("ingrese el estado del personaje (invencible (1) o vulnerable (2)): ");
            estado = byte.Parse(Console.ReadLine());

            Random rnd = new Random();
            municion = (byte)rnd.Next(1, 11);
            Console.WriteLine(municion);

            if (estado == 1 && municion > 0)
            {
                Console.WriteLine("El personaje puede disparar");
            }
            else
            {
                Console.WriteLine("El personaje no puede disparar");
            }












        }
    }
}

