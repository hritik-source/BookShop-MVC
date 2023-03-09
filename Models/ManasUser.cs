using System;
using System.Collections.Generic;

namespace bookshop.Models;

public partial class ManasUser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
