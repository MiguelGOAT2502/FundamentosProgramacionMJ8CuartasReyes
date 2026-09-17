using System;
using System.Security.Cryptography;


namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego encuentre y muestre el valor máximo y mínimo de los números ingresados.

            /* int[] vector = new int[15];

             for(int i = 0; i < vector.Length; i++) {
                 Console.Write("Ingrese el numero del espacio " + (i + 1) + ": ");
                 vector[i] = int.Parse(Console.ReadLine());
             }

             int max = vector[0];
             int min = vector[0];

             for(int i = 1; i < vector.Length; i++) {
                 if(vector[i] > max) {
                     max = vector[i];
                 }
                 if(vector[i] < min) {
                     min = vector[i];
                 }
             }

             Console.WriteLine($"El valor máximo es: {max}");
             Console.WriteLine($"El valor mínimo es: {min}");*/

            //2. Escribir un algoritmo que permita: 1.Crear dos vectores del mismo tamaño.  2.Llenarlos con números. 3.Comparar posición por posición. 4.Indicar cuántos elementos son iguales

            /* int[] vector1 = new int[5];
             int[] vector2 = new int[5];

             for (int i = 0; i < 5; i++)
             {
                 Console.Write("Ingrese el numero del espacio " + (i + 1) + " del primer vector: ");
                 vector1[i] = int.Parse(Console.ReadLine());
             }

             Console.WriteLine("Ingrese los elementos del segundo vector:");
             for (int i = 0; i < 5; i++)
             {
                 Console.Write("Ingrese el numero del espacio " + (i + 1) + " del segundo vector: ");
                 vector2[i] = int.Parse(Console.ReadLine());
             }

             int iguales = 0;
             for (int i = 0; i < 5; i++)
             {
                 if (vector1[i] == vector2[i])
                 {
                     iguales++;
                 }
             }

             Console.WriteLine($"Número de elementos iguales: {iguales}");*/

            //3. . Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el orden de los elementos del vector. Se deben mostrar lo dos vectores. 
            /*
                        char[] vector = new char[5];

                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.Write("Ingrese el carácter del espacio " + (i + 1) + ": ");
                            vector[i] = char.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Vector original:");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.Write(vector[i] + "");
                        }

                        Console.WriteLine("\nVector invertido:");
                        for (int i = vector.Length - 1; i >= 0; i--)
                        {
                            Console.Write(vector[i] + "");
                        }*/

            //4. Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre  0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el vector resaltando el número en un color diferente.Si no se encuentra el número, se debe devolver y mostrar - 1.

            /* int[] vector = new int[20];
             int numeroBuscado;
             Random rand = new Random();

             for (int i = 0; i < vector.Length; i++)
             {
                 vector[i] = rand.Next(0, 51);
             }

             Console.WriteLine("ingrese un número para buscar en el vector: ");
             numeroBuscado = int.Parse(Console.ReadLine());

             for (int i = 0; i < vector.Length; i++)
             {
                 if (vector[i] == numeroBuscado)
                 {
                     Console.WriteLine($"Número encontrado en la posición: {i+1}");
                     Console.WriteLine("Vector con el número resaltado:");
                     for (int j = 0; j < vector.Length; j++)
                     {
                         if (j == i)
                         {
                             Console.ForegroundColor = ConsoleColor.Green;
                             Console.Write(vector[j] + " ");
                             Console.ResetColor();
                         }
                         else
                         {
                             Console.Write(vector[j] + " ");
                         }
                     }
                     return;
                 }
             }

             Console.WriteLine("-1");*/

            //5. Escribir un algoritmo que permita:   a.Crear un vector con rango impar, exceptuando el 1.  b.Pedirle al usuario un número entero y almacenarlo en la mitad del vector.  c.Llenar la primera mitad del vector, con los números menores al número almacenado en la posición de la mitad.  d.Llenar la parte inicial del vector, con los números menores al número almacenado en la posición de la mitad.  e.Llenar la parte final del vector, con los números mayores al número almacenado en la posición de la mitad.  f.Mostrar el vector en pantalla.

            int[] vector = new int[7]; 
            Random random = new Random();

            Console.WriteLine("ingrese un número entero para almacenar en la mitad del vector: ");
            vector[3] = int.Parse(Console.ReadLine());
            for(int i = 0; i < vector.Length; i++)
            {
                if (i < 3)
                {
                    vector[i] = random.Next(0, vector[3]);
                }
                else if (i > 3)
                {
                    vector[i] = random.Next(vector[3], 100);
                }
            }
            Console.WriteLine("Vector resultante:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }
    }
}

