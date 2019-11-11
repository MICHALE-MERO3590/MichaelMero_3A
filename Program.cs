using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tarea3_Poo.clases;

namespace Tarea3_Poo
{
    class Program
    {
        public static void Main(string[] args)
        {
            cliente clientito = new cliente();
                gasolina gasolinita = new gasolina();

            Console.Write("Ingrese el nombre del cliente: ");
                clientito.Nombre = Console.ReadLine();
            Console.Write("Ingrese el apellidos del cliente: ");
                clientito.Apellidos = Console.ReadLine();
            Console.Write("Ingrese el numero de identificacion: ");
                clientito.Id = Console.ReadLine();
            Console.Write("Ingrese la direccion: ");
                clientito.Direccion = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Ingrese el tipo de gasolina: ");
            string abc = Console.ReadLine();

            if (abc == "extra" || abc == "super")
            {
                gasolinita.Tipo = abc;
            }

            else
            {
                Console.WriteLine("Tipo de gasolina no valida");
                    gasolinita.Tipo = Console.ReadLine();
            }
           
            Console.Write("Ingrese cantidad de galones: ");
            gasolinita.CantidadDeGalones = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("\t"+"  FACTURA  " + "\n");
            Console.WriteLine(  "  Nombres y Apellidos: " + clientito.Nombre + " " + clientito.Apellidos + "\n" +
                                "   Numero de cedula: " + clientito.Id + "\n" +
                                "   Direccion del cliente: " + clientito.Direccion + "\n");

            Console.WriteLine("     Valor de gasolina: $" + gasolinita.PrecioDeVenta);

            Console.WriteLine("     Subtotal a pagar: $" + gasolinita.SubTotal);
                Console.WriteLine("      Iva a pagar: $" + gasolinita.Iva);
                    Console.WriteLine("     Total a pagar: $" + gasolinita.Total);
            Console.ReadKey();
        }
    }
}
