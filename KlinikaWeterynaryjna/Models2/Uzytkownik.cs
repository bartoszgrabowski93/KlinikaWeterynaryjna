using System;
using System.Collections.Generic;

namespace KlinikaWeterynaryjna.Models2;

public partial class Uzytkownik
{
    public int IdUzytkownik { get; set; }

    public string Login { get; set; } = null!;

    public string Haslo { get; set; } = null!;

    public string? Rola { get; set; }
}
