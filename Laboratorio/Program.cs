using Laboratorio.CLASES;
using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
   
        string Path = "C:\\Users\\Mynor Ruano\\source\\repos\\Laboratorio\\Empleados4.db";
        GestorEmpleados gestorEmpleados = new GestorEmpleados(Path);


        gestorEmpleados.CrearTabla();


        gestorEmpleados.AgregarEmpleado(new EMPLEADO(1, "Juan", "Pérez", 30, "Desarrollador", 25000));
        gestorEmpleados.AgregarEmpleado(new EMPLEADO(2, "María", "López", 25, "Diseñador", 22000));
        gestorEmpleados.AgregarEmpleado(new EMPLEADO(3, "Carlos", "González", 35, "Gerente"));
        gestorEmpleados.AgregarEmpleado(new EMPLEADO(4, "Laura", "Martínez", 28, "Analista", 28000));
        gestorEmpleados.AgregarEmpleado(new EMPLEADO(5, "Pedro", "Rodríguez", 32, "Desarrollador", 25000));
        gestorEmpleados.AgregarEmpleado(new EMPLEADO(6, "Ana", "Hernández", 27, "Diseñador", 22000));
        gestorEmpleados.AgregarEmpleado(new EMPLEADO(7, "Luis", "Sánchez", 29, "Analista", 28000));
        gestorEmpleados.AgregarEmpleado(new EMPLEADO(8, "Sofía", "Gómez", 31, "Gerente", 50000));
        gestorEmpleados.AgregarEmpleado(new EMPLEADO(9, "Diego", "Luna", 33, "Desarrollador", 25000));
        gestorEmpleados.AgregarEmpleado(new EMPLEADO(10, "Isabela", "Vargas", 26, "Diseñador", 22000));

        List<EMPLEADO> empleados = gestorEmpleados.ObtenerEmpleados();


        foreach (EMPLEADO empleado in empleados)
        {
            Console.WriteLine(empleado);
        }
        gestorEmpleados.ObtenerEmpleados().ForEach(e => Console.WriteLine(e.Nombre));
    }
}
