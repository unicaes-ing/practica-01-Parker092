using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    class Ejer2
    {
        public void ejerDos()
        {
            //variables
            String nombre, cargo, correo; //fecha formato
            Double sueldo;            DateTime fecha;            int edad;            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Cargo: ");
            cargo = Console.ReadLine();
            System.Console.Write("Correo: ");
            correo = Console.ReadLine();
            Console.Write("Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fecha de Contratacion: ");
            fecha = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Nombre: " + nombre);          
            Console.Write("Cargo: " + cargo);
            Console.Write("Correo: " + correo);
            Console.Write("Edad: " + edad);
            Console.Write("Fecha de Contratacion: "+fecha);

            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}
