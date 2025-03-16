using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class Duyurular
{
    public int Id { get; set; }

    public int OgretmenId { get; set; }

    public string Baslik { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public DateTime? YayinTarihi { get; set; }

    public virtual Ogretmenler Ogretmen { get; set; } = null!;
}
