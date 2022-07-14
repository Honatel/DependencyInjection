using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Repository.interfaces;
using DependencyInjection.Services.Interfaces;

namespace DependencyInjection.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;
        public PacienteService(IPacienteRepository pacienteRepository)
        {
            this._pacienteRepository = pacienteRepository;
        }
        public void Create(Paciente entity)
        {
            _pacienteRepository.Create(entity);
        }
    }
}