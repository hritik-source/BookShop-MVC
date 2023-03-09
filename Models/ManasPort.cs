using System;
using System.Collections.Generic;

namespace bookshop.Models;

public partial class ManasPort
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ManasFerry> ManasFerryDestinationNavigations { get; } = new List<ManasFerry>();

    public virtual ICollection<ManasFerry> ManasFerryOriginNavigations { get; } = new List<ManasFerry>();
}
