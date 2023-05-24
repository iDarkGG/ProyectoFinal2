using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dependencias.Models;

public partial class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public decimal ProductPrice { get; set; }

    public int ProductStock { get; set; }
}
