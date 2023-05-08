using System;
using System.Collections.Generic;

namespace LibraryEntityFramework;

public partial class IssuanceBook
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int ReaderId { get; set; }

    public DateTime DateBegin { get; set; }

    public DateTime? DateEnd { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Reader Reader { get; set; } = null!;
}
