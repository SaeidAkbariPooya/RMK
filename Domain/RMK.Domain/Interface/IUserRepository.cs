namespace RMK.Domain.Interface
{
    public interface IUserRepository:IAsyncDisposable
    {
        Task<bool> Login(string userName,string pass);
    }
}
