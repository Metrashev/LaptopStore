namespace LaptopStore.Data.Common
{
    using System.Linq;

    using LaptopStore.Data.Common.Models;

    public interface IDbRepository<T> where T : class
    {
        IQueryable<T> All();

        void Add(T entity);

        T Find(object id);

        void Update(T entity);

        T Delete(T entity);

        T Delete(object id);

        int SaveChanges();
    }
}
