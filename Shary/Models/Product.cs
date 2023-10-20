using System;
using System.Collections.Generic;

namespace Shary.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? CatId { get; set; }

    public decimal? Price { get; set; }

    public string? Photo { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Cat { get; set; }
}
