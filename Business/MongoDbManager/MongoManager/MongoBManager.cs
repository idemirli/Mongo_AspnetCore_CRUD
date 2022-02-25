using AutoMapper;
using Business.MongoDbManager.IMongoManager;
using Contract.DTO;
using DAL.Entity;
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
        private IMapper _mapper;
        public MongoBManager(ISampleRepository repository, IMapper mapper)
        {
            _sampleRepository = repository;
            _mapper = mapper;
        }
        public async Task Create(SampleDTO obj)
        {
            await _sampleRepository.Create(_mapper.Map<SampleDTO, SampleEntity>(obj));
        }

        public void Delete(string id)
        {
            _sampleRepository.Delete(id);
        }

        public SampleDTO Get(string id)
        {
            return _mapper.Map<SampleEntity, SampleDTO>(_sampleRepository.Get(id));
        }

        public IEnumerable<SampleDTO> Get()
        {
            return _mapper.Map<IEnumerable<SampleEntity>, IEnumerable<SampleDTO>>(_sampleRepository.Get());

        }

        public void Update(SampleDTO obj)
        {
            _sampleRepository.Update(_mapper.Map<SampleDTO, SampleEntity>(obj));
        }
    }
}
