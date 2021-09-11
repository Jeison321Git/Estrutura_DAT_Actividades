using System;

namespace Punto_6
{
    class ejercicio6
    {
        static void Main(string[] args)
        {
            //creacion de variables 

            int or, sado,min,seg;
            string teclado ="";

            System.Console.WriteLine("Escriba la cantida de segundos ");
            teclado=Console.ReadLine(); //leer dato
            seg=Convert.ToInt32(teclado); //almacenar dato

            // determinar a cuanto vale dias,hora,minutos y segundos 

            sado = seg / (24 * 60* 60);
            seg = seg % (24 * 60* 60);
            or = seg / (60 * 60);
            seg = seg % (60*60);
            min = seg / (60);
            seg = seg % (60);

            //salida

            System.Console.WriteLine("El numero que ingreso equivale a {0} dias, {1} horas, {2} minutos , {3} segundos ",sado,or,min,seg);
        }
    }
}
