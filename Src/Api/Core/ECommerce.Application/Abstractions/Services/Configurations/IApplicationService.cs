using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstractions.Services.Configurations;

public interface IApplicationService
{
    List<Menu> GetAuthorizeDefinitionEndpoints(Type type);
}