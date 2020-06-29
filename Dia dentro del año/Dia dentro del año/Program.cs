using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_dentro_del_año
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int b,c,f = 0;
            Console.WriteLine("ingrese el numero del mes ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el dia de ese mes ");
            c = Convert.ToInt32(Console.ReadLine());
 
            if (a[b]>=c)
            {
                for (int i = 0; i < b; i++)
                {
                    f += a[i];  
                }
                f += c;
                
                Console.WriteLine("El dia del año es: "+f);
            }
            else
            {
                Console.WriteLine("El mes ingresado no tiene tantos dias");
            }
            Console.ReadKey();
        }
    }
}
