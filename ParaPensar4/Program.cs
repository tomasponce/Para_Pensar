using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensar4
{
    class Program
    {
        static void Main(string[] args)
        { int[] arreglo;
            arreglo = new int[99];

            int c = 1;
            int[] arreglo2;
            arreglo2 = new int[49];
            for (int i = 0; i < 99; i++)
            {
                arreglo[i] = i+1;}

                for (int i = 0; i < 49;  i ++)
            {
                arreglo2[i] = arreglo[c];
          
                c =c+2;
                Console.WriteLine(arreglo2[i]);
              

                                                          }
                Console.ReadLine();
        }
    }
}
