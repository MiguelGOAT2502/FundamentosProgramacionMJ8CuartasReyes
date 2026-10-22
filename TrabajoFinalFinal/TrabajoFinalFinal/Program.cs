
using System;

namespace TrabajoFinalFinal
{
    internal class Program
    {

        static string[] nombresAlumnos = new string[100];
        static int[] edadesAlumnos = new int[100];
        static string[] idsAlumnos = new string[100];
        static string[] correosAlumnos = new string[100];
        static string[] carrerasAlumnos = new string[100];
        static int cantidadAlumnos = 0;

        static int[] idsCursos = new int[10];
        static string[] nombresCursos = new string[10];
        static string[] descripcionesCursos = new string[10];
        static string[] horariosCursos = new string[10];

        static string[,] alumnosPorCurso = new string[10, 15];
        static int[] cantidadPorCurso = new int[10];
        static int cantidadCursos = 0;
        static double[,] notasCursos = new double[10, 15];

        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        // MENU PRINCIPAL
        static void MenuPrincipal()
        {
            int opcion = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("========== MENU PRINCIPAL ==========");
                Console.WriteLine("1. Gestion de alumnos");
                Console.WriteLine("2. Gestion de cursos");
                Console.WriteLine("3. Gestion de notas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese una opcion numerica valida.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        GestionAlumnos();
                        break;

                    case 2:
                        GestionCursos();
                        break;

                    case 3:
                        GestionNotas();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 4);
        }

        // GESTION DE ALUMNOS
        static void GestionAlumnos()
        {
            // Vectores locales estaticos que conservan sus datos
            // mientras el programa se encuentra ejecutandose.
            int opcion = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("========== GESTION DE ALUMNOS ==========");
                Console.WriteLine("1. Crear alumno");
                Console.WriteLine("2. Ver lista de alumnos");
                Console.WriteLine("3. Editar informacion de un alumno");
                Console.WriteLine("4. Regresar al menu principal");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese una opcion numerica valida.");
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
                        Console.WriteLine("Regresando al menu principal...");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        Console.ReadKey();
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

        // CREAR ALUMNO
        static void CrearAlumno()
        {
            // Los datos se almacenan en vectores compartidos
            // mediante variables static declaradas en este metodo.
            Console.Clear();

            Console.WriteLine("========== CREAR ALUMNO ==========");

            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacio.");
                return;
            }

            Console.Write("Ingrese la edad del alumno: ");

            if (!int.TryParse(Console.ReadLine(), out int edad) || edad <= 0)
            {
                Console.WriteLine("La edad ingresada no es valida.");
                return;
            }

            Console.Write("Ingrese la carrera del alumno: ");
            string carrera = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(carrera))
            {
                Console.WriteLine("La carrera no puede estar vacia.");
                return;
            }

            Console.Write("Ingrese el correo del alumno: ");
            string correo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(correo))
            {
                Console.WriteLine("El correo no puede estar vacio.");
                return;
            }

            Console.WriteLine("\nAlumno registrado correctamente.");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carrera: " + carrera);
            Console.WriteLine("Correo: " + correo);

            Console.WriteLine("\nNOTA:");
            Console.WriteLine("En la siguiente parte se conectaran estos datos");
            Console.WriteLine("con los vectores generales de alumnos y sus ID.");
        }

        // VER ALUMNOS
        static void VerAlumnos()
        {
            Console.Clear();

            Console.WriteLine("========== LISTA DE ALUMNOS ==========");
            Console.WriteLine("La lista se conectara con los alumnos registrados");
            Console.WriteLine("cuando se integren los vectores generales.");
        }

        // EDITAR ALUMNO
        static void EditarAlumno()
        {
            Console.Clear();

            Console.WriteLine("========== EDITAR ALUMNO ==========");
            Console.WriteLine("Esta seccion se conectara con los datos guardados");
            Console.WriteLine("de cada alumno en la siguiente parte.");
        }


        static void GestionCursos()
        {
            int opcion = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("========== GESTION DE CURSOS ==========");
                Console.WriteLine("1. Crear curso");
                Console.WriteLine("2. Ver lista de cursos");
                Console.WriteLine("3. Editar o eliminar curso");
                Console.WriteLine("4. Asignar alumno a un curso");
                Console.WriteLine("5. Ver alumnos de un curso");
                Console.WriteLine("6. Regresar al menu principal");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese una opcion numerica valida.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CrearCurso();
                        break;

                    case 2:
                        VerCursos();
                        break;

                    case 3:
                        EditarCurso();
                        break;

                    case 4:
                        AsignarAlumno();
                        break;

                    case 5:
                        VerAlumnosCurso();
                        break;

                    case 6:
                        Console.WriteLine("Regresando al menu principal...");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        Console.ReadKey();
                        break;
                }

                if (opcion != 6)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 6);
        }

        static void CrearCurso()
        {
            Console.Clear();
            Console.WriteLine("========== CREAR CURSO ==========");

            if (cantidadCursos >= idsCursos.Length)
            {
                Console.WriteLine("Se alcanzo el limite de 10 cursos.");
                return;
            }

            Console.Write("Nombre del curso: ");
            string nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacio.");
                return;
            }

            Console.Write("Descripcion del curso: ");
            string descripcion = Console.ReadLine();

            Console.Write("Horario del curso (ejemplo: Lunes 8:00-10:00): ");
            string horario = Console.ReadLine();

            Random aleatorio = new Random();
            int id;
            bool repetido;

            do
            {
                id = aleatorio.Next(1, 10000);
                repetido = false;

                for (int i = 0; i < cantidadCursos; i++)
                {
                    if (idsCursos[i] == id)
                    {
                        repetido = true;
                        break;
                    }
                }

            } while (repetido);

            idsCursos[cantidadCursos] = id;
            nombresCursos[cantidadCursos] = nombre;
            descripcionesCursos[cantidadCursos] = descripcion;
            horariosCursos[cantidadCursos] = horario;
            cantidadPorCurso[cantidadCursos] = 0;
            for (int i = 0; i < 15; i++)
            {
                notasCursos[cantidadCursos, i] = -1;
            }

            cantidadCursos++;

            Console.WriteLine("\nCurso creado correctamente.");
            Console.WriteLine("ID del curso: " + id.ToString("D4"));
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Horario: " + horario);
        }

        static void VerCursos()
        {
            Console.Clear();
            Console.WriteLine("========== LISTA DE CURSOS ==========");

            if (cantidadCursos == 0)
            {
                Console.WriteLine("No hay cursos registrados.");
                return;
            }

            for (int i = 0; i < cantidadCursos; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("ID: " + idsCursos[i].ToString("D4"));
                Console.WriteLine("Nombre: " + nombresCursos[i]);
                Console.WriteLine("Descripcion: " + descripcionesCursos[i]);
                Console.WriteLine("Horario: " + horariosCursos[i]);
                Console.WriteLine("Alumnos inscritos: " + cantidadPorCurso[i] + "/15");
            }
        }

        static int BuscarCurso(int id)
        {
            for (int i = 0; i < cantidadCursos; i++)
            {
                if (idsCursos[i] == id)
                {
                    return i;
                }
            }

            return -1;
        }

        static void AsignarAlumno()
        {
            Console.Clear();
            Console.WriteLine("========== ASIGNAR ALUMNO ==========");

            if (cantidadCursos == 0)
            {
                Console.WriteLine("No hay cursos registrados.");
                return;
            }

            if (cantidadAlumnos == 0)
            {
                Console.WriteLine("No hay alumnos registrados.");
                return;
            }

            Console.Write("Ingrese el ID del curso: ");

            if (!int.TryParse(Console.ReadLine(), out int idCurso))
            {
                Console.WriteLine("ID de curso invalido.");
                return;
            }

            int posicionCurso = BuscarCurso(idCurso);

            if (posicionCurso == -1)
            {
                Console.WriteLine("No existe un curso con ese ID.");
                return;
            }

            if (cantidadPorCurso[posicionCurso] >= 15)
            {
                Console.WriteLine("El curso ya tiene sus 15 alumnos.");
                return;
            }

            Console.WriteLine("\nAlumnos registrados:");

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine(
                    "ID: " + idsAlumnos[i] +
                    " | Nombre: " + nombresAlumnos[i]);
            }

            Console.Write("\nIngrese el ID del alumno: ");
            string idAlumno = Console.ReadLine();

            int posicionAlumno = -1;

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                if (idsAlumnos[i] == idAlumno)
                {
                    posicionAlumno = i;
                    break;
                }
            }

            if (posicionAlumno == -1)
            {
                Console.WriteLine("No existe un alumno con ese ID.");
                return;
            }

            for (int i = 0; i < cantidadPorCurso[posicionCurso]; i++)
            {
                if (alumnosPorCurso[posicionCurso, i] == idAlumno)
                {
                    Console.WriteLine("El alumno ya esta inscrito en este curso.");
                    return;
                }
            }

            int lugar = cantidadPorCurso[posicionCurso];

            alumnosPorCurso[posicionCurso, lugar] = idAlumno;
            cantidadPorCurso[posicionCurso]++;

            Console.WriteLine(
                "Alumno " + nombresAlumnos[posicionAlumno] +
                " asignado al curso " + nombresCursos[posicionCurso] + ".");
        }

        static void VerAlumnosCurso()
        {
            Console.Clear();
            Console.WriteLine("========== ALUMNOS POR CURSO ==========");

            if (cantidadCursos == 0)
            {
                Console.WriteLine("No hay cursos registrados.");
                return;
            }

            Console.Write("Ingrese el ID del curso: ");

            if (!int.TryParse(Console.ReadLine(), out int idCurso))
            {
                Console.WriteLine("ID invalido.");
                return;
            }

            int posicionCurso = BuscarCurso(idCurso);

            if (posicionCurso == -1)
            {
                Console.WriteLine("No existe un curso con ese ID.");
                return;
            }

            Console.WriteLine("\nCurso: " + nombresCursos[posicionCurso]);
            Console.WriteLine("Horario: " + horariosCursos[posicionCurso]);
            Console.WriteLine("Alumnos inscritos:");

            if (cantidadPorCurso[posicionCurso] == 0)
            {
                Console.WriteLine("No hay alumnos inscritos.");
                return;
            }

            for (int i = 0; i < cantidadPorCurso[posicionCurso]; i++)
            {
                string idAlumno = alumnosPorCurso[posicionCurso, i];

                for (int j = 0; j < cantidadAlumnos; j++)
                {
                    if (idsAlumnos[j] == idAlumno)
                    {
                        Console.WriteLine(
                            (i + 1) + ". " + nombresAlumnos[j] +
                            " | ID: " + idsAlumnos[j]);
                        break;
                    }
                }
            }
        }

        static void EditarCurso()
        {
            Console.Clear();
            Console.WriteLine("========== EDITAR O ELIMINAR CURSO ==========");

            if (cantidadCursos == 0)
            {
                Console.WriteLine("No hay cursos registrados.");
                return;
            }

            Console.Write("Ingrese el ID del curso: ");

            if (!int.TryParse(Console.ReadLine(), out int idCurso))
            {
                Console.WriteLine("ID invalido.");
                return;
            }

            int posicion = BuscarCurso(idCurso);

            if (posicion == -1)
            {
                Console.WriteLine("No existe un curso con ese ID.");
                return;
            }

            int opcion = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("Curso: " + nombresCursos[posicion]);
                Console.WriteLine("ID: " + idsCursos[posicion].ToString("D4"));
                Console.WriteLine("1. Cambiar nombre");
                Console.WriteLine("2. Cambiar descripcion");
                Console.WriteLine("3. Cambiar horario");
                Console.WriteLine("4. Eliminar curso");
                Console.WriteLine("5. Regresar");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion invalida.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nuevo nombre: ");
                        string nombre = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nombre))
                        {
                            nombresCursos[posicion] = nombre;
                            Console.WriteLine("Nombre actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("El nombre no puede estar vacio.");
                        }
                        break;

                    case 2:
                        Console.Write("Nueva descripcion: ");
                        string descripcion = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(descripcion))
                        {
                            descripcionesCursos[posicion] = descripcion;
                            Console.WriteLine("Descripcion actualizada.");
                        }
                        else
                        {
                            Console.WriteLine("La descripcion no puede estar vacia.");
                        }
                        break;

                    case 3:
                        Console.Write("Nuevo horario: ");
                        string horario = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(horario))
                        {
                            horariosCursos[posicion] = horario;
                            Console.WriteLine("Horario actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("El horario no puede estar vacio.");
                        }
                        break;

                    case 4:
                        Console.Write("¿Confirma que desea eliminar el curso? (S/N): ");
                        string respuesta = Console.ReadLine();

                        if (respuesta.Equals("S", StringComparison.OrdinalIgnoreCase))
                        {
                            EliminarCurso(posicion);
                            Console.WriteLine("Curso eliminado correctamente.");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Operacion cancelada.");
                        }
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }

        static void EliminarCurso(int posicion)
        {
            for (int i = posicion; i < cantidadCursos - 1; i++)
            {
                idsCursos[i] = idsCursos[i + 1];
                nombresCursos[i] = nombresCursos[i + 1];
                descripcionesCursos[i] = descripcionesCursos[i + 1];
                horariosCursos[i] = horariosCursos[i + 1];
                cantidadPorCurso[i] = cantidadPorCurso[i + 1];

                for (int j = 0; j < 15; j++)
                {
                    alumnosPorCurso[i, j] = alumnosPorCurso[i + 1, j];
                }
            }

            cantidadCursos--;

            idsCursos[cantidadCursos] = 0;
            nombresCursos[cantidadCursos] = null;
            descripcionesCursos[cantidadCursos] = null;
            horariosCursos[cantidadCursos] = null;
            cantidadPorCurso[cantidadCursos] = 0;

            for (int j = 0; j < 15; j++)
            {
                alumnosPorCurso[cantidadCursos, j] = null;
            }
        }


        static void GestionNotas()
        {
            int opcion = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("========== GESTION DE NOTAS ==========");
                Console.WriteLine("1. Registrar o modificar una nota");
                Console.WriteLine("2. Mostrar notas de un curso");
                Console.WriteLine("3. Regresar al menu principal");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese una opcion numerica valida.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        RegistrarNota();
                        break;

                    case 2:
                        MostrarNotasCurso();
                        break;

                    case 3:
                        Console.WriteLine("Regresando al menu principal...");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        Console.ReadKey();
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 3);
        }

        static void RegistrarNota()
        {
            Console.Clear();

            Console.WriteLine("========== REGISTRAR NOTA ==========");

            if (cantidadCursos == 0)
            {
                Console.WriteLine("No hay cursos registrados.");
                return;
            }

            Console.WriteLine("Cursos disponibles:");

            for (int i = 0; i < cantidadCursos; i++)
            {
                Console.WriteLine(
                    "ID: " + idsCursos[i].ToString("D4") +
                    " | Curso: " + nombresCursos[i]);
            }

            Console.Write("\nIngrese el ID del curso: ");

            if (!int.TryParse(Console.ReadLine(), out int idCurso))
            {
                Console.WriteLine("ID de curso invalido.");
                return;
            }

            int posicionCurso = BuscarCurso(idCurso);

            if (posicionCurso == -1)
            {
                Console.WriteLine("No existe un curso con ese ID.");
                return;
            }

            if (cantidadPorCurso[posicionCurso] == 0)
            {
                Console.WriteLine("Este curso no tiene alumnos inscritos.");
                return;
            }

            Console.WriteLine("\nAlumnos inscritos en " + nombresCursos[posicionCurso]);

            for (int i = 0; i < cantidadPorCurso[posicionCurso]; i++)
            {
                string idAlumno = alumnosPorCurso[posicionCurso, i];

                for (int j = 0; j < cantidadAlumnos; j++)
                {
                    if (idsAlumnos[j] == idAlumno)
                    {
                        Console.WriteLine(
                            "ID: " + idsAlumnos[j] +
                            " | Nombre: " + nombresAlumnos[j]);
                        break;
                    }
                }
            }

            Console.Write("\nIngrese el ID del alumno: ");
            string idBuscado = Console.ReadLine();

            int posicionInscripcion = -1;

            for (int i = 0; i < cantidadPorCurso[posicionCurso]; i++)
            {
                if (alumnosPorCurso[posicionCurso, i] == idBuscado)
                {
                    posicionInscripcion = i;
                    break;
                }
            }

            if (posicionInscripcion == -1)
            {
                Console.WriteLine("El alumno no esta inscrito en este curso.");
                return;
            }

            int posicionAlumno = -1;

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                if (idsAlumnos[i] == idBuscado)
                {
                    posicionAlumno = i;
                    break;
                }
            }

            if (posicionAlumno == -1)
            {
                Console.WriteLine("No se encontraron los datos del alumno.");
                return;
            }

            Console.WriteLine("\nAlumno: " + nombresAlumnos[posicionAlumno]);

            if (notasCursos[posicionCurso, posicionInscripcion] == -1)
            {
                Console.WriteLine("Nota actual: Pendiente");
            }
            else
            {
                Console.WriteLine(
                    "Nota actual: " +
                    notasCursos[posicionCurso, posicionInscripcion].ToString("F1"));
            }

            Console.Write("Ingrese la nota final (0 a 5): ");

            if (!double.TryParse(Console.ReadLine(), out double nota)
                || nota < 0 || nota > 5)
            {
                Console.WriteLine("Nota invalida. Debe estar entre 0 y 5.");
                return;
            }

            notasCursos[posicionCurso, posicionInscripcion] = nota;

            Console.WriteLine("\nNota registrada correctamente.");
            Console.WriteLine("Alumno: " + nombresAlumnos[posicionAlumno]);
            Console.WriteLine("Curso: " + nombresCursos[posicionCurso]);
            Console.WriteLine("Nota final: " + nota.ToString("F1"));
        }

        static void MostrarNotasCurso()
        {
            Console.Clear();

            Console.WriteLine("========== NOTAS FINALES POR CURSO ==========");

            if (cantidadCursos == 0)
            {
                Console.WriteLine("No hay cursos registrados.");
                return;
            }

            Console.WriteLine("Cursos disponibles:");

            for (int i = 0; i < cantidadCursos; i++)
            {
                Console.WriteLine(
                    "ID: " + idsCursos[i].ToString("D4") +
                    " | Curso: " + nombresCursos[i]);
            }

            Console.Write("\nIngrese el ID del curso: ");

            if (!int.TryParse(Console.ReadLine(), out int idCurso))
            {
                Console.WriteLine("ID de curso invalido.");
                return;
            }

            int posicionCurso = BuscarCurso(idCurso);

            if (posicionCurso == -1)
            {
                Console.WriteLine("No existe un curso con ese ID.");
                return;
            }

            Console.WriteLine("\nCurso: " + nombresCursos[posicionCurso]);
            Console.WriteLine("Horario: " + horariosCursos[posicionCurso]);
            Console.WriteLine("---------------------------------------------");

            if (cantidadPorCurso[posicionCurso] == 0)
            {
                Console.WriteLine("No hay alumnos inscritos.");
                return;
            }

            for (int i = 0; i < cantidadPorCurso[posicionCurso]; i++)
            {
                string idAlumno = alumnosPorCurso[posicionCurso, i];
                string nombreAlumno = "Alumno no encontrado";

                for (int j = 0; j < cantidadAlumnos; j++)
                {
                    if (idsAlumnos[j] == idAlumno)
                    {
                        nombreAlumno = nombresAlumnos[j];
                        break;
                    }
                }

                Console.WriteLine("\nAlumno: " + nombreAlumno);
                Console.WriteLine("ID: " + idAlumno);

                if (notasCursos[posicionCurso, i] == -1)
                {
                    Console.WriteLine("Nota final: Pendiente");
                }
                else
                {
                    Console.WriteLine(
                        "Nota final: " +
                        notasCursos[posicionCurso, i].ToString("F1"));
                }
            }
        }


    }
}
