using Microsoft.Win32;
using System;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Security.Policy;
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

            /*int tiempo = 0;
            int sumaTiempos = 0;
            int contador = 0;
            bool menor15 = false;
            bool noMayor20 = true;


            for (int dias = 1; dias <= 10; dias++)
            {
                Console.WriteLine("Ingrese el tiempo para el día {0}: ", dias);
                tiempo = int.Parse(Console.ReadLine());
                sumaTiempos += tiempo;
                contador++;

                if (tiempo < 15)
                {
                    menor15 = true;
                }
                if (tiempo > 20)
                {
                    noMayor20 = false;
                }
            }

            double promedio = (double)sumaTiempos / contador;

            if (noMayor20 && menor15 && promedio <= 18)
            {
                Console.WriteLine("El atleta es apto para la competencia.");
            }
            else
            {
                Console.WriteLine("El atleta no es apto para la competencia.");
            }*/

            //5. Se aplicó una encuesta a n personas solicitando su opinión sobre el tema del servicio militar obligatorio para las mujeres. Las opciones de  respuesta fueron: a favor, en contra y no responde. Se solicita un algoritmo que calcule qué porcentaje de los encuestados marcó cada una de las respuestas

            /* int totalEncuestados = 0;
             int favor = 0;
             int contra = 0;
             int noResponde = 0;

             Console.WriteLine("Ingrese el número total de encuestados: ");
             totalEncuestados = int.Parse(Console.ReadLine());

             for (int i = 0; i < totalEncuestados; i++)
             {
                 Console.WriteLine("Ingrese la respuesta para la persona {0} (a favor: 1, en contra: 2, no responde: 3): ", i + 1);
                 int respuesta = int.Parse(Console.ReadLine());

                 if (respuesta == 1) favor++;
                 else if (respuesta == 2) contra++;
                 else if (respuesta == 3) noResponde++;
                 else Console.WriteLine("Respuesta inválida, no se contará.");
             }

             double porcentajeFavor = (double)favor / totalEncuestados * 100;
             double porcentajeContra = (double)contra / totalEncuestados * 100;
             double porcentajeNoResponde = (double)noResponde / totalEncuestados * 100;

             Console.WriteLine("Porcentaje a favor: " + porcentajeFavor + "%");
             Console.WriteLine("Porcentaje en contra: " + porcentajeContra + "%");
             Console.WriteLine("Porcentaje no responde: " + porcentajeNoResponde + "%");
 */


            //6. Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos de esos números son positivos, cuántos negativos, cuántos son neutros (0); además que imprima por pantalla la sumatoria de los números positivos y la de los negativos. 
            /* int positivos = 0;
             int negativos = 0;
             int neutros = 0;
             Random rnd = new Random();

             for (int i = 1; i <= 40; i++)
             {
                 int numero = rnd.Next(-50, 51);
                 Console.WriteLine("Número {0}: {1}", i, numero);

                 if (numero > 0)
                 {
                     positivos++;
                 }
                 else if (numero < 0)
                 {
                     negativos++;
                 }
                 else
                 {
                     neutros++;
                 }
             }

             Console.WriteLine("Números positivos: {0}", positivos);
             Console.WriteLine("Números negativos: {0}", negativos);
             Console.WriteLine("Números neutros: {0}", neutros);*/

            //7.  Una persona desea realizar un muestreo con 70 personas para determinar el promedio de peso de los niños, jóvenes, adultos y viejos que existen en su zona y cuántos son de cada una de las categorías.  Las categorías están dadas por la siguiente tabla:  Niños: 0 - 13  Jóvenes: 14 - 30  Adultos: 31 - 60   Viejos 61 en adelante

            int niños = 0; double pesoNiños = 0;
            int jóvenes = 0; double pesoJóvenes = 0;
            int adultos = 0; double pesoAdultos = 0;
            int viejos = 0; double pesoViejos = 0;



            /* for (int i = 0; i <= 69; i++)
             {
                 Console.WriteLine("Ingrese la edad de la persona {0}: ", i + 1);
                 int edad = int.Parse(Console.ReadLine());

                 Console.WriteLine("ingrese el peso de la persona {0}: ", i + 1);
                 int peso = int.Parse(Console.ReadLine());

                 if (edad >= 0 && edad <= 13)
                 {
                     niños++;
                     pesoNiños += peso;
                 }
                 else if (edad >= 14 && edad <= 30)
                 {
                     jóvenes++;
                     pesoJóvenes += peso;
                 }
                 else if (edad >= 31 && edad <= 60)
                 {
                     adultos++;
                     pesoAdultos += peso;
                 }
                 else
                 {
                     viejos++;
                     pesoViejos += peso;
                 }
             }

             Console.WriteLine("Niños: {0}, Peso promedio: {1}", niños, niños > 0 ? pesoNiños / niños : 0);
             Console.WriteLine("Jóvenes: {0}, Peso promedio: {1}", jóvenes, jóvenes > 0 ? pesoJóvenes / jóvenes : 0);
             Console.WriteLine("Adultos: {0}, Peso promedio: {1}", adultos, adultos > 0 ? pesoAdultos / adultos : 0);
             Console.WriteLine("Viejos: {0}, Peso promedio: {1}", viejos, viejos > 0 ? pesoViejos / viejos : 0);
         }*/

            //8. El Departamento de Transito de Antioquia. desea saber de los n autos que entran a la ciudad de Medellín, cuántos autos entran con calcomanía de un determinado color.Conociendo el último dígito de la placa de cada automóvil se puede determinar el color de la calcomanía, para determinar lo anterior utilice la siguiente tabla: DÍGITO COLOR 1 o 2 amarilla  3 o 4 rosa  5 o 6 roja  7 o 8 verde  9 o 0 azul

            int placa = 0;
            int amarilla = 0;
            int rosa = 0;
            int roja = 0;
            int verde = 0;
            int azul = 0;
            int autos = 0;

            Console.WriteLine("Ingrese la cantidad de autos que entran a la ciudad: ");
            autos = int.Parse(Console.ReadLine());

            for (int i = 0; i < autos; i++)
            {
                Console.WriteLine("Ingrese el último dígito de la placa del auto {0}: ", i + 1);
                placa = int.Parse(Console.ReadLine());

                if (placa == 1 || placa == 2)
                {
                    amarilla++;
                }
                else if (placa == 3 || placa == 4)
                {
                    rosa++;
                }
                else if (placa == 5 || placa == 6)
                {
                    roja++;
                }
                else if (placa == 7 || placa == 8)
                {
                    verde++;
                }
                else if (placa == 9 || placa == 0)
                {
                    azul++;
                }
            }
            Console.WriteLine("Cantidad de autos con calcomanía amarilla: " + amarilla);
            Console.WriteLine("Cantidad de autos con calcomanía rosa: " + rosa);
            Console.WriteLine("Cantidad de autos con calcomanía roja: " + roja);
            Console.WriteLine("Cantidad de autos con calcomanía verde: " + verde);
            Console.WriteLine("Cantidad de autos con calcomanía azul: " + azul);
        }
    }
}


