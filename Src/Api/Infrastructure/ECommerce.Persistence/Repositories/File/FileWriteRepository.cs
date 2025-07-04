using ECommerce.Application.Repositories;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories;

public class FileWriteRepository : WriteRepository<ECommerce.Domain.Entities.File>, IFileWriteRepository
{
    public FileWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}