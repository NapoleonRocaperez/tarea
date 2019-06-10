using System;
using System.Collections.Generic;
using System.Text;

namespace tarea
{
    class Class3
    {
        static void Main(string[] args)

        //Escriba un programa en C# para comprobar si el año es año bisiesto o no.
        //Un año es bisiesto si es múltiplo de 4 (por ejemplo 1984).
        // Los años múltiplos de 100 no son bisiestos,
        //salvo si ellos son también múltiplos de 400 (2000 es bisiesto, pero;  1800 no lo es)
        {
            int año;
            Console.WriteLine("Ingresa año");

            while (!int.TryParse(Console.ReadLine(), out año))
            {
                Console.WriteLine("error, debe ingresar un número que sea un año  intente de nuevo");
            }


            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
            {
                Console.WriteLine("El año " + año + " Si es bisiesto ");
            }
            else
            {
                Console.WriteLine("El año " + año + " No es bisiesto ");
            }
            Console.ReadLine();
        }


    }
}
