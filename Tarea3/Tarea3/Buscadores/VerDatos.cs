using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Buscadores
{
    class VerDatos
    {
        public void Ver()
        {
        try
            {
                StreamReader sr = new StreamReader("LogRegistro.txt");
                var leer = sr.ReadToEnd();

                string[] partes = leer.Split(new char[] { '-' });
                foreach (string item in partes)
                {
                    Console.WriteLine(item);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nNo tienes ningun dato guardado! \n\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pulse enter para volver atras");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();


        }
    }
}
