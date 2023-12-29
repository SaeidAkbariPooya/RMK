using RMK.Domain.Models;

namespace RMK.Domain.Interface
{
    public interface IPersonRepository : IAsyncDisposable
    {
         IQueryable<Person> GetAll();
    }
}
