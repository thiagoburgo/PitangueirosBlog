using System.Collections.Generic;

namespace Pitangueiros.Blog.Domain.Entities {
    public class Autor : Usuario
    {
        public string Bio { get; set; }

        public virtual IList<Postagem> Postagems { get; set; }
    }
}