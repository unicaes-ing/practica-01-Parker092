using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    class Ejer1
    {
        public void ejerUno()
        {
            // variables
            String nombre, especie;
            int edad;
            //instrucciones
            System.Console.WriteLine("Ingrese el nombre de su mascota: ");
            nombre = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese la especie de " + nombre + ": ");
            especie = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese la edad de " + nombre + ": (años)");
            edad = Convert.ToInt32(System.Console.ReadLine());
            Console.Clear();
            System.Console.WriteLine("Nombre: " + nombre);
            System.Console.WriteLine("Edad: " + edad + " años");
            System.Console.WriteLine("Especie: " + especie);
            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}
