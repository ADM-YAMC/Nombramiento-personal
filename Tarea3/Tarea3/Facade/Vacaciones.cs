using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Singleton;
using Tarea3.Buscadores;
namespace Tarea3.Facade
{
    class Vacaciones
    {
        public string inicio { get; set; }
        public string final { get; set; }
        public void vacaciones()
        {
            DataBusqueda dataBusqueda = new DataBusqueda();
           var dta = dataBusqueda.buscar();

            Console.WriteLine("\nPulsa enter para continuar...\n");
            Console.ReadKey();
            if (dta != "false")
            {
                Console.WriteLine("Formulario de vacaciones\n" +
                    "----------------------------------------------------------------------\n");
                Console.WriteLine("Ingrese la fecha de inicio de las vacaciones del empleado:");
                inicio = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de finalizacion de las vacaciones del empleado:");
                final = Console.ReadLine();

                string data = ""+dta+"" +
                          "-VACACIONES" +
                          "-Fecha de inicio de las vacaciones: " + inicio + "" +
                          "-Fecha de finalizacion de las vacaciones: " + final + "";
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
