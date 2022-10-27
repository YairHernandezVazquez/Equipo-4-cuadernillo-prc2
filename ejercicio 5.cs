using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_nvo
{
    class Program
    {
        static void Main(string[] args)
        {
            double cq, p;
            Console.WriteLine("Introduce la cantidad de quesos");
            cq = double.Parse(Console.ReadLine());
            if (cq <= 30 && cq > 0)
            {
                p = cq * 55;
            }
            else
            {
                p = cq * 50;
            }
            Console.WriteLine("El precio a pagar es: ");
            Console.WriteLine(p);
            Console.ReadKey();
            
        }
    }
}
