using Business.MongoDbManager.IMongoManager;
using DAL.MongoDbService.Concrete;
using DAL.MongoDbService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MongoDbManager
{
    public class MongoBManager : IMongoBManager
    {
        private ISampleRepository _sampleRepository;
        public MongoBManager(ISampleRepository repository)
        {
            _sampleRepository = repository;
        }
        public async Task Create(SampleDTO obj)
        {
            await _sampleRepository.Create(obj);
        }

        public void Delete(string id)
        {

            _sampleRepository.Delete(id);
        }

        public async Task<SampleDTO> Get(string id)
        {
            return await _sampleRepository.Get(id);
        }

        public async Task<IEnumerable<SampleDTO>> Get()
        {
            return await _sampleRepository.Get();
        }

        public void Update(SampleDTO obj)
        {
            _sampleRepository.Update(obj);
        }
    }
}
