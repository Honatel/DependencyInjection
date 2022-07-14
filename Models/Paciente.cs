using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Paciente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Email Email { get; set; }

        public CPF Cpf { get; set; }

        public bool Validar()
        {
            return Email.Valida() && Cpf.Validar();
        }
    }
}