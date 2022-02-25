using Contract.DTO;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoDbService.Repository
{
    public interface ISampleRepository : IBaseRepository<SampleEntity>
    {
        void MyMethod(string s);
    }
}
