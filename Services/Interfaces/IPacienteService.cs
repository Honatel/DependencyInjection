using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.Services.Interfaces
{
    public interface IPacienteService
    {
        void Create(Paciente entity);
    }
}