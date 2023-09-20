using Microsoft.AspNetCore.Mvc;
using Proyecto_0001_DriverSchool.Command.Trabajador;
using Proyecto_0001_DriverSchool.Queries;
using Proyecto_0001_DriverSchool.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Proyecto_0001_DriverSchool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrabajadorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ITrabajadorQueries _trabajadorQueries;
        private readonly ITrabajadorCommand _trabajadorCommand;

        public TrabajadorController(ApplicationDbContext context, ITrabajadorQueries trabajadorQueries, ITrabajadorCommand trabajadorCommand)
        {
            _context = context;
            _trabajadorQueries = trabajadorQueries;
            _trabajadorCommand = trabajadorCommand;
        }


        [HttpGet]
        [Route("listarTrabajador")]
        public async Task<ActionResult<IEnumerable<ListarTrabajadorResponse>>> ListarTrabajador()
        {
            var response = await _trabajadorQueries.ListarTrabajador();
            return Ok(response);
        }

        [HttpGet]
        [Route("obtenerTrabajador")]
        public async Task<ActionResult<ListarTrabajadorResponse>> ObtenerTrabajador([FromQuery] ObtenerTrabajadorRequest request)
        {
            var result = await _trabajadorQueries.ObtenerTrabajador(request);
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("listarEvaluaciones")]
        public async Task<ActionResult<List<ListarEvaluacionesResponse>>> ListarEvaluaciones([FromQuery] ListarEvaluacionesRequest request)
        {
            var result = await _trabajadorQueries.ListarEvaluaciones(request);
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("obtenerEvaluacion")]
        public async Task<ActionResult<ObtenerEvaluacionResponse>> ObtenerEvaluacion([FromQuery] ObtenerEvaluacionRequest request)
        {
            var result = await _trabajadorQueries.ObtenerEvaluacion(request);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("guardarTrabajador")]
        public async Task<ActionResult<GuardarTrabajadorResponse>> GuardarTrabajador([FromQuery] GuardarTrabajadorRequest request)
        {
            var result = await _trabajadorCommand.GuardarTrabajador(request);
            return new JsonResult(result);
        }
    }
}
