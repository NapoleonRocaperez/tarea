using System;
using System.Collections.Generic;
using System.Text;

namespace tarea
{
    class Class6
    {

        //Escribe un programa en C# para introducir cualquier alfabeto y comprueba si es vocal o consonante.
        static void Main(string[] args)
        {

            
            string  letra;
            int letra1;
            Console.WriteLine("Ingresa un caracter");

           
            letra = Console.ReadLine();
                        
         
  
            if (letra == "a" ||letra== "e" ||letra=="i" ||letra=="o" ||letra=="u")

                Console.WriteLine("has ingresado una vocal");
            

           // if (letra == "1" || letra == "2" || letra == "3" || letra == "4" || letra == "5" || letra == "6" || letra == "7" || letra == "8" || letra == "9" )
               // Console.WriteLine("Error,has ingresado un número");

            else
                Console.WriteLine("has ingresado una letra");
        }






    }
}
