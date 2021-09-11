using System;

namespace Punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
             int rc,nv,c;
             Console.Write("Ingrese el numero de ventas de A ");
             rc = int.Parse(Console.ReadLine());
             Console.Write("Ingrese el numero de ventas de B ");
             nv = int.Parse(Console.ReadLine());
             Console.Write("Ingrese el numero de ventas de C ");
             c = int.Parse(Console.ReadLine());
             if (rc>nv && rc>c)
             Console.WriteLine("Las ventas del producto A son las más elevadas.");
             if (rc>200 && nv>200 && c>200)
             Console.WriteLine("Ningún producto tiene unas ventas inferiores a 200.");
             if (rc<400 || nv<400 || c<400)
             Console.WriteLine("Algún producto tiene unas ventas superiores a 400.");
             if ((rc+nv+c)/3>=500)
             Console.WriteLine("La media de ventas es superior a 500.");
             if (nv<rc && nv<c)
             Console.WriteLine("El producto B no es el más vendido.");
             if((rc+nv+c)>=500 || (rc+nv+c)<=1000 )
             Console.WriteLine("El total de ventas esta entre 500 y 1000.");
        }
    }
}
