using System;
using System.Collections.Generic;

namespace bookshop.Models;

public partial class Usertbl
{
    public int UserId { get; set; }

    public string? Password { get; set; }

    public string? Username { get; set; }
}
