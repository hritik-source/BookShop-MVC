using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bookshop.Models;

public partial class Bookhritik
{
    
    public int Bookid { get; set; }

    public int? Authorid { get; set; }

    [Required(ErrorMessage = " Name Of the Book Is Mandatory"), MaxLength(100)]
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime? Year { get; set; }

    [Range(500,999999,ErrorMessage ="Price should be atleast 500")]
    public int? Price { get; set; }
    
    [Required(ErrorMessage = " Name Of the Genre     Is Mandatory"), MaxLength(100)]
    public string? Genre { get; set; }

    public virtual Authorhritik? Author { get; set; }
}
