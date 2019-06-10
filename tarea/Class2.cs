using System;
using System.Collections.Generic;
using System.Text;

namespace tarea
{
    class Class2

    //3. Escriba un programa en C# para comprobar si un número es par o impar.
    {
        static void Main(string[] args)
        {

            int num1;

            Console.WriteLine("Ingrese el Primer número");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("error, debe ingresar un número intente de nuevo");
            }

           


            if (num1 %2==0)

                Console.WriteLine("el número1 {0}, ingresado es par", num1);
            else
                Console.WriteLine("el número1 {0}, ingresado es impar", num1);



        }
    }
}
