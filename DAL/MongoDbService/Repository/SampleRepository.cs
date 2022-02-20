using DAL.MongoDbService.Concrete;
using DAL.MongoDbService.MongoDbContext;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoDbService.Repository
{
    public class SampleRepository : BaseRepository<SampleDTO>, ISampleRepository
    {
        public SampleRepository(IMongoDBContext context) : base(context)
        {
        }
        public void MyMethod(string s)
        {
            //My Method operations
        }

        public override void Update(SampleDTO obj)
        {
            _dbCollection.ReplaceOneAsync(s => s.Id == obj.Id, obj);
        }
    }
}
