using System;
using System.Collections.Generic;

namespace KlinikaWeterynaryjna.Models2;

public partial class Zwierzetum
{
    public int IdZwierzeta { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Gatunek { get; set; } = null!;

    public DateTime? DataOstWizyty { get; set; }

    public int? IdWlasciciel { get; set; }

    public virtual Wlasciciel? IdWlascicielNavigation { get; set; }
}
