
using Proyecto_0001_DriverSchool.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Proyecto_0001_DriverSchool.Queries
{
    public interface ITrabajadorQueries
    {
        Task<List<ListarEvaluacionesResponse>> ListarEvaluaciones(ListarEvaluacionesRequest request);
        Task<IEnumerable<ListarTrabajadorResponse>> ListarTrabajador();
        Task<ObtenerEvaluacionResponse> ObtenerEvaluacion(ObtenerEvaluacionRequest request);
        Task<ListarTrabajadorResponse> ObtenerTrabajador(ObtenerTrabajadorRequest request);
    }
}