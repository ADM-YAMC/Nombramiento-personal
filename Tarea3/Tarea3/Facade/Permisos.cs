using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Buscadores;
using Tarea3.Singleton;
namespace Tarea3.Facade
{
    class Permisos
    {
        public string inicio { get; set; }
        public void Permiso()
        {
            DataBusqueda dataBusqueda = new DataBusqueda();
            var dta = dataBusqueda.buscar();
            Console.WriteLine("\nPulsa enter para continuar...\n");
            Console.ReadKey();
            if (dta != "false")
            {
                Console.WriteLine("Formulario de permisos\n" +
                    "----------------------------------------------------------------------\n");
                Console.WriteLine("Ingrese la fecha del permiso:");
                inicio = Console.ReadLine();
                string data = "" + dta + "" +
                          "-PERMISO" +
                          "-Fecha de emicion del permiso: " + inicio + "";
                var d = dataBusqueda.cedula;
                SingletonBienestar.Intance.guardar(data, d,1);
                Console.WriteLine("Pulse enter para volver atras...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
