using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_de_cada_mes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {31,28,31,30,31,30,31,31,30,31,30,31};
            int b;
            Console.WriteLine("ingrese el numero del mes del cual quiere saber cuantos dias tiene: ");
            b = Convert.ToInt32(Console.ReadLine());
            int c = b-1;
            Console.WriteLine("La cantidad de dias que tiene el mes "+b+" es: "+ a[c]);
            Console.ReadKey();

        }
    }
}
