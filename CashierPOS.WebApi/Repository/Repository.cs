using CashierPOS.WebApi.DataContext;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

namespace CashierPOS.WebApi.Repository
{
    public class Repository<TE> : IRepository<TE> where TE : class
    {
        private readonly CashierPOSContext _context;
        public Repository(CashierPOSContext context)
        {
            _context = context;
        }

        public IEnumerable<TE> GetAll() => _context.Set<TE>().ToList();

        public TE? GetById(string id)
        {
            return _context.Set<TE>().Find(id);
        }

        public IQueryable<TE?> GetQueryable()
        {
            return _context.Set<TE>().AsQueryable();
        }
        public void Add(TE entity)
        {
            _context.Set<TE>().Add(entity);
        }

        public void AddRange(ICollection<TE> entities)
        {
            _context.Set<TE>().AddRange(entities);
        }

        public void Update(TE entity)
        {
            _context.Set<TE>().Update(entity);
        }

        public void UpdateRange(ICollection<TE> entities)
        {
            _context.Set<TE>().UpdateRange(entities);

        }
        public void Delete(TE entity)
        {
            _context.Set<TE>().Remove(entity);
        }

        public void DeleteRange(ICollection<TE> entities)
        {
            _context.Set<TE>().RemoveRange(entities);
        }
        public int SaveChanges()
        {
           return _context.SaveChanges();
        }
        
        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }

        public TE PropertyNotModify(TE entity, params Expression<Func<TE, object>>[] propertiesToExclude)
        {
            var entry = _context.Entry(entity);

            entry.State = EntityState.Modified;

            foreach (var property in propertiesToExclude)
            {
                entry.Property(property).IsModified = false;
            }
            return entry.Entity;
        }
    }
}
