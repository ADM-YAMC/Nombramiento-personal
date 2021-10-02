using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Factory
{
    class Fabrica
    {
        public static TiposEmpleado Creador(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    return new TiempoCompleto();
                case "2":
                    return new MedioTiempo();
                case "3":
                    return new Temporero();
                default:
                    return null;
            }
        }
    }
}
