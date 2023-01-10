using EasyJob.Domain.Entities.Users;

namespace EasyJob.Application.Services.Users;

public interface IUserService
{
    ValueTask<User> CreateUserAsync(User user);
    IQueryable<User> RetrieveUsers();
    ValueTask<User> RetrieveUserByIdAsync(Guid userId);
    ValueTask<User> ModifyUserAsync(User user);
    ValueTask<User> RemoveUserAsync(Guid user);
}