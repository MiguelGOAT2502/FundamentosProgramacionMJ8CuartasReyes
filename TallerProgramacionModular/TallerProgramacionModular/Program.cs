using System;
using System.Linq;


namespace TallerProgramacionModular { }
//{
//internal class Program
//{
//static void Main(string[] args)
//{
//    //1. Desarrolla un programa que permita: 1. Ingresar una palabra  2.LLevar la palabra ingresada a un vector de caracteres 3.Contar la cantidad de vocales y consonantes en la palabra proporcionada por el usuario.
//    /*char[] vector = IngresarPalabra();
//    PalabraVector(vector);
//    ContarVocalesConsonantes(vector);*/
//}
//}


//}

/* static char[] IngresarPalabra()
 {
     Console.WriteLine("Ingrese una palabra: ");
     string palabra = Console.ReadLine();
     char[] vector = palabra.ToCharArray();
     return vector;
 }

 static void PalabraVector(char[] vector)
 {
     Console.WriteLine("La palabra ingresada en un vector de caracteres es: ");
     foreach (char c in vector)
     {
         Console.Write(c + " ");
     }
     Console.WriteLine();
 }
 static (int, int) ContarVocalesConsonantes(char[] vector)
 {
     int vocales = 0;
     int consonantes = 0;
     foreach (char c in vector)
     {
         if ("aeiouAEIOU".IndexOf(c) >= 0)
         {
             vocales++;
         }
         else if (Char.IsLetter(c))
         {
             consonantes++;
         }
     }
     Console.WriteLine($"Cantidad de vocales: {vocales}");
     Console.WriteLine($"Cantidad de consonantes: {consonantes}");
     return (vocales, consonantes);
 }*/

//2. Crear un programa que permita gestionar una lista de tareas: 1. Agregar tareas. 2. Eliminar tareas. 3. Mostrar la lista de tareas.
/*internal class Program

{
 static void Main(string[] args)
 {
     string[] tareas = new string[0];
     int opcion;
     do
     {
         Console.WriteLine("1. Agregar tarea");
         Console.WriteLine("2. Eliminar tarea");
         Console.WriteLine("3. Mostrar lista de tareas");
         Console.WriteLine("4. Salir");
         Console.WriteLine("Ingrese una opción: ");
         opcion = int.Parse(Console.ReadLine());
         switch (opcion)
         {
             case 1:
                 tareas = AgregarTarea(tareas);
                 break;
             case 2:
                 tareas = EliminarTarea(tareas);
                 break;
             case 3:
                 MostrarTareas(tareas);
                 break;
             case 4:
                 Console.WriteLine("Saliendo del programa...");
                 break;
             default:
                 Console.WriteLine("Opción inválida, intente nuevamente.");
                 break;
         }
     } while (opcion != 4);
 }
 static string[] AgregarTarea(string[] tareas)
 {
     Console.WriteLine("Ingrese la tarea a agregar: ");
     string tarea = Console.ReadLine();
     Array.Resize(ref tareas, tareas.Length + 1);
     tareas[tareas.Length - 1] = tarea;
     return tareas;
 }
 static string[] EliminarTarea(string[] tareas)
 {
     MostrarTareas(tareas);
     Console.WriteLine("Ingrese el número de la tarea a eliminar: ");
     int index = int.Parse(Console.ReadLine()) - 1;
     if (index >= 0 && index < tareas.Length)
     {
         for (int i = index; i < tareas.Length - 1; i++)
         {
             tareas[i] = tareas[i + 1];
         }
         Array.Resize(ref tareas, tareas.Length - 1);
     }
     else
     {
         Console.WriteLine("Índice inválido.");
     }
     return tareas;
 }
 static void MostrarTareas(string[] tareas)
 {
     if (tareas.Length == 0)
     {
         Console.WriteLine("No hay tareas en la lista.");
     }
     else
     {
         Console.WriteLine("Lista de Tareas:");
         for (int i = 0; i < tareas.Length; i++)
         {
             Console.WriteLine($"{i + 1}. {tareas[i]}");
         }
     }
 }
}*/

//3. Desarrolla un programa que permita: Elegir un tipo de unidad de medida (Masa, Capacidad, Longitud o Tiempo), elegir una unidad de medida para convertir, ingresar un valor para convertir, al final mostrar el valor y unidad a convertir, y el valor y la unidad a la que se convirtió.

/*internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione el tipo de unidad de medida:");
        Console.WriteLine("1. Masa");
        Console.WriteLine("2. Capacidad");
        Console.WriteLine("3. Longitud");
        Console.WriteLine("4. Tiempo");
        int tipoUnidad = int.Parse(Console.ReadLine());
        switch (tipoUnidad)
        {
            case 1:
                ConvertirMasa();
                break;
            case 2:
                ConvertirCapacidad();
                break;
            case 3:
                ConvertirLongitud();
                break;
            case 4:
                ConvertirTiempo();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
    static void ConvertirMasa()
    {
        Console.WriteLine("1. Kilogramos a gramos");
        Console.WriteLine("2. Gramos a kilogramos");
        Console.WriteLine("Seleccione una conversion:");

        int opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor a convertir:");
        float valor = float.Parse(Console.ReadLine());

        float resultado = 0;
        string origen = "";
        string destino = "";

        switch (opcion)
        {
            case 1:
                resultado = valor * 1000;
                origen = "kilogramos";
                destino = "gramos";
                break;
            case 2:
                resultado = valor / 1000;
                origen = "gramos";
                destino = "kilogramos";
                break;
            default:
                Console.WriteLine("Opcion invalida.");
                return;
        }

        MostrarResultado(valor, resultado, origen, destino);
    }

    static void ConvertirCapacidad()
    {
        Console.WriteLine("1. Litros a mililitros");
        Console.WriteLine("2. Mililitros a litros");
        Console.WriteLine("Seleccione una conversion:");

        int opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor a convertir:");
        float valor = float.Parse(Console.ReadLine());

        float resultado = 0;
        string origen = "";
        string destino = "";

        switch (opcion)
        {
            case 1:
                resultado = valor * 1000;
                origen = "litros";
                destino = "mililitros";
                break;
            case 2:
                resultado = valor / 1000;
                origen = "mililitros";
                destino = "litros";
                break;
            default:
                Console.WriteLine("Opcion invalida.");
                return;
        }

        MostrarResultado(valor, resultado, origen, destino);
    }

    static void ConvertirLongitud()
    {
        Console.WriteLine("1. Kilometros a metros");
        Console.WriteLine("2. Metros a kilometros");
        Console.WriteLine("Seleccione una conversion:");

        int opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor a convertir:");
        float valor = float.Parse(Console.ReadLine());

        float resultado = 0;
        string origen = "";
        string destino = "";

        switch (opcion)
        {
            case 1:
                resultado = valor * 1000;
                origen = "kilometros";
                destino = "metros";
                break;
            case 2:
                resultado = valor / 1000;
                origen = "metros";
                destino = "kilometros";
                break;
            default:
                Console.WriteLine("Opcion invalida.");
                return;
        }

        MostrarResultado(valor, resultado, origen, destino);
    }

    static void ConvertirTiempo()
    {
        Console.WriteLine("1. Horas a segundos");
        Console.WriteLine("2. Segundos a horas");
        Console.WriteLine("Seleccione una conversion:");

        int opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor a convertir:");
        float valor = float.Parse(Console.ReadLine());

        float resultado = 0;
        string origen = "";
        string destino = "";

        switch (opcion)
        {
            case 1:
                resultado = valor * 3600;
                origen = "horas";
                destino = "segundos";
                break;
            case 2:
                resultado = valor / 3600;
                origen = "segundos";
                destino = "horas";
                break;
            default:
                Console.WriteLine("Opcion invalida.");
                return;
        }

        MostrarResultado(valor, resultado, origen, destino);
    }

    static void MostrarResultado(float valor, float resultado,
        string origen, string destino)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Valor original: " + valor + " " + origen);
        Console.WriteLine("Valor convertido: " + resultado + " " + destino);
        Console.WriteLine("--------------------------------");
    }

*/

//4. Utiliza programación modular para crear un programa que permita: 1. Recorrer una matriz y llenarla con nombres de contactos, 2. Ingresar un nombre y buscarlo en la matriz, 3. Si se encuentra el nombre, cambiarlo en la matriz por un nuevo nombre que ingresa el usuario, 4. Mostrar por la pantalla el nombre encontrado, su posición en la matriz (f, c), y el nuevo nombre ingresado.

/*    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] contactos = new string[2, 3];

            LlenarMatriz(contactos);
            MostrarMatriz(contactos);

            Console.WriteLine("Ingrese el nombre que desea buscar:");
            string nombreBuscado = Console.ReadLine();

            int fila, columna;

            if (BuscarContacto(contactos, nombreBuscado, out fila, out columna))
            {
                Console.WriteLine("Ingrese el nuevo nombre:");
                string nuevoNombre = Console.ReadLine();
                contactos[fila, columna] = nuevoNombre;
                MostrarResultado(
                    nombreBuscado, fila, columna, nuevoNombre
                );

                Console.WriteLine("\nMatriz actualizada:");
                MostrarMatriz(contactos);
            }
            else
            {
                Console.WriteLine("El contacto no se encuentra en la matriz.");
            }
        }

        static void LlenarMatriz(string[,] contactos)
        {
            for (int f = 0; f < contactos.GetLength(0); f++)
            {
                for (int c = 0; c < contactos.GetLength(1); c++)
                {
                    Console.WriteLine(
                        $"Ingrese el nombre para la posición [{f},{c}]:"
                    );
                    contactos[f, c] = Console.ReadLine();
                }
            }
        }

        static void MostrarMatriz(string[,] contactos)
        {
            Console.WriteLine("\nLista de contactos:");
            for (int f = 0; f < contactos.GetLength(0); f++)
            {
                for (int c = 0; c < contactos.GetLength(1); c++)
                {
                    Console.Write(contactos[f, c] + "\t");
                }
                Console.WriteLine();
            }
        }
        static bool BuscarContacto(
            string[,] contactos, string nombre,
            out int fila, out int columna)
        {
            for (int f = 0; f < contactos.GetLength(0); f++)
            {
                for (int c = 0; c < contactos.GetLength(1); c++)
                {
                    if (string.Equals(
                        contactos[f, c],
                        nombre,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        fila = f;
                        columna = c;
                        return true;
                    }
                }
            }

            fila = -1;
            columna = -1;
            return false;
        }

        static void MostrarResultado(
            string encontrado, int fila, int columna,
            string nuevoNombre)
        {
            Console.WriteLine("\nContacto actualizado correctamente.");
            Console.WriteLine("Nombre encontrado: " + encontrado);
            Console.WriteLine("Posición (fila, columna): (" +
                fila + ", " + columna + ")");
            Console.WriteLine("Nuevo nombre: " + nuevoNombre);
        }
    }*/

//5. Crear un programa que implemente el juego de tres en raya, para dos jugadores. El programa debe: 1. Dibujar un tablero, 2. Permitir realizar movimientos, 3. Verificar ganadores.

internal class Program
{
    static void Main(string[] args)
    {
        char[,] tablero = new char[3, 3];

        InicializarTablero(tablero);

        char jugador = 'X';
        bool ganador = false;

        while (!ganador && !TableroLleno(tablero))
        {
            DibujarTablero(tablero);

            Console.WriteLine("Turno del jugador " + jugador);
            Console.WriteLine("Ingrese una posición del 1 al 9:");

            if (!int.TryParse(Console.ReadLine(), out int posicion)
                || posicion < 1 || posicion > 9)
            {
                Console.WriteLine("Posición inválida. Intente nuevamente.");
                continue;
            }

            int fila = (posicion - 1) / 3;
            int columna = (posicion - 1) % 3;

            if (!RealizarMovimiento(tablero, fila, columna, jugador))
            {
                Console.WriteLine("Casilla ocupada. Intente otra.");
                continue;
            }
            ganador = VerificarGanador(tablero, jugador);

            if (!ganador)
            {
                jugador = (jugador == 'X') ? 'O' : 'X';
            }
        }

        DibujarTablero(tablero);

        if (ganador)
        {
            Console.WriteLine("¡Ganó el jugador " + jugador + "!");
        }
        else
        {
            Console.WriteLine("¡Empate! El tablero está lleno.");
        }
    }

    static void InicializarTablero(char[,] tablero)
    {
        char posicion = '1';

        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 3; c++)
            {
                tablero[f, c] = posicion;
                posicion++;
            }
        }
    }

    static void DibujarTablero(char[,] tablero)
    {
        Console.WriteLine("\nTablero:");

        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(" " + tablero[f, c] + " ");

                if (c < 2)
                {
                    Console.Write("|");
                }
            }

            Console.WriteLine();

            if (f < 2)
            {
                Console.WriteLine("---+---+---");
            }
        }

        Console.WriteLine();
    }

    static bool RealizarMovimiento(
        char[,] tablero, int fila, int columna, char jugador)
    {
        if (tablero[fila, columna] == 'X'
            || tablero[fila, columna] == 'O')
        {
            return false;
        }

        tablero[fila, columna] = jugador;
        return true;
    }

    static bool VerificarGanador(char[,] tablero, char jugador)
    {
        for (int f = 0; f < 3; f++)
        {
            if (tablero[f, 0] == jugador
&& tablero[f, 1] == jugador
&& tablero[f, 2] == jugador)
            {
                return true;
            }
        }

        for (int c = 0; c < 3; c++)
        {
            if (tablero[0, c] == jugador
&& tablero[1, c] == jugador
&& tablero[2, c] == jugador)
            {
                return true;
            }
        }

        if (tablero[0, 0] == jugador
&& tablero[1, 1] == jugador
&& tablero[2, 2] == jugador)
        {
            return true;
        }

        if (tablero[0, 2] == jugador
&& tablero[1, 1] == jugador
&& tablero[2, 0] == jugador)
        {
            return true;
        }

        return false;
    }

    static bool TableroLleno(char[,] tablero)
    {
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 3; c++)
            {
                if (tablero[f, c] != 'X'
&& tablero[f, c] != 'O')
                {
                    return false;
                }
            }
        }

        return true;
    }
}
 
