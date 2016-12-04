namespace LaptopStore.Data.Common
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using LaptopStore.Data.Common.Models;

    // TODO: Why BaseModel<int> instead BaseModel<TKey>?
    public class DbRepository<T> : IDbRepository<T>
        where T : class
    {
        public DbRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", nameof(context));
            }

            this.context = context;
            this.set = this.context.Set<T>();
        }

        private DbContext context;
        private IDbSet<T> set;

        public IQueryable<T> All()
        {
            return this.set;
        }

        public void Add(T entity)
        {
            ChangeState(entity, EntityState.Added);
        }

        public T Find(object id)
        {
            return this.set.Find(id);
        }

        public void Update(T entity)
        {
            ChangeState(entity, EntityState.Modified);
        }

        public T Delete(T entity)
        {
            ChangeState(entity, EntityState.Deleted);
            return entity;
        }

        public T Delete(object id)
        {
            T entity = this.Find(id);
            this.Delete(entity);
            return entity;
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private void ChangeState(T entity, EntityState state)
        {
            var entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = state;

        }
    }
}
