using DAL.MongoDbService.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.MongoDbManager.IMongoManager
{
    public interface IMongoBManager
    {
        Task Create(SampleDTO obj);
        void Update(SampleDTO obj);
        void Delete(string id);
        Task<SampleDTO> Get(string id);
        Task<IEnumerable<SampleDTO>> Get();
    }
}
