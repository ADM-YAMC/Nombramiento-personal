using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Facade;

namespace Tarea3.Menus
{
    class MenuBienestalLaboral
    {
        string opcion;
        public void menu()
        {
            opcion = "0";
            do
            {
                Console.WriteLine("Bienestar laboral\n\nSelecione la opcion que decea para el bienestar del empleado" +
                    "\n\n1.-Vacaciones" +
                    "\n2.-Permisos" +
                    "\n3.-Desvinculaciones" +
                    "\n\nOtras opereraciones ---------------------\n" +
                    "\n4.-Ir al menu principal" +
                    "\n0.-Salir del sistema");

                opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                        Console.Clear();
                        Vacaciones vacaciones = new Vacaciones();
                        vacaciones.vacaciones();
                            break;
                        case "2":
                            Console.Clear();
                        Permisos permisos = new Permisos();
                        permisos.Permiso();
                            break;
                        case "3":
                            Console.Clear();
                            Desvinculaciones desvinculaciones = new Desvinculaciones();
                            desvinculaciones.eliminar();
                            break;
                         case "4":
                            Console.Clear();
                            MenuPrincipal menuPrincipal = new MenuPrincipal();
                            menuPrincipal.Menu();
                            break;
                    default:
                            break;
                    }
            } while (opcion != "0");
        }
    }
}
