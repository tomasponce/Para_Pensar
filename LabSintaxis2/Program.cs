using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Ingrese la cantidad de digitos que quiere que muestre de la sucesion de Fibonacci");
            /* string a = Console.ReadLine();
             string b = Console.ReadLine();
         int n1 = int.Parse(a);
         int n2 = int.Parse(b);*/
            Console.WriteLine("¿Cuantos elementos de la serie quiere sumar?");
            string l = Console.ReadLine();
            int cant = int.Parse(l);
            int a = 0;
            int temp = 0;
            int sum = 0;
            int b = 1;
            for (int i = 0; i < cant; i++)
            {
                sum += b;
                temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(a);
            }
            Console.WriteLine(sum);
            Console.ReadLine();




        }
    }
}
