
using DEALERSHIP_MANAGEMENT_SYSTEM.Data;
using Microsoft.EntityFrameworkCore;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Interface.Impelementation
{
    public class GenaricRepo<T> : IGenaricRepo<T> where T : class
    {
        private readonly AppDbContext _context;
        public DbSet<T> db;
        public GenaricRepo(AppDbContext _context)
        {
            db=_context.Set<T>();
        }
        public void Add(T item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            db.Remove(getById(id));
        }

        public ICollection<T> GetAll()
        {
           return db.ToList();
        }

        public T getById(int id)
        {
            return db.Find(id);
        }

        public void Update(T item, int id)
        {
            db.Update(item);
        }
    }
}
