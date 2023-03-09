using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace bookshop.Models;

public partial class Bookuserhritik
{
    [Required(ErrorMessage = " Username is Required"), MaxLength(100)]
    public string? Uname { get; set; }

    public int Uid { get; set; }
    
    [Required(ErrorMessage = " Password is Required"), MinLength(4)]
    public string? Password { get; set; }
}
