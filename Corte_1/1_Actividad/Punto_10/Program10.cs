using System;

namespace Punto_10
{
    class Program
    {
        static void Main(string[] args)
        {
             String contrasena = "iloveyou123";
             Boolean bandera = false;

            do
            {
                Console.Write("Ingrese la contraseña: ");
                contrasena = Console.ReadLine();

                if (contrasena.Equals("iloveyou123"))
                {
                    bandera = true;
                    Console.WriteLine("\n--> Contraseña correcta <--\n");
                }
                else
                {
                    Console.WriteLine("\n***Contraseña incorrecta");
                }

            } while (bandera == false);
        }
    }
}
