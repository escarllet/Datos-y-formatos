using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dias_para_acabar_el_año
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] a = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int b, c, f = 0;
            Console.WriteLine("ingrese el numero del mes ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el dia de ese mes ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a[b] >= c)
            {
                for (int i = 0; i < b; i++)
                {
                    f += a[i];
                }
                f += c;
                f =365-f;
                Console.WriteLine("Faltan: " + f+ " dias para terminar el año");
            }
            else
            {
                Console.WriteLine("El mes ingresado no tiene tantos dias");
            }
            Console.ReadKey();
        }
    }
}
