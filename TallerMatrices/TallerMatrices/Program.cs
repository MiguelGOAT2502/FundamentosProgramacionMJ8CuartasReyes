using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //1.  Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por las filas y la suma de los elementos de cada columna.
             int[,] matriz = new int[10, 20];
             int[] sumaColumnas = new int[20];


             Random rand = new Random();
             for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 20; j++)
                 {
                     matriz[i, j] = rand.Next(1, 101);
                 }
             }


             for (int j = 0; j < 20; j++)
             {
                 sumaColumnas[j] = 0;
                 for (int i = 0; i < 10; i++)
                 {
                     sumaColumnas[j] += matriz[i, j];
                 }
             }

             Console.WriteLine("Matriz generada:");
             for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 20; j++)
                 {
                     Console.Write($"{matriz[i, j],4} ");
                 }
                 Console.WriteLine();
             }

             Console.WriteLine("Suma de los elementos de cada columna:");
             for (int j = 0; j < 20; j++)
             {
                 Console.Write($"Columna {j + 1}: {sumaColumnas[j]} ");
             }*/

            /* //2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla.El programa debe intercambiar la primera fila con la última fila de la matriz.Al final se debe imprimir la matriz original, y la matriz con el intercambio de filas. 

             int n = 0;
             int m = 0;
             Console.WriteLine("Ingrese el número de filas (n):");
             n = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el número de columnas (m):");
             m = int.Parse(Console.ReadLine());
             int[,] matriz = new int[n, m];

             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     Console.WriteLine($"Ingrese el carácter para la posición [{i}, {j}]:");
                     matriz[i, j] = Console.Read();
                     Console.ReadLine();
                 }
             }

             Console.WriteLine("Matriz original:");
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     Console.Write($"{(char)matriz[i, j],4} ");
                 }
                 Console.WriteLine();
             }

             for (int j = 0; j < m; j++)
             {
                 int temp = matriz[0, j];
                 matriz[0, j] = matriz[n - 1, j];
                 matriz[n - 1, j] = temp;
             }

             Console.WriteLine("Matriz con el intercambio de filas:");
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     Console.Write($"{(char)matriz[i, j],4} ");
                 }
                 Console.WriteLine();
             }*/

            /* // 3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 5x5 llena de números aleatorios. El algoritmo debe permitir: 1. Usa la función Random para generar los números aleatorios. 2. Crea un arreglo adicional para almacenar la frecuencia de cada número. 3. Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número.
             int[,] matriz = new int[5, 5];
             int[] frecuencia = new int[11]; 

             Random rand = new Random();
             for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j < 5; j++)
                 {
                     matriz[i, j] = rand.Next(1, 11);
                 }
             }

             for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j < 5; j++)
                 {
                     frecuencia[matriz[i, j]]++;
                 }
             }

             Console.WriteLine("Matriz generada:");
             for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j < 5; j++)
                 {
                     Console.Write($"{matriz[i, j],4} ");
                 }
                 Console.WriteLine();
             }

             Console.WriteLine("Frecuencia de cada número:");
             for (int k = 1; k <= 10; k++)
             {
                 Console.Write($"Número {k}: {frecuencia[k]} ");
             }*/

           /* //4. Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la posición de una "X". El algoritmo debe permitir: 1.Usar la función Random para colocar las "X" en la matriz. 2. Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado. 3.Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz. 

            char[,] tablero = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablero[i, j] = '-';
                }
            }

            // Colocar 3 "X" en posiciones aleatorias
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                int fila = rand.Next(0, 5);
                int columna = rand.Next(0, 5);
                if (tablero[fila, columna] != 'X')
                {
                    tablero[fila, columna] = 'X';
                }
                else
                {
                    i--;
                }
            }

            Console.WriteLine("ingresa las coordenadas de la primera X (fila y columna) entre 0 y 4:");
            int filaUsuario = int.Parse(Console.ReadLine());
            int columnaUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa las coordenadas de la segunda X (fila y columna) entre 0 y 4:");
            int filaUsuario2 = int.Parse(Console.ReadLine());
            int columnaUsuario2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa las coordenasdas de la tercera X (fila y columna) entre 0 y 4:");
            int filaUsuario3 = int.Parse(Console.ReadLine());
            int columnaUsuario3 = int.Parse(Console.ReadLine());

            // Verificar si el usuario acertó
            bool acierto1 = tablero[filaUsuario, columnaUsuario] == 'X';
            bool acierto2 = tablero[filaUsuario2, columnaUsuario2] == 'X';
            bool acierto3 = tablero[filaUsuario3, columnaUsuario3] == 'X';

            // Mostrar mensaje de éxito o error, diciendo las coordenas de la x que encontraste
            if (acierto1 || acierto2 || acierto3)
            {
                Console.WriteLine("¡Felicidades! Has acertado una posición de la 'X'.");
                if (acierto1)
                {
                    Console.WriteLine($"La 'X' estaba en la posición: ({filaUsuario}, {columnaUsuario})");

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write($"{tablero[i, j],4} ");
                        }
                        Console.WriteLine();
                    }
                }
                if (acierto2)
                {
                    Console.WriteLine($"La 'X' estaba en la posición: ({filaUsuario2}, {columnaUsuario2})");

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write($"{tablero[i, j],4} ");
                        }
                        Console.WriteLine();
                    }
                }
                if (acierto3)
                {
                    Console.WriteLine($"La 'X' estaba en la posición: ({filaUsuario3}, {columnaUsuario3})");

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write($"{tablero[i, j],4} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Lo siento, no acertaste ninguna posición de la 'X'. Aquí está el tablero:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write($"{tablero[i, j],4} ");
                    }
                    Console.WriteLine();
                }


            }*/

            /*// 5. Desarrollar un programa que:  1. Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz de enteros. 2.Cargue los datos de la matriz ingresándolos por teclado. 3. Muestre la matriz ingresada Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser ahora la columna 1. 4. Mostrar la nueva matriz.

            Console.WriteLine("Ingrese el número de filas:");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = int.Parse(Console.ReadLine());

            
            int[,] matriz = new int[filas, columnas];
            Console.WriteLine("Ingrese los datos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("Matriz ingresada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j],4} ");
                }
                Console.WriteLine();
            }

            
            int[,] nuevaMatriz = new int[columnas, filas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    nuevaMatriz[j, i] = matriz[i, j];
                }
            }

            
            Console.WriteLine("Nueva matriz (filas convertidas en columnas):");
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.Write($"{nuevaMatriz[i, j],4} ");
                }
                Console.WriteLine();
            }*/

            //6. Crear una aplicación en C# que permita realizar las siguientes acciones: 1. Crear una matriz de n filas por m columnas Llenar la matriz con números aleatorios del 1 al 3(investigar la función random en C#)   2.Mostrar la matriz generada  3.Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el número 3, y cuál de los tres números fue repetido más veces.
            int n;
            int m;

            Console.WriteLine("Ingrese el número de filas:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas:");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Matriz generada:");
            Random ran = new Random();
            int[,] matriz = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = ran.Next(1, 4);
                }
            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j],4} ");
                }
                Console.WriteLine();
            }

            
            int count1 = 0, count2 = 0, count3 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    switch (matriz[i, j])
                    {
                        case 1:
                            count1++;
                            break;
                        case 2:
                            count2++;
                            break;
                        case 3:
                            count3++;
                            break;
                    }
                }
            }

            
            Console.WriteLine($"Número 1 repetido {count1} veces.");
            Console.WriteLine($"Número 2 repetido {count2} veces.");
            Console.WriteLine($"Número 3 repetido {count3} veces.");

            if (count1 >= count2 && count1 >= count3)
                Console.WriteLine("El número 1 fue repetido más veces.");
            else if (count2 >= count1 && count2 >= count3)
                Console.WriteLine("El número 2 fue repetido más veces.");
            else
                Console.WriteLine("El número 3 fue repetido más veces.");
        }


    }
}
