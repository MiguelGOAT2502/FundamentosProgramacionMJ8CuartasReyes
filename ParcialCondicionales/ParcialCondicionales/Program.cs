using System;
using System.Reflection.Emit;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            //Selección de sala, juego y precio (70%) Desarrolle un programa en C# que permita a un usuario seleccionar una sala y un juego de acuerdo con su edad, y determine el precio que debe pagar a. Ingreso de datosEl programa debe solicitar al usuario: Edad, expresada como un número entero positivo.
            //            //b.Determinación de las salas habilitada De acuerdo con la edad ingresada, se determinarán las salas a las que el usuario puede acceder: 
            //Edad
            //Sala(s) habilitada(s)
            //1 a 5 años
            //Sala 1
            //6 a 16 años
            //Sala 2
            //17 a 25 años
            //Sala 3 y Sala 4
            //26 años o más
            //Sala 5
            //Si la edad ingresada no corresponde a un rango válido, el programa debe mostrar un mensaje de error y finalizar.
            //Cuando exista una sola sala habilitada, esta será asignada automáticamente.Cuando existan dos salas habilitadas, el programa debe mostrar ambas opciones y permitir al usuario seleccionar una.
            //c.Juegos disponibles por sala
            //Una vez determinada la sala, el programa debe mostrar los juegos disponibles en ella:

            //
            //Sala
            //Juegos disponibles
            //Sala 1
            //Juego1, Juego5
            //Sala 2
            //Juego3, Juego6
            //Sala 3
            //Juego2, Juego7
            //Sala 4
            //Juego4, Juego8
            //Sala 5
            //Juego9, Juego10
            //El usuario debe seleccionar uno de los juegos disponibles para la sala elegida.
            //Si el usuario selecciona una sala o un juego que no corresponda a las opciones habilitadas, el programa debe mostrar un mensaje indicando que la selección no es válida y finalizar.
            //d.Precio de los juegos
            //El precio que debe pagar el usuario depende del juego seleccionado:

            //
            //Juego
            //Precio
            //Juego1, Juego10
            //$3.000
            //Juego2, Juego9
            //$5.000
            //Juego3, Juego5, Juego8
            //$7.000
            //Juego4, Juego6
            //$9.000
            //Juego7
            //$10.000

            //e.Salida del programa
            //Una vez realizadas las selecciones correctamente, el programa debe mostrar:
            //Edad del usuario
            //Sala seleccionada
            //Juego seleccionado
            //Precio a pagar
            //Por ejemplo:
            //Edad del usuario: 20
            //Sala seleccionada: Sala 3
            //Juego seleccionado: Juego2
            //Precio a pagar: $5.000
            //El estudiante podrá utilizar las estructuras condicionales estudiadas en clase que considere adecuadas para resolver el problema.


            {
                int edad;
                int juego = 0;
                int sala = 0;


                Console.WriteLine("ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                if (edad >0 && edad <= 5)
                {
                    sala = 1;
                    Console.WriteLine("ingreso a la sala 1");
                    Console.WriteLine("juegos disponibles: Juego 1, Juego 5");
                    Console.WriteLine("ingrese el número del juego que desea jugar: ");
                    juego = int.Parse(Console.ReadLine());
                    if (juego == 1)
                    {
                        Console.WriteLine("Juego 1 seleccionado debe pagar: $3.000");
                    }
                    else if (juego == 5)
                    {
                        Console.WriteLine("Juego 5 seleccionado debe pagar: $7.000");
                    }
                    else
                    {
                        Console.WriteLine("selección no válida");
                    }
                }
                else if (edad >= 6 && edad <= 16)
                {
                    sala = 2;
                    Console.WriteLine("ingreso a la sala 2");
                    Console.WriteLine("juegos disponibles: Juego3, Juego6");
                    Console.WriteLine("ingrese el número del juego que desea jugar: ");
                    juego = int.Parse(Console.ReadLine());
                    if (juego == 3)
                    {
                        Console.WriteLine("Juego 3 seleccionado debe pagar: $7.000");
                    }
                    else if (juego == 6)
                    {
                        Console.WriteLine("Juego 6 seleccionado debe pagar: $9.000");
                    }
                    else
                    {
                        Console.WriteLine("selección no válida");
                    }
                }
                else if (edad >= 17 && edad <= 25)
                {
                    Console.WriteLine("ingreso a la sala 3 o sala 4");
                    Console.WriteLine("seleccione la sala a la que quiere ingresar (3 o 4): ");
                    sala = int.Parse(Console.ReadLine());
                    if (sala == 3)
                    {
                        Console.WriteLine("ingreso a la sala 3");
                        Console.WriteLine("juegos disponibles: Juego 2, Juego 7");
                        Console.WriteLine("ingrese el número del juego que desea jugar: ");
                        juego = int.Parse(Console.ReadLine());
                        if (juego == 2)
                        {
                            Console.WriteLine("Juego 2 seleccionado debe pagar: $5.000");
                        }
                        else if (juego == 7)
                        {
                            Console.WriteLine("Juego 7 seleccionado debe pagar: $10.000");
                        }
                        else
                        {
                            Console.WriteLine("selección no válida");
                        }
                    }
                    else if (sala == 4)
                    {
                        Console.WriteLine("ingreso a la sala 4");
                        Console.WriteLine("juegos disponibles: Juego 4, Juego 8");
                        Console.WriteLine("ingrese el número del juego que desea jugar: ");
                        juego = int.Parse(Console.ReadLine());
                        if (juego == 4)
                        {
                            Console.WriteLine("Juego 4 seleccionado debe pagar: $9.000");
                        }
                        else if (juego == 8)
                        {
                            Console.WriteLine("Juego 8 seleccionado debe pagar: $7.000");
                        }
                        else
                        {
                            Console.WriteLine("selección no válida");
                        }
                    }
                    else
                    {
                        Console.WriteLine("selección no válida");
                    }
                }
                else if (edad >= 26) 
                {
                    sala = 5;
                    Console.WriteLine("ingreso a la sala 5");
                    Console.WriteLine("juegos disponibles: Juego 9, Juego 10");
                    Console.WriteLine("ingrese el número del juego que desea jugar: ");
                    juego = int.Parse(Console.ReadLine());
                    if (juego == 9)
                    {
                        Console.WriteLine("Juego 9 seleccionado debe pagar: $5.000");
                    }
                    else if (juego == 10)
                    {
                        Console.WriteLine("Juego 10 seleccionado debe pagar: $3.000");
                    }
                    else
                    {
                        Console.WriteLine("selección no válida");
                    }
                }
                else
                {
                    Console.WriteLine("edad no válida");
                }
                
                {
                    Console.WriteLine("Resumen de sus elecciones:");
                    Console.WriteLine("Edad: " + edad);
                    Console.WriteLine("Sala: " + sala);
                    Console.WriteLine("Juego: " + juego);
                    Console.WriteLine("precio a pagar: " + (juego == 1 ? "$3.000" : juego == 2 ? "$5.000" : juego == 3 ? "$7.000" : juego == 4 ? "$9.000" : juego == 5 ? "$7.000" : juego == 6 ? "$9.000" : juego == 7 ? "$10.000" : juego == 8 ? "$7.000" : juego == 9 ? "$5.000" : juego == 10 ? "$3.000" : "selección no válida"));


                }


            }
        }
    }
}
