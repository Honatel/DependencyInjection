using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.Repository.interfaces
{
    public interface IPacienteRepository
    {
        void Create(Paciente entity);
    }
}