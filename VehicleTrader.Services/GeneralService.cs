using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VehicleTrader.Core.Domain;
using VehicleTrader.Core.Repo;

namespace VehicleTrader.Services
{
    public class GeneralService<T> : IGeneralService<T> where T : Entity
    {
        protected IRepositoryBase<T> Repository;

        protected IQueryable<T> Table => Repository.Table;
        protected IQueryable<T> TableNoTracking => Repository.TableNoTracking;

        public GeneralService(IRepositoryBase<T> repository)
        {
            Repository = repository;
        }

        public T Find(object id)
        {
            return Repository.GetById(id);
        }
        public async Task<T> FindAsync(object id)
        {
            return await Repository.GetByIdAsync(id);
        }

        public void Insert(T entity)
        {
            Repository.Insert(entity);
        }

        public void Insert(IEnumerable<T> entities)
        {
            Repository.Insert(entities);
        }

        public void Update(T entity)
        {
            Repository.Update(entity);
        }

        public void Update(IEnumerable<T> entities)
        {
            Repository.Update(entities);
        }

        public void Delete(T entity)
        {
            Repository.Delete(entity);
        }

        public void Delete(IEnumerable<T> entities)
        {
            Repository.Delete(entities);
        }

        public ICollection<T> GetAll()
        {
            return Repository.GetAll().ToList();
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await Repository.GetAll(expression).ToListAsync();
        }

        public ICollection<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return Repository.GetAll(expression).ToList();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return Repository.Any(expression);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return Repository.FirstOrDefault(expression);
        }

        public T LastOrDefault(Expression<Func<T, bool>> expression)
        {
            return Repository.LastOrDefault(expression);
        }

        public IQueryable<T> FindAsNoTrackingBy(Expression<Func<T, bool>> expression)
        {
            return TableNoTracking.Where(expression);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }

        public IQueryable<T> GetAllAsQueryableNoTracking()
        {
            return TableNoTracking;
        }

        public IQueryable<T> GetAllAsQueryable()
        {
            return Table;
        }

        public void TrackedSaveChanges()
        {
            Repository.TrackedSaveChanges();
        }
    }
}