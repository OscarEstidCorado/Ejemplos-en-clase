using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3enclase
{
    class Program
    {

        public static string Mid(string parametro, int starIndex, int Length)//La Funcion Mid es la que acepta tres parametros 
        {
            string result = parametro.Substring(starIndex, Length);

            return result;

        }

        static void Main(string[] args)
        {
            string Nombre;
            string Caracter;
            int Movimiento = 0;
            int Inicio = 0;
            int tamCadena = 0;
            int Limite = 0;
            Console.Write("Ingrese su nombre: ");//aqui le pedimos al usuario su nombre
            Nombre = Console.ReadLine();//Se lee el nombre y se guarda en la variabe
            Console.SetCursorPosition(1, 12);//se le asigna un lugar al cursor para la impresion
            Console.Write(Nombre);//aqui imprime el nombre antes de iniciar la animacion

            tamCadena = Nombre.Length;// se le asigna como valor la cantidad de caracteres que hayan
            Limite = 50;//Con esta variable indicamos la posicion en que quedar en relacon horizontal
            Nombre = Nombre.ToUpper();//Transformar de minusculas a mayusculas

            for (Inicio = Nombre.Length; Inicio >= 1; Inicio--)//controla los caracteres que se van imprimiendo
            {
                Caracter = Mid(Nombre, Inicio - 1, 1);//Enviandole parametros a la funcion


                for (Movimiento = tamCadena; Movimiento <= Limite; Movimiento++)//Este ciclo controla las posiciones donde se imprime cada letra
                {
                    Console.SetCursorPosition(Movimiento, 12);//Ubica la impresion en un area determinada(vertical)
                    Console.Write(" " + Caracter);//IMprime las letras
                    System.Threading.Thread.Sleep(25);//Controla la velociad del desplazamiento

                }

                Limite--; // al Limite se le resta
                tamCadena--;// al tamCadena se le resta
            }

            Console.WriteLine();

        }
    }
}
