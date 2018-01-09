using System.Collections.Generic;

namespace Pitangueiros.Blog.Domain.Entities {
    public class Moderador : Usuario
    {
        public virtual IList<Postagem> PostagensModeradas { get; set; }
    }
}