using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class Roller
{
    public int Id { get; set; }

    public string RolAdi { get; set; } = null!;

    public virtual ICollection<KullaniciRolleri> KullaniciRolleris { get; set; } = new List<KullaniciRolleri>();
}
