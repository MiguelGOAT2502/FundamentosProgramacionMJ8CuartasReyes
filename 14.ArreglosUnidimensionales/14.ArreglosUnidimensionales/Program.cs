using System;

namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*//Arreglos Unidimensionales o vector
            int[] numeros = new int[5];
            numeros[0] = 15;
            numeros[1] = 56;
            numeros[2] = 20;
            numeros[3] = 47;
            numeros[4] = 27;
            //numeros[5] = 100; No es posible porque la posicion 6 con indice 5 no existe
            Console.WriteLine($"El dato almacenado en la posicion 4 con indice 3 es: {numeros[3]}");

            float[] notas = new float[3];
            notas[0] = 3.6f;
            notas[1] = 4.3f;
            notas[2] = 5.0f;
            //Otras formas de declarar e iniciaizar
            char[] simbolos = new char[] { '?', '(', '5', 'f' };
            bool[] valoresVerdad = { true, false, true, true, false };

            //recorrer un vector para llenarlo de datos
            string[] nombres = new string[7];

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"ingrese el nombre para las P{i + 1}:I{i}");
                nombres[i] = Console.ReadLine();
            }

            //Recorrer el vector para recuperar los datos almacenados en el vector
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($" {nombres[i]} |");
            }*/

            //Crear arreglo llamado "enteros" de 100 elementos asignar el numero 10 en cada una de las posicones del arreglo. Leer el contenido de cada elemento y mostrarlo en pantalla.

            int[] enteros = new int[100];

            for (int i = 0;i < 100; i++)
            {
                enteros[i] = 10;
            }

            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine($"El valor del elemento {i} es: {enteros[i]}");
            }

        }
    }
}
