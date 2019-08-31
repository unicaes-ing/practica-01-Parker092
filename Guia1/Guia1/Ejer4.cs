using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    class Ejer4
    {
        public void ejerCuatro()
        {
            int num;
            do
            {
                Console.Write("Ingrese un numero entero positivo: ");
                num = Convert.ToInt32(Console.ReadLine()); 
            } while (num<=0);
            Console.WriteLine("Raiz Cuadrada de "+num+" es: "+ Math.Sqrt(num));
            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}
