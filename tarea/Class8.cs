using System;
using System.Collections.Generic;
using System.Text;

namespace tarea
{
    class Class8
    {
        //Escriba un programa en C# que imprima el número total de días de un mes.
        static void Main(string[] args)
        {

            int num;
            string mes = "";
            Console.WriteLine("Ingrese el Primer número");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("error, has ingresado letras");

            }


            switch (num)
            {

                case 1:

                    mes = ("enero tiene 31 dias");
                    Console.WriteLine(mes);
                    break;

                case 2:

                    mes = ("febrero tiene 28 dias");
                    Console.WriteLine(mes);
                    break;

                case 3:

                    mes = ("marzo tiene 31 dias");
                    Console.WriteLine(mes);
                    break;
                case 4:

                    mes = ("abril tiene 30 dias");
                    Console.WriteLine(mes);
                    break;
                case 5:

                    mes= ("mayo tiene 31 dias");
                    Console.WriteLine(mes);
                    break;
                case 6:

                    mes = ("junio tiene 30 dias");
                    Console.WriteLine(mes);
                    break;
                case 7:

                    mes = ("julio tiene 31 dias");
                    Console.WriteLine(mes);
                    break;

                case 8:

                    mes = ("agosto tiene 31 dias");
                    Console.WriteLine(mes);
                    break;
                case 9:

                    mes = ("septiembre tiene 31 dias");
                    Console.WriteLine(mes);
                    break;
                case 10:

                    mes = ("octubre tiene 31 dias");
                    Console.WriteLine(mes);
                    break;
                case 11:

                    mes = ("noviembre tiene 31 dias");
                    Console.WriteLine(mes);
                    break;
                case 12:

                    mes = ("diciembre tiene 31 dias");
                    Console.WriteLine(mes);
                    break;
                default:
                    Console.WriteLine("Opción no valida,error debe seleccionar un numero entre 1 y 12 meses del año calendario gregoriano");

                    break;


            }

        }
        }
}
