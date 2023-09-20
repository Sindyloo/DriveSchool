using System;

namespace Proyecto_0001_DriverSchool.Models
{
    public class Evaluaciones
    {
        public int Id { get; set; }
        public int IdTrabajador { get; set; }
        public int TipoEvaluacion { get; set; }
        public DateTime? FechaEvaluacion { get; set; }
        public string Resultado { get; set; }
        public string NombreEvaluacion { get; set; }   
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool EsEliminado { get; set; }

        public Evaluaciones() { }
    }
}
