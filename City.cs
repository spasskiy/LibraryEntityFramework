using System;
using System.Collections.Generic;

namespace LibraryEntityFramework;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Publisher> Publishers { get; set; } = new List<Publisher>();

    public virtual ICollection<Reader> Readers { get; set; } = new List<Reader>();
}
