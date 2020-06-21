using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_de_10_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int b = 0,c;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escriba un numero para sacar su media (" + (i + 1) + "/10)");
                a[i] = Convert.ToInt32(Console.ReadLine());
                b += a[i];
            }
            c = b / 10;
            Console.WriteLine("La media de estos numeros es: "+ c);
            Console.WriteLine("Los numeros superiores a media son: ");
            for (int i = 0; i < 10; i++)
            {
               if (a[i] > c )
               {
                    Console.Write(a[i]+" , ");
               }
            }

        }
    }
}
