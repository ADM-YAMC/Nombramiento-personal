using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Buscadores
{
    class Buscador
    {

        dynamic data;
        public string buscador(string empleado)
        {
            if (!empleado.Equals("") || !empleado.Equals(""))
            {

                try
                {
                    string rutaArchivo = "LogRegistro.txt";
                    List<string> nuevosRegistros = new List<string>();
                    foreach (string item in File.ReadAllLines(rutaArchivo, Encoding.Default))
                    {
                        if (item.Contains(empleado))
                        {
                            nuevosRegistros.Add(item);
                        }
                    }
                    foreach (string item in nuevosRegistros)
                    {
                        data = item;
                    }
                    if (data == null)
                    {
                        return "false";
                    }
                    else
                    {
                        return data;
                    }

                }
                catch (FileNotFoundException e)
                {
                    return "false";
                }
            }
            else
            {
                return "false";
            }

        }
    }
}
