using System;
using System.Runtime.CompilerServices;


namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Algoritmo que le pida a un grupo de usuarios, numero de cuenta y saldo; para cada usuario debe hacer lo siguiente: 1. si el saldo es mayor a 3.000.000, sacar un mensaje que diga el nombre del usuario, el numero de cuenta, el saldo y "es apto para el credito"    2. si el saldo es menor a 3.000.000, sacar un mensaje que diga el nombre del usuario, el numero de cuenta, el saldo y "no es apto para el credito#". El algoritmo debe permitir preguntar la informacion de usuarios, hasta que se le indique que ya no se desea preguntar mas.   Ademas, el algoritmo debe permitir mostrar el numero de usuarios a los que se le pregunto por la informacion, y debe mostar el promedio de los saldo.
            int usuarios = 0;
            string nombre;
            int numeroCuenta = 0;
            int saldo = 0;
            int seleccion = 0;
            int sumaSaldo = 0;
            float promedio = 0.0f;

            do
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su numero de cuenta: ");
                numeroCuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese su saldo: ");
                saldo = int.Parse(Console.ReadLine());

                if (saldo >= 3000000)
                {
                    Console.WriteLine($"Nombre de usuario: {nombre}, numero de cuenta: {numeroCuenta}, Saldo: {saldo}. Eres apto para el credito.");
                }
                else
                {
                    Console.WriteLine($"Nombre de usuario: {nombre}, numero de cuenta: {numeroCuenta}, Saldo: {saldo}. No eres apto para el credito."); 
                }

                Console.WriteLine("¿Quieres ingresar otro usuario? (1) para si, cualquier otro numetro para no.");
                seleccion = int.Parse(Console.ReadLine());

                sumaSaldo += saldo;

                usuarios++;

                promedio = sumaSaldo / usuarios;

            } while (seleccion == 1);

            Console.WriteLine($" se le pregunto a {usuarios} usuarios, el promedio de los saldos es: {promedio} ");

           
            

        }
    }
}
