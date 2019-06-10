using System;

namespace tarea
{
    class Program

    //Escriba un programa en C# para encontrar el máximo entre dos números.
    {
        static void Main(string[] args)
        {

            int num1, num2;



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

            if (num1 > num2)
            
                Console.WriteLine("el número1 {0}, ingresado es mayor que el segundo numero2 {1}, ingresado",num1,num2);
            else
                Console.WriteLine("el número2 {1}, ingresado es mayor que el segundo numero1 {0}, ingresado",num2,num1);








        }
    }
}
