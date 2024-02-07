using System.ComponentModel.DataAnnotations;

namespace greenTea.Models
{
    public class ContatoViewModel
    {
        [Required(ErrorMessage = "Favor digitar um nome válido.")]

        [MinLength(3, ErrorMessage = "Nome deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email obrigatório!")]
        [EmailAddress(ErrorMessage = "Favor digitar um Email válido.")]

        public string Email { get; set; }

        public string Assunto { get; set; }

        [Required(ErrorMessage = "Favor digitar sua mensagem.")]
        [MinLength(10, ErrorMessage = "Nome deve ter no mínimo 10 caracteres.")]
        public string Mensagem { get; set; }

    }
}
