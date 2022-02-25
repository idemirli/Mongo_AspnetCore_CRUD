using Contract.DTO;
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
        SampleDTO Get(string id);
        IEnumerable<SampleDTO> Get();
    }
}
