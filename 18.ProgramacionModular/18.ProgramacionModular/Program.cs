using System;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static int AñoActual = 2026;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de fundamentos de programación");
            MostrarMensaje("Miguel");
            Console.WriteLine($"Miguel tiene {CalcularEdad()} años");
            MostrarMensaje("Luis");
            int añoNacimiento = 2008;
            Console.WriteLine($"Luis tiene {CalcularEdad(añoNacimiento, AñoActual)} años");
            MostrarMensaje("Miguel", "Cuartas Reyes");
            Console.ReadKey();
            BorrarPantalla();
        }


        //funciones con parametros
        static int CalcularEdad(int añoNacimiento, int añoActual)
        {
            return añoActual - añoNacimiento;
        }
        //Funciones sin parametros
        static int CalcularEdad()
        {
            int añoNacimiento = 2008;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        } 
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso Fundamentos de programacion");
        }

        static void MostrarMensaje(String nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso Fundamentos de programacion");
        }
    }
}
