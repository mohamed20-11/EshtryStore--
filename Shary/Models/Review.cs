using System;
using System.Collections.Generic;

namespace Shary.Models;

public partial class Review
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Subject { get; set; }

    public string? Description { get; set; }
}
