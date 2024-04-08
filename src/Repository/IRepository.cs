
namespace Repository
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(object id);
        public T GetById(object id);
        public IEnumerable<T> GetAll();
        public void Save();
    }
}
