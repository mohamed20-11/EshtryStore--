using System;
using System.Collections.Generic;

namespace Shary.Models;

public partial class Category
{
    public string? Name { get; set; }

    public int Id { get; set; }

    public string? Photo { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
