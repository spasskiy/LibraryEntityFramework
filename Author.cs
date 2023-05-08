using System;
using System.Collections.Generic;

namespace LibraryEntityFramework;

public partial class Author
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? CountryId { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual Country? Country { get; set; }
}
