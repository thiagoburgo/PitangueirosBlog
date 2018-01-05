using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.Blog.App.Entities {
    public class AutenticacaoInputDto {
        [Required]
        [Display(Name = "Usuário")]

        public string Login { get; set; }

        [Required]
        [StringLength(maximumLength:50, ErrorMessage = "A senha não ter mais entre 6 e 50 caracteres.",
            MinimumLength = 6)]
        public string Senha { get; set; }

        [Display(Name = "Lembrar de mim")]
        public bool LembrarDeMim { get; set; }
    }
}