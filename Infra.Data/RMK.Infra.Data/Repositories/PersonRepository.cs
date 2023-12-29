using RMK.Domain.Interface;
using RMK.Domain.Models;
using RMK.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace RMK.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        #region constractor
        private readonly RMKContext _context;
        public PersonRepository(RMKContext context)
        {
            _context = context;
        }
        #endregion

        public IQueryable<Person> GetAll()
        {
            return _context.People.Include(s => s.Addresses).AsNoTracking();
        }

        #region dispose
        public async ValueTask DisposeAsync()
        {
            if (_context != null) await _context.DisposeAsync();
        }
        #endregion
    }
}
