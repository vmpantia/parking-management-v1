using Microsoft.EntityFrameworkCore;
using Web.DataAccess;
using Web.Model;

namespace Web.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _db;
        private readonly DbSet<T> _table;
        public BaseRepository(DataDbContext dbContext)
        {
            _db = dbContext;
            _table = _db.Set<T>();
        }

        public async Task<IEnumerable<T>> GetByFilter(int PageNo, int PageSize)
        {
            return await _table.Skip((PageNo - 1) * PageSize).Take(PageSize).ToListAsync();
        }

        public async Task<T> GetOne(object id)
        {
            var result = await _table.FindAsync(id);

            //Check if the result is Null
            if (result == null)
                throw new Exception(Constants.DATA_NOT_FOUND);

            return result;
        }

        public async Task Insert(T entity)
        {
            await _table.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Update(object id, object value)
        {
            var t = await GetOne(id);
            _db.Entry(t).CurrentValues.SetValues(value);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(object id)
        {
            var t = await GetOne(id);
            _table.Remove(t);
            await _db.SaveChangesAsync();
        }
    }
}
