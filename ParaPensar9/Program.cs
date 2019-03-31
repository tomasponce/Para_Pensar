using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensar9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de filas que desea que tenga la piramide");
           
            string a = Console.ReadLine();
            int filas = int.Parse(a);
            for (int i = 0; i < filas; i++)
            {
                {
                    for (int j = 0; j < filas-i; j++)
                   
                    {
                        Console.Write(" ");
                    }
                        for (int k = 0; k < (2 * i + 1); k++)
                    {
                      

                        
                        Console.Write("A");


                    }

                }

                Console.WriteLine();

            }



        }
    }
}
