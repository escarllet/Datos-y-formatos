using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = {"lunes","martes","miercoles","jueves","sabado","domingo" };
            foreach (var item in a)
            {
                Console.Write(item+ " , ");
            }
        }
    }
}
