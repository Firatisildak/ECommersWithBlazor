using ECommerce.Persistence.Contexts;
using ECommerce.Domain.Entities;
using ECommerce.Application.Repositories;

namespace ECommerce.Persistence.Repositories
{
    public class BasketWriteRepository : WriteRepository<Basket>, IBasketWriteRepository
    {
        public BasketWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
