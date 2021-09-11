using System;

/* Creado por: Jeison Silva
 * Grupo: 239-2A
 * Turno: Diurno 
*/

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
           //En un videoclub se ofrece la promoción de llevarse tres películas, por el precio de las dos más baratas. Haga un programa que, dados los tres precios de las películas, determine la cantidad a pagar//
            Console.WriteLine("Bienvenido, el dia de hoy tenemos una promoción llevate 3 peliculas y paga las 2 más baratas!");

            double Precio1;
            double Precio2;
            double Precio3;
            double Operación1;

            Console.Write("Ingrese el primer precio ");
            Precio1 =
                double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo precio ");
            Precio2 =
                double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer precio ");
            Precio3 =
                double.Parse(Console.ReadLine());

            if (Precio1 > Precio2 && Precio1 > Precio3)
            {
                Operación1 = Precio2 + Precio3;
                Console.WriteLine("La promoción es: " + Operación1);
            }
            //Hace lo que esté entre los corchetes si la condición es falsa//
            else if (Precio2 > Precio1 && Precio2 > Precio3)
            {
                Operación1 = Precio1 + Precio3;
                Console.WriteLine("El precio de la promoción es: " + Operación1);
            }
            else
            {
                Operación1 = Precio2 + Precio1;
                Console.WriteLine("El precio de la promoción es: " + Operación1);
            }
            Console.ReadLine();
            Console.WriteLine("Gracias por su compra , regrese pronto");
            Console.ReadLine();


        }
	}
        
}
