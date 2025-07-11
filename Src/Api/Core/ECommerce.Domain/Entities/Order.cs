﻿using ECommerce.Domain.Entities.Common;

namespace ECommerce.Domain.Entities;

public class Order : BaseEntity
{
    public Guid CustomerId { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public ICollection<Product> Products { get; set; } = new List<Product>();
    public Customer Customer { get; set; } = new();
}
