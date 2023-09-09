using System;
using System.Collections.Generic;

namespace KlinikaWeterynaryjna.Models2;

public partial class Pracownik
{
    public int IdPracownika { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public string? Email { get; set; }

    public DateTime? DataUrodzenia { get; set; }
}
