using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasolineraTIC.Clases;

namespace GasolineraTIC
{
    class Program
    {
        static void Main(string[] args)
        {


            string consumidor="";
            Console.WriteLine("Ingrese el nombre del consumidor: "); consumidor = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de identificación del consumidor: ");string ci = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del consumidor: "); string dire = Console.ReadLine();
            
            ///Datos de la gasolina.

            Console.WriteLine("La gasolina comprada fue: ");string gas = Console.ReadLine();
            Console.WriteLine("Cantidad de gasolina "+ gas + ""); int cant = Convert.ToInt32(Console.ReadLine());

            Gasolinita gasolina = new Gasolinita(gas,cant);
            Clientito cliente = new Clientito(consumidor,ci,dire);








            Console.WriteLine("\t\t\tSistema de Facturacion PetroUleamEC");
            Console.WriteLine("\t\t============================================================");
            Console.WriteLine("\t\t\tInformación de la compra|Factura|");
            Console.WriteLine("\tConsumidor: " + cliente.Nombres);
            Console.WriteLine("\tIdentifación: " + cliente.Identificacion);
            Console.WriteLine("\tDirección: " + cliente.Direccion);
            Console.WriteLine("\t\tInformación de la compra realizada por el consumidor: " + cliente.Nombres);
            Console.WriteLine("\tTipo de gasolina que adquirió: " + gasolina.Tipo);
            Console.WriteLine("\tCantidad de Galones de gasolina tipo " + gasolina.Tipo + "que adquirió¨: " + gasolina.Galones);
            Console.WriteLine("\tSubtotal: " + gasolina.Subtotal);
            Console.WriteLine("\tIva: 12% ");
            Console.WriteLine("\tTotal: " + gasolina.Total);

            Console.WriteLine("\t\t============================================================");

            Console.ReadKey();








            }
    }
}
