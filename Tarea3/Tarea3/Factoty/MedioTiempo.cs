using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Menus;
using Tarea3.Sistema;
namespace Tarea3.Factory
{
    class MedioTiempo : TiposEmpleado
    {
        public string TipoCuenta { get; set; }
        public string horas { get; set; }
        public override void TipoEmpleado()
        {
            string opcion = "0";
            do
            {
                Console.WriteLine("Bienvenido\n\nEmpleado de medio tiempo\n\nSelecione una opcion" +
                    "\n\n1.-Crear" +
                    "\n2.-Ir al menu principal" +
                    "\n0.-Salir del sistema");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Crear();
                        break;
                    case "2":
                        Console.Clear();
                        MenuPrincipal menuPrincipal = new MenuPrincipal();
                        menuPrincipal.Menu();
                        break;
                    default:
                        break;
                }

            } while (opcion != "0");
        }

        void Crear()
        {
            Empleado empleado = new Empleado();
            Imprecion imprecion = new Imprecion();
            Console.WriteLine("Escriba la cedula del empleado:");
            empleado.CedulaEmpleado = Console.ReadLine();
            Console.WriteLine("Escriba el nombre del empleado:");
            empleado.NombreEmpleado = Console.ReadLine();
            Console.WriteLine("Nombre del departamento:");
            empleado.Departamento = Console.ReadLine();
            Console.WriteLine("Cargo del empleado:");
            empleado.Cargo = Console.ReadLine();
            Console.WriteLine("Salario del emleado:");
            empleado.Salario = Console.ReadLine();
            Console.WriteLine("Precio por hora:");
            empleado.PrecioPorHora = Console.ReadLine();
            Console.WriteLine("Numero de cuenta del empleado:");
            empleado.Cuenta = Console.ReadLine();
            empleado.CantidadHorasTrabajadas = "4 horas";
            empleado.CreacionEmpleado = "" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToString("hh:mm:ss") + "";
            TipoCuenta = "Cuenta bancaria";

            imprecion.imprimir(empleado, TipoCuenta,empleado.Cuenta, "Medio tiempo");
        }
    }
}
