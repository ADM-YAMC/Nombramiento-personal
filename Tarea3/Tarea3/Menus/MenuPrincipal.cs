using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Facade;
using Tarea3.Factory;
using Tarea3.Buscadores;
namespace Tarea3.Menus
{
    class MenuPrincipal
    {
        TiposEmpleado tiposEmpleado;
        string opcion;
        public void Menu()
        {
            opcion = "0";
            do
            {
                Console.WriteLine("Bienvenido\n\nSelecione el tipo de empleado que quiere nombrar" +
                    "\n\n1.-Empleado de tiempo completo" +
                    "\n2.-Empleado de medio tiempo" +
                    "\n3.-Empleado temporero" +
                    "\n\nOtras opereraciones ---------------------\n" +
                    "\n4.-Buscar un empleado" +
                    "\n5.-Ver todos los registrados" +
                    "\n6.-Bienestar laboral" +
                    "\n7.-Ver todo el personal desvinculado" +
                    "\n0.-Salir");

                opcion = Console.ReadLine();

                if (opcion == "1" || opcion == "2" || opcion == "3")
                {
                    Console.Clear();
                    tiposEmpleado = Fabrica.Creador(opcion);
                    tiposEmpleado.TipoEmpleado();
                }
                else
                {
                    switch (opcion)
                    {
                        case "4":
                            Console.Clear();
                            BuscarUnEmpleado buscador = new BuscarUnEmpleado();
                            buscador.buscar();
                            break;
                        case "5":
                            Console.Clear();
                            VerDatos verDatos = new VerDatos();
                            verDatos.Ver();
                            break;
                        case "6":
                            Console.Clear();
                            MenuBienestalLaboral menuBienestalLaboral = new MenuBienestalLaboral();
                            menuBienestalLaboral.menu();
                            break;
                        case "7":
                            Console.Clear();
                            VerDesvinculados verDesvinculados = new VerDesvinculados();
                            verDesvinculados.Ver();
                            break;
                        default:
                            break;
                    }

                }
            } while (opcion != "0");
        }
    }
}
