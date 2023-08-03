namespace FreeSR.Database.Mongo
{
    using MongoDB.Driver;
    using System.Linq.Expressions;

    public class SRMongoDatabase<T> : ISRDatabase<T> where T : class
    {
        protected readonly IMongoCollection<T> _collection;

        public SRMongoDatabase(IMongoDatabase database, string collectionName)
        {
            _collection = database.GetCollection<T>(collectionName);
        }

        public async Task Insert(T document)
        {
            await _collection.InsertOneAsync(document);
        }

        public async Task InsertMany(IEnumerable<T> documents)
        {
            await _collection.InsertManyAsync(documents);
        }

        public async Task<List<T>> Find(Expression<Func<T, bool>> filter)
        {
            var result = await _collection.FindAsync(filter);
            return await result.ToListAsync();
        }

        public async Task<T> FindOne(Expression<Func<T, bool>> filter)
        {
            var result = await _collection.FindAsync(filter);
            return await result.FirstOrDefaultAsync();
        }

        public async Task Update(Expression<Func<T, bool>> filter, T updatedDocument)
        {
            await _collection.ReplaceOneAsync(filter, updatedDocument);
        }

        public async Task Delete(Expression<Func<T, bool>> filter)
        {
            await _collection.DeleteOneAsync(filter);
        }

        public async Task<long> Count()
        {
            return await _collection.CountDocumentsAsync(Builders<T>.Filter.Empty);
        }

        public async Task<T> FindMax(Expression<Func<T, object>> fieldSelector)
        {
            var sortDefinition = Builders<T>.Sort.Descending(fieldSelector);
            return await _collection.Find(Builders<T>.Filter.Empty).Sort(sortDefinition).FirstOrDefaultAsync();
        }
    }
}
