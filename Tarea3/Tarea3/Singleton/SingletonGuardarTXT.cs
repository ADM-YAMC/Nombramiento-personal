using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Sistema;
namespace Tarea3.Singleton
{
    class SingletonGuardarTXT
    {
        ManejoDataSistema dataSistema = new ManejoDataSistema();
        private static SingletonGuardarTXT intance = null;

        public static SingletonGuardarTXT Intance
        {
            get
            {
                if (intance == null)
                {
                    intance = new SingletonGuardarTXT();
                }
                return intance;
            }
        }
        public void guardar(string data)
        {
            string path = "LogRegistro.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Datos registrados hasta el momento");
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
                    StreamReader sr = new StreamReader("LogRegistro.txt");
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
                    Console.WriteLine("\n\nError al guardar los datos! \n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\nLos datos se guardaron con exito! \n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }
    }
}
