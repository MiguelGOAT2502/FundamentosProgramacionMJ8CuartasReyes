using System;
using System.Security.Cryptography;


namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Una institución educativa requiere un programa para procesar el rendimiento académico de los 25 estudiantes del curso de Ciencias Naturales. Por cada estudiante se debe calcular su nota definitiva y determinar si aprobó o reprobó. Utilizando obligatoriamente una estructura repetitiva, el programa debe: Solicitar por teclado las tres calificaciones del período(Examen 1, Examen 2 y Trabajo de Investigación) para cada uno de los 25 estudiantes.Cada nota debe estar entre 0.0 y 5.0. Calcular el promedio de las tres notas y mostrar en pantalla si el estudiante Aprobó(promedio >= 3.5) o Reprobó. Al finalizar el procesamiento de todo el curso, el programa debe mostrar un resumen estadístico que incluya: La cantidad total de estudiantes que aprobaron. La cantidad total de estudiantes que reprobaron. El promedio general de todo el curso (el promedio de los promedios de los 25 estudiantes).

            double examen1;
            double examen2;
            double trabajoInvestigacion;
            double promedio;
            int aprobados = 0;
            int reprobados = 0;
            double sumaPromedios = 0;

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine($"Ingrese las calificaciones del estudiante {i}:");

                do
                {
                    Console.Write("Examen 1 (0.0 - 5.0): ");
                    examen1 = Convert.ToDouble(Console.ReadLine());
                } while (examen1 < 0.0 || examen1 > 5.0);

                do
                {
                    Console.Write("Examen 2 (0.0 - 5.0): ");
                    examen2 = Convert.ToDouble(Console.ReadLine());
                } while (examen2 < 0.0 || examen2 > 5.0);

                do
                {
                    Console.Write("Trabajo de Investigación (0.0 - 5.0): ");
                    trabajoInvestigacion = Convert.ToDouble(Console.ReadLine());
                } while (trabajoInvestigacion < 0.0 || trabajoInvestigacion > 5.0);

                promedio = (examen1 + examen2 + trabajoInvestigacion) / 3;

                if (promedio >= 3.5)
                {
                    Console.WriteLine($"El estudiante {i} aprobó con un promedio de {promedio:F2}.");
                    aprobados++;
                    sumaPromedios += promedio;
                }
                else
                {
                    Console.WriteLine($"El estudiante {i} reprobó con un promedio de {promedio:F2}.");
                    sumaPromedios += promedio;
                    reprobados++;
                }
            }
            Console.WriteLine("Resumen estadístico del curso:");
            Console.WriteLine($"Cantidad de estudiantes que aprobaron: {aprobados}");
            Console.WriteLine($"Cantidad de estudiantes que reprobaron: {reprobados}");
            Console.WriteLine("Promedio general del curso: " + (sumaPromedios / 25).ToString("F2"));
        }
    }
}
