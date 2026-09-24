using System;
using System.Text.RegularExpressions;


namespace _17.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Diseñe un algoritmo que permita transformar una matriz numérica reemplazando todos sus elementos que sean menores a un valor umbral N, por dicho valor. Requerimientos: 1.Solicitar al usuario las dimensiones de la matriz(número de filas y columnas). 2. Capturar los valores numéricos para llenar la matriz. 3.Solicitar el valor límite u objetivo(N). 4. Recorrer la matriz y actualizar cualquier valor que cumpla la condición elemento<N. 5. Mostrar la matriz resultante.
            int filas = 0;
            int columnas = 0;
            int N = 0;

            Console.WriteLine("ingrese el número de filas de la matriz:");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el número de columnas de la matriz:");
            columnas = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor límite u objetivo (N):");
            N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición [{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] < N)
                    {
                        matriz[i, j] = N;
                    }
                }
            }

            
            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
