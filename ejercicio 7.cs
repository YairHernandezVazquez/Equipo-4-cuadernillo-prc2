using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double refrescos, precio;
            Console.WriteLine("Introduce la cantidad de refrescos");
            refrescos = double.Parse(Console.ReadLine());
            if (refrescos < 5 && refrescos > 0)
            {
                precio = refrescos * 15;
            }
            else
            {
                precio = refrescos * 15 - 10;
            }
            Console.WriteLine("El precio a pagar es: ");
            Console.WriteLine(precio);
            Console.ReadKey();


        }
    }
}
