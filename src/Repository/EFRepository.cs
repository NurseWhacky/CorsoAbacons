

using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    public class EFRepository<T> : IRepository<T> where T : DataObject, new() // constraint
    {
        private readonly DataContext context; // DataContext instance initialized in ctor
        private readonly DbSet<T> table;

        public EFRepository()
        {
            this.context = new DataContext();
        }

        public EFRepository(DataContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            entity.CreationDate = DateTime.Now;
            entity.LastModified = DateTime.Now;
            table.Add(entity);
        }

        public void Delete(object id)
        {
            T? entity = table.Find(id);
            if (entity is not null)
            {
                table.Remove(entity);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return table?.ToList() ?? new();
        }

        public T? GetById(object id)
        {
            return table.Find(id);
        }

        // THIS method finalizes changes in DB. Q: why not call it directly inside the Update, Delete and Add method? --> A: so we can control when finalize modification, eg. at the end of a series of modification on the same table, and then CLOSE the connection 
        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            entity.LastModified = DateTime.Now;
            table.Attach(entity);
            // connect the entity given to the dbset to the db using the context object
            context.Entry(entity).State = EntityState.Modified; // EF keeps track of modifications in records. The record 'entity' is then SAVED (see below)
        }

    }
}
