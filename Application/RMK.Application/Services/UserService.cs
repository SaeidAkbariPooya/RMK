using RMK.Application.DTOs;
using RMK.Application.Interfaces;
using RMK.Domain.Interface;

namespace RMK.Application.Services
{
    public class UserService: IUserService
    {
        #region constractor
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion


        public async Task<bool> LoginUser(LoginUserDTO model)
        {
            var user = await _userRepository.Login(model.UserName,model.Password);
            if (user == false) return false; 
            return true;
        }
    }
}
