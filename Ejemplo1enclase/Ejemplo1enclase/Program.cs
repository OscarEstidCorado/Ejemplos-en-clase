using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1enclase
{

    class Program
    {


        static void Main(string[] args)
        {
            byte cantidadNumeros, K;
            int NUM;
            string Linea;
            Console.WriteLine("Cuantos Numeros");
            Linea = Console.ReadLine();
            cantidadNumeros = byte.Parse(Linea);
            Random Aleatorio = new Random();


            for (K = 1; K <= cantidadNumeros; K++)
            {
                NUM = Convert.ToInt32(Aleatorio.Next(50, 100));
                Console.WriteLine($"El Numero generado es{ NUM}");

                if (((NUM > 0) & (NUM < 256)))
                    Console.WriteLine($"El codigo de {NUM} es {Convert.ToString((char)NUM)}");
            }
        }

    }
}
