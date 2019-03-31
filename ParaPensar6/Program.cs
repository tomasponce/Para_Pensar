using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensar6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, unidades, decenas, centenas, mil;
            Console.WriteLine("Ingrese el numero para pasarlo a numero romano");
            string a = Console.ReadLine();
             n = int.Parse(a);
            unidades = n % 10; n = n / 10;
            decenas = n % 10; n = n / 10;
            centenas = n % 10; n = n / 10;
            mil = n % 10; n = n / 10;

         switch(mil)
            {
                case 1 :Console.Write("M");break;
                case 2: Console.Write("MM"); break;
                case 3: Console.Write("MMM"); break;

            }
            switch(centenas)
            {
                case 1: Console.Write("C"); break;
                case 2: Console.Write("CC"); break;
                case 3: Console.Write("CCC"); break;
                case 4: Console.Write("CD"); break;
                case 5: Console.Write("D"); break;
                case 6: Console.Write("DC"); break;
                case 7: Console.Write("DCC"); break;
                case 8: Console.Write("DCCC"); break;
                case 9: Console.Write("CM"); break;

            }
            switch (decenas)
            {
                case 1: Console.Write("X"); break;
                case 2: Console.Write("XX"); break;
                case 3: Console.Write("XXX"); break;
                case 4: Console.Write("XL"); break;
                case 5: Console.Write("L"); break;
                case 6: Console.Write("LX"); break;
                case 7: Console.Write("LXX"); break;
                case 8: Console.Write("LXXX"); break;
                case 9: Console.Write("XC"); break;

            }
            switch (unidades)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;

            }
            Console.WriteLine();
        }
    }
}
