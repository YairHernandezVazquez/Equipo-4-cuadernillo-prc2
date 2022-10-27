using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double cc, pf;
            Console.WriteLine("Introduce la cantidad de naranjas que va a comprar");
            cc = double.Parse(Console.ReadLine());
            pf = cc * 1.50;
            Console.WriteLine("El precio a pagar es: ");
            Console.WriteLine(pf);
            Console.ReadKey();

        }
    }
}
