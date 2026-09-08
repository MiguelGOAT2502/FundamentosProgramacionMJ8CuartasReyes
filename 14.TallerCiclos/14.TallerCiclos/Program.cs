using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;


namespace _14.TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo  le permitirá al usuario, introducir tantas calificaciones como así desee, en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente. 

            /*float calificacion = 0;
            float suma = 0;
            int continuar = 1;
            int numContador = 0;

            do 
            {
                Console.WriteLine("Ingrese una calificación: ");
                calificacion = float.Parse(Console.ReadLine());
                suma += calificacion;
                numContador++;
                Console.WriteLine("¿Desea continuar capturando calificaciones? (1 = Sí, cualquier otro valor = No): ");
                continuar = int.Parse(Console.ReadLine());
            } while (continuar == 1) ;

            double promedioFinal = suma / numContador;
            Console.WriteLine("El promedio de las calificaciones es: " +  promedioFinal);*/


            // 2. Se requiere un algoritmo para mostrar por pantalla los divisores de un  número ingresado por teclado. Tener en cuenta que dados dos números enteros a y b, se dice que b es divisor de a si se cumple que al efectuar una división entera a/ b el residuo es 0, en C# utilizar el operador Mod para obtener el residuo de una división de dos números. Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 2, 1 que son los divisores del número 6.

            /*int numero = 0;

            Console.WriteLine("Ingrese un número entero para ver sus divisores: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            // 3.  Dados dos números enteros ingresados por teclado: b que es la base y e que es el exponente, se requiere calcular el resultado de la potenciación. Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32 Mostrar por pantalla el resultado de la potenciación.  Seguir pidiendo por teclado la base y el exponente y realizar la potenciación correspondiente, hasta que el usuario ingrese por teclado el carácter de escape ‘n’ 
            /*
                        int baseNum = 0;
                        int exponente = 0;
                        string escape = "n";

                        do
                        {
                            Console.WriteLine("Ingrese la base: ");
                            baseNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el exponente: ");
                            exponente = int.Parse(Console.ReadLine());
                            int resultado = 1;
                            for (int i = 0; i < exponente; i++)
                            {
                                resultado *= baseNum;
                            }
                            Console.WriteLine("El resultado de la potenciación es: " + resultado);
                            Console.WriteLine("¿Desea continuar? (Ingrese 'n' para salir, cualquier otra tecla para continuar): ");
                            escape = Console.ReadLine();
                        } while (escape != "n");*/

            // 4.  Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco kilómetros durante 10 días, para determinar si es apto para la prueba de 5 kilómetros.Para considerarlo apto debe cumplir las siguientes condiciones: Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos, Que al menos en una de las pruebas realice un tiempo menor de 15 minutos, Que su promedio sea menor o igual a 18 minutos. Diseñar un algoritmo para registrar los datos y decidir si es apto para la competencia.

            int tiempo = 0;
            int sumaTiempos = 0;
            int contador = 0;


            for (int dias = 1; dias <= 10; dias++)
            {
                Console.WriteLine("Ingrese el tiempo para el día {0}: ", dias);
                tiempo = int.Parse(Console.ReadLine());
                sumaTiempos += tiempo;
                contador++;
            }

            double promedio = sumaTiempos / contador;

            if (tiempo <= 20 && tiempo < 15 && promedio <= 18)
            {
                Console.WriteLine("El atleta es apto para la competencia.");
            }
            else
            {
                Console.WriteLine("El atleta no es apto para la competencia.");
            }
        }
    }
}
