using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    class Ejer5
    {
        public void ejerCinco()
        {
            int ventas, ventas1, ventas2;
            double promedio;

            Console.Write("Ingrese total de ventas de Trimestre 1:");
            ventas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese total de ventas de Trimestre 2:");
            ventas1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese total de ventas de Trimestre 3:");
            ventas2 = Convert.ToInt32(Console.ReadLine());

            promedio = (ventas + ventas1 + ventas2) / 3;

            Console.WriteLine("Promedio de ventas: "+promedio);
            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();

        }
    }
}
