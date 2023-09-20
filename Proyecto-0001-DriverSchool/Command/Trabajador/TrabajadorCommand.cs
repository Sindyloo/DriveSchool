using Proyecto_0001_DriverSchool.Models;
using Proyecto_0001_DriverSchool.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_0001_DriverSchool.Command.Trabajador
{
    public class TrabajadorCommand : ITrabajadorCommand
    {
        private readonly ApplicationDbContext _context;
        public TrabajadorCommand(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<GuardarTrabajadorResponse> GuardarTrabajador(GuardarTrabajadorRequest request)
        {
            var trabajador = new Proyecto_0001_DriverSchool.Models.Trabajador();

            if (request.Id == null)
            {
                trabajador =  new Proyecto_0001_DriverSchool.Models.Trabajador
                {
                    Nombre = request.Nombre,
                    Puesto = request.Puesto,
                    Salario = request.Salario,
                    Edad = request.Edad,
                    FechaCreacion = request.FechaCreacion

                };

                _context.Trabajador.Add(trabajador); 

                await _context.SaveChangesAsync();

            }


            return new GuardarTrabajadorResponse { Id = trabajador.Id };
        }
    }
}
