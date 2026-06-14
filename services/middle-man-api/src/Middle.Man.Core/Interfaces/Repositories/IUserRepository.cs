using System.Threading;
using Middle.Man.Core.DTOs;
using Middle.Man.Core.Entities;

namespace Middle.Man.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<Entities.User?> GetUserByEmailAsync(string email, CancellationToken ct = default);
        
        Task<Entities.User> AddUserAsync(Entities.User user, CancellationToken ct = default);
        
        Task UpdateUserAsync(Entities.User user, CancellationToken ct = default);
        
        Task<UserProfileDto?> GetUserProfileByEmailAsync(string email, CancellationToken ct = default); 
    }
}