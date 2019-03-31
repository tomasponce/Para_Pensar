using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensar5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el mes que desee . Ej: enero, marzo, etc");
            bool band = false;
            while (band==false)
            {
                string nombre = Console.ReadLine();
                nombre = nombre.ToLower();





                switch (nombre)
                {
                    case "enero": Console.WriteLine(nombre + " 1"); band = true; break;
                    case "febrero": Console.WriteLine(nombre + " 2"); band = true; break;
                    case "marzo": Console.WriteLine(nombre + " 3"); band = true; break;
                    case "abril": Console.WriteLine(nombre + " 4"); band = true; break;

                    case "mayo": Console.WriteLine(nombre + " 5"); band = true; break;
                    case "junio": Console.WriteLine(nombre + " 6"); band = true; break;

                    case "julio": Console.WriteLine(nombre + " 7"); band = true; break;
                    case "agosto": Console.WriteLine(nombre + " 8"); band = true; break;
                    case "septiembre": Console.WriteLine(nombre + " 9"); band = true; break;
                    case "setiembre": Console.WriteLine(nombre + " 9"); band = true; break;


                    case "octubre": Console.WriteLine(nombre + " 10"); band = true; break;

                    case "noviembre": Console.WriteLine(nombre + " 11"); band = true; break;
                    case "diciembre": Console.WriteLine(nombre + " 12"); band = true; break;


                    default:
                        Console.WriteLine("Ingrese un mes valido");
                        break;
                        



                }
          


            }
          
        }
    }
}