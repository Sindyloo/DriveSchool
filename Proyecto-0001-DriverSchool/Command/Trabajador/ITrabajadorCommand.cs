using Proyecto_0001_DriverSchool.ViewModel;
using System.Threading.Tasks;

namespace Proyecto_0001_DriverSchool.Command.Trabajador
{
    public interface ITrabajadorCommand
    {
        Task<GuardarTrabajadorResponse> GuardarTrabajador(GuardarTrabajadorRequest request);
    }
}