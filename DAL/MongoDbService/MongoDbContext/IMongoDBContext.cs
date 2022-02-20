using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoDbService.MongoDbContext
{
    public interface IMongoDBContext
    {
        IMongoCollection<Book> GetCollection<Book>(string name);
    }
}
