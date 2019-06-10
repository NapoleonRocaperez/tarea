using System;
using System.Collections.Generic;
using System.Text;

namespace tarea
{
    class Class1
    {
        //2. Escriba un programa en C# para encontrar el máximo entre tres números.

        static void Main(string[] args)
        {

            int num1, num2, num3;



            Console.WriteLine("Ingrese el Primer número");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("error, debe ingresar un número intente de nuevo");
            }

            Console.WriteLine("Ingrese el segundo número");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("error, debe ingresar un número intente de nuevo");
            }
            Console.WriteLine("Ingrese el tercer número");
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("error, debe ingresar un número intente de nuevo");
            }

            if (num1 > num2 && num1> num3)

                Console.WriteLine("el número1 {0}, ingresado es mayor que el segundo numero2 {1}, y numero3 {2}, ingresado", num1, num2,num3);
            
              


            if (num2 > num3 && num2 > num1)
                Console.WriteLine("el número2 {1}, ingresado es mayor que el Primer numero {0}, y numero3 {2}, ingresado", num1, num2, num3);

            if (num3 > num2 && num3 > num1)
                Console.WriteLine("el número3 {2}, ingresado es mayor que el Primer numero {0}, y numero2 {1}, ingresado", num1, num2, num3);
        }

    }
}
