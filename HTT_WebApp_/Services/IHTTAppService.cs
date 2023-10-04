namespace HTT_WebApp_.Services
{
    public interface IHTTAppService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
    }
}
