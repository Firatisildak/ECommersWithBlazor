using ECommerce.Persistence.Contexts;
using ECommerce.Domain.Entities;
using ECommerce.Application.Repositories;

namespace ECommerce.Persistence.Repositories
{
    public class BasketReadRepository : ReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
