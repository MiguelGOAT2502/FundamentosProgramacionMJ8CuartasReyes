using System;


namespace _16.ArregloBidimensional_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //Arreglos bidimensionales-Matrices
            int[,] numeros = new int[2, 3];
            //numeros[2, 1] = 45; no se puede almacenar porque el indice de la fila no existe
            //numeros[1, 4] = 20; no se puede almacenar porque el indice de la columna no existe
            numeros[0, 0] = 12;
            numeros[0, 1] = 89;
            numeros[0, 2] = 46;
            numeros[1, 0] = 2;
            numeros[1, 1] = 54;
            numeros[1, 2] = 25;
            //Recuperar dato de una posicion 
            Console.WriteLine($"El valor almacenado en numeros[1, 0] es: {numeros[1, 0]}");
            //recorrer matriz para llenar
            char[,] simbolos = new char[3, 2];
            for (int i = 0; i < 3; i++) //recorrer las filas
            {
                for (int j = 0; j < 2; j++) //recorrer las columnas
                {
                    Console.WriteLine($"Escriba el caracter para la posicion [{i}, {j}]: ");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            //Recorrer para recuperar los datos
            for (int i=0; i<simbolos.GetLength(0); i++) //recorrer las filas
            {
                for (int j = 0; j < simbolos.GetLength(1); j++) //recorrer las columnas
                {
                    Console.Write($"{simbolos[i, j]} |");
                }
                Console.WriteLine(); // Salto de línea después de cada fila
            }

            //Otra forma de declarar e inicializar matrices
            string[,] nombres = {
                                 {"Juan", "Pedro", "Maria", "Sofia"},
                                 {"Ana", "Luis", "Carlos", "Elena"},
                                 {"Alejandro", "Manolo", "Sebastian", "Santiago"}
            };
        }*/

            /* //1. Crear una matriz [10, 20] en cada posicion de la matriz poner el numero 100; mostrar la matriz en consola.
             int[,] matriz = new int[10, 20];
             for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 20; j++)
                 {
                     matriz[i, j] = 100;
                 }
             }

             // Mostrar la matriz en consola
             for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 20; j++)
                 {
                     Console.Write($"| {matriz[i, j]} |");
                 }
                 Console.WriteLine();
             }
         }*/

            //2. escribe un programa que realice la suma de dos materices de dimensiones 2x3. requisitos: 1. Solicitar al usuario que ingrese los valores de la primera matriz. 2. Solicitar al usuario que ingrese los valores de la segunda matriz. 3. calcular la matriz suma, resultado de sumar cada elemeto correspondiente de las dos matrices. 4. Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas)..
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] matrizSuma = new int[2, 3];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición [{i}, {j}] de la primera matriz: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición [{i}, {j}] de la segunda matriz: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matrizSuma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++)
                {
                    matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            Console.Clear();
            Console.WriteLine("Matriz suma:");
            for (int i = 0; i < matrizSuma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++)
                {
                    Console.Write($"| {matrizSuma[i, j]} |");
                }
                Console.WriteLine();
            }
        }
    }
}
