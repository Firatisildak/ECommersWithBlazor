using ECommerce.Application.Repositories;
using ECommerce.Domain.Entities;

namespace ECommerce.Persistence.Repositories
{
    public class EndpointWriteRepository : WriteRepository<Endpoint>, IEndpointWriteRepository
    {
        public EndpointWriteRepository(Contexts.ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
