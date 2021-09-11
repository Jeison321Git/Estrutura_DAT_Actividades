using System;

namespace Punto_8
{
    class Program
    {
        static void Main(string[] args)
        {
            show_measurement ('U');//Salida: Es una vocal: U
            show_measurement('m');//Salida: Es una letra minúscula: m
            show_measurement('´');//Salida: Símbolo del alfabeto:´

            void show_measurement(char j)
            {
                if((j=='U')|(j=='K')|(j=='V')|(j=='W')|(j=='Z'))
                {
                    Console.WriteLine($"Es una vocal: {j}");
                }
                else if (char.IsLower(j))
                {
                    Console.WriteLine($"Es una letra minúscula: {j}" );
                }
                else
                {
                    Console.WriteLine($"Es un símbolo del alfabeto: {j}");
                }

            }
        }
    }
}
