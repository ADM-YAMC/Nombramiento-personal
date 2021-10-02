using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Singleton
{
    class SingletonBienestar
    {
        private static SingletonBienestar intance = null;
        public string Archivo { get; set; }
        public string mensaje { get; set; }
        public string mensajedev { get; set; }

        public static SingletonBienestar Intance
        {
            get
            {
                if (intance == null)
                {
                    intance = new SingletonBienestar();
                }
                return intance;
            }
        }
        public void guardar(string data, string cedula, int opcion)
        {
            if (opcion == 1)
            {
                Archivo = "LogRegistro.txt";
                mensaje = "Los datos se guardaron con exito!";
                mensajedev = "Datos registrados hasta el momento";
            }
            else if (opcion == 0)
            {
                Archivo = "Desvinculados.txt";
                mensaje = "Los datos se eliminaron con exito!";
                mensajedev = "Personal dervinculado hasta el momento.";

            }
            using (StreamWriter fileWrite = new StreamWriter("temp.txt"))
            {
                using (StreamReader fielRead = new StreamReader("LogRegistro.txt"))
                {
                    string rutaArchivo = "LogRegistro.txt";
                    List<string> nuevosRegistros = new List<string>();
                    foreach (string item in File.ReadAllLines(rutaArchivo, Encoding.Default))
                    {
                        if (!item.Contains(cedula) || !item.Contains(""))
                        {
                            nuevosRegistros.Add(item);
                        }
                    }
                    foreach (string item in nuevosRegistros)
                    {
                        fileWrite.WriteLine(item);
                    }
                }
            }

            File.Delete("LogRegistro.txt");
            File.Move("temp.txt", "LogRegistro.txt");

            StreamReader sr = new StreamReader("LogRegistro.txt");
            var leer = sr.ReadToEnd();
            sr.Close();
            if (!File.Exists(Archivo))
            {
                using (StreamWriter sw = File.CreateText(Archivo))
                {
                    sw.WriteLine(mensajedev);
                    sw.WriteLine(data);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(Archivo))
                {
                    sw.WriteLine(leer);
                    sw.WriteLine(data);
                    sw.Close();
                }

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n" + mensaje + "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
