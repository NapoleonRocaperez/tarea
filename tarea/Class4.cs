using System;
using System.Collections.Generic;
using System.Text;

namespace tarea
{
    class Class4


    {
        static void Main(string[] args)

        //Escriba un programa en C# para comprobar si un carácter es un alfabeto o no.
        {


            int letra;
           

            Console.WriteLine("Ingrese un caracter");

            if (int.TryParse(Console.ReadLine(), out letra))
            
                Console.WriteLine("ha ingresado un número");
            else
                Console.WriteLine("ha ingresado una letra del alfabeto");





        }
    }
}
