using System;
using System.Collections.Generic;

namespace KlinikaWeterynaryjna.Models2;

public partial class Wlasciciel
{
    public int IdWlasciciel { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Telefon { get; set; }

    public virtual ICollection<Zwierzetum> Zwierzeta { get; set; } = new List<Zwierzetum>();
}
