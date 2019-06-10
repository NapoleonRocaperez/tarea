using System;
using System.Collections.Generic;
using System.Text;

namespace tarea
{
    class Class5


    //Escriba un programa en C# para comprobar si un número es negativo, positivo o cero.
    {
        static void Main(string[] args) {


            int num;
            Console.WriteLine("Ingrese el Primer número");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("error, debe ingresar un número intente de nuevo");
            }
            if (num > 0)
                Console.WriteLine("el  numero es positivo");

            if (num <0 )
                Console.WriteLine("el  numero es negativo");

            if (num==0 )
                Console.WriteLine("el  numero es igual a cero");



        }

        

    }
}
