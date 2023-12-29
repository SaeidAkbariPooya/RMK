using RMK.Domain.Interface;
using RMK.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace RMK.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region constractor
        private readonly RMKContext _context;
        public UserRepository(RMKContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<bool> Login(string userName,string pass)
        {
            return await _context.Users.AnyAsync(u => u.UserName == userName && u.Password == pass);
        }
        #region dispose
        public async ValueTask DisposeAsync()
        {
            if (_context != null) await _context.DisposeAsync();
        }
        #endregion
    }
}
