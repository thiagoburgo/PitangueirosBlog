using System;
using System.Collections.Generic;

namespace Pitangueiros.Blog.Domain.Entities {
    public class Postagem : EntidadeBase<int> {
        public Autor Autor { get; set; }

        public List<Tag> Tag { get; set; }

        public List<Comentario> Comentario { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public DateTime DataHoraCriacao { get; set; }

        public DateTime DataHoraAtualizacao { get; set; }

        
    }
}