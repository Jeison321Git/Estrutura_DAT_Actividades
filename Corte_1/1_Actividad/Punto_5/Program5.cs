using System;

namespace Punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese un numero para que le de la raiz cuadrada:");
            double numero1 = 0;
            double rt = 0;
           numero1 = Convert.ToInt32(Console.ReadLine());
           
           if(numero1 <= 0){
               Console.WriteLine("El programa no se ejecutara ya que ingreso un numero negativo.");
            }  
           else{
            rt = Math.Sqrt(numero1); 
           }
           
           Console.WriteLine("La raiz cuadrada de: " + numero1 + " es:  "+ rt);
        }
    }
}
