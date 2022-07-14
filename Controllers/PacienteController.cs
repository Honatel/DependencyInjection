using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Services.Interfaces;

namespace DependencyInjection.Controllers
{
    public class PacienteController
    {
        private readonly IPacienteService _pacienteService;
        public PacienteController(IPacienteService pacienteService)
        {
            this._pacienteService = pacienteService;
        }
        public void Post(Paciente entity)
        {
            _pacienteService.Create(entity);
        }
    }
}