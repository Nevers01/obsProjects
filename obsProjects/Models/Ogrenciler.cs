using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class Ogrenciler
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string SifreHash { get; set; } = null!;

    public string OgrenciNo { get; set; } = null!;

    public virtual ICollection<DersProgrami> DersProgramis { get; set; } = new List<DersProgrami>();

    public virtual ICollection<Devamsizlik> Devamsizliks { get; set; } = new List<Devamsizlik>();

    public virtual ICollection<Notlar> Notlars { get; set; } = new List<Notlar>();

    public virtual ICollection<Odevler> Odevlers { get; set; } = new List<Odevler>();

    public virtual ICollection<Sohbetler> Sohbetlers { get; set; } = new List<Sohbetler>();
}
