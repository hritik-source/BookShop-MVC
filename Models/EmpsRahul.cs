using System;
using System.Collections.Generic;

namespace bookshop.Models;

public partial class EmpsRahul
{
    public int Eid { get; set; }

    public string Ename { get; set; } = null!;

    public string Ecity { get; set; } = null!;

    public int Esal { get; set; }

    public DateTime Edoj { get; set; }
}
