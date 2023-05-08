using System;
using System.Collections.Generic;

namespace LibraryEntityFramework;

public partial class BookInfo
{
    public string НазваниеКниги { get; set; } = null!;

    public string Имя { get; set; } = null!;

    public string? Отчество { get; set; }

    public string Фамилия { get; set; } = null!;

    public string Издатель { get; set; } = null!;

    public decimal? Цена { get; set; }
}
