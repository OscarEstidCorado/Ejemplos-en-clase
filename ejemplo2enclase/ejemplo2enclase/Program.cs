using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejemplo2enclase
{
    class Program
    {
        public static void Dibuja(int cantidad)
        {
            int Filas = 15;
            int Columnas = 50;
            int FilaInterna = 2;
            int Posicion = 2;
            int F, C, A;

            for (A = 1; A <= cantidad; A++)
            {
                for (F = Posicion; F <= Columnas; F++)
                {
                    Console.SetCursorPosition(F, Filas); Console.Write("I");
                    Console.SetCursorPosition(F, FilaInterna); Console.Write("J");

                }
                for (C = FilaInterna; C <= Filas; C++)
                {
                    Console.SetCursorPosition(Posicion, C); Console.Write("K");
                    Console.SetCursorPosition(Columnas, C); Console.Write("X");
                }
                FilaInterna++;
                Filas--;
                Posicion++;
                Columnas--;
            }
            Console.WriteLine();
        }




        static void Main(string[] args)
        {
            for (int tan = 1; tan < 11; tan++)//en este for da las instrucciones de cuantas veces tiene que dibujarse el marco
            {
                Dibuja(tan);//aqui llamamos a  la funcion
                Thread.Sleep(1000);// aqui vemos la velocidad a la que se imprimira cada marco


            }


            Console.WriteLine();
        }


    }
}
