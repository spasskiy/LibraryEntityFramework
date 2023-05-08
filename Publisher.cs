using System;
using System.Collections.Generic;

namespace LibraryEntityFramework;

public partial class Publisher
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? CountryId { get; set; }

    public int? CityId { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual City? City { get; set; }

    public virtual Country? Country { get; set; }
}
