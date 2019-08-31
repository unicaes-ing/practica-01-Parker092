using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    class Ejer3
    {
        public void ejerTres()
        {
            Int32 num1, num2;
            Int32 sum = 0, rest = 0, mult = 0, div = 0;
            Console.WriteLine("Ingrese numero 1: ");
            num1 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Ingrese numero 2: ");
            num2 = Convert.ToInt32(System.Console.ReadLine());
            Console.Clear();
            sum = num1 + num2;
            rest = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            Console.WriteLine("La suma de " + num1 + " + " + num2 + " = " + sum);
            Console.WriteLine("La resta de " + num1 + " - " + num2 + " = " + rest);
            Console.WriteLine("La multiplicacion de " + num1 + " * " + num2 + " = " + mult);
            Console.WriteLine("La division de " + num1 + " / " + num2 + " = " + div);

            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}
