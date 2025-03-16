using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class Dersler
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public int OgretmenId { get; set; }

    public virtual ICollection<DersProgrami> DersProgramis { get; set; } = new List<DersProgrami>();

    public virtual ICollection<Devamsizlik> Devamsizliks { get; set; } = new List<Devamsizlik>();

    public virtual ICollection<Notlar> Notlars { get; set; } = new List<Notlar>();

    public virtual ICollection<Odevler> Odevlers { get; set; } = new List<Odevler>();

    public virtual Ogretmenler Ogretmen { get; set; } = null!;
}
