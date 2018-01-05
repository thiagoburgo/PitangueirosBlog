using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.Blog.App.Entities
{
    public class UsuarioInputDto
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        [Compare(nameof(Senha), ErrorMessage = "A senha e a confirmação são diferentes.")]
        [Display(Name = "Confirmação de Senha")]

        public string ConfirmacaoSenha { get; set; }


        [Required]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
