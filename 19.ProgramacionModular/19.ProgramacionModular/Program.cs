using System;
using System.Data.SqlTypes;

namespace _19.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }

        static void RealizarOperaciones(int opcion)
        {

            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"la SUMA de los numeros ingresados es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"la RESTA de los numeros ingresados es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"la MULTIPLICACIÓN de los numeros ingresados es: {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"La DIVISIÓN de los numeros ingresados es: {Division()}");
                        break;
                    case 0:
                        Console.WriteLine("Salir");
                        break;

                }
            }
            Console.ReadKey();
            Console.Clear();
            MostrarMenu();
            opcion = CapturarOpcion();
        }

        static float Suma() 
        { 
            float suma = 0;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("ingrese un numero");
                numero=float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea ingresar otro numero? (s: continuar)");
                respuesta=char.Parse(Console.ReadLine());
            } while (respuesta=='s');
            return suma;
        }

        static float Resta()
        {
            Console.WriteLine("Ingrese el numero1:");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero2:");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 - numero2;
        }

        static float Multiplicacion()
        {
            float multiplicacion = 1;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea seguir multiplicando? (s: continuar)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicacion;
        }

        static float Division()
        {
            Console.WriteLine("Ingrese el numero1:");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero2:");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 / numero2;
        }


        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }


            static void MostrarMenu()
            {
                Console.WriteLine("-------------MENU-------------");
                Console.WriteLine("1. Suma           2. Resta");
                Console.WriteLine("3. Multiplicación 4. División");
                Console.WriteLine("0. salir");

            }
        }
    }

