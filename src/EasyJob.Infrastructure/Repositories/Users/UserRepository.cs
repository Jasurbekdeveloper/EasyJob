using EasyJob.Domain.Entities.Users;
using EasyJob.Infrastructure.Contexts;

namespace EasyJob.Infrastructure.Repositories.Users;

public sealed class UserRepository : GenericRepository<User, Guid>, IUserRepository
{
	public UserRepository(AppDbContext appDbContext)
		: base(appDbContext)
	{
	}
}