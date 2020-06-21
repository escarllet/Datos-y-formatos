using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_de_4_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Escriba un numero para sacar su media ("+(i+1)+"/4)");
                a[i] = Convert.ToInt32( Console.ReadLine());
                
            }
            Console.Write("Los numeros que introdujo fueron: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(a[i]+" ");
                b += a[i];
            }
            b /=4;
            Console.WriteLine("\nLa media de los numeros es: "+ b);
        }
    }
}
