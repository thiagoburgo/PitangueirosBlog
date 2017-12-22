using System.Collections.Generic;

namespace Pitangueiros.Blog.Domain.Entities {
    public class Postagem : EntidadeBase {
        public Autor Autor { get; set; }

        public List<Tag> Tag { get; set; }

        public List<Comentario> Comentario { get; set; }
    }
}