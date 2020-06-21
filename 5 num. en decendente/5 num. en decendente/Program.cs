using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_num.en_decendente
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] a = new float[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Escriba un numero (" + (i + 1) + "/5)");
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("\nNumeros en el orden contrario al que se introdujeron: ");
            for (int i = 4; i >= 0; i--)
            {

                Console.Write( a[i]+ " ");
            }
        }
    }
}
