using System;

namespace Punto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string teclado="";
            int numero=0;
            Console.WriteLine("Digite un numero: ");
            teclado=Console.ReadLine();
            numero=Convert.ToInt32(teclado);
            
            while (numero!=1)
            {
                if (numero%2==0)
                {
                    numero=numero/2;
                }
                else
                {
                    numero= 3*numero +1;
                }
                System.Console.WriteLine(""+numero);
            }
        }
    }
}
