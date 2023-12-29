using RMK.Application.DTOs;

namespace RMK.Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> LoginUser(LoginUserDTO loginUser);
    }
}
