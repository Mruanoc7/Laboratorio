using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.CLASES
{
    public class EMPLEADO
    {
        private int v1;
        private string v2;
        private string v3;
        private int v4;
        private string v5;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Edad { get; set; }
        public string Cargo { get; set; }

        public decimal Sueldo { get; set; }


        public EMPLEADO(int id, string nombre, string apellido, int edad, string cargo, decimal sueldo)
        {
            Id = id;
            Nombre = nombre;
            this.Apellido = apellido;
            Edad = edad;
            Cargo = cargo;
            Sueldo = sueldo;
        }

        public EMPLEADO(int v1, string v2, string v3, int v4, string v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public override string ToString()
        {
            return $"Id: {Id} Nombre: {Nombre} Apellido: {Apellido} Edad: {Edad} Cargo: {Cargo} Sueldo: {Sueldo}";
        }
    }
}
