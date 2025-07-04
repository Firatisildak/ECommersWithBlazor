using ECommerce.Application.Repositories;
using ECommerce.Domain.Entities;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories;

public class OrderWriteRepository(ECommerceAPIDbContext context) : WriteRepository<Order>(context), IOrderWriteRepository
{
}