using ECommerce.Application.Repositories;
using ECommerce.Domain.Entities;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories;

public class ProductWriteRepository(ECommerceAPIDbContext context) : WriteRepository<Product>(context), IProductWriteRepository
{
}