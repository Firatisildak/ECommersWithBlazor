﻿using ECommerce.Application.Repositories;
using ECommerce.Domain.Entities;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories;

public class OrderReadRepository(ECommerceAPIDbContext context) : ReadRepository<Order>(context), IOrderReadRepository
{
}