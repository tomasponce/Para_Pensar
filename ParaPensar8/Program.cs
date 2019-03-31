using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensar8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba una clave, luego tendra 3 intentos para colocarla otra vez");
            string a = Console.ReadLine();
            int clave = int.Parse(a);
            int intento = 1;
            int reingreso= 0;
            while( (intento <4) && (reingreso != clave) )
            {
                Console.WriteLine("Intento numero " + intento);
                a = Console.ReadLine();
                reingreso = int.Parse(a);
                intento = intento + 1;
                

            }
             if( reingreso==clave)
            { Console.WriteLine("Clave correcta, bien hecho."); }
             else
            { Console.WriteLine(" Ya realizo los 3 intentos y no reingreso la clave correctamente, lo lamentamos mucho."); }
        }
    }
}
