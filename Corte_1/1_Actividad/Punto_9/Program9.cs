using System;

namespace Punto_9
{
    class Program
    {
        static void Main(string[] args)
        {
             int zz;
             double ññ,tt;
             Console.Write("Ingrese la edad un perro en años: ");
             zz = int.Parse(Console.ReadLine());
 
             if (zz <= 2 )
             {
             ññ = 10.5 * zz;
             Console.WriteLine("La edad de su mascota es:  "+ññ);
             }
 
             else if (zz>=3)
             {
             tt = 21 + ((zz - 2)*4);
             Console.WriteLine("La edad de su mascota es: "+tt);
            }
        }
    }
}
