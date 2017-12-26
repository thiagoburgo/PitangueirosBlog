using System;
using System.Collections.Generic;

namespace Pitangueiros.Blog.Domain.Entities {
    public abstract class EntidadeBase<TId>: IEntidadeBase<TId>
        where TId : IComparable<TId>, IEquatable<TId>
    {
        public TId Id { get; set; }
    }
}