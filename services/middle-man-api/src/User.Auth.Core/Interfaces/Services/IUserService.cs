using System.Threading;
using User.Auth.Core.DTOs;

namespace User.Auth.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserSignUpResponseDto> SignUpAsync(UserDto userDto, CancellationToken ct = default);

        Task<TokenResponseDto?> SignInAsync(UserDto userDto, CancellationToken ct = default);

        Task<UserProfileDto?> GetUserProfileAsync(string email, CancellationToken ct = default);

        Task<UserUpdateResponseDto?> UpdateUserProfileAsync(string email, UserUpdateDto updates, CancellationToken ct = default);
    }
}