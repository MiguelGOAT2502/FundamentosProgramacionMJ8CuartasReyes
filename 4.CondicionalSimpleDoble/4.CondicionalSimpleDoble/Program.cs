using System;


namespace _4.CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Estructura de control Condicional
            //Simple
            //1.  Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web"
            /*  byte edad = 0;
              Console.WriteLine("Ingrese su edad: ");
              edad = Convert.ToByte( Console.ReadLine() );
              if (edad >= 18)
              {
                  //si la condicion es verdadera
                  Console.WriteLine("Biewnvenido a mi sitio web");
              }
              else
              {
                  Console.WriteLine("VETE DE MI SITIO WEB");
              }*/

            //2. Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.

            string nombre = "miguel";
            float sueldo = 0.0f;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su sueldo");
            sueldo = float.Parse(Console.ReadLine());
            if (sueldo > 3000)
            {
                    Console.WriteLine(nombre + " abona, firmes por la patria, ponle la raya al tigre");
            }
            else 
            {
                Console.WriteLine(nombre + " maldito pobre, petrista tenias que ser");
            }

        }
    }
}
