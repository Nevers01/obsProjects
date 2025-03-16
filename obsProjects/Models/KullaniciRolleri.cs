using System;
using System.Collections.Generic;

namespace obsProjects.Models;

public partial class KullaniciRolleri
{
    public int Id { get; set; }

    public int KullaniciId { get; set; }

    public int RolId { get; set; }

    public virtual Roller Rol { get; set; } = null!;
}
