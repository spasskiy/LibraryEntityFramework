using System;
using System.Collections.Generic;

namespace LibraryEntityFramework;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Capital { get; set; }

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<Publisher> Publishers { get; set; } = new List<Publisher>();
}
