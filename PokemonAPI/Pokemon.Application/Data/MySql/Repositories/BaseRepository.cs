using Microsoft.EntityFrameworkCore;
using Pokemon.Application.Data.MySql;
using Pokemon.Application.Data.MySql.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pokemon.Data.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly PokemonApiContext _db;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(PokemonApiContext db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }

        public async Task<ICollection<TEntity>> GetAll()
        {
            return await _dbSet.AsNoTracking()
                               .ToListAsync();
        }

        public async Task<TEntity> GetById(string id)
        {
            return await _dbSet.AsNoTracking()
                               .FirstOrDefaultAsync(x => x.Id.ToString() == id);
        }

        public async Task Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            _db.SaveChanges();
        }

        public TEntity Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            _db.SaveChanges();
        }
    }
}