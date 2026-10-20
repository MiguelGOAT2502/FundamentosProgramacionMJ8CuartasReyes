using System;

namespace TrabajoFinal
{
    internal class Program
    {
        public class Alumno
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string ID { get; set; }
            public string Correo { get; set; }
            public string Carrera { get; set; }

            public Alumno(string nombre, int edad, string id,
                          string correo, string carrera)
            {
                Nombre = nombre;
                Edad = edad;
                ID = id;
                Correo = correo;
                Carrera = carrera;
            }
        }

        
        static Alumno[] alumnos = new Alumno[100];
        static int cantidadAlumnos = 0;

        static void Main(string[] args)
        {
            GestionAlumnos();
        }

        static void GestionAlumnos()
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("\n========== GESTION DE ALUMNOS ==========");
                Console.WriteLine("1. Crear un alumno");
                Console.WriteLine("2. Ver lista de todos los alumnos");
                Console.WriteLine("3. Editar informacion de un alumno");
                Console.WriteLine("4. Salir de Gestion de alumnos");
                Console.Write("Ingrese una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese una opcion numerica valida.");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CrearAlumno();
                        break;

                    case 2:
                        VerAlumnos();
                        break;

                    case 3:
                        EditarAlumno();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo de gestion de alumnos...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        Console.ReadKey();
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione una tecla para volver al menu...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

        static void CrearAlumno()
        {
            if (cantidadAlumnos >= alumnos.Length)
            {
                Console.WriteLine("No se pueden registrar mas alumnos.");
                return;
            }

            Console.WriteLine("\n========== CREAR ALUMNO ==========");

            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad del alumno: ");
            if (!int.TryParse(Console.ReadLine(), out int edad) || edad <= 0)
            {
                Console.WriteLine("La edad ingresada no es valida.");
                return;
            }

            Console.Write("Ingrese el ID del alumno: ");
            string id = Console.ReadLine();

            Console.Write("Ingrese la carrera del alumno: ");
            string carrera = Console.ReadLine();

            Console.Write("Ingrese el correo del alumno: ");
            string correo = Console.ReadLine();

            // Evitar IDs duplicados
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                if (alumnos[i].ID == id)
                {
                    Console.WriteLine("Ya existe un alumno con ese ID.");
                    return;
                }
            }

            Alumno alumno = new Alumno(nombre, edad, id, correo, carrera);

            alumnos[cantidadAlumnos] = alumno;
            cantidadAlumnos++;

            Console.WriteLine($"Alumno {alumno.Nombre} creado exitosamente.");
        }

        static void VerAlumnos()
        {
            Console.WriteLine("\n========== LISTA DE ALUMNOS ==========");

            if (cantidadAlumnos == 0)
            {
                Console.WriteLine("No hay alumnos registrados.");
                return;
            }

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine($"\nAlumno #{i + 1}");
                Console.WriteLine($"Nombre: {alumnos[i].Nombre}");
                Console.WriteLine($"Edad: {alumnos[i].Edad}");
                Console.WriteLine($"ID: {alumnos[i].ID}");
                Console.WriteLine($"Carrera: {alumnos[i].Carrera}");
                Console.WriteLine($"Correo: {alumnos[i].Correo}");
            }
        }

        static void EditarAlumno()
        {
            Console.Clear();

            Console.WriteLine("========== EDITAR ALUMNO ==========");

            if (cantidadAlumnos == 0)
            {
                Console.WriteLine("No hay alumnos para editar.");
                return;
            }

            Console.Write("Ingrese el ID del alumno que desea editar: ");
            string idBuscado = Console.ReadLine();

            int posicion = -1;

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                if (alumnos[i].ID == idBuscado)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion == -1)
            {
                Console.WriteLine("No se encontro un alumno con ese ID.");
                return;
            }

            Alumno alumno = alumnos[posicion];
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("========== EDITAR ALUMNO ==========");
                Console.WriteLine($"Alumno: {alumno.Nombre}");
                Console.WriteLine($"ID: {alumno.ID}");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Cambiar nombre");
                Console.WriteLine("2. Cambiar edad");
                Console.WriteLine("3. Cambiar carrera");
                Console.WriteLine("4. Cambiar correo");
                Console.WriteLine("5. Volver al menu principal");
                Console.Write("Que dato desea modificar?: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese una opcion valida.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nuevo nombre: ");
                        string nombre = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nombre))
                        {
                            alumno.Nombre = nombre;
                            Console.WriteLine("Nombre actualizado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("El nombre no puede estar vacio.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese la nueva edad: ");

                        if (int.TryParse(Console.ReadLine(), out int edad) && edad > 0)
                        {
                            alumno.Edad = edad;
                            Console.WriteLine("Edad actualizada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("La edad ingresada no es valida.");
                        }
                        break;

                    case 3:
                        Console.Write("Ingrese la nueva carrera: ");
                        string carrera = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(carrera))
                        {
                            alumno.Carrera = carrera;
                            Console.WriteLine("Carrera actualizada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("La carrera no puede estar vacia.");
                        }
                        break;

                    case 4:
                        Console.Write("Ingrese el nuevo correo: ");
                        string correo = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(correo))
                        {
                            alumno.Correo = correo;
                            Console.WriteLine("Correo actualizado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("El correo no puede estar vacio.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Volviendo al menu principal...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }
}

