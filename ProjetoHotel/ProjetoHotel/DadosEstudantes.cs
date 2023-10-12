using System.Globalization;

namespace ProjetoHotel
{
    public class DadosEstudantes
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }

        public DadosEstudantes(string nome, string email)
        {

            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome}, {Email}";
        }
    }
}
