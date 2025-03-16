using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class Odevler
{
    public int Id { get; set; }

    public int DersId { get; set; }

    public int OgrenciId { get; set; }

    public string Baslik { get; set; } = null!;

    public string? Aciklama { get; set; }

    public DateOnly SonTarih { get; set; }

    public string? DosyaYolu { get; set; }

    public virtual Dersler Ders { get; set; } = null!;

    public virtual Ogrenciler Ogrenci { get; set; } = null!;
}
