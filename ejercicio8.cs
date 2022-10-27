using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int DL, M, PM;
            DL = 0;
            M = 0;
            PM = 0;
            Console.WriteLine("MULTA DE LOS LIBROS");
            Console.WriteLine("DIAS QUE SE QUEDO CON EL LIBRO");
            DL = int.Parse(Console.ReadLine());

            if (DL >= 5)
            {
                DL = M;
                M = 100;

            }
            else
                if (DL >= 3)
                {
                    DL = M;
                    M = 50;

                }
            else
                    if (DL <= 2 && DL >= 1)
                    {
                        Console.WriteLine("No aplica multa");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (DL < 1)
                        {
                            Console.WriteLine("Verifique el numero que dias indico");
                        }
                    }
            Console.WriteLine("la multa que recibira sera de: "+ M);
            Console.ReadKey();

       
        }
    }
}
