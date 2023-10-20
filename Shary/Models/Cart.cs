using System;
using System.Collections.Generic;

namespace Shary.Models;

public partial class Cart
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual Product? Product { get; set; }
}
