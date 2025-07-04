using ECommerce.Application.Repositories;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories;

public class FileReadRepository : ReadRepository<ECommerce.Domain.Entities.File>, IFileReadRepository
{
    public FileReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}