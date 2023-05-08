using System;
using System.Collections.Generic;

namespace LibraryEntityFramework;

public partial class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? AuthorId { get; set; }

    public int? PublisherId { get; set; }

    public decimal? Price { get; set; }

    public string? Info { get; set; }

    public virtual Author? Author { get; set; }

    public virtual ICollection<IssuanceBook> IssuanceBooks { get; set; } = new List<IssuanceBook>();

    public virtual Publisher? Publisher { get; set; }
}
