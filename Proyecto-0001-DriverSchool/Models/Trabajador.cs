using System;

namespace Proyecto_0001_DriverSchool.Models
{
    public class Trabajador
    {
        public int Id { get; set; }
        public string Puesto { get; set; }
        public decimal Salario { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool EsEliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Trabajador()
        {

        }

        public Trabajador(int id, string puesto, decimal salario, string nombre, int edad)
        {
            Id = id;
            Puesto = puesto;
            Salario = salario;
            Nombre = nombre;
            Edad = edad;
            EsEliminado = false;
        }


    }


}
