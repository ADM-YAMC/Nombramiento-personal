using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Buscadores
{
    class BuscarUnEmpleado
    {
        public void buscar()
        {
            Buscador buscador = new Buscador();
            Console.WriteLine("Escriba la cedula del empleado que quiere buscar: ");
            string empleado = Console.ReadLine();
            var gf = buscador.buscador(empleado);
            if (gf!= "false")
            {
                string[] partes = gf.Split(new char[] { '-' });
                Console.WriteLine("");
                foreach (string item in partes)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("" + item);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEl empleado no fue encontrado!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nPulse enter para volver atras");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();

        }
    }
}
