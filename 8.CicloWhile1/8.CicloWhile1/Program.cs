using System;


namespace _8.CicloWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.
            int numero = 0;
            int suma = 0;
            Console.WriteLine("Ingrese números enteros positivos para sumarlos. Ingrese un número negativo para finalizar.");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                suma += numero;
                Console.WriteLine("Ingrese otro número entero positivo o un número negativo para finalizar.");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La suma total de los números ingresados es: " + suma);
        }
    }
}
