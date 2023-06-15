using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class ProductDto
{
    public int ProductId { get; set; }

    [Required]
    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;
    [Required]

    public decimal ProductPrice { get; set; }

    public int ProductStock { get; set; }
}
