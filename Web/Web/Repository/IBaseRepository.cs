namespace Web.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetByFilter(int PageNo, int PageSize);
        Task<T> GetOne(object id);
        Task Insert(T entity);
        Task Update(object id, object value);
        Task Delete(object id);
    }
}
