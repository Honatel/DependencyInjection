namespace DependencyInjection.Models
{
    public class CPF
    {
        public string Documento { get; set; }

        public bool Validar()
        {
            return Documento.Length == 11;
        }
    }
}