using System;
using System.Collections.Generic;

namespace KlinikaWeterynaryjna.Models2;

public partial class Uzytkownicy
{
    public int IdUzytkownicy { get; set; }

    public string? Email { get; set; }

    public string Login { get; set; } = null!;

    public string Haslo { get; set; } = null!;
}
