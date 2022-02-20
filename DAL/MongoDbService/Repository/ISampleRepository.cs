using DAL.MongoDbService.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoDbService.Repository
{
    public interface ISampleRepository : IBaseRepository<SampleDTO>
    {
        void MyMethod(string s);
    }
}
