using System;
using System.Collections.Generic;

namespace LibraryEntityFramework;

public partial class Archive
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? AuthorId { get; set; }

    public int? PublisherId { get; set; }

    public decimal? Price { get; set; }

    public string? Info { get; set; }
}
