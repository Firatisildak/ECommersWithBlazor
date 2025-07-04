using ECommerce.Application.Repositories;
using ECommerce.Domain.Entities;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories;

public class ProductReadRepository(ECommerceAPIDbContext context) : ReadRepository<Product>(context), IProductReadRepository
{
}