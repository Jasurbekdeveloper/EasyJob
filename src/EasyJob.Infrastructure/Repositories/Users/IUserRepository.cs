using EasyJob.Domain.Entities.Users;

namespace EasyJob.Infrastructure.Repositories.Users;

public interface IUserRepository : IGenericRepository<User, Guid>
{
}