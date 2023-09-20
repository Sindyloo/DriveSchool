using System;

namespace Proyecto_0001_DriverSchool.ViewModel
{
    public class ListarTrabajadorResponse
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Puesto { get; set; }
        public decimal Salario { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool EsEliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string NombreUsuario { get; internal set; }
        public string Contraseña { get; internal set; }
    }
    public class ObtenerTrabajadorRequest
    {
        public string? Nombre { get; set; }
        public string? Puesto { get; set; }
    }

    public class GuardarTrabajadorRequest
    {
        public int? Id { get; set; }
        public string Puesto { get; set; }
        public decimal Salario { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool EsEliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
    public class GuardarTrabajadorResponse
    {
        public int Id { get; set; }

    }

    public class ListarEvaluacionesResponse
    {
        public int IdEvaluacion { get; set; }
        public int IdTrabajador { get; set; }
        public int TipoEvaluacion { get; set; }
        public string NombreEvaluacion { get; set; }
        public DateTime? FechaEvaluacion { get; set; }
        public string Resultado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool EsEliminado { get; set; }
    }
    public class ListarEvaluacionesRequest
    {
        public int? TipoEvaluacion { get; set; }
        public string NombreEvaluacion { get; set; }
    }

    public class ObtenerEvaluacionResponse
    {
        public int IdEvaluacion { get; set; }
        public int IdTrabajador { get; set; }
        public int TipoEvaluacion { get; set; }
        public string NombreEvaluacion { get; set; }
        public DateTime? FechaEvaluacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool EsEliminado { get; set; }
    }
    public class ObtenerEvaluacionRequest
    {
        public int IdEvaluacion { get; set; }
        public int IdTrabajador { get; set; }
    }
}
