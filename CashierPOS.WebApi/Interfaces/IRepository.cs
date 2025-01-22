using System.Linq.Expressions;

namespace CashierPOS.WebApi.Interface
{
    public interface IRepository<TE> where TE : class
    {
        //Task<IEnumerable<TE>> GetAllAsync();
        IEnumerable<TE> GetAll();
        IQueryable<TE?> GetQueryable();

        TE? GetById(string id);

        void Add(TE entity);
        void AddRange(ICollection<TE> entities);

        void Update(TE entity);
        void UpdateRange(ICollection<TE> entities);

        void Delete(TE entity);
        void DeleteRange(ICollection<TE> entities);
        int SaveChanges();
        void Rollback();
        TE PropertyNotModify(TE entity, params Expression<Func<TE, object>>[] propertiesToExclude);
    }
}