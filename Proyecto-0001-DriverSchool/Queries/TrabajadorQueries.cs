using Microsoft.EntityFrameworkCore;
using Proyecto_0001_DriverSchool.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_0001_DriverSchool.Queries
{
    public class TrabajadorQueries : ITrabajadorQueries
    {

        private readonly ApplicationDbContext _context;

        public TrabajadorQueries(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ListarTrabajadorResponse>> ListarTrabajador()
        {

            var trabajadores = await (from t in _context.Trabajador join u in _context.Usuario on t.Id equals u.IdTrabajador select new {t,u}).ToListAsync();

            var response = trabajadores.Select(x => new ListarTrabajadorResponse
            {
                Id = x.t.Id,
                Puesto = x.t.Puesto,
                Salario = x.t.Salario,
                Nombre = x.t.Nombre,
                Edad = x.t.Edad,
                NombreUsuario = x.u.NombreUsuario,
                Contraseña = x.u.Contraseña,
                FechaCreacion = x.t.FechaCreacion,
                FechaModificacion = x.t.FechaModificacion,
                EsEliminado = x.t.EsEliminado,
            });

            return response;
        }

        public async Task<ListarTrabajadorResponse> ObtenerTrabajador(ObtenerTrabajadorRequest request)
        {

            var trabajadores = await (from t in _context.Trabajador join u in _context.Usuario on t.Id equals u.IdTrabajador select new { t, u }).ToListAsync();

            if (!string.IsNullOrEmpty(request.Nombre))
            {
                trabajadores = trabajadores.Where(x => x.t.Nombre.Contains(request.Nombre)).ToList();
            }

            if (!string.IsNullOrEmpty(request.Puesto))
            {
                trabajadores = trabajadores.Where(x => x.t.Nombre.Contains(request.Puesto)).ToList();
            }

            var response = trabajadores.Select(x => new ListarTrabajadorResponse
            {
                Id = x.t.Id,
                Puesto = x.t.Puesto,
                Salario = x.t.Salario,
                Nombre = x.t.Nombre,
                Edad = x.t.Edad,
                NombreUsuario = x.u.NombreUsuario,
                Contraseña = x.u.Contraseña,
                FechaCreacion = x.t.FechaCreacion,
                FechaModificacion = x.t.FechaModificacion,
                EsEliminado = x.t.EsEliminado,
            }).FirstOrDefault();

            return response;
        }

        public async Task<List<ListarEvaluacionesResponse>> ListarEvaluaciones(ListarEvaluacionesRequest request)
        {

            var evaluaciones = await (from t in _context.Trabajador join e in _context.Evaluaciones on t.Id equals e.IdTrabajador select new { t, e }).ToListAsync();

            if (!string.IsNullOrEmpty(request.NombreEvaluacion))
            {
                evaluaciones = evaluaciones.Where(x => x.e.NombreEvaluacion.Contains(request.NombreEvaluacion)).ToList();
            }

            if (request.TipoEvaluacion.HasValue)
            {
                evaluaciones = evaluaciones.Where(x => x.e.TipoEvaluacion == request.TipoEvaluacion).ToList();
            }

            var response = evaluaciones.Select(x => new ListarEvaluacionesResponse
            {
                IdTrabajador = x.t.Id,
                IdEvaluacion = x.e.Id,
                NombreEvaluacion = x.e.NombreEvaluacion,
                FechaEvaluacion = x.e.FechaEvaluacion,
                TipoEvaluacion = x.e.TipoEvaluacion,
                FechaCreacion = x.e.FechaCreacion,
                FechaModificacion = x.e.FechaModificacion,
                EsEliminado = x.e.EsEliminado,
            }).ToList();

            return response;
        }
        public async Task<ObtenerEvaluacionResponse> ObtenerEvaluacion(ObtenerEvaluacionRequest request)
        {

            var evaluaciones = await (from t in _context.Trabajador join e in _context.Evaluaciones on t.Id equals e.IdTrabajador select new { t, e }).ToListAsync();

            var response = evaluaciones.Select(x => new ObtenerEvaluacionResponse
            {
                IdTrabajador = x.t.Id,
                IdEvaluacion = x.e.Id,
                NombreEvaluacion = x.e.NombreEvaluacion,
                FechaEvaluacion = x.e.FechaEvaluacion,
                TipoEvaluacion = x.e.TipoEvaluacion,
                FechaCreacion = x.e.FechaCreacion,
                FechaModificacion = x.e.FechaModificacion,
                EsEliminado = x.e.EsEliminado,
            }).FirstOrDefault();

            return response;
        }
    }
}
