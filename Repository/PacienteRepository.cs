using DependencyInjection.Data;
using DependencyInjection.Models;
using DependencyInjection.Repository.interfaces;

namespace DependencyInjection.Repository
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly DataContext _context;

        public PacienteRepository(DataContext context)
        {
            this._context = context;
        }
        public void Create(Paciente entity)
        {
            _context.Add(entity);
        }
    }
}