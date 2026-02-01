using System.ComponentModel.DataAnnotations;

namespace WebBibi.Models
{
    public class ValidadorModelo
    {
        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O celular é obrigatório.")]
        [RegularExpression(@"^\(?\d{2}\)?[\s-]?9?\d{4}[\s-]?\d{4}$",
            ErrorMessage = "Formato inválido. Use (XX) 9XXXX-XXXX.")]
        public string Celular { get; set; }
        public string Nome { get; set; }
    }
}
