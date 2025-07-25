﻿using ECommerce.Application.Repositories;
using ECommerce.Domain.Entities;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories;

public class CustomerReadRepository(ECommerceAPIDbContext context) : ReadRepository<Customer>(context), ICustomerReadRepository
{
}