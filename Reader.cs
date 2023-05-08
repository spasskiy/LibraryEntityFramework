using System;
using System.Collections.Generic;

namespace LibraryEntityFramework;

public partial class Reader
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public int? CityId { get; set; }

    public string? Phone { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<IssuanceBook> IssuanceBooks { get; set; } = new List<IssuanceBook>();
}
