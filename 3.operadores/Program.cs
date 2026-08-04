using System;


namespace _3.operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores numericos
            //Incremento y decremento
            int dato1 = 0;
            dato1++; //dato1= dato1 + 1; Incremento
            dato1--; //dato1= dato1 - 1; Decremento
            dato1 += 5; //dato1= dato1 + 5; Incremento en 5 unidades
            dato1 *= 3; //dato1= dato1 * 3; Multiplicacion por 3
            dato1 /= 2; //dato1= dato1 / 2; Division entre 2
            dato1 += dato1; //dato1= dato1 + dato1; Incremento en 2 veces su valor

            //Orden evaluacion de operadores numericos
            float dato2 = 4 / 3 * 2;
            float dato3 = 4 * (2 / 3);
            float dato4 = 4 + 6 * 2;
            float dato5 = 4 + 6 * (2 - 1);
            float dato6 = dato2 * dato3 - dato3 - dato4 / dato5;

            //Operadores logicos
            //Conjuncion - AND - Y - &&
            Console.WriteLine("-----------TABLA DE LA CONJUNCION---------");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("------------------------------------------");

            //Disyuncion - OR - O - ||
            Console.WriteLine("-----------TABLA DE LA DISYUNCION---------");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("------------------------------------------");

            //Negacion - NOT - NO - !
            Console.WriteLine("-----------TABLA DE LA NEGACION---------");
            Console.WriteLine("!V = " + (!true));
            Console.WriteLine("!F = " + (!false));
            Console.WriteLine("------------------------------------------");

        
            bool dato7 = true;
            bool dato8 = !dato7;
            //OPERADORES DE COMPARACION
            bool dato9 = 5 > 4;
            bool dato10 = 100 <= 99;
            bool dato11 = 25 == 25;
            bool dato12 = 4 != 4;
            bool dato13 = 5 <4 && dato7;
            bool dato14 = 0 == 1 || 12 > 3 && dato9;    


        }
    }
}
