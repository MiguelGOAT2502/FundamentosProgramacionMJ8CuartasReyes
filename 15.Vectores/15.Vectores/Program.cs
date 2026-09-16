using System;


namespace _15.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Llene un arreglo con 15 números ingresados por teclado. Una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo. Finalmente, determine cuál es el número mayor y cuál es el número menor, junto con la posición que ocupa cada uno dentro del arreglo. 
            int[] numeros = new int[15];
            Console.WriteLine("ingrese 15 números:");
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los números ingresados son:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} ");
            }

            int mayor = numeros[0];
            int menor = numeros[0];
            int posMayor = 0;
            int posMenor = 0;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posMayor = i;
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posMenor = i;
                }
            }

            Console.WriteLine($"\nEl número mayor es {mayor} y está en la posición {posMayor}");
            Console.WriteLine($"El número menor es {menor} y está en la posición {posMenor}");
        }
    }
}
