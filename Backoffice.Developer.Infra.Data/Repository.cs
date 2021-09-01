using Backoffice.Developer.Domain.Interface;
using Backoffice.Developer.Infra.Data.Interface;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice.Developer.Infra.Data
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly IMongoCollection<T> _collection;
        public Repository(Settings settings)
        {
            var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.Database);
            _collection = database.GetCollection<T>(typeof(T).Name);
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> filterExpression)
            => await _collection.FindOneAndDeleteAsync(filterExpression);

        public virtual async Task DeleteAsync(T document)
        {
            var filter = Builders<T>.Filter.Eq(filter => filter.Id, document.Id);

            await _collection.FindOneAndDeleteAsync(filter);
        }

        public virtual async Task CreateAsync(T entity)
        {
            entity.LastUpdate = DateTime.Now;
            await _collection.InsertOneAsync(entity);
        }

        public virtual async Task<T> FindAsync(ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq(entity => entity.Id, id);
            return await _collection.Find(filter).SingleOrDefaultAsync();
        }

        public virtual async Task<List<T>> FindAsync(Expression<Func<T, bool>> filter)
            => await _collection.Find(filter).ToListAsync();

        public virtual async Task<List<T>> FindAsync(FilterDefinition<T> build)
            => await _collection.Find(build).ToListAsync();

        public virtual async Task UpdateAsync(T entity)
        {
            entity.LastUpdate = DateTime.Now;
            var filter = Builders<T>.Filter.Eq(filter => filter.Id, entity.Id);

            await _collection.ReplaceOneAsync(filter, entity, new ReplaceOptions { IsUpsert = true });
        }

        public async Task<List<T>> GetAll()
            => await _collection.Find(f => f.Id != null).ToListAsync();

    }
}
