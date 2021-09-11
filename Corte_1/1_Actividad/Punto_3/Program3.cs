using System;

namespace Punto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string teclado="";
            int promedio;
            int not1,not2,not3,not4;
            Console.Write("Programa para hallar el promedio, la calificación mayor y la Menor, de 4 calificaciones:  ");
		    

			Console.Write("Ingrese la primera calificación para el estudiante de 0 a 100: ");
			teclado=Console.ReadLine();
            not1=Convert.ToInt32(teclado);

            Console.Write("Ingrese la segunda calificación para el estudiante de 0 a 100: ");
			 teclado=Console.ReadLine();
            not2=Convert.ToInt32(teclado);

            Console.Write("Ingrese la tercera calificación para el estudiante de 0 a 100: ");
			 teclado=Console.ReadLine();
            not3=Convert.ToInt32(teclado);

            Console.Write("Ingrese la cuarta calificación para el estudiante de 0 a 100: ");
			 teclado=Console.ReadLine();
            not4=Convert.ToInt32(teclado);

            promedio = ( not1 + not2+ not3 + not4 /4);

            Console.Write("El promedio de sus calificaciones es: "+ promedio);
            
            
            if(not1>not2 && not1>not3 && not1>not4)
            {
                System.Console.WriteLine("la nota mayor es: "+not1);

            }
             if(not2>not1 && not2>not3 && not2>not4)
             {
                System.Console.WriteLine("la nota mayor es: "+not2);

            }
               if(not3>not1 && not3>not2 && not3>not4)
               {
                System.Console.WriteLine("la nota mayor es: "+not3);

            }
               if(not4>not1 && not4>not3 && not4>not3)
               {
                System.Console.WriteLine("la nota mayor es: "+not4);

            }
            if(not1<not2 && not1<not3 && not1<not4)
            {
                System.Console.WriteLine("la nota menor es: "+not1);

            }
             if(not2<not1 && not2<not3 && not2<not4)
             {
                System.Console.WriteLine("la nota menor es: "+not2);

            }
               if(not3<not1 && not3<not2 && not3<not4)
               {
                System.Console.WriteLine("la nota menor es: "+not3);

            }
               if(not4<not1 && not4<not3 && not4<not3)
               {
                System.Console.WriteLine("la nota menor es: "+not4);

            }

            


        }

    }
}
