using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class Sohbetler
{
    public int Id { get; set; }

    public int GonderenId { get; set; }

    public int AliciId { get; set; }

    public string Mesaj { get; set; } = null!;

    public DateTime? GonderimTarihi { get; set; }

    public virtual Ogretmenler Alici { get; set; } = null!;

    public virtual Ogrenciler Gonderen { get; set; } = null!;
}
