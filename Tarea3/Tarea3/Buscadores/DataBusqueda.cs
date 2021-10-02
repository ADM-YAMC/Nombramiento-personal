using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Buscadores
{
    class DataBusqueda
    {
        public string empleado { get; set; }
        public string cedula { get; set; }
        public string buscar()
        {
            Buscador buscador = new Buscador();
            Console.WriteLine("Escriba la cedula del empleado que quiere buscar: ");
            cedula = Console.ReadLine();
            if (cedula.Length==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo digito el numero de cedula!!!");
                Console.ForegroundColor = ConsoleColor.White;
                return "false";
            }
            else
            {
                Cedula();
                Console.WriteLine("");
                var dta = buscador.buscador(cedula);
                if (dta == "false")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEl usuario no existe!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return "false";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string[] partes = dta.Split(new char[] {'-'});
                    foreach (string item in partes)
                    {
                        Console.WriteLine("" + item);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    return dta;
                }
            }

        }
        public string Cedula()
        {
            return cedula;
        }
    }
}
