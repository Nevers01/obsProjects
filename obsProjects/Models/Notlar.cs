using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class Notlar
{
    public int Id { get; set; }

    public int OgrenciId { get; set; }

    public int DersId { get; set; }

    public decimal? VizeNotu { get; set; }

    public decimal? FinalNotu { get; set; }

    public decimal? SozluNotu { get; set; }

    public virtual Dersler Ders { get; set; } = null!;

    public virtual Ogrenciler Ogrenci { get; set; } = null!;
}
