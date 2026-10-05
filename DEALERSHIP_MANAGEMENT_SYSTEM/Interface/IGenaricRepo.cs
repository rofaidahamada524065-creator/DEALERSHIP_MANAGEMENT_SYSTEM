namespace DEALERSHIP_MANAGEMENT_SYSTEM.Interface
{
    public interface IGenaricRepo<T> where T : class
    {
        void Add(T item);
        void Update(T item,int id);

        void Delete(int id);

        ICollection<T> GetAll();

        T getById(int id);
    }
}
