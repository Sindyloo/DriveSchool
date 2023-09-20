using System;

namespace Proyecto_0001_DriverSchool.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdTrabajador { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public bool EsEliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }


    }

}
