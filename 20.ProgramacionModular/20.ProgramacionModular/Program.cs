using System;


namespace _20.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz.


            int filas = CapturarFilas();
            int columnas = CapturarColumnas();
            int[,] matriz = new int[filas, columnas];
            LlenarMatriz(filas, columnas, matriz);
            MostrarMatriz(matriz);
            BorrarPantalla();
        }

        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas de la matriz: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas de la matriz: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void LlenarMatriz(int filas, int columnas, int[,] matriz)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición [{i},{j}] (múltiplo de 5): ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    while (valor % 5 != 0)
                    {
                        Console.WriteLine("El valor ingresado no es múltiplo de 5. Intente nuevamente: ");
                        valor = Convert.ToInt32(Console.ReadLine());
                    }
                    matriz[i, j] = valor;
                }
            }
        }

        static void MostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("La matriz ingresada es: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void BorrarPantalla()
        {
            Console.WriteLine("Presione cualquier tecla para borrar la pantalla...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

