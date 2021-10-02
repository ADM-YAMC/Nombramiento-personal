using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Sistema
{
    class ManejoDataSistema
    {
        public void sistema(string data)
        {
            string path = "ManejoDataSistema.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(data);
                    sw.Close();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nLos datos se guardaron con exito! \n\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                try
                {
                    StreamReader sr = new StreamReader("ManejoDataSistema.txt");
                    var leer = sr.ReadToEnd();
                    sr.Close();
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(leer);
                        sw.WriteLine(data);
                        sw.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nError al guardar los datos! \n\n" +e);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }
        }
    }
}
