using System.Collections.Generic;
using System.Linq;
using App.Datos.Datos;
using App.Repository.Contracts;
using Microsoft.EntityFrameworkCore;


namespace App.Datos.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        private readonly DatosDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DatosDbContext context)
        {

            _context = context;

        }

        public IEnumerable<T> GetAll()
        {

            return _dbSet.ToList();

        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }


        public void Add(T entity)
        {
             _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

    }
}
