using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Singleton;
namespace Tarea3.Sistema
{
    class Imprecion
    {
        public void imprimir(Empleado empleado, string tipocuenta, string numerocuenta, string tipo)
        {
            if (tipocuenta == "Cheque")
            {
                numerocuenta = "N/A";
            }
            string data = "\nCedula del empleado: " + empleado.CedulaEmpleado + "" + 
                           "-Nombre del empleado: " + empleado.NombreEmpleado + "" +
                           "-Departamento: " + empleado.Departamento + "" +
                           "-Cargo: " + empleado.Cargo + "" +
                           "-Tipo de empleado: " + tipo + "" +
                           "-Salario: " + empleado.Salario + "" +
                           "-Precio por hora: " + empleado.PrecioPorHora + "" +
                           "-Tipo de cuenta: " + tipocuenta + "" +
                           "-Numero de cuenta: " + numerocuenta + "" +
                           "-Fecha y hora de creacion: " + empleado.CreacionEmpleado + "" +
                           "-Horas diarias laborales: " + empleado.CantidadHorasTrabajadas + "";

            string Log = "\nCedula del empleado: " + empleado.CedulaEmpleado + "" +
                           "\nNombre del empleado: " + empleado.NombreEmpleado + "" +
                           "\nDepartamento: " + empleado.Departamento + "" +
                           "\nCargo: " + empleado.Cargo + "" +
                           "\nTipo de empleado: " + tipo + "" +
                           "\nSalario: " + empleado.Salario + "" +
                           "\nPrecio por hora: " + empleado.PrecioPorHora + "" +
                           "\nTipo de cuenta: " + tipocuenta + "" +
                           "\nNumero de cuenta: " + numerocuenta + "" +
                           "\nFecha y hora de creacion: " + empleado.CreacionEmpleado + "" +
                           "\nHoras diarias laborales: " + empleado.CantidadHorasTrabajadas + "";

            Console.WriteLine("Datos del registro");
            Console.WriteLine(Log);
            SingletonGuardarTXT.Intance.guardar(data);
        }
    }
}
