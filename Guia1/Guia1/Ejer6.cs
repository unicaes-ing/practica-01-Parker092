using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    class Ejer6
    {
        public void ejerSeis()
        {
            String nombre;
            decimal sueldo, isss, rent, afp, total, desc;

            Console.WriteLine("Ingree su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo: ");
            sueldo = Convert.ToDecimal(Console.ReadLine());
            afp = sueldo * 0.0725M;
            isss = sueldo * 0.03M;
            if (sueldo <= 525.00M) 
            {
                Console.WriteLine("No pagas renta.");
                rent = 0M;
            } else
            {
                rent = sueldo * 0.06045M;
            }
            desc = isss + afp + rent;
            total = sueldo - desc;
            Console.WriteLine("Sueldo con descuemto (AFP, ISSS y RENTA): "+total.ToString("C2"));
            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}
