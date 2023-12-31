﻿using System;
using System.Collections.Generic;

namespace PrivateWeb.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string? Image { get; set; }

    public int IsFeatured { get; set; }

    public int Status { get; set; }

    public string ShowHome { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

	public virtual ICollection<Product> Products { get; set; } = new List<Product>();

	public virtual ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
}
