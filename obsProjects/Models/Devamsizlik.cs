using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class Devamsizlik
{
    public int Id { get; set; }

    public int OgrenciId { get; set; }

    public int DersId { get; set; }

    public DateOnly Tarih { get; set; }

    public virtual Dersler Ders { get; set; } = null!;

    public virtual Ogrenciler Ogrenci { get; set; } = null!;
}
