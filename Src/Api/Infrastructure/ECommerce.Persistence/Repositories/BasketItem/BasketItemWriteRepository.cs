using ECommerce.Persistence.Contexts;
using ECommerce.Application.Repositories;
using ECommerce.Domain.Entities;

namespace ECommerce.Persistence.Repositories
{
    public class BasketItemWriteRepository : WriteRepository<BasketItem>, IBasketItemWriteRepository
    {
        public BasketItemWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
