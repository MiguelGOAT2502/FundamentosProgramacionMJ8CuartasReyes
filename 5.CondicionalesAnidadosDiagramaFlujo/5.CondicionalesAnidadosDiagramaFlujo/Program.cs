using System;


namespace _5.CondicionalesAnidadosDiagramaFlujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales anidados - Diagrama de flujo
            // B. diseñar un algoritmo que lea tres números y determine cuál es el mayor de los tres.

            int num1;
            int num2;
            int num3;

            Console.WriteLine("Ingrese 3 numeros: ");

            Console.WriteLine("ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2) 
            { //verdadera
                if (num1 > num3)
                {
                    Console.WriteLine("El numero 1 es el mayor");
                }
                else 
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }
            }
            else 
            {//Falsa
                if (num2 > num3)
                {
                    Console.WriteLine("El numero 2 es el mayor");
                }
                else {
                    Console.WriteLine("El numero 3 es el mayor");
                }
            }
        }
    }
}
