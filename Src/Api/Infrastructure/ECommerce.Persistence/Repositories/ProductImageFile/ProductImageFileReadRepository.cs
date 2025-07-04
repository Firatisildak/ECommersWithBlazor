using ECommerce.Application.Repositories;
using ECommerce.Domain.Entities;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories;

public class ProductImageFileReadRepository : ReadRepository<ProductImageFile>, IProductImageFileReadRepository
{
    public ProductImageFileReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}