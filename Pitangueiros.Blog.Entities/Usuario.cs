namespace Pitangueiros.Blog.Domain.Entities {
    public class Usuario : EntidadeBase {
        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }
    }
}