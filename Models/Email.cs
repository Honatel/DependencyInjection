namespace DependencyInjection.Models
{
    public class Email
    {
        public string Endereco { get; set; }

        public bool Valida()
        {
            return Endereco.Contains("@");
        }
    }
}