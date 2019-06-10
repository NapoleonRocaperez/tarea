using System;
using System.Collections.Generic;
using System.Text;

namespace tarea
{
    class Class7
    {

        //Escriba un programa en C# para imprimir el nombre del día de la semana.

        static void Main(string[] args)
        {

            int num;
            string dia="";
            Console.WriteLine("Ingrese el Primer número");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("error, debe ingresar un número de 1 a 7 intente de nuevo");

            }


            switch (num)
            {

                case 1:

                    dia = ("lunes");
                    Console.WriteLine(dia);
                    break;

                case 2:

                    dia = ("martes");
                    Console.WriteLine(dia);
                    break;

                case 3:

                    dia = ("miercoles");
                    Console.WriteLine(dia);
                    break;
                case 4:

                    dia = ("jueves");
                    Console.WriteLine(dia);
                    break;
                case 5:

                    dia = ("viernes");
                    Console.WriteLine(dia);
                    break;
                case 6:

                    dia = ("sabado");
                    Console.WriteLine(dia);
                    break;
                    case 7:

                        dia = ("domingo");
                    Console.WriteLine(dia);
                    break;

                    default:
                        Console.WriteLine("Opción no valida,error debe seleccionar un numero entre 1 y 7");

                        break;


                }
            

            

        }
    }
}





