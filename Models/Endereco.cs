using System.ComponentModel.DataAnnotations;

namespace CadastroAlunos.Models
{
    public class Endereco
    {
        [Required(ErrorMessage = "O CEP é obrigatório.")]
        public string Cep { get; set; } = string.Empty;

        public string Logradouro { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}
