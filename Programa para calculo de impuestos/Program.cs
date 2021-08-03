using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_para_calculo_de_impuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite productos a adquirieron");

            Console.WriteLine("1- Coca~Cola");
            Console.WriteLine("2- libra de azucar");
            Console.WriteLine("3- Carne");
            Console.WriteLine("4- Aspirina");

            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Coca~Cola su impuestos son = 12%");
                Console.WriteLine("Precio de la Coca~Cola $ 1.90 + impuestos");

                double b = 1.90 * 0.12;
                double x = b + 1.90;
                Console.WriteLine("El precio de la Coca~Cola es:" + x);
            }

            else if (a == 2)
            {
                Console.WriteLine("libra de azucar su impuestos son = 12%");
                Console.WriteLine("Precio de la azucar $ 0.57 + impuestos");

                double b = 0.57 * 0.12;
                double x = b + 0.57;
                Console.WriteLine("El precio de la azucar es:" + x);
            }

            else if (a == 3)
            {
                Console.WriteLine("Carne su impuestos son = 12%");
                Console.WriteLine("Precio de carne $ 4.75 + impuestos");

                double b = 4.75 * 0.12;
                double x = b + 4.75;
                Console.WriteLine("El precio de la carne es:" + x);
            }

            else if (a == 4)
            {
                Console.WriteLine("Aspirina su impuestos son = 0%");
                Console.WriteLine("Precio de la aspirina $ 1.99 + impuestos");

                double b = 1.99 * 0.0;
                double x = b + 1.99;
                Console.WriteLine("El precio de la aspirina es:" + x);
            }



            Console.ReadKey();
        }
    }
}
