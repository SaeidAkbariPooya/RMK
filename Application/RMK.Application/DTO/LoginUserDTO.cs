using System.ComponentModel.DataAnnotations;

namespace RMK.Application.DTOs
{
    public class LoginUserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public enum LoginUserResult
    {
        NotFound,
        NotActivate,
        Success
    }
}
