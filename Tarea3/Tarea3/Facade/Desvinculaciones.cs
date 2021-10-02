using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Buscadores;
using Tarea3.Singleton;
namespace Tarea3.Facade
{
    class Desvinculaciones
    {
        public string causa { get; set; }
        public void eliminar()
        {
            DataBusqueda dataBusqueda = new DataBusqueda();
            var dta = dataBusqueda.buscar();
            Console.WriteLine("\nPulsa enter para continuar...\n");
            Console.ReadKey();
            if (dta != "false")
            {
                Console.WriteLine("Formulario de desvinculacion\n" +
                    "----------------------------------------------------------------------\n");
                Console.WriteLine("Ingrese la causa de la desvinculacion:");
                causa = Console.ReadLine();
                string data = "" + dta + "" +
                          "-DESVINCULACION" +
                          "-Causa de la desvinculacion: " + causa + "" +
                          "-Fecha de desvinculacion: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToString("hh: mm: ss") + "";
                var d = dataBusqueda.cedula;
                string opcion = "n";
                do
                {
                    Console.Write("¿Quieres eliminar los datos de este empleado? (y/N): ");
                    opcion = Console.ReadLine();
                    opcion.ToLower();
                    if (opcion == "y")
                    {
                        SingletonBienestar.Intance.guardar(data, d, 0);
                        Console.WriteLine("Pulse enter para volver atras...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                   
                } while (opcion != "n");
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
