using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class Ogretmenler
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string SifreHash { get; set; } = null!;

    public virtual ICollection<Dersler> Derslers { get; set; } = new List<Dersler>();

    public virtual ICollection<Duyurular> Duyurulars { get; set; } = new List<Duyurular>();

    public virtual ICollection<Sohbetler> Sohbetlers { get; set; } = new List<Sohbetler>();
}
