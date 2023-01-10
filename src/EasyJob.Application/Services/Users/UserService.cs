using EasyJob.Domain.Entities.Users;
using EasyJob.Infrastructure.Repositories.Users;

namespace EasyJob.Application.Services.Users;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public async ValueTask<User> CreateUserAsync(User user)
    {
        var addedUser = await this.userRepository
            .InsertAsync(user);

        return addedUser;
    }

    public IQueryable<User> RetrieveUsers() =>
        this.userRepository.SelectAll();

    public async ValueTask<User> RetrieveUserByIdAsync(Guid userId)
    {
        return await this.userRepository
            .SelectByIdAsync(userId);
    }

    public async ValueTask<User> ModifyUserAsync(User user)
    {
        var modifiedUser = await this.userRepository
            .UpdateAsync(user);

        return modifiedUser;
    }

    public async ValueTask<User> RemoveUserAsync(Guid userId)
    {
        var user = await this.userRepository
            .SelectByIdAsync(userId);

        var removedUser = await this.userRepository
            .DeleteAsync(user);

        return removedUser;
    }
}