﻿using System;
using System.Collections.Generic;

namespace bookshop.Models;

public partial class Empsuppawanish
{
    public int SId { get; set; }

    public string? Sname { get; set; }

    public virtual ICollection<Empawanish> Empawanishes { get; } = new List<Empawanish>();
}
